using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NS_Admissions.StrongTypesNS;
using NS_StuReg.StrongTypesNS;
using Utilities;

namespace Admissions.UtilityScreens
{
    public partial class PGCESubjectChoices : Form
    {
        DS_ADM_STUDataSet ds_adm_stu;
        int deg_num = default(int), total_deg = default(int);

        ds_degreeDataSet ds_degrees;
        DS_PG_COURSEDataSet ds_pg_courses;
        ds_subjectDataSet ds_pgce_subjects;

        public PGCESubjectChoices(DS_ADM_STUDataSet ds_adm_stu, int deg_num)
        {
            InitializeComponent();

            this.dgvPGCEChoice.AutoGenerateColumns = false;
            this.ds_adm_stu = ds_adm_stu;
            this.deg_num = deg_num;
        }

        #region Form Events

        private void PGCESubjectChoices_Load(object sender, EventArgs e)
        {
            try
            {
                DisableEditState();
                if (ds_pg_courses == null) ds_pg_courses = Proxy.Admissions.Get_PG_Courses();
                if (ds_degrees == null) ds_degrees = Proxy.StudentRegistration.GetDegrees(Global.Global.tempyr);

                PopulateStudentDetails();
                LoadCurrentDegreeDetails();
            }
            catch (Exception ex)
            {
                Utils.HandleException(ExceptionSource.Admissions, ex);
            }
        }

        void PGCESubjectChoices_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {
            if (e.CloseReason.Equals(CloseReason.UserClosing) && !scPGCE.Panel2Collapsed)
            {
                string msg = "Are you sure you want to close this screen?";
                if (!MessageBox.Show(msg, "Admissions", MessageBoxButtons.YesNo, MessageBoxIcon.Question).Equals(DialogResult.Yes)) e.Cancel = true;
            }
        }

        #endregion

        #region Local Methods

        void EnableEditState()
        {
            pnlButtons.Enabled = false;
            scPGCE.Panel2Collapsed = false;
            scPGCE.Panel1.Enabled = false;
        }

        void DisableEditState()
        {
            errorProvider.Clear();

            pnlButtons.Enabled = true;
            scPGCE.Panel2Collapsed = true;
            scPGCE.Panel1.Enabled = true;

            if (cbPGCEChoice.Items.Count > 0)
            { cbPGCEChoice.SelectedIndex = 0; }
        }

        void PopulateStudentDetails()
        {
            total_deg = default(int);
            for (int i = 1; i <= 8; i++)
            {
                if (ds_adm_stu.TT_ADM[0][string.Concat("PG_DEGR", i)] != System.DBNull.Value &&
                    !string.IsNullOrEmpty(ds_adm_stu.TT_ADM[0][string.Concat("PG_DEGR", i)].ToString()))
                { total_deg++; }
                else break;
            }
        }
        bool HasPGCDegree()
        {
            bool hasPGCE = false;

            for (int i = 1; i <= 8; i++)
            {
                if (ds_adm_stu.TT_ADM[0][string.Concat("PG_DEGR", i)] == System.DBNull.Value ||
                    string.IsNullOrEmpty(ds_adm_stu.TT_ADM[0][string.Concat("PG_DEGR", i)].ToString()) ||
                    !ds_adm_stu.TT_ADM[0][string.Concat("PG_DEGR", i)].ToString().StartsWith("PGCE"))
                {
                    ds_adm_stu.TT_ADM[0][string.Concat("PG_PGCE", i)] = System.DBNull.Value;
                }
                else
                {
                    if (deg_num <= 0) deg_num = i;
                    hasPGCE = true;
                }
            }

            return hasPGCE;
        }

        void CommitCurrentDegreeDetails()
        {
            if (deg_num > 0 && ds_adm_stu.TT_ADM.Rows.Count > 0 && ds_pgce_subjects != null)
            {
                string subj_choices = string.Empty;
                foreach (ds_subjectDataSet.tt_subjectRow subject in ds_pgce_subjects.tt_subject.Rows)
                {
                    if (!string.IsNullOrEmpty(subj_choices)) subj_choices += ",";
                    subj_choices += subject.subj;
                }
                ds_adm_stu.TT_ADM[0][string.Concat("PG_PGCE", deg_num)] = subj_choices;
            }
        }

        void LoadCurrentDegreeDetails()
        {
            if (deg_num > 0 && ds_adm_stu.TT_ADM.Rows.Count > 0)
            {
                string degree = string.Empty;
                int index = new BindingSource(ds_degrees, "tt_degree").Find("degr", ds_adm_stu.TT_ADM[0][string.Concat("PG_DEGR", deg_num)].ToString());
                if (index >= 0) degree = ds_degrees.tt_degree[index].degr;

                ds_pgce_subjects = new ds_subjectDataSet();
                if (ds_adm_stu.TT_ADM[0][string.Concat("PG_PGCE", deg_num)] != System.DBNull.Value && !string.IsNullOrEmpty(ds_adm_stu.TT_ADM[0][string.Concat("PG_PGCE", deg_num)].ToString()))
                {
                    string[] subjects = ds_adm_stu.TT_ADM[0][string.Concat("PG_PGCE", deg_num)].ToString().Split(',');
                    if (subjects.Length > 0)
                    {
                        List<string> list = new List<string>(subjects);
                        list.ForEach(delegate(string s)
                        {
                            index = new BindingSource(Global.Global.ds_subjects, "tt_subject").Find("subj", s);
                            if (index >= 0) ds_pgce_subjects.tt_subject.LoadDataRow(Global.Global.ds_subjects.tt_subject[index].ItemArray, true);
                        });
                    }
                }
                dgvPGCEChoice.DataSource = ds_pgce_subjects.tt_subject;

                if (!string.IsNullOrEmpty(degree))
                {
                    ds_subjectDataSet ds_subjects = (ds_subjectDataSet)Global.Global.ds_subjects.Copy();
                    DataView dvSubjects = new DataView(ds_subjects.tt_subject);
                    dvSubjects.RowFilter = string.Format("discont = false and subjname like '*{0}*'", degree);
                    dvSubjects.Sort = "subjname";
                    cbPGCEChoice.DataSource = dvSubjects;
                }
                else cbPGCEChoice.DataSource = null;
            }
        }

        #endregion

        #region Button Events

        private void btnNew_Click(object sender, EventArgs e)
        {
            EnableEditState();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string msg = string.Empty;
                if (dgvPGCEChoice.SelectedRows.Count.Equals(0))
                {
                    msg = "There is no selected item to delete.";
                    MessageBox.Show(msg, "Admissions", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    msg = "Are you sure you want to delete the selected subject?";
                    if (!MessageBox.Show(msg, "Admissions", MessageBoxButtons.YesNo, MessageBoxIcon.Question).Equals(DialogResult.Yes)) return;
                }

                int index = new BindingSource(ds_pgce_subjects, "tt_subject").Find("subj", dgvPGCEChoice.SelectedRows[0].Cells[cChoiceCode.Name].Value.ToString());
                if (index < 0) return;
                ds_pgce_subjects.tt_subject.Removett_subjectRow(ds_pgce_subjects.tt_subject[index]);
                dgvPGCEChoice.DataSource = ds_pgce_subjects.tt_subject;
            }
            catch (Exception ex)
            {
                Utils.HandleException(ExceptionSource.Admissions, ex);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbPGCEChoice.SelectedValue == null)
                {
                    string msg = "Select a subject to add from the list.";
                    errorProvider.SetError(cbPGCEChoice, msg); return;
                }

                if (ds_pgce_subjects == null) ds_pgce_subjects = new ds_subjectDataSet();
                int index = new BindingSource(ds_pgce_subjects, "tt_subject").Find("subj", cbPGCEChoice.SelectedValue.ToString());
                if (index >= 0)
                {
                    string msg = "The selected subject has already been added to subject list.";
                    MessageBox.Show(msg, "Admissions", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                index = new BindingSource(Global.Global.ds_subjects, "tt_subject").Find("subj", cbPGCEChoice.SelectedValue.ToString());
                if (index < 0) return;
                ds_pgce_subjects.tt_subject.LoadDataRow(Global.Global.ds_subjects.tt_subject[index].ItemArray, true);
                dgvPGCEChoice.DataSource = ds_pgce_subjects.tt_subject;
            }
            catch (Exception ex)
            {
                Utils.HandleException(ExceptionSource.Admissions, ex);
            }
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            DisableEditState();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            CommitCurrentDegreeDetails();
        }

        #endregion

        #region DataGridView Events

        void dgvPGCEChoice_DataBindingComplete(object sender, System.Windows.Forms.DataGridViewBindingCompleteEventArgs e)
        {
            dgvPGCEChoice.ClearSelection();
        }

        #endregion
    }
}

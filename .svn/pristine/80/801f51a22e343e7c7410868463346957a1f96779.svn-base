using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using RhodesWizard;
using Utilities;
using Admissions.Utilities;
using NS_Admissions.StrongTypesNS;
using NS_StuReg.StrongTypesNS;

namespace Admissions.AdmissionForms
{
    public partial class PGCEChoices : UserControl, IWizard
    {
        DS_ADM_STUDataSet ds_adm_stu;
        int deg_num = default(int), total_deg = default(int);

        ds_degreeDataSet ds_degrees;
        DS_PG_COURSEDataSet ds_pg_courses;
        ds_subjectDataSet ds_pgce_subjects;

        public PGCEChoices()
        {
            InitializeComponent();
            dgvPGCEChoice.AutoGenerateColumns = false;
        }

        #region IWizard Members

        public bool ShowView()
        {
            try
            {
                DisableEditState();
                if (ds_pg_courses == null) ds_pg_courses = Proxy.Admissions.Get_PG_Courses();
                if (ds_degrees == null) ds_degrees = Proxy.StudentRegistration.GetDegrees(Global.Global.tempyr);

                PopulateStudentDetails();
                if (!HasPGCDegree() && ds_adm_stu.TT_ADM.Rows.Count > 0)
                {
                    //TODO: Save data
                    return false;
                }

                LoadCurrentDegreeDetails();
            }
            catch (Exception ex)
            {
                Utils.HandleException(ExceptionSource.Admissions, ex);
            }
            return true;
        }

        public bool Next()
        {
            try
            {
                CommitCurrentDegreeDetails();
            }
            catch (Exception ex)
            {
                Utils.HandleException(ExceptionSource.Admissions, ex);
            }
            return true;
        }

        public void Back()
        {
            CommitCurrentDegreeDetails();
        }

        #endregion

        #region Local Methods

        void EnableEditState()
        {
            scPGCE.Panel2Collapsed = false;
            scPGCE.Panel1.Enabled = false;
        }

        void DisableEditState()
        {
            errorProvider.Clear();

            scPGCE.Panel2Collapsed = true;
            scPGCE.Panel1.Enabled = true;

            if (cbPGCEChoice.Items.Count > 0)
            { cbPGCEChoice.SelectedIndex = 0; }
        }

        void PopulateStudentDetails()
        {
            if (WizardEnvironment.State.ContainsKey(AdmissionStateItems.AdmissionStudent) && WizardEnvironment.State[AdmissionStateItems.AdmissionStudent] != null)
            {
                ds_adm_stu = (DS_ADM_STUDataSet)WizardEnvironment.State[AdmissionStateItems.AdmissionStudent];
            }
            else
            {
                ds_adm_stu = new DS_ADM_STUDataSet();
            }
            if (ds_adm_stu.TT_ADM.Rows.Count.Equals(0)) return;

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
                    ds_adm_stu.TT_ADM[0][string.Concat("PG_PGCE1", i)] = System.DBNull.Value;
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
                ds_adm_stu.TT_ADM[0][string.Concat("PG_PGCE1", deg_num)] = subj_choices;
            }
        }

        void LoadCurrentDegreeDetails()
        {
            if (deg_num > 0 && ds_adm_stu.TT_ADM.Rows.Count > 0)
            {
                string degree = string.Empty;
                int index = new BindingSource(ds_degrees, "tt_degree").Find("degr", ds_adm_stu.TT_ADM[0][string.Concat("PG_DEGR", deg_num)].ToString());
                if (index >= 0)
                {
                    degree = ds_degrees.tt_degree[index].degr;
                    lblDegreeName.Text = string.Concat(": ", ds_degrees.tt_degree[index].descrip);
                }
                else lblDegreeName.Text = ":";

                index = new BindingSource(Global.Global.ds_control, "tt_dept").Find("dcode", ds_adm_stu.TT_ADM[0][string.Concat("PG_DEPT1", deg_num)].ToString());
                if (index >= 0) lblDepartment1.Text = string.Concat(": ", Global.Global.ds_control.tt_dept[index].descrip);
                else lblDepartment1.Text = ":";

                index = new BindingSource(Global.Global.ds_control, "tt_dept").Find("dcode", ds_adm_stu.TT_ADM[0][string.Concat("PG_DEPT2", deg_num)].ToString());
                if (index >= 0) lblDepartment2.Text = string.Concat(": ", Global.Global.ds_control.tt_dept[index].descrip);
                else lblDepartment2.Text = ":";

                index = new BindingSource(ds_pg_courses, "TT_PG_COURSE").Find("CRSE_CODE", ds_adm_stu.TT_ADM[0][string.Concat("PG_CHOICE", deg_num)].ToString());
                if (index >= 0) lblPGChoice.Text = string.Concat(": ", ds_pg_courses.TT_PG_COURSE[index].PG_CHOICE);
                else lblPGChoice.Text = ":";

                ds_pgce_subjects = new ds_subjectDataSet();
                if (ds_adm_stu.TT_ADM[0][string.Concat("PG_PGCE1", deg_num)] != System.DBNull.Value && !string.IsNullOrEmpty(ds_adm_stu.TT_ADM[0][string.Concat("PG_PGCE1", deg_num)].ToString()))
                {
                    string[] subjects = ds_adm_stu.TT_ADM[0][string.Concat("PG_PGCE1", deg_num)].ToString().Split(',');
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

            lblDegNum.Text = string.Concat(deg_num, " of ", total_deg);
            UpdateNavigationButtons();
        }

        void UpdateNavigationButtons()
        {
            btnFirst.Enabled = btnPrev.Enabled = true;
            btnLast.Enabled = btnNext.Enabled = true;

            if (deg_num <= 1)
            {
                btnFirst.Enabled = btnPrev.Enabled = false;
            }

            if (deg_num.Equals(total_deg))
            {
                btnLast.Enabled = btnNext.Enabled = false;
            }
        }

        #endregion

        #region Button Events

        private void btnFirst_Click(object sender, EventArgs e)
        {
            int first_pgce = deg_num;
            for (int i = deg_num - 1; i >= 1; i--)
            {
                if (ds_adm_stu.TT_ADM[0][string.Concat("PG_DEGR", i)] == System.DBNull.Value ||
                    string.IsNullOrEmpty(ds_adm_stu.TT_ADM[0][string.Concat("PG_DEGR", i)].ToString()) ||
                    ds_adm_stu.TT_ADM[0][string.Concat("PG_DEGR", i)].ToString().StartsWith("PGCE")) first_pgce = i;
            }

            if (first_pgce.Equals(deg_num))
            {
                string msg = "This is the first PGCE degree in the degree list.";
                MessageBox.Show(msg, "Admissions", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                CommitCurrentDegreeDetails();
                deg_num = first_pgce;
                LoadCurrentDegreeDetails();
            }
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            int prev_pgce = deg_num;
            for (int i = deg_num - 1; i >= 1; i--)
            {
                if (ds_adm_stu.TT_ADM[0][string.Concat("PG_DEGR", i)] == System.DBNull.Value ||
                    string.IsNullOrEmpty(ds_adm_stu.TT_ADM[0][string.Concat("PG_DEGR", i)].ToString()) ||
                    ds_adm_stu.TT_ADM[0][string.Concat("PG_DEGR", i)].ToString().StartsWith("PGCE"))
                { prev_pgce = i; break; }
            }

            if (prev_pgce.Equals(deg_num))
            {
                string msg = "This is the first PGCE degree in the degree list.";
                MessageBox.Show(msg, "Admissions", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                CommitCurrentDegreeDetails();
                deg_num = prev_pgce;
                LoadCurrentDegreeDetails();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            int next_pgce = deg_num;
            for (int i = deg_num + 1; i <= total_deg; i++)
            {
                if (ds_adm_stu.TT_ADM[0][string.Concat("PG_DEGR", i)] == System.DBNull.Value ||
                    string.IsNullOrEmpty(ds_adm_stu.TT_ADM[0][string.Concat("PG_DEGR", i)].ToString()) ||
                    ds_adm_stu.TT_ADM[0][string.Concat("PG_DEGR", i)].ToString().StartsWith("PGCE"))
                { next_pgce = i; break; }
            }

            if (next_pgce.Equals(deg_num))
            {
                string msg = "This is the last PGCE degree in the degree list.";
                MessageBox.Show(msg, "Admissions", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                CommitCurrentDegreeDetails();
                deg_num = next_pgce;
                LoadCurrentDegreeDetails();
            }
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            int last_pgce = deg_num;
            for (int i = deg_num + 1; i <= total_deg; i++)
            {
                if (ds_adm_stu.TT_ADM[0][string.Concat("PG_DEGR", i)] == System.DBNull.Value || 
                    string.IsNullOrEmpty(ds_adm_stu.TT_ADM[0][string.Concat("PG_DEGR", i)].ToString()) || 
                    ds_adm_stu.TT_ADM[0][string.Concat("PG_DEGR", i)].ToString().StartsWith("PGCE")) last_pgce = i;
            }

            if (last_pgce.Equals(deg_num))
            {
                string msg = "This is the last PGCE degree in the degree list.";
                MessageBox.Show(msg, "Admissions", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                CommitCurrentDegreeDetails();
                deg_num = last_pgce;
                LoadCurrentDegreeDetails();
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            EnableEditState();
        }

        private void btnDelete_Click(object sender, EventArgs e)
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

        #endregion

        #region ComboBox Events

        private void cbPGCEChoice_SelectedIndexChanged(object sender, EventArgs e)
        {
            errorProvider.SetError(cbPGCEChoice, string.Empty);
        }

        #endregion

        #region DataGridView Events

        void dgvPGCEChoice_CellDoubleClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {
            
        }

        void dgvPGCEChoice_DataBindingComplete(object sender, System.Windows.Forms.DataGridViewBindingCompleteEventArgs e)
        {
            dgvPGCEChoice.ClearSelection();
        }

        #endregion
    }
}

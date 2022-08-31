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
using NS_Admissions.StrongTypesNS;
using NS_StuReg.StrongTypesNS;
using Admissions.Utilities;
using Admissions.UtilityScreens;

namespace Admissions.AdmissionForms
{
    public partial class PGCEStudentSubjectChoices : UserControl, IWizard
    {
        DS_ADM_STUDataSet ds_adm_stu;
        int deg_num = default(int), total_deg = default(int);

        ds_degreeDataSet ds_degrees;
        ds_degreeDataSet ds_stu_degrees;
        DS_PG_COURSEDataSet ds_pg_courses;

        public PGCEStudentSubjectChoices()
        {
            InitializeComponent();
        }

        #region IWizard Members

        public bool ShowView()
        {
            try
            {
                if (ds_pg_courses == null) ds_pg_courses = Proxy.Admissions.Get_PG_Courses();
                if (ds_degrees == null) ds_degrees = Proxy.StudentRegistration.GetDegrees(Global.Global.tempyr);

                PopulateStudentDetails();

                if (!HasPGCDegree()) return false;
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
                string temperror = Proxy.Admissions.Save_PGCE_Subject_Choices(ds_adm_stu);
                if (!string.IsNullOrEmpty(temperror))
                {
                    MessageBox.Show(temperror, "Admissions", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            catch (Exception ex)
            {
                Utils.HandleException(ExceptionSource.Admissions, ex);
                return false;
            }
            return true;
        }

        public void Back()
        {
            
        }

        #endregion

        #region Local Methods

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

        void PopulateStudentDetails()
        {
            total_deg = default(int);
            ds_stu_degrees = new ds_degreeDataSet();
            if (WizardEnvironment.State.ContainsKey(AdmissionStateItems.AdmissionStudent) && WizardEnvironment.State[AdmissionStateItems.AdmissionStudent] != null)
            {
                ds_adm_stu = (DS_ADM_STUDataSet)WizardEnvironment.State[AdmissionStateItems.AdmissionStudent];
            }
            else
            {
                ds_adm_stu = new DS_ADM_STUDataSet();
            }
            if (ds_adm_stu.TT_ADM.Rows.Count.Equals(0)) return;

            for (int i = 1; i <= 8; i++)
            {
                if (ds_adm_stu.TT_ADM[0][string.Concat("PG_DEGR", i)] != System.DBNull.Value &&
                    !string.IsNullOrEmpty(ds_adm_stu.TT_ADM[0][string.Concat("PG_DEGR", i)].ToString()))
                {
                    total_deg++;
                    int index = new BindingSource(ds_degrees, "tt_degree").Find("degr", ds_adm_stu.TT_ADM[0][string.Concat("PG_DEGR", i)].ToString());
                    if (index >= 0) ds_stu_degrees.tt_degree.LoadDataRow(ds_degrees.tt_degree[index].ItemArray, false);
                }
                else break;
            }

            DataView dvStudentDegrees = new DataView(ds_stu_degrees.tt_degree);
            dvStudentDegrees.RowFilter = "degr like '*PGCE*'";
            cbDegree.DataSource = dvStudentDegrees;
        }

        void LoadCurrentDegreeDetails()
        {
            if (cbDegree.SelectedValue == null) return;
            int i = new BindingSource(ds_stu_degrees, "tt_degree").Find("degr", cbDegree.SelectedValue);
            if (i < 0) return;
            else deg_num = i + 1;

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

                if (!string.IsNullOrEmpty(degree))
                {
                    if (degree.StartsWith("PGCE"))
                    {
                        lblPGCESubjects.Text = ": ";
                        lblPGCESubj.Visible = lblPGCESubjects.Visible = btnSubj.Visible = true;

                        if (ds_adm_stu.TT_ADM[0][string.Concat("PG_PGCE", deg_num)] != System.DBNull.Value && !string.IsNullOrEmpty(ds_adm_stu.TT_ADM[0][string.Concat("PG_PGCE", deg_num)].ToString()))
                        {
                            string mnemonics = string.Empty;
                            List<string> subjects = new List<string>(ds_adm_stu.TT_ADM[0][string.Concat("PG_PGCE", deg_num)].ToString().Split(','));
                            subjects.ForEach(delegate(string subject)
                            {
                                index = new BindingSource(Global.Global.ds_subjects, "tt_subject").Find("subj", subject);
                                if (index >= 0)
                                {
                                    if (!string.IsNullOrEmpty(mnemonics)) mnemonics += ",";
                                    mnemonics += Global.Global.ds_subjects.tt_subject[index].mnemonic;
                                }
                            });
                            lblPGCESubjects.Text += mnemonics;
                        }
                    }
                    else
                    {
                        lblPGCESubjects.Text = ":";
                        lblPGCESubj.Visible = lblPGCESubjects.Visible = btnSubj.Visible = false;
                    }

                    int x = lblPGCESubjects.Location.X + lblPGCESubjects.Width + 5;
                    if (x > 650) x = 650;
                    btnSubj.Location = new Point(x, btnSubj.Location.Y);
                }

                index = new BindingSource(Global.Global.ds_control, "tt_dept").Find("dcode", ds_adm_stu.TT_ADM[0][string.Concat("PG_DEPT1", deg_num)].ToString());
                if (index >= 0) lblDepartment1.Text = string.Concat(": ", Global.Global.ds_control.tt_dept[index].descrip);
                else lblDepartment1.Text = ":";

                index = new BindingSource(Global.Global.ds_control, "tt_dept").Find("dcode", ds_adm_stu.TT_ADM[0][string.Concat("PG_DEPT2", deg_num)].ToString());
                if (index >= 0) lblDepartment2.Text = string.Concat(": ", Global.Global.ds_control.tt_dept[index].descrip);
                else lblDepartment2.Text = ":";

                index = new BindingSource(ds_pg_courses, "TT_PG_COURSE").Find("CRSE_CODE", ds_adm_stu.TT_ADM[0][string.Concat("PG_CHOICE", deg_num)].ToString());
                if (index >= 0) lblPGChoice.Text = string.Concat(": ", ds_pg_courses.TT_PG_COURSE[index].PG_CHOICE);
                else lblPGChoice.Text = ":";
            }
        }

        #endregion

        #region Button Events

        private void btnSubj_Click(object sender, EventArgs e)
        {
            try
            {
                PGCESubjectChoices subjectChoices = new PGCESubjectChoices(ds_adm_stu, deg_num);
                if (subjectChoices.ShowDialog().Equals(DialogResult.OK))
                {
                    LoadCurrentDegreeDetails();
                }
            }
            catch (Exception ex)
            {
                Utils.HandleException(ExceptionSource.Admissions, ex);
            }
        }

        #endregion

        #region ComboBox Events

        private void cbDegree_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                LoadCurrentDegreeDetails();
            }
            catch (Exception ex)
            {
                Utils.HandleException(ExceptionSource.Admissions, ex);
            }
        }

        #endregion
    }
}

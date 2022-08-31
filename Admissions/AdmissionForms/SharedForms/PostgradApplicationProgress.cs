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
using Admissions.Utilities;
using NS_StuReg.StrongTypesNS;
using Admissions.UtilityScreens;

namespace Admissions.AdmissionForms
{
    public partial class PostgradApplicationProgress : UserControl, IWizard
    {
        DS_ADM_STUDataSet ds_adm_stu;
        int deg_num = default(int), total_deg = default(int);
        bool read_only;

        ds_degreeDataSet ds_degrees;
        ds_degreeDataSet ds_stu_degrees;
        DS_PG_COURSEDataSet ds_pg_courses;

        public PostgradApplicationProgress()
        {
            InitializeComponent();
            read_only = false;
        }

        public PostgradApplicationProgress(bool read_only)
            : this()
        {
            this.read_only = read_only;
            if (read_only == true)
            {
                txtComments.Enabled = gbDates.Enabled = gbConditions.Enabled = btnSubj.Enabled = false;
            }            
        }

        #region IWizard Members

        public bool ShowView()
        {
            try
            {
                ResetDates();

                if (ds_pg_courses == null) ds_pg_courses = Proxy.Admissions.Get_PG_Courses();
                if (ds_degrees == null) ds_degrees = Proxy.StudentRegistration.GetDegrees(Global.Global.tempyr);

                PopulateStudentDetails();
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

                string tempwarning = string.Empty, part_full_time = "F";
                int app_type = (int)WizardEnvironment.State[AdmissionStateItems.ApplicationType];
                bool session = (bool)WizardEnvironment.State[AdmissionStateItems.ApplicationSession];
                bool dean_appr = true, attend = true;

                //TODO: Get other method variables

                string feedback = Proxy.Admissions.Save_Postgraduate_Application_Progress(app_type, session, ds_adm_stu, dean_appr, attend, part_full_time, out tempwarning);
                if (!string.IsNullOrEmpty(feedback))
                {
                    MessageBox.Show(feedback, "Admissions", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                else if (!string.IsNullOrEmpty(tempwarning))
                {
                    MessageBox.Show(tempwarning, "Admissions", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            CommitCurrentDegreeDetails();
        }

        #endregion

        #region Local Methods

        void PopulateStudentDetails()
        {
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

            total_deg = default(int);
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
            cbDegree.DataSource = ds_stu_degrees.tt_degree;

            if (WizardEnvironment.State.ContainsKey(AdmissionStateItems.DefaultDegreeChoice) && WizardEnvironment.State[AdmissionStateItems.DefaultDegreeChoice] != null)
            {
                string default_deg = WizardEnvironment.State[AdmissionStateItems.DefaultDegreeChoice].ToString();
                int index = Int32.Parse(default_deg) - 1;
                if (index >= 0 && index < cbDegree.Items.Count) cbDegree.SelectedIndex = index;
            }

            /*
            if (WizardEnvironment.State.ContainsKey(AdmissionStateItems.DefaultProgressDegree) && WizardEnvironment.State[AdmissionStateItems.DefaultProgressDegree] != null)
            {
                string default_deg = WizardEnvironment.State[AdmissionStateItems.DefaultProgressDegree].ToString();
                int index = new BindingSource(ds_stu_degrees, "tt_degree").Find("degr", default_deg);
                if (index >= 0 && index < cbDegree.Items.Count) cbDegree.SelectedIndex = index;
            }
             */
        }

        void CommitCurrentDegreeDetails()
        {
            if (deg_num > 0)
            {
                if (txtComments.Text.Trim().Equals(string.Empty)) ds_adm_stu.TT_ADM[0][string.Concat("PG_COMMENTS1", deg_num)] = System.DBNull.Value;
                else ds_adm_stu.TT_ADM[0][string.Concat("PG_COMMENTS1", deg_num)] = txtComments.Text.Trim();

                if (txtComments.Text.Trim().Equals(string.Empty)) ds_adm_stu.TT_ADM[0][string.Concat("PG_COMMENTS1", deg_num)] = System.DBNull.Value;
                else ds_adm_stu.TT_ADM[0][string.Concat("PG_COMMENTS1", deg_num)] = txtComments.Text.Trim();

                if (nudProvOffer.Value == null) ds_adm_stu.TT_ADM[0][string.Concat("PG_PROV_OF", deg_num)] = System.DBNull.Value;
                else ds_adm_stu.TT_ADM[0][string.Concat("PG_PROV_OF", deg_num)] = (DateTime)nudProvOffer.Value;

                if (nudProvOfferDept1.Value == null) ds_adm_stu.TT_ADM[0][string.Concat("PG_DEPT1_POFF_DTE", deg_num)] = System.DBNull.Value;
                else ds_adm_stu.TT_ADM[0][string.Concat("PG_DEPT1_POFF_DTE", deg_num)] = nudProvOfferDept1.Value;

                if (nudProvOfferDept2.Value == null) ds_adm_stu.TT_ADM[0][string.Concat("PG_DEPT2_POFF_DTE", deg_num)] = System.DBNull.Value;
                else ds_adm_stu.TT_ADM[0][string.Concat("PG_DEPT2_POFF_DTE", deg_num)] = nudProvOfferDept2.Value;

                if (nudOffer.Value == null) ds_adm_stu.TT_ADM[0][string.Concat("PG_OFF_DTE", deg_num)] = System.DBNull.Value;
                else ds_adm_stu.TT_ADM[0][string.Concat("PG_OFF_DTE", deg_num)] = nudOffer.Value;

                if (nudOfferDept1.Value == null) ds_adm_stu.TT_ADM[0][string.Concat("PG_DEPT1_OFFER_DTE", deg_num)] = System.DBNull.Value;
                else ds_adm_stu.TT_ADM[0][string.Concat("PG_DEPT1_OFFER_DTE", deg_num)] = nudOfferDept1.Value;

                if (nudOfferDept2.Value == null) ds_adm_stu.TT_ADM[0][string.Concat("PG_DEPT2_OFFER_DTE", deg_num)] = System.DBNull.Value;
                else ds_adm_stu.TT_ADM[0][string.Concat("PG_DEPT2_OFFER_DTE", deg_num)] = nudOfferDept2.Value;

                if (nudWaitList.Value == null) ds_adm_stu.TT_ADM[0][string.Concat("PG_WL_DTE", deg_num)] = System.DBNull.Value;
                else ds_adm_stu.TT_ADM[0][string.Concat("PG_WL_DTE", deg_num)] = nudWaitList.Value;

                if (nudWaitListDept1.Value == null) ds_adm_stu.TT_ADM[0][string.Concat("PG_DEPT1_WL_DTE", deg_num)] = System.DBNull.Value;
                else ds_adm_stu.TT_ADM[0][string.Concat("PG_DEPT1_WL_DTE", deg_num)] = nudWaitListDept1.Value;

                if (nudWaitListDept2.Value == null) ds_adm_stu.TT_ADM[0][string.Concat("PG_DEPT2_WL_DTE", deg_num)] = System.DBNull.Value;
                else ds_adm_stu.TT_ADM[0][string.Concat("PG_DEPT2_WL_DTE", deg_num)] = nudWaitListDept2.Value;

                if (nudDeclined.Value == null) ds_adm_stu.TT_ADM[0][string.Concat("PG_REJ_DTE", deg_num)] = System.DBNull.Value;
                else ds_adm_stu.TT_ADM[0][string.Concat("PG_REJ_DTE", deg_num)] = nudDeclined.Value;

                if (nudAccept.Value == null) ds_adm_stu.TT_ADM[0][string.Concat("PG_ACCEPT_DTE", deg_num)] = System.DBNull.Value;
                else ds_adm_stu.TT_ADM[0][string.Concat("PG_ACCEPT_DTE", deg_num)] = nudAccept.Value;

                if (nudRefuse.Value == null) ds_adm_stu.TT_ADM[0][string.Concat("PG_REFUSE_DTE", deg_num)] = System.DBNull.Value;
                else ds_adm_stu.TT_ADM[0][string.Concat("PG_REFUSE_DTE", deg_num)] = nudRefuse.Value;

                if (nudCancel.Value == null) ds_adm_stu.TT_ADM[0][string.Concat("PG_XL_DTE", deg_num)] = System.DBNull.Value;
                else ds_adm_stu.TT_ADM[0][string.Concat("PG_XL_DTE", deg_num)] = nudCancel.Value;

                if (nudPaid.Value == null) ds_adm_stu.TT_ADM[0][string.Concat("PG_PD_DTE", deg_num)] = System.DBNull.Value;
                else ds_adm_stu.TT_ADM[0][string.Concat("PG_PD_DTE", deg_num)] = nudPaid.Value;

                if (txtDept1Condition.Text == string.Empty) ds_adm_stu.TT_ADM[0][string.Concat("PG_DEPT1_CONDITIONS", deg_num)] = System.DBNull.Value;
                else ds_adm_stu.TT_ADM[0][string.Concat("PG_DEPT1_CONDITIONS", deg_num)] = txtDept1Condition.Text;

                if (txtDept2Condition.Text == string.Empty) ds_adm_stu.TT_ADM[0][string.Concat("PG_DEPT2_CONDITIONS", deg_num)] = System.DBNull.Value;
                else ds_adm_stu.TT_ADM[0][string.Concat("PG_DEPT2_CONDITIONS", deg_num)] = txtDept2Condition.Text;
            }
        }

        void LoadCurrentDegreeDetails()
        {
            if (deg_num <= 0 && total_deg > 0) deg_num = 1;

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
                
                //Only use one PG Comments field (PG_COMMENTS1)
                if (ds_adm_stu.TT_ADM[0][string.Concat("APP_STATUS", deg_num)] == System.DBNull.Value) lblAppStatus.Text = string.Empty;
                else lblAppStatus.Text = ds_adm_stu.TT_ADM[0][string.Concat("APP_STATUS", deg_num)].ToString();
                
                if (ds_adm_stu.TT_ADM[0][string.Concat("PG_COMMENTS1", deg_num)] == System.DBNull.Value) txtComments.Text = string.Empty;
                else txtComments.Text = ds_adm_stu.TT_ADM[0][string.Concat("PG_COMMENTS1", deg_num)].ToString();

                if (ds_adm_stu.TT_ADM[0][string.Concat("PG_PROV_OF", deg_num)] == System.DBNull.Value) nudProvOffer.Value = null;
                else nudProvOffer.Value = ds_adm_stu.TT_ADM[0][string.Concat("PG_PROV_OF", deg_num)];

                if (ds_adm_stu.TT_ADM[0][string.Concat("PG_DEPT1_POFF_DTE", deg_num)] == System.DBNull.Value) nudProvOfferDept1.Value = null;
                else nudProvOfferDept1.Value = ds_adm_stu.TT_ADM[0][string.Concat("PG_DEPT1_POFF_DTE", deg_num)];

                if (ds_adm_stu.TT_ADM[0][string.Concat("PG_DEPT2_POFF_DTE", deg_num)] == System.DBNull.Value) nudProvOfferDept2.Value = null;
                else nudProvOfferDept2.Value = ds_adm_stu.TT_ADM[0][string.Concat("PG_DEPT2_POFF_DTE", deg_num)];

                if (ds_adm_stu.TT_ADM[0][string.Concat("PG_OFF_DTE", deg_num)] == System.DBNull.Value) nudOffer.Value = null;
                else nudOffer.Value = ds_adm_stu.TT_ADM[0][string.Concat("PG_OFF_DTE", deg_num)];

                if (ds_adm_stu.TT_ADM[0][string.Concat("PG_DEPT1_OFFER_DTE", deg_num)] == System.DBNull.Value) nudOfferDept1.Value = null;
                else nudOfferDept1.Value = ds_adm_stu.TT_ADM[0][string.Concat("PG_DEPT1_OFFER_DTE", deg_num)];

                if (ds_adm_stu.TT_ADM[0][string.Concat("PG_DEPT2_OFFER_DTE", deg_num)] == System.DBNull.Value) nudOfferDept2.Value = null;
                else nudOfferDept2.Value = ds_adm_stu.TT_ADM[0][string.Concat("PG_DEPT2_OFFER_DTE", deg_num)];

                if (ds_adm_stu.TT_ADM[0][string.Concat("PG_WL_DTE", deg_num)] == System.DBNull.Value) nudWaitList.Value = null;
                else nudWaitList.Value = ds_adm_stu.TT_ADM[0][string.Concat("PG_WL_DTE", deg_num)];

                if (ds_adm_stu.TT_ADM[0][string.Concat("PG_DEPT1_WL_DTE", deg_num)] == System.DBNull.Value) nudWaitListDept1.Value = null;
                else nudWaitListDept1.Value = ds_adm_stu.TT_ADM[0][string.Concat("PG_DEPT1_WL_DTE", deg_num)];

                if (ds_adm_stu.TT_ADM[0][string.Concat("PG_DEPT2_WL_DTE", deg_num)] == System.DBNull.Value) nudWaitListDept2.Value = null;
                else nudWaitListDept2.Value = ds_adm_stu.TT_ADM[0][string.Concat("PG_DEPT2_WL_DTE", deg_num)];

                if (ds_adm_stu.TT_ADM[0][string.Concat("PG_REJ_DTE", deg_num)] == System.DBNull.Value) nudDeclined.Value = null;
                else nudDeclined.Value = ds_adm_stu.TT_ADM[0][string.Concat("PG_REJ_DTE", deg_num)];

                if (ds_adm_stu.TT_ADM[0][string.Concat("PG_ACCEPT_DTE", deg_num)] == System.DBNull.Value) nudAccept.Value = null;
                else nudAccept.Value = ds_adm_stu.TT_ADM[0][string.Concat("PG_ACCEPT_DTE", deg_num)];

                if (ds_adm_stu.TT_ADM[0][string.Concat("PG_REFUSE_DTE", deg_num)] == System.DBNull.Value) nudRefuse.Value = null;
                else nudRefuse.Value = ds_adm_stu.TT_ADM[0][string.Concat("PG_REFUSE_DTE", deg_num)];

                if (ds_adm_stu.TT_ADM[0][string.Concat("PG_XL_DTE", deg_num)] == System.DBNull.Value) nudCancel.Value = null;
                else nudCancel.Value = ds_adm_stu.TT_ADM[0][string.Concat("PG_XL_DTE", deg_num)];

                if (ds_adm_stu.TT_ADM[0][string.Concat("PG_PD_DTE", deg_num)] == System.DBNull.Value) nudPaid.Value = null;
                else nudPaid.Value = ds_adm_stu.TT_ADM[0][string.Concat("PG_PD_DTE", deg_num)];

                if (ds_adm_stu.TT_ADM[0][string.Concat("PG_DEPT1_CONDITIONS", deg_num)] == System.DBNull.Value) txtDept1Condition.Text = string.Empty;
                else txtDept1Condition.Text = ds_adm_stu.TT_ADM[0][string.Concat("PG_DEPT1_CONDITIONS", deg_num)].ToString();

                if (ds_adm_stu.TT_ADM[0][string.Concat("PG_DEPT2_CONDITIONS", deg_num)] == System.DBNull.Value) txtDept2Condition.Text = string.Empty;
                else txtDept2Condition.Text = ds_adm_stu.TT_ADM[0][string.Concat("PG_DEPT2_CONDITIONS", deg_num)].ToString();
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

        void ResetDates()
        {
            nudProvOffer.Value = nudProvOfferDept1.Value = nudProvOfferDept2.Value = null;
            nudOffer.Value = nudOfferDept1.Value = nudOfferDept2.Value = null;
            nudWaitList.Value = nudWaitListDept1.Value = nudWaitListDept2.Value = null;
            nudDeclined.Value = nudAccept.Value = nudRefuse.Value = nudCancel.Value = nudPaid.Value = null;
        }

        #endregion

        #region Button Events

        private void btnFirst_Click(object sender, EventArgs e)
        {
            CommitCurrentDegreeDetails();
            if (total_deg > 0) deg_num = 1;
            LoadCurrentDegreeDetails();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            CommitCurrentDegreeDetails();
            if (deg_num > 0) deg_num--;
            LoadCurrentDegreeDetails();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            CommitCurrentDegreeDetails();
            if (deg_num < total_deg) deg_num++;
            LoadCurrentDegreeDetails();
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            CommitCurrentDegreeDetails();
            if (deg_num < total_deg) deg_num = total_deg;
            LoadCurrentDegreeDetails();
        }

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

        #region NumericUpDown Events

        private void nudProvOffer_ValueChanged(object sender, EventArgs e)
        {
            if (nudProvOffer.Value != null)
            {
                nudProvOfferDept1.Enabled = nudProvOfferDept2.Enabled = true;
            }
            else
            {
                nudProvOfferDept1.Value = nudProvOfferDept2.Value = null;
                nudProvOfferDept1.Enabled = nudProvOfferDept2.Enabled = false;
            }
        }

        private void nudOffer_ValueChanged(object sender, EventArgs e)
        {
            if (nudOffer.Value != null)
            {
                nudOfferDept1.Enabled = nudOfferDept2.Enabled = true;
            }
            else
            {
                nudOfferDept1.Value = nudOfferDept2.Value = null;
                nudOfferDept1.Enabled = nudOfferDept2.Enabled = false;
            }
        }

        private void nudWaitList_ValueChanged(object sender, EventArgs e)
        {
            if (nudWaitList.Value != null)
            {
                nudWaitListDept1.Enabled = nudWaitListDept2.Enabled = true;
            }
            else
            {
                nudWaitListDept1.Value = nudWaitListDept2.Value = null;
                nudWaitListDept1.Enabled = nudWaitListDept2.Enabled = false;
            }
        }

        #endregion

        #region ComboBox Events

        private void cbDegree_SelectedIndexChanged(object sender, EventArgs e)
        {
            CommitCurrentDegreeDetails();
            deg_num = cbDegree.SelectedIndex + 1;
            LoadCurrentDegreeDetails();
        }

        #endregion
    }
}

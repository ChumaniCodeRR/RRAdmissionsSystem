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
using NS_System.StrongTypesNS;
using Admissions.Utilities;
using NS_StuReg.StrongTypesNS;
using Admissions.UtilityScreens;
using Admissions.EventArguments;
using NS_Admissions.StrongTypesNS;

namespace Admissions.AdmissionForms
{
    public partial class StudentDegreeDetails : UserControl, IWizard
    {
        #region Local Variables

        ds_genDataSet ds_codes;
        ds_genDataSet ds_deg1_subj, ds_deg2_subj;
        DS_ADM_STUDataSet ds_adm_stu;
        ds_degreeDataSet ds_degrees;

        bool ask_law, ask_mus, ask_art, ask_bis;

        #endregion

        #region Constructors

        public StudentDegreeDetails()
        {
            InitializeComponent();

            dgvPossibleSubj1.AutoGenerateColumns = false;
            dgvPossibleSubj2.AutoGenerateColumns = false;
        }

        #endregion

        #region Overriden Methods

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData.Equals(Keys.Control | Keys.C))
            {
                ckProposedReg.Checked = ckFirstDegree.Checked = ckSecondDegree.Checked = true;
                return true;
            }
            else return base.ProcessCmdKey(ref msg, keyData);
        }

        #endregion

        #region IWizard Members

        public bool ShowView()
        {
            try
            {
                PopuleteComboBoxes();
                GetSubjectChoicesLookup();
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
                if (!IsValidDegreeChecks()) return false;

                string temperror = string.Empty;

                #region Load Degrees And Faculties

                ds_adm_stu.TT_ADM[0].DEGR1 = txtDeg1.Text.Trim().ToUpper();
                ds_adm_stu.TT_ADM[0].DEGR2 = txtDeg2.Text.Trim().ToUpper();

                string fac1 = string.Empty, fac2 = string.Empty;
                temperror = Proxy.Admissions.Get_Faculties_By_Degrees(ds_adm_stu.TT_ADM[0].DEGR1, ds_adm_stu.TT_ADM[0].DEGR2, out fac1, out fac2);
                if (!string.IsNullOrEmpty(temperror))
                {
                    MessageBox.Show(temperror, "Admissions", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                ds_adm_stu.TT_ADM[0].FAC1 = fac1;
                ds_adm_stu.TT_ADM[0].FAC2 = fac2;

                #endregion

                #region Load Possible Degree 1 Subjects
                int x = 0;
                foreach (DataGridViewRow subj in dgvPossibleSubj1.Rows)
                {
                    x++;
                    string columnName = string.Concat("subject1", x);
                    ds_adm_stu.TT_ADM_STU[0][columnName] = subj.Cells[cPossCode1.Name].Value;
                }

                while (x < 5)
                {
                    x++;
                    string columnName = string.Concat("subject1", x);
                    ds_adm_stu.TT_ADM_STU[0][columnName] = string.Empty;
                }
                #endregion

                #region Load Possible Degree 2 Subjects
                x = 0;
                foreach (DataGridViewRow subj in dgvPossibleSubj2.Rows)
                {
                    x++;
                    string columnName = string.Concat("subject2", x);
                    ds_adm_stu.TT_ADM_STU[0][columnName] = subj.Cells[cPossCode2.Name].Value;
                }

                while (x < 5)
                {
                    x++;
                    string columnName = string.Concat("subject2", x);
                    ds_adm_stu.TT_ADM_STU[0][columnName] = string.Empty;
                }
                #endregion



                bool currentstudent = false;
                int app_type = (int)WizardEnvironment.State[AdmissionStateItems.ApplicationType];
                bool tempsession = (bool)WizardEnvironment.State[AdmissionStateItems.ApplicationSession], declined, cont_update, add_school = false;
                string declined_msg = string.Empty;

                bsAdmStudent.EndEdit();

                bool degChange = false;
                temperror = Proxy.Admissions.Save_Degree_Choice(app_type, tempsession, out currentstudent, ref ds_adm_stu);
                if (!string.IsNullOrEmpty(temperror))
                {
                    MessageBox.Show(temperror, "Admissions", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                /*   if (cbDeg2.SelectedValue != null && cbDeg2.SelectedValue.ToString().StartsWith("LLB") || cbDeg1.SelectedValue != null && cbDeg1.SelectedValue.ToString().StartsWith("LLB"))
                   {
                       temperror = Proxy.Admissions.Save_Matric_Subject_Details(Global.Global.FromWhere,app_type, tempsession, ref ds_adm_stu, Global.Global.admissions_view, "Display", out declined_msg, out cont_update);
                       if (!string.IsNullOrEmpty(temperror))
                       {
                           MessageBox.Show(temperror, "Admissions", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                       }

                       Global.Global.ChangeShow = "Show";

                       MatricPoints points = new MatricPoints(Global.Global.admissions_view, ds_adm_stu, "");                    
                       points.ShowDialog();
                       degChange = points.degChange;

                       if(degChange) return false;
                   } */




                WizardEnvironment.State[AdmissionStateItems.AdmissionStudent] = ds_adm_stu;

            }
            catch (Exception ex)
            {
                Utils.HandleException(ExceptionSource.Admissions, ex);
            }
            return true;
        }

        public void Back()
        {

        }

        #endregion

        #region Local Methods

        void PopuleteComboBoxes()
        {
            if (cbRegStatus.Items.Count.Equals(0))
            {
                ds_genDataSet ds_reg_status = Proxy.System.Get_Gen("TRUE", "RS");
                cbRegStatus.DataSource = ds_reg_status.TT_GEN;
            }

            if (cbDeg1.Items.Count.Equals(0) || cbDeg2.Items.Count.Equals(0))
            {
                ds_degrees = Proxy.StudentRegistration.GetDegrees(DateTime.Today.Year);

                ds_degreeDataSet ds_degr1 = (ds_degreeDataSet)ds_degrees.Copy();
                ds_degreeDataSet.tt_degreeRow deg1Default = ds_degr1.tt_degree.Newtt_degreeRow();
                ds_degr1.tt_degree.Addtt_degreeRow("0", "[Please Select]", "[Please Select]");
                DataView dvDegree1 = new DataView(ds_degr1.tt_degree);
                dvDegree1.Sort = "descrip";
                if (Global.Global.IsGadra == true) dvDegree1.RowFilter = "[degr] LIKE 'SP*' or [degr] = '0'";
                cbDeg1.DataSource = dvDegree1;
                

                ds_degreeDataSet ds_degr2 = (ds_degreeDataSet)ds_degrees.Copy();
                ds_degreeDataSet.tt_degreeRow deg2Default = ds_degr2.tt_degree.Newtt_degreeRow();
                ds_degr2.tt_degree.Addtt_degreeRow("0", "[Please Select]", "[Please Select]");
                DataView dvDegree2 = new DataView(ds_degr2.tt_degree);
                dvDegree2.Sort = "descrip";
                if (Global.Global.IsGadra == true) dvDegree2.RowFilter = "[degr] LIKE 'SP*' or  [degr] = '0'";
                cbDeg2.DataSource = dvDegree2;
                

            }

            if (cbAcademicStatus.Items.Count.Equals(0))
            {
                List<BooleanStringBinding> status = new List<BooleanStringBinding>();
                status.Add(new BooleanStringBinding(true, "Undergraduate"));
                status.Add(new BooleanStringBinding(false, "Postgraduate"));
                cbAcademicStatus.DataSource = status;
            }

            if (cbEntryStatus.Items.Count.Equals(0))
            {
                ds_genDataSet ds_entry_level = Proxy.System.Get_Gen("TRUE", "ES");
                cbEntryStatus.DataSource = ds_entry_level.TT_GEN;
            }
        }

        void GetSubjectChoicesLookup()
        {
            if (ds_codes == null)
            { ds_codes = Proxy.System.Get_Gen("TRUE", "SC"); }
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
            bsAdmStudent.DataSource = ds_adm_stu.TT_ADM_STU;
            bsAdmissions.DataSource = ds_adm_stu.TT_ADM;

            if (ds_adm_stu.TT_ADM.Rows.Count > 0)
            {
                txtDeg1.Text = !ds_adm_stu.TT_ADM[0].IsDEGR1Null() ? ds_adm_stu.TT_ADM[0].DEGR1 : string.Empty;
                txtDeg2.Text = !ds_adm_stu.TT_ADM[0].IsDEGR2Null() ? ds_adm_stu.TT_ADM[0].DEGR2 : string.Empty;
            }

            LoadFirstChoiceDegree();
            LoadSecondChoiceDegree();

            LoadFirstChoiceSubjects();
            LoadSecondChoiceSubjects();

            dgvPossibleSubj1.ClearSelection();
            dgvPossibleSubj2.ClearSelection();

            cbDeg1_SelectedIndexChanged(cbDeg1, EventArgs.Empty);
            cbDeg2_SelectedIndexChanged(cbDeg2, EventArgs.Empty);
        }

        void LoadFirstChoiceDegree()
        {
            if (!string.IsNullOrEmpty(txtDeg1.Text.Trim()))
            {
                cbDeg1.SelectedValue = txtDeg1.Text.Trim();

                if (cbDeg1.SelectedValue == null && cbDeg1.Items.Count > 0)
                { cbDeg1.SelectedValue = 0; }
            }
        }

        void LoadSecondChoiceDegree()
        {
            if (!string.IsNullOrEmpty(txtDeg2.Text.Trim()))
            {
                cbDeg2.SelectedValue = txtDeg2.Text.Trim();

                if (cbDeg2.SelectedValue == null && cbDeg2.Items.Count > 0)
                { cbDeg2.SelectedIndex = 0; }
            }
        }

        void LoadFirstChoiceSubjects()
        {
            if (dgvPossibleSubj1.Rows.Count > 0) return;

            List<string> subjects = new List<string>();

            int x = 0;
            do
            {
                x++;
                string columnName = string.Concat("subject1", x);
                if (ds_adm_stu.TT_ADM_STU[0][columnName] == System.DBNull.Value) continue;

                string subject = ds_adm_stu.TT_ADM_STU[0][columnName].ToString();
                if (string.IsNullOrEmpty(subject)) continue;

                subjects.Add(subject);
            }
            while (x < 5);

            if (subjects.Count > 0)
            {
                SubjectChoice choices = new SubjectChoice(ds_codes, (int)Enumerations.DegreeChoice.FirstDegree, subjects, cbDeg1.Text);
                choices.SubjectChoiceSelected += new EventHandler<SubjectChoiceSelected>(choices_SubjectChoiceSelected);
                choices.AddSubjectChoices();
            }
        }

        void LoadSecondChoiceSubjects()
        {
            if (dgvPossibleSubj2.Rows.Count > 0) return;

            List<string> subjects = new List<string>();

            int x = 0;
            do
            {
                x++;
                string columnName = string.Concat("subject2", x);
                if (ds_adm_stu.TT_ADM_STU[0][columnName] == System.DBNull.Value) continue;

                string subject = ds_adm_stu.TT_ADM_STU[0][columnName].ToString();
                if (string.IsNullOrEmpty(subject)) continue;

                subjects.Add(subject);
            }
            while (x < 5);

            if (subjects.Count > 0)
            {
                SubjectChoice choices = new SubjectChoice(ds_codes, (int)Enumerations.DegreeChoice.SecondDegree, subjects, cbDeg2.Text);
                choices.SubjectChoiceSelected += new EventHandler<SubjectChoiceSelected>(choices_SubjectChoiceSelected);
                choices.AddSubjectChoices();
            }
        }

        void ValidateDegreeAdditionalInfo()
        {
            try
            {
                if (ds_adm_stu == null || ds_adm_stu.TT_ADM_STU.Rows.Count.Equals(0)) return;

                string temperror = string.Empty;
                string deg1 = cbDeg1.SelectedValue != null && !cbDeg1.SelectedValue.ToString().Equals("0") ? cbDeg1.SelectedValue.ToString() : string.Empty;
                string deg2 = cbDeg2.SelectedValue != null && !cbDeg2.SelectedValue.ToString().Equals("0") ? cbDeg2.SelectedValue.ToString() : string.Empty;

                string fac1 = string.Empty, fac2 = string.Empty;
                temperror = Proxy.Admissions.Get_Faculties_By_Degrees(deg1, deg2, out fac1, out fac2);
                if (!string.IsNullOrEmpty(temperror))
                {
                    MessageBox.Show(temperror, "Admissions", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                temperror = string.Empty;

                temperror = Proxy.Admissions.Validate_Degree_Additional_Info(ds_adm_stu.TT_ADM_STU[0].STUNO, fac1, fac2, deg1, deg2, out ask_law, out ask_mus, out ask_art, out ask_bis);
                if (!string.IsNullOrEmpty(temperror))
                {
                    MessageBox.Show(temperror, "Admissions", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                ckLwaStream1.Enabled = ckLwaStream2.Enabled = ask_law;
                ckMusicProof.Enabled = ask_mus;
                ckFineArt.Enabled = ask_art;
                ckBComIS.Enabled = ask_bis;
            }
            catch (Exception ex)
            {
                Utils.HandleException(ExceptionSource.Admissions, ex);
            }
        }

        bool IsValidDegreeChecks()
        {
            errorProvider.Clear();

            bool valid = true;

            if (!ckProposedReg.Checked)
            {
                valid = false;
                errorProvider.SetError(pnlProposedRegCheck, "You have to verified this information as correct.");
            }

            if (!ckFirstDegree.Checked)
            {
                valid = false;
                errorProvider.SetError(pnlFirstDegreeCheck, "You have to verified this information as correct.");
            }

            if (!ckSecondDegree.Checked)
            {
                valid = false;
                errorProvider.SetError(pnlSecondDegreeCheck, "You have to verified this information as correct.");
            }

            return valid;
        }

        #endregion

        #region ComboBox Events

        private void cbDeg1_SelectedIndexChanged(object sender, EventArgs e)
        {
            errorProvider.SetError(cbDeg1, string.Empty);
            if (cbDeg1.SelectedValue != null && cbDeg1.SelectedIndex > 0)
            {
                btnAddPossSubj1.Enabled = true;
                txtDeg1.Text = cbDeg1.SelectedValue.ToString();
            }
            else
            {
                btnAddPossSubj1.Enabled = false;
            }
            ValidateDegreeAdditionalInfo();
        }

        private void cbDeg2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbDeg2.SelectedValue != null && cbDeg2.SelectedIndex > 0)
            {
                btnAddPossSubj2.Enabled = true;
                txtDeg2.Text = cbDeg2.SelectedValue.ToString();
            }
            else
            {
                btnAddPossSubj2.Enabled = false;
            }
            ValidateDegreeAdditionalInfo();
        }

        private void ckProposedReg_CheckedChanged(object sender, EventArgs e)
        {
            errorProvider.SetError(pnlProposedRegCheck, string.Empty);
            gbProposedReg.Enabled = !ckProposedReg.Checked;
        }

        private void ckFirstDegree_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                errorProvider.SetError(pnlFirstDegreeCheck, string.Empty);
                if (ckFirstDegree.Checked && cbDeg1.SelectedValue != null && !cbDeg1.SelectedValue.ToString().Equals("0") && dgvPossibleSubj1.Rows.Count.Equals(0))
                {
                    ckFirstDegree.Checked = false;
                    string msg = "You have to add at least one subject choice for 'First Degree Choice'.";
                    MessageBox.Show(msg, "Admissions", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                gbFirstDegree.Enabled = !ckFirstDegree.Checked;
                ValidateDegreeAdditionalInfo();

            }
            catch (Exception ex)
            {
                Utils.HandleException(ExceptionSource.Admissions, ex);
            }
        }

        private void ckSecondDegree_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                errorProvider.SetError(pnlSecondDegreeCheck, string.Empty);
                if (ckFirstDegree.Checked && cbDeg2.SelectedValue != null && !cbDeg2.SelectedValue.ToString().Equals("0") && dgvPossibleSubj2.Rows.Count.Equals(0))
                {
                    ckSecondDegree.Checked = false;
                    string msg = "You have to add at least one subject choice for 'Second Degree Choice'.";
                    MessageBox.Show(msg, "Admissions", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                gbSecondDegree.Enabled = !ckSecondDegree.Checked & cbDeg1.SelectedValue != null & cbDeg1.SelectedIndex > 0;
                ValidateDegreeAdditionalInfo();

            }
            catch (Exception ex)
            {
                Utils.HandleException(ExceptionSource.Admissions, ex);
            }
        }

        #endregion

        #region  TextBox Events

        void txtDeg1_Leave(object sender, System.EventArgs e)
        {
            LoadFirstChoiceDegree();
        }

        void txtDeg2_Leave(object sender, System.EventArgs e)
        {
            LoadSecondChoiceDegree();
        }

        void txtDeg1_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals((char)Keys.Enter)) LoadFirstChoiceDegree();
        }

        void txtDeg2_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals((char)Keys.Enter)) LoadSecondChoiceDegree();
        }

        #endregion

        #region Button Events

        private void btnEntryInfo_Click(object sender, EventArgs e)
        {
            EntryStatusDescriptions entryStatus = new EntryStatusDescriptions();
            entryStatus.ShowDialog();
        }

        private void btnAddPossSubj1_Click(object sender, EventArgs e)
        {
            List<string> subjects = new List<string>();
            foreach (DataGridViewRow subject in dgvPossibleSubj1.Rows)
            {
                subjects.Add(subject.Cells[cPossCode1.Name].Value.ToString());
            }

            SubjectChoice choices = new SubjectChoice(ds_codes, (int)Enumerations.DegreeChoice.FirstDegree, subjects, cbDeg1.Text);
            choices.SubjectChoiceSelected += new EventHandler<SubjectChoiceSelected>(choices_SubjectChoiceSelected);
            choices.ShowDialog();
        }

        private void btnAddPossSubj2_Click(object sender, EventArgs e)
        {


            List<string> subjects = new List<string>();
            foreach (DataGridViewRow subject in dgvPossibleSubj2.Rows)
            {
                subjects.Add(subject.Cells[cPossCode2.Name].Value.ToString());
            }

            SubjectChoice choices = new SubjectChoice(ds_codes, (int)Enumerations.DegreeChoice.SecondDegree, subjects, cbDeg2.Text);
            choices.SubjectChoiceSelected += new EventHandler<SubjectChoiceSelected>(choices_SubjectChoiceSelected);
            choices.ShowDialog();
        }

        void choices_SubjectChoiceSelected(object sender, SubjectChoiceSelected e)
        {
            if (e.DegreeChoice.Equals((int)Enumerations.DegreeChoice.FirstDegree))
            {
                ds_deg1_subj = new ds_genDataSet();
                foreach (string choice in e.SubjectChoices)
                {
                    int index = new BindingSource(ds_codes, "TT_GEN").Find("code", choice);
                    if (index < 0) continue;

                    ds_deg1_subj.TT_GEN.LoadDataRow(ds_codes.TT_GEN[index].ItemArray, true);
                }
                dgvPossibleSubj1.DataSource = ds_deg1_subj.TT_GEN;
            }
            else if (e.DegreeChoice.Equals((int)Enumerations.DegreeChoice.SecondDegree))
            {
                ds_deg2_subj = new ds_genDataSet();
                foreach (string choice in e.SubjectChoices)
                {
                    int index = new BindingSource(ds_codes, "TT_GEN").Find("code", choice);
                    if (index < 0) continue;

                    ds_deg2_subj.TT_GEN.LoadDataRow(ds_codes.TT_GEN[index].ItemArray, true);
                }
                dgvPossibleSubj2.DataSource = ds_deg2_subj.TT_GEN;
            }
            else throw new ApplicationException("Could not resolve degree choice.");
        }

        private void btnRemovePossSubj1_Click(object sender, EventArgs e)
        {
            if (dgvPossibleSubj1.SelectedRows.Count > 0)
            {
                string msg = "Are you sure you want to remove the selected subject choice?";
                if (!MessageBox.Show(msg, AdmissionConstants.MessageBoxCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question).Equals(DialogResult.Yes)) return;

                string code = dgvPossibleSubj1.SelectedRows[0].Cells[cPossCode1.Name].Value.ToString();
                int index = new BindingSource(ds_deg1_subj, "TT_GEN").Find("code", code);
                if (index < 0) throw new ApplicationException("Could not find the selected subjec code in datasource");

                ds_deg1_subj.TT_GEN.Rows.RemoveAt(index);
            }
            else
            {
                string msg = "There is no selected subject choice to remove.";
                MessageBox.Show(msg, AdmissionConstants.MessageBoxCaption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnRemovePossSubj2_Click(object sender, EventArgs e)
        {
            if (dgvPossibleSubj2.SelectedRows.Count > 0)
            {
                string msg = "Are you sure you want to remove the selected subject choice?";
                if (!MessageBox.Show(msg, AdmissionConstants.MessageBoxCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question).Equals(DialogResult.Yes)) return;

                string code = dgvPossibleSubj2.SelectedRows[0].Cells[cPossCode2.Name].Value.ToString();
                int index = new BindingSource(ds_deg2_subj, "TT_GEN").Find("code", code);
                if (index < 0) throw new ApplicationException("Could not find the selected subjec code in datasource");

                ds_deg2_subj.TT_GEN.Rows.RemoveAt(index);
            }
            else
            {
                string msg = "There is no selected subject choice to remove.";
                MessageBox.Show(msg, AdmissionConstants.MessageBoxCaption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        #endregion

        #region DataGridView Events

        void dgvPossibleSubj1_DataBindingComplete(object sender, System.Windows.Forms.DataGridViewBindingCompleteEventArgs e)
        {
            dgvPossibleSubj1.ClearSelection();
        }

        void dgvPossibleSubj2_DataBindingComplete(object sender, System.Windows.Forms.DataGridViewBindingCompleteEventArgs e)
        {
            dgvPossibleSubj2.ClearSelection();
        }

        #endregion

        #region Focus Events

        void txtDeg2_GotFocus(object sender, System.EventArgs e)
        {
            txtDeg1.SelectAll();
        }

        void txtDeg1_GotFocus(object sender, System.EventArgs e)
        {
            txtDeg2.SelectAll();
        }

        #endregion



    }
}

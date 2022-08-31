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
using NS_StuReg.StrongTypesNS;
using NS_Admissions.StrongTypesNS;
using Admissions.Utilities;

namespace Admissions.AdmissionForms
{
    public partial class ACEDegreeDetails : UserControl, IWizard
    {
        DS_ADM_STUDataSet ds_adm_stu;

        public ACEDegreeDetails()
        {
            InitializeComponent();
        }

        #region IWizard Members

        public bool ShowView()
        {
            try
            {
                PopulateComboBoxes();
                PopulateStudentDetails();
            }
            catch (Exception ex)
            {
                Utils.HandleException(ExceptionSource.HonoursSys, ex);
            }
            return true;
        }

        public bool Next()
        {
            try
            {
                int app_type = (int)WizardEnvironment.State[AdmissionStateItems.ApplicationType];
                bool tempsession = (bool)WizardEnvironment.State[AdmissionStateItems.ApplicationSession];
                string temperror = Proxy.Admissions.Save_ACE_Degree(app_type, tempsession, ref ds_adm_stu);
                if (!string.IsNullOrEmpty(temperror))
                {
                    MessageBox.Show(temperror, "Admissions", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                WizardEnvironment.State[AdmissionStateItems.AdmissionStudent] = ds_adm_stu;
            }
            catch (Exception ex)
            {
                Utils.HandleException(ExceptionSource.HonoursSys, ex);
            }
            return true;
        }

        public void Back()
        {

        }

        #endregion

        #region Local Methods

        void PopulateComboBoxes()
        {
            if (cbRegStatus.Items.Count.Equals(0))
            {
                ds_genDataSet ds_reg_status = Proxy.System.Get_Gen("TRUE", "RS");
                cbRegStatus.DataSource = ds_reg_status.TT_GEN;
            }

            if (cbEntryStatus.Items.Count.Equals(0))
            {
                ds_genDataSet ds_entry_level = Proxy.System.Get_Gen("TRUE", "ES");
                cbEntryStatus.DataSource = ds_entry_level.TT_GEN;
            }

            if (cbDegreeName.Items.Count.Equals(0))
            {
                ds_degreeDataSet ds_degrees = Proxy.StudentRegistration.GetDegrees(DateTime.Today.Year);

                ds_degreeDataSet ds_degr1 = (ds_degreeDataSet)ds_degrees.Copy();
                ds_degreeDataSet.tt_degreeRow deg1Default = ds_degr1.tt_degree.Newtt_degreeRow();
                ds_degr1.tt_degree.Addtt_degreeRow("0", "[Please Select]", "[Please Select]");
                DataView dvDegree1 = new DataView(ds_degr1.tt_degree);
                dvDegree1.Sort = "descrip";
                cbDegreeName.DataSource = dvDegree1;
            }

            if (cbChoice.Items.Count.Equals(0))
            {
                ds_genDataSet ds_pg_choice = Proxy.System.Get_Gen("TRUE", "SC");
                ds_genDataSet.TT_GENRow choice = ds_pg_choice.TT_GEN.NewTT_GENRow();
                choice.code = "-1"; choice.descrip = "[Please Select]";
                ds_pg_choice.TT_GEN.Rows.InsertAt(choice, 0);
                cbChoice.DataSource = ds_pg_choice.TT_GEN;
            }
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

            if (cbChoice.SelectedValue == null) cbChoice.SelectedValue = "EDUC";
        }

        #endregion

        #region TextBox Events

        void txtDegree_Leave(object sender, System.EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtDegree.Text.Trim())) cbDegreeName.SelectedValue = txtDegree.Text.Trim();
            else if (cbDegreeName.Items.Count > 0) cbDegreeName.SelectedIndex = 0;
        }

        void txtChoice_Leave(object sender, System.EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtChoice.Text.Trim())) cbChoice.SelectedValue = txtChoice.Text.Trim();
            else if (cbChoice.Items.Count > 0) cbChoice.SelectedIndex = 0;
        }

        #endregion

        #region ComboBox Events

        private void cbDegreeName_SelectedIndexChanged(object sender, EventArgs e)
        {
            errorProvider.SetError(cbDegreeName, string.Empty);
            if (cbDegreeName.SelectedValue != null && cbDegreeName.SelectedIndex > 0) txtDegree.Text = cbDegreeName.SelectedValue.ToString();
            else if (cbDegreeName.SelectedIndex.Equals(0)) txtDegree.Text = string.Empty;
        }

        private void cbChoice_SelectedIndexChanged(object sender, EventArgs e)
        {
            errorProvider.SetError(cbChoice, string.Empty);
            if (cbChoice.SelectedValue != null && cbChoice.SelectedIndex > 0) txtChoice.Text = cbChoice.SelectedValue.ToString();
            else if (cbChoice.SelectedIndex.Equals(0)) txtChoice.Text = string.Empty;
        }

        #endregion
    }
}

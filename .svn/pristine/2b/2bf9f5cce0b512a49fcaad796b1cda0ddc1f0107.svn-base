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
using NS_System.StrongTypesNS;
using Admissions.UtilityScreens;

namespace Admissions.AdmissionForms
{
    public partial class ResidenceDetails : UserControl, IWizard
    {
        DS_ADM_STUDataSet ds_adm_stu;
        DS_ADM_RESDataSet ds_adm_res;

        public ResidenceDetails()
        {
            InitializeComponent();
        }

        #region IWizard Members

        public bool ShowView()
        {
            try
            {
                if (WizardEnvironment.State.ContainsKey(AdmissionStateItems.CurrentStudent))
                {
                    bool currentstudent = (bool)WizardEnvironment.State[AdmissionStateItems.CurrentStudent];
                    if (currentstudent) return false;
                }

                if (WizardEnvironment.State.ContainsKey(AdmissionStateItems.AppDeclined))
                {
                    bool declined = (bool)WizardEnvironment.State[AdmissionStateItems.AppDeclined];
                    if (declined) return false;
                }

                LoadResidenceDetails();
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
                bool valid = true;
                if (!string.IsNullOrEmpty(txtResCode.Text.Trim()) && !IsValidResidenceCode(int.Parse(txtResCode.Text.Trim())))
                {
                    valid = false;
                    errorProvider.SetError(txtResCode, "Invalid residence code");
                }
                if(!string.IsNullOrEmpty(txtAltResCode.Text.Trim()) && !IsValidResidenceCode(int.Parse(txtAltResCode.Text.Trim())))
                {
                    valid = false;
                    errorProvider.SetError(txtAltResCode, "Invalid residence code");
                }
                if (!valid) return false;

                ds_adm_stu.TT_ADM_STU[0].REQ_RES = txtResCode.Text.Trim().Equals(string.Empty) ? 0 : int.Parse(txtResCode.Text.Trim());
                ds_adm_stu.TT_ADM_STU[0].ALT_RES = txtAltResCode.Text.Trim().Equals(string.Empty) ? 0 : int.Parse(txtAltResCode.Text.Trim());

                int app_type = (int)WizardEnvironment.State[AdmissionStateItems.ApplicationType];
                bool tempsession = (bool)WizardEnvironment.State[AdmissionStateItems.ApplicationSession];
                string temperror = Proxy.Admissions.Save_Residence_Details(app_type, tempsession, ds_adm_stu);
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

        void LoadResidenceDetails()
        {
            if (WizardEnvironment.State.ContainsKey(AdmissionStateItems.AdmissionStudent) && WizardEnvironment.State[AdmissionStateItems.AdmissionStudent] != null)
            {
                ds_adm_stu = (DS_ADM_STUDataSet)WizardEnvironment.State[AdmissionStateItems.AdmissionStudent];
            }
            else
            {
                ds_adm_stu = new DS_ADM_STUDataSet();
            }
            
            if (ds_adm_stu != null && ds_adm_stu.TT_ADM_STU.Rows.Count > 0)
            {
                txtResCode.Text = ds_adm_stu.TT_ADM_STU[0].REQ_RES.ToString();
                txtAltResCode.Text = ds_adm_stu.TT_ADM_STU[0].ALT_RES.ToString();

                if (!ds_adm_stu.TT_ADM_STU[0].REQ_RES.Equals(0))
                {
                    ckResidenceRequired.Checked = true;
                }
                else ckResidenceRequired.Checked = false;
            }
        }

        bool IsValidResidenceCode(int res_code)
        {
            if (res_code.Equals(0)) return true;

            if (ds_adm_res == null) ds_adm_res = Proxy.Admissions.Get_Admission_Resindences();
            int index = new BindingSource(ds_adm_res, "TT_ADM_RES").Find("RES", res_code);
            if (index < 0) return false;
            else return true;
        }

        #endregion

        #region CheckBox Events

        private void ckResidenceRequired_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (ckResidenceRequired.Checked)
                {
                    gbResidenceDetails.Enabled = true;

                    if (ds_adm_stu.TT_ADM_STU[0].REQ_RES.Equals(0)) txtResCode.Text = "900";
                    else txtResCode.Text = ds_adm_stu.TT_ADM_STU[0].REQ_RES.ToString();

                    if (ds_adm_stu.TT_ADM_STU[0].ALT_RES.Equals(0)) txtAltResCode.Text = "900";
                    else txtAltResCode.Text = ds_adm_stu.TT_ADM_STU[0].ALT_RES.ToString();
                }
                else
                {
                    gbResidenceDetails.Enabled = false;
                    txtResCode.Text = txtAltResCode.Text = "0";
                }
            }
            catch (Exception ex)
            {
                Utils.HandleException(ExceptionSource.Admissions, ex);
            }
        }

        #endregion

        #region Button Events

        private void btnReqRes_Click(object sender, EventArgs e)
        {
            try
            {
                if (ds_adm_res == null) ds_adm_res = Proxy.Admissions.Get_Admission_Resindences();
                ResidenceLookup lookup = new ResidenceLookup(ds_adm_res);
                if (lookup.ShowDialog().Equals(DialogResult.OK))
                {
                    txtResCode.Text = lookup.ResCode.ToString();
                }
            }
            catch (Exception ex)
            {
                Utils.HandleException(ExceptionSource.Admissions, ex);
            }
        }

        private void btnAltRes_Click(object sender, EventArgs e)
        {
            try
            {
                if (ds_adm_res == null) ds_adm_res = Proxy.Admissions.Get_Admission_Resindences();
                ResidenceLookup lookup = new ResidenceLookup(ds_adm_res);
                if (lookup.ShowDialog().Equals(DialogResult.OK))
                {
                    txtAltResCode.Text = lookup.ResCode.ToString();
                }
            }
            catch (Exception ex)
            {
                Utils.HandleException(ExceptionSource.Admissions, ex);
            }
        }

        #endregion

        #region TextBox Events

        private void txtResCode_TextChanged(object sender, EventArgs e)
        {
            try
            {
                errorProvider.SetError(txtResCode, string.Empty);

                if (!txtResCode.Text.Equals(string.Empty))
                {
                    if (ds_adm_res == null) ds_adm_res = Proxy.Admissions.Get_Admission_Resindences();
                    int index = new BindingSource(ds_adm_res, "TT_ADM_RES").Find("RES", txtResCode.Text.Trim());
                    if (index < 0) return;

                    DS_ADM_RESDataSet.TT_ADM_RESRow res = ds_adm_res.TT_ADM_RES[index];
                    txtReqResName.Text = res.RES_NAME;
                }
                else
                {
                    txtReqResSex.Text = string.Empty;
                    txtReqResName.Text = string.Empty;
                }
            }
            catch (Exception ex)
            {
                Utils.HandleException(ExceptionSource.Admissions, ex);
            }
        }

        private void txtAltResCode_TextChanged(object sender, EventArgs e)
        {
            try
            {
                errorProvider.SetError(txtAltResCode, string.Empty);

                if (!txtAltResCode.Text.Equals(string.Empty))
                {
                    if (ds_adm_res == null) ds_adm_res = Proxy.Admissions.Get_Admission_Resindences();
                    int index = new BindingSource(ds_adm_res, "TT_ADM_RES").Find("RES", txtAltResCode.Text.Trim());
                    if (index < 0) return;

                    DS_ADM_RESDataSet.TT_ADM_RESRow res = ds_adm_res.TT_ADM_RES[index];
                    txtAltResName.Text = res.RES_NAME;
                }
                else
                {
                    txtAltResSex.Text = string.Empty;
                    txtAltResName.Text = string.Empty;
                }
            }
            catch (Exception ex)
            {
                Utils.HandleException(ExceptionSource.Admissions, ex);
            }
        }

        void txtResCode_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (char.IsControl((char)e.KeyValue) || char.IsNumber((char)e.KeyValue)) e.Handled = false;
        }

        void txtAltResCode_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (char.IsControl((char)e.KeyValue) || char.IsNumber((char)e.KeyValue)) e.Handled = false;
        }

        #endregion

        #region Focus Events

        void txtAltResCode_GotFocus(object sender, System.EventArgs e)
        {
            txtAltResCode.SelectAll();
        }

        void txtResCode_GotFocus(object sender, System.EventArgs e)
        {
            txtResCode.SelectAll();
        }

        #endregion
    }
}

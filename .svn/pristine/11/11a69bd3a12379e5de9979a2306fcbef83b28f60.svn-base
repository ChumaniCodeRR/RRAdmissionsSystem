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

namespace Admissions.AdmissionForms
{
    public partial class AccountPayer : UserControl, IWizard
    {
        DS_ADM_STUDataSet ds_adm_stu;

        public AccountPayer()
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

                PopulateComboBoxes();
                LoadAccountPayerDetails();
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
                errorProvider.Clear();
                string temperror = Proxy.Admissions.Save_Account_Payer_Details(Global.Global.FromWhere, ckStudentPaying.Checked, ds_adm_stu, Global.Global.admissions_view);
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
            Global.Global.FromWhere = "";
            return true;            
        }

        public void Back()
        {
            errorProvider.Clear();
        }

        #endregion

        #region Local Methods

        void PopulateComboBoxes()
        {
            if (cbAccountPayerCopyFrom.Items.Count.Equals(0))
            {
                AdmissionUtilities.PopulateCopyAddress(cbAccountPayerCopyFrom, Enumerations.AddressType.Account_Payer_Address);
            }
        }

        void LoadAccountPayerDetails()
        {
            if (WizardEnvironment.State.ContainsKey(AdmissionStateItems.AdmissionStudent) && WizardEnvironment.State[AdmissionStateItems.AdmissionStudent] != null)
            {
                ds_adm_stu = (DS_ADM_STUDataSet)WizardEnvironment.State[AdmissionStateItems.AdmissionStudent];
            }
            else
            {
                if (!string.IsNullOrEmpty(Global.Global.tempstu))
                {

                }
                else ds_adm_stu = new DS_ADM_STUDataSet();
            }
            bsAdmStudent.DataSource = ds_adm_stu.TT_ADM_STU;

            if (!ds_adm_stu.TT_ADM_STU[0].IsFEES_IDNull() && !ds_adm_stu.TT_ADM_STU[0].IsIDNull())
            {
                if (ds_adm_stu.TT_ADM_STU[0].FEES_ID.Equals(ds_adm_stu.TT_ADM_STU[0].ID))
                {
                    ckStudentPaying.Checked = true;
                }
            }
        }

        void ClearAccountPayerDetails()
        {
            txtTitle.Text = txtInitials.Text = string.Empty;
            txtSurname.Text = txtFeePayerId.Text = string.Empty;

            txtAddress1.Text = txtAddress2.Text = txtAddress3.Text =
                txtAddress4.Text = txtAddress5.Text = txtPostalCode.Text = string.Empty;

            txtPhone.Text = txtCell.Text = txtFaxNo.Text = txtEmail.Text = string.Empty;
        }

        #endregion

        #region CheckBox Events

        private void ckResidenceRequired_CheckedChanged(object sender, EventArgs e)
        {
            if (ckStudentPaying.Checked)
            {
                ClearAccountPayerDetails();

                lblIdNumber.Enabled = /*txtIdNumber.Enabled =*/ true;
                txtIdNumber.Text = ds_adm_stu.TT_ADM_STU[0].ID;
                gbAccountPayer.Enabled = false;
                cb_fee_verified.Checked = true;
            }
            else
            {
                lblIdNumber.Enabled = /*txtIdNumber.Enabled =*/ false;
                txtIdNumber.Text = string.Empty;
                gbAccountPayer.Enabled = true;
                cb_fee_verified.Checked = false;
            }
        }

        #endregion

        #region ComboBox Events

        private void cbAccountPayerCopyFrom_SelectedIndexChanged(object sender, EventArgs e)
        {
            errorProvider.SetError(cbAccountPayerCopyFrom, string.Empty);
        }

        #endregion

        #region Button Events

        private void btnCopyToAccountPayer_Click(object sender, EventArgs e)
        {
            if (cbAccountPayerCopyFrom.SelectedIndex.Equals(-1) || cbAccountPayerCopyFrom.SelectedIndex.Equals(0))
            {
                errorProvider.SetError(cbAccountPayerCopyFrom, "Select address to copy from");
                return;
            }

            if (ds_adm_stu != null && ds_adm_stu.TT_ADM_STU.Rows.Count > 0)
            {
                List<TextBox> txt = new List<TextBox>(new TextBox[]
                {
                    
                    txtAddress1, txtAddress2, txtAddress3, txtAddress4,
                    txtAddress5, txtPostalCode, new TextBox()
                });

                List<string> addr = null;
                int fromAddr = (int)cbAccountPayerCopyFrom.SelectedValue;
                switch (fromAddr)
                {
                    case (int)Enumerations.AddressType.Home_Postal_Address:
                        addr = AdmissionUtilities.GetAdmissionsHomeAddress(ds_adm_stu); break;
                    case (int)Enumerations.AddressType.Home_Street_Address:
                        addr = AdmissionUtilities.GetAdmissionsLocalAddress(ds_adm_stu); break;
                    case (int)Enumerations.AddressType.Guardian_Address:
                        addr = AdmissionUtilities.GetAdmissionsKinAddress(ds_adm_stu); break;
                    case (int)Enumerations.AddressType.Account_Payer_Address:
                        addr = AdmissionUtilities.GetAdmissionsAccountAddress(ds_adm_stu); break;
                    default: throw new ApplicationException("Unknown address type to copy from");
                }

                AdmissionUtilities.CopyAddress(txt, addr);
                bsAdmStudent.EndEdit();
            }
        }

        #endregion

        #region Control Focus Events

        void txtEmail_GotFocus(object sender, System.EventArgs e)
        {
            txtEmail.SelectAll();
        }

        void txtFaxNo_GotFocus(object sender, System.EventArgs e)
        {
            txtFaxNo.SelectAll();
        }

        void txtCell_GotFocus(object sender, System.EventArgs e)
        {
            txtCell.SelectAll();
        }

        void txtPhone_GotFocus(object sender, System.EventArgs e)
        {
            txtPhone.SelectAll();
        }

        void txtPostalCode_GotFocus(object sender, System.EventArgs e)
        {
            txtPostalCode.SelectAll();
        }

        void txtAddress5_GotFocus(object sender, System.EventArgs e)
        {
            txtAddress5.SelectAll();
        }

        void txtAddress4_GotFocus(object sender, System.EventArgs e)
        {
            txtAddress4.SelectAll();
        }

        void txtAddress3_GotFocus(object sender, System.EventArgs e)
        {
            txtAddress3.SelectAll();
        }

        void txtAddress2_GotFocus(object sender, System.EventArgs e)
        {
            txtAddress2.SelectAll();
        }

        void txtAddress1_GotFocus(object sender, System.EventArgs e)
        {
            txtAddress1.SelectAll();
        }

        void txtFeePayerId_GotFocus(object sender, System.EventArgs e)
        {
            txtFeePayerId.SelectAll();
        }

        void txtSurname_GotFocus(object sender, System.EventArgs e)
        {
            txtSurname.SelectAll();
        }

        void txtInitials_GotFocus(object sender, System.EventArgs e)
        {
            txtInitials.SelectAll();
        }

        void txtTitle_GotFocus(object sender, System.EventArgs e)
        {
            txtTitle.SelectAll();
        }

        void txtIdNumber_GotFocus(object sender, System.EventArgs e)
        {
            txtIdNumber.SelectAll();
        }
        #endregion
    }
}

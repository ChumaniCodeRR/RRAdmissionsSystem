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

namespace Admissions.AdmissionForms
{
    public partial class AdmissionGuardianAddressDetails : UserControl, IWizard
    {
        DS_ADM_STUDataSet ds_adm_stu;

        public AdmissionGuardianAddressDetails()
        {
            InitializeComponent();
        }

        #region IWizard Members

        public bool ShowView()
        {
            if (WizardEnvironment.State.ContainsKey(AdmissionStateItems.CurrentStudent))
            {
                bool currentstudent = (bool)WizardEnvironment.State[AdmissionStateItems.CurrentStudent];
                if (currentstudent) return false;
            }

            try
            {
                if (cbGuardianCopyFrom.Items.Count.Equals(0))
                {
                    AdmissionUtilities.PopulateCopyAddress(cbGuardianCopyFrom, Enumerations.AddressType.Guardian_Address);
                }
                
                PopulateGuardianAddress();
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
                errorProvider.Clear();
                string temperror = Proxy.Admissions.Save_Guardian_Addresses_And_Contacts(ref ds_adm_stu, Global.Global.admissions_view);
                if (!string.IsNullOrEmpty(temperror))
                {
                    MessageBox.Show(temperror, "Admissions", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                WizardEnvironment.State[AdmissionStateItems.AdmissionStudent] = ds_adm_stu;
                return true;
            }
            catch (Exception ex)
            {
                Utils.HandleException(ExceptionSource.Admissions, ex);
            }
            return true;
        }

        public void Back()
        {
            errorProvider.Clear();
        }

        #endregion

        #region Local Methods

        void PopulateGuardianAddress()
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
        }

        #endregion

        #region Button Events

        private void btnCopyToTermPostal_Click(object sender, EventArgs e)
        {
            if (cbGuardianCopyFrom.SelectedIndex.Equals(-1) || cbGuardianCopyFrom.SelectedIndex.Equals(0))
            {
                errorProvider.SetError(cbGuardianCopyFrom, "Select address to copy from");
                return;
            }

            if (ds_adm_stu != null && ds_adm_stu.TT_ADM_STU.Rows.Count > 0)
            {
                List<TextBox> txt = new List<TextBox>(new TextBox[]
                {
                    
                    txtGuardianAddressLine1, txtGuardianAddressLine2, txtGuardianAddressLine3, txtGuardianAddressLine4,
                    txtGuardianAddressLine5, txtGuardianAddressPostalCode, new TextBox()
                });

                List<string> addr = null;
                int fromAddr = (int)cbGuardianCopyFrom.SelectedValue;
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

        #region ComboBox Events

        private void cbGuardianCopyFrom_SelectedIndexChanged(object sender, EventArgs e)
        {
            errorProvider.SetError(cbGuardianCopyFrom, string.Empty);
        }

        #endregion
    }
}

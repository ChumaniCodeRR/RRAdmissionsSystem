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
    public partial class StudentAddressDetails : UserControl, IWizard
    {
        DS_ADM_STUDataSet ds_adm_stu;

        bool loading = true;

        public StudentAddressDetails()
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

                PopulateComboBoxes();
                PopulateAddressDetails();

                Enumerations.AdmissionApplicationType appType = (Enumerations.AdmissionApplicationType)Enum.Parse(typeof(Enumerations.AdmissionApplicationType), WizardEnvironment.State[AdmissionStateItems.ApplicationType].ToString());

              /*  #region Hide Local Address
                if (loading && appType.Equals(Enumerations.AdmissionApplicationType.ACE))
                {
                    gbLocalPost.Visible = false;
                    gbContactDetails.Location = gbLocalPost.Location;

                    lblStuEmail.Location = lblStudentCell.Location;
                    txtStudentEmail.Location = txtStudentCell.Location;

                    lblStudentCell.Location = lblHomeFax.Location;
                    txtStudentCell.Location = txtHomeFax.Location;

                    gbContactDetails.Height = gbContactDetails.Height - txtHomeFax.Height;
                    lblHomeFax.Visible = txtHomeFax.Visible = false;
                    
                    loading = false;
                }
                #endregion  */
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
                string temperror = Proxy.Admissions.Save_Home_And_Local_Addresses_And_Contacts(ref ds_adm_stu, Global.Global.admissions_view);
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

        void PopulateComboBoxes()
        {
            if (cbHomeAddCopyFrom.Items.Count.Equals(0))
            {
                AdmissionUtilities.PopulateCopyAddress(cbHomeAddCopyFrom, Enumerations.AddressType.Home_Postal_Address);
            }

            if (cbLocalPostalCopyFrom.Items.Count.Equals(0))
            {
                AdmissionUtilities.PopulateCopyAddress(cbLocalPostalCopyFrom, Enumerations.AddressType.Home_Street_Address);
            }
        }

        void PopulateAddressDetails()
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

        private void btnCopyToVacHome_Click(object sender, EventArgs e)
        {
            if (cbHomeAddCopyFrom.SelectedIndex.Equals(-1) || cbHomeAddCopyFrom.SelectedIndex.Equals(0))
            {
                errorProvider.SetError(cbHomeAddCopyFrom, "Select address to copy from");
                return;
            }

            if (ds_adm_stu != null && ds_adm_stu.TT_ADM_STU.Rows.Count > 0)
            {
                List<TextBox> txt = new List<TextBox>(new TextBox[]
                {
                    txtVacAddressLine1, txtVacAddressLine2, txtVacAddressLine3, txtVacAddressLine4,
                    txtVacAddressLine5, txtVacAddressPostalCode, txtHomeFax
                });

                List<string> addr = null;
                int fromAddr = (int)cbHomeAddCopyFrom.SelectedValue;
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

        private void btnCopyToTermPhysical_Click(object sender, EventArgs e)
        {
            if (cbLocalPostalCopyFrom.SelectedIndex.Equals(-1) || cbLocalPostalCopyFrom.SelectedIndex.Equals(0))
            {
                errorProvider.SetError(cbLocalPostalCopyFrom, "Select address to copy from");
                return;
            }

            if (ds_adm_stu != null && ds_adm_stu.TT_ADM_STU.Rows.Count > 0)
            {
                List<TextBox> txt = new List<TextBox>(new TextBox[]
                {
                    txtTermPhysicalAddressLine1, txtTermPhysicalAddressLine2, txtTermPhysicalAddressLine3, txtTermPhysicalAddressLine4,
                    txtTermPhysicalAddressLine5, txtTermPhysicalAddressPostalCode, new TextBox()
                });

                List<string> addr = null;
                int fromAddr = (int)cbLocalPostalCopyFrom.SelectedValue;
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

        private void cbLocalPostalCopyFrom_SelectedIndexChanged(object sender, EventArgs e)
        {
            errorProvider.SetError(cbLocalPostalCopyFrom, string.Empty);
        }

        private void cbHomeAddCopyFrom_SelectedIndexChanged(object sender, EventArgs e)
        {
            errorProvider.SetError(cbLocalPostalCopyFrom, string.Empty);
        }

        #endregion
    }
}
 
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
    public partial class AdmissionSchoolPrincipal : UserControl, IWizard
    {
        DS_ADM_STUDataSet ds_adm_stu;

        public AdmissionSchoolPrincipal()
        {
            InitializeComponent();
        }

        #region IWizard Members

        public bool ShowView()
        {
            try
            {
                if (WizardEnvironment.State.ContainsKey(AdmissionStateItems.AppDeclined))
                {
                    bool declined = (bool)WizardEnvironment.State[AdmissionStateItems.AppDeclined];
                    if (declined) return false;
                }

                PopulatePrincipalDetails();
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
                string temperror = Proxy.Admissions.Save_Principal_Information(ds_adm_stu);
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

        void PopulatePrincipalDetails()
        {
            if (WizardEnvironment.State.ContainsKey(AdmissionStateItems.AdmissionStudent) && WizardEnvironment.State[AdmissionStateItems.AdmissionStudent] != null)
            {
                ds_adm_stu = (DS_ADM_STUDataSet)WizardEnvironment.State[AdmissionStateItems.AdmissionStudent];
            }
            else
            {
                ds_adm_stu = new DS_ADM_STUDataSet();
            }
            bsAdmissions.DataSource = ds_adm_stu.TT_ADM;
            bsAdmStudent.DataSource = ds_adm_stu.TT_ADM_STU;
        }

        #endregion

        #region Control Focus Events

        void textBox1_GotFocus(object sender, System.EventArgs e)
        {
            textBox1.SelectAll();
        }

        void txtContactPhone_GotFocus(object sender, System.EventArgs e)
        {
            txtContactPhone.SelectAll();
        }

        void txtContactEmail_GotFocus(object sender, System.EventArgs e)
        {
            txtContactEmail.SelectAll();
        }

        void txtPosition_GotFocus(object sender, System.EventArgs e)
        {
            txtPosition.SelectAll();
        }

        #endregion
    }
}

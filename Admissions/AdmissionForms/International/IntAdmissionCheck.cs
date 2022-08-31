using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using RhodesWizard;
using NS_Admissions.StrongTypesNS;
using Utilities;
using Admissions.Utilities;
using Admissions.EventArguments;

namespace Admissions.AdmissionForms
{
    public partial class IntAdmissionCheck : UserControl, IWizard
    {
        public event EventHandler<AdmissionStudentEventArgs> AdmissionStudentValidated;

        public IntAdmissionCheck()
        {
            InitializeComponent();
        }

        #region IWizard Members

        public bool ShowView()
        {
            try
            {
                int adm_year = default(int);
                DS_APP_TYPEDataSet ds_app_types = Proxy.Admissions.Get_Adm_Year_And_Application_Types(out adm_year);
                lblAdmissionYear.Text = string.Concat("We are now processing ", adm_year, " applications");
                rbCurrent.Text = string.Concat("Current (", adm_year, ")");
                rbNext.Text = string.Concat("Next (", adm_year + 1, ")");
            }
            catch (Exception ex)
            {
                Utils.HandleException(ExceptionSource.Admissions, ex);
            }
            return true;
        }

        public bool Next()
        {
            string old_num = txtStuNo.Text.Trim();
            int app_type = (int)Enumerations.AdmissionApplicationType.International;
            bool adm_session = rbCurrent.Checked;

            DS_VALIDATIONDataSet ds_validations;
            DS_ADM_STUDataSet ds_adm_stu = Proxy.Admissions.Validate_Previous_Rhodes_Number(old_num, app_type, adm_session, Global.Global.admissions_view, string.Empty, out ds_validations);
            if (ds_validations.TT_VALIDATION.Rows.Count > 0)
            {
                bool stop_msg = false;
                StringBuilder msg = new StringBuilder(string.Concat("The following validations failed for the given student number:", Environment.NewLine));
                foreach (DS_VALIDATIONDataSet.TT_VALIDATIONRow validation in ds_validations.TT_VALIDATION)
                {
                    msg.Append(string.Concat(Environment.NewLine, validation.VAL_MSG));
                    if (validation.IS_STOP) stop_msg = true;
                }

                if (stop_msg)
                {
                    MessageBox.Show(msg.ToString(), AdmissionConstants.MessageBoxCaption, MessageBoxButtons.OK, MessageBoxIcon.Warning); return false;
                }
                else
                {
                    msg.Append(string.Concat(Environment.NewLine, Environment.NewLine, "Do you want to continue anyway?"));
                    if (!MessageBox.Show(msg.ToString(), AdmissionConstants.MessageBoxCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question).Equals(DialogResult.Yes)) return false;
                }
            }

            if (ds_adm_stu.TT_ADM_STU.Count > 0)
            {
                WizardEnvironment.State[AdmissionStateItems.AdmissionStudent] = ds_adm_stu;
            }
            else
            {
                if (WizardEnvironment.State.ContainsKey(AdmissionStateItems.AdmissionStudent))
                { WizardEnvironment.State.Remove(AdmissionStateItems.AdmissionStudent); }
            }

            WizardEnvironment.State[AdmissionStateItems.ApplicationType] = app_type;
            WizardEnvironment.State[AdmissionStateItems.ApplicationSession] = adm_session;
            if (AdmissionStudentValidated != null)
            {
                AdmissionStudentValidated(this, new AdmissionStudentEventArgs(old_num));
            }
            return true;
        }

        public void Back()
        {
            
        }

        #endregion
    }
}

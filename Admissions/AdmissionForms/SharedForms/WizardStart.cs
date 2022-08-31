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
    public partial class WizardStart : UserControl, IWizard
    {
        DS_ADM_STUDataSet ds_adm_stu;
        DS_VALIDATIONDataSet ds_validations;

        public WizardStart()
        {
            InitializeComponent();
        }

        #region IWizard Members

        public bool ShowView()
        {
            try
            {
                //int app_type = (int)Enumerations.AdmissionApplicationType.UG;
                int app_type = (int)Global.Global.AdmAppType;
                bool adm_session = true;
                ds_adm_stu = Proxy.Admissions.Validate_Previous_Rhodes_Number(Global.Global.tempstu, app_type, adm_session, Global.Global.admissions_view, string.Empty, out ds_validations);

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
                        MessageBox.Show(msg.ToString(), AdmissionConstants.MessageBoxCaption, MessageBoxButtons.OK, MessageBoxIcon.Warning); return true;
                    }
                    else
                    {
                        msg.Append(string.Concat(Environment.NewLine, Environment.NewLine, "Do you want to continue anyway?"));
                        if (!MessageBox.Show(msg.ToString(), AdmissionConstants.MessageBoxCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question).Equals(DialogResult.Yes)) return true;
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
                    return true;
                }

                WizardEnvironment.State[AdmissionStateItems.ApplicationType] = app_type;
                WizardEnvironment.State[AdmissionStateItems.ApplicationSession] = adm_session;
            }
            catch (Exception ex)
            {
                Utils.HandleException(ExceptionSource.Admissions, ex);
                return true;
            }
            return false;
        }

        public bool Next()
        {
            string msg = "An error occured during wizard load. You will not be able to continue with this update. Please cancel and restart the update wizard.";
            MessageBox.Show(msg, "Admissions", MessageBoxButtons.OK, MessageBoxIcon.Warning); return false;
        }

        public void Back()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}

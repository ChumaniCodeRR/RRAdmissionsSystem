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
using Admissions.EventArguments;

namespace Admissions.AdmissionForms
{
    public partial class GadraAdmissionCheck : UserControl, IWizard
    {
        public event EventHandler<AdmissionStudentEventArgs> AdmissionStudentValidated;

        string ref_no;
        int yr_selection;
        string oldstuno;

        public GadraAdmissionCheck(int yr_selection, string oldstuno, string ref_no)
        {
            InitializeComponent();
            this.ref_no = ref_no;
            this.oldstuno = oldstuno;
            this.yr_selection = yr_selection;
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

                if (yr_selection == adm_year) rbCurrent.Checked = true;
                if (yr_selection == adm_year + 1) rbNext.Checked = true;

                if (oldstuno != string.Empty) txtStuNo.Text = oldstuno;

                gbStudentDetails.Focus();
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
                string old_num = txtStuNo.Text.Trim();
                int app_type = (int)Enumerations.AdmissionApplicationType.Gadra;
                bool adm_session = rbCurrent.Checked;

                DS_VALIDATIONDataSet ds_validations;
                DS_ADM_STUDataSet ds_adm_stu = Proxy.Admissions.Validate_Previous_Rhodes_Number(old_num, app_type, adm_session, Global.Global.admissions_view, ref_no, out ds_validations);
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
            catch (Exception ex)
            {
                Utils.HandleException(ExceptionSource.Admissions, ex);
                return false;
            }
        }

        public void Back()
        {

        }

        #endregion
    }
}

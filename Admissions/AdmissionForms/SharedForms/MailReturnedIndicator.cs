using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RhodesWizard;
using Utilities;
using NS_System.StrongTypesNS;
using NS_Admissions.StrongTypesNS;
using Admissions.Utilities;
using Admissions.EventArguments;

namespace Admissions.AdmissionForms
{
    public partial class MailReturnedIndicator : UserControl, IWizard
    {
        DS_ADM_STUDataSet ds_adm_stu;

        public MailReturnedIndicator()
        {
            InitializeComponent();
        }

        #region IWizard Members

        public bool ShowView()
        {
            try
            {
                LoadComments();
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
                ds_adm_stu.TT_ADM[0].MAIL_RETURN = chbxReturn.Checked;
                string temperror = Proxy.Admissions.Save_Mail_Return(ref ds_adm_stu);
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

        void LoadComments()
        {
            if (WizardEnvironment.State.ContainsKey(AdmissionStateItems.AdmissionStudent) && WizardEnvironment.State[AdmissionStateItems.AdmissionStudent] != null)
            {
                ds_adm_stu = (DS_ADM_STUDataSet)WizardEnvironment.State[AdmissionStateItems.AdmissionStudent];
            }
            else
            {
                ds_adm_stu = new DS_ADM_STUDataSet();
            }
            bs_mail.DataSource = ds_adm_stu.TT_ADM;
            chbxReturn.Checked = ds_adm_stu.TT_ADM[0].MAIL_RETURN;
        }

        #endregion
    }
}

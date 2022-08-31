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
    public partial class Exemptions : UserControl, IWizard
    {
        DS_ADM_STUDataSet ds_adm_stu;

        public Exemptions()
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
                ds_adm_stu.TT_ADM_STU[0].EXEMP_PROB1 = txtExempt1.Text.ToString().ToUpper();
                ds_adm_stu.TT_ADM_STU[0].EXEMP_PROB2 = txtExempt2.Text.ToString().ToUpper();
                ds_adm_stu.TT_ADM_STU[0].EXEMP_PROB3 = txtExempt3.Text.ToString().ToUpper();
                ds_adm_stu.TT_ADM_STU[0].EXEMP_PROB4 = txtExempt4.Text.ToString().ToUpper();

                string temperror = Proxy.Admissions.Save_Exemptions(ref ds_adm_stu);
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
            bs_exemptions.DataSource = ds_adm_stu.TT_ADM;
                txtExempt1.Text = ds_adm_stu.TT_ADM_STU[0].EXEMP_PROB1;
                txtExempt2.Text = ds_adm_stu.TT_ADM_STU[0].EXEMP_PROB2;
                txtExempt3.Text = ds_adm_stu.TT_ADM_STU[0].EXEMP_PROB3;
                txtExempt4.Text = ds_adm_stu.TT_ADM_STU[0].EXEMP_PROB4;
        }

        #endregion

    }
}

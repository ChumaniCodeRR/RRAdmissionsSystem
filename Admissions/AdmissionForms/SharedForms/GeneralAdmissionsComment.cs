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
    public partial class GeneralAdmissionsComment : UserControl, IWizard
    {
        DS_ADM_STUDataSet ds_adm_stu;

        public GeneralAdmissionsComment()
        {
            InitializeComponent();
        }

        #region IWizard Members

        public bool ShowView()
        {
            try
            {
                LoadComment();
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
                string tempstuno = ds_adm_stu.TT_ADM_STU[0].STUNO;
                DialogResult dialogResult = MessageBox.Show("This comment will appear on ROSS exactly as typed. Confirm that you wish to add it?", "Confirmation", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    string temperror = Proxy.Admissions.Update_Stu_Comment(tempstuno, txtComment.Text.ToString().ToUpper());
                    if (!string.IsNullOrEmpty(temperror))
                    {
                        MessageBox.Show(temperror, "Admissions", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                }
                else if (dialogResult == DialogResult.No)
                {
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

        void LoadComment()
        {
            if (WizardEnvironment.State.ContainsKey(AdmissionStateItems.AdmissionStudent) && WizardEnvironment.State[AdmissionStateItems.AdmissionStudent] != null)
            {
                ds_adm_stu = (DS_ADM_STUDataSet)WizardEnvironment.State[AdmissionStateItems.AdmissionStudent];
            }
            else
            {
                ds_adm_stu = new DS_ADM_STUDataSet();
            }
            txtComment.Text = Proxy.Admissions.Get_Stu_Comment(ds_adm_stu.TT_ADM_STU[0].STUNO);
        }

        #endregion
    }
}

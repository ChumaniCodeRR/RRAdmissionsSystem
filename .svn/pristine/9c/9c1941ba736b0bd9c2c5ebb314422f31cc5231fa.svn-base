using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using RhodesWizard;
using Admissions.Utilities;
using NS_Admissions.StrongTypesNS;
using Utilities;

namespace Admissions.AdmissionForms
{
    public partial class ACEFormDetails : UserControl, IWizard
    {
        DS_ADM_STUDataSet ds_adm_stu;

        public ACEFormDetails()
        {
            InitializeComponent();
        }

        #region IWizard Members

        public bool ShowView()
        {
            try
            {
                LoadStudentDetails();
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
                string temperror = Proxy.Admissions.Save_Student_Additional_Info(ref ds_adm_stu, Global.Global.admissions_view);
                if (!string.IsNullOrEmpty(temperror))
                {
                    MessageBox.Show(temperror, "Admissions", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                WizardEnvironment.State[AdmissionStateItems.AdmissionStudent] = ds_adm_stu;
                WizardEnvironment.State[AdmissionStateItems.ShowAttention] = ckAttentionDetails.Checked;
                return true;
            }
            catch (Exception ex)
            {
                Utils.HandleException(ExceptionSource.HonoursSys, ex);
                return false;
            }
        }

        public void Back()
        {
            
        }

        #endregion

        #region Local Method

        void LoadStudentDetails()
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
    }
}

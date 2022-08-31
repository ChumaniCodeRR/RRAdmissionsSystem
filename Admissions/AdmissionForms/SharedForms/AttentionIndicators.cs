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
    public partial class AttentionIndicators : UserControl, IWizard
    {
        DS_ADM_STUDataSet ds_adm_stu;

        public AttentionIndicators()
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

                LoadAttentionDetails();

                bool showAttention = (bool)WizardEnvironment.State[AdmissionStateItems.ShowAttention];
                if (!showAttention) { SaveStudentDetails(); return false; }
            }
            catch (Exception ex)
            {
                Utils.HandleException(ExceptionSource.HonoursSys, ex);
                return false;
            }
            return true;
        }

        public bool Next()
        {
            try
            {
                return SaveStudentDetails();
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

        #region Local Methods

        void LoadAttentionDetails()
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
            bs_attentions.DataSource = ds_adm_stu.tt_attentions;
        }

        bool SaveStudentDetails()
        {
            int app_type = (int)WizardEnvironment.State[AdmissionStateItems.ApplicationType];
            bool tempsession = (bool)WizardEnvironment.State[AdmissionStateItems.ApplicationSession];
            string temperror = Proxy.Admissions.Save_Attention_Info(app_type, tempsession, ref ds_adm_stu);
            if (!string.IsNullOrEmpty(temperror))
            {
                MessageBox.Show(temperror, "Admissions", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            WizardEnvironment.State[AdmissionStateItems.AdmissionStudent] = ds_adm_stu;
            return true;
        }

        #endregion

      

       

      

        private void dg_list_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dg_list.IsCurrentCellDirty && dg_list.CurrentCell.GetType().Equals(typeof(DataGridViewCheckBoxCell)))
            {
                dg_list.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

       


    }
}

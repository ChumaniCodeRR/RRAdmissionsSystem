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
    public partial class InternalAdmissionNotes : UserControl, IWizard
    {
        DS_ADM_STUDataSet ds_adm_stu;

        public InternalAdmissionNotes()
        {
            InitializeComponent();
        }

        #region IWizard Members

        public bool ShowView()
        {
            try
            {
                if (WizardEnvironment.State.ContainsKey(AdmissionStateItems.AdmissionStudent) && WizardEnvironment.State[AdmissionStateItems.AdmissionStudent] != null)
                {
                    ds_adm_stu = (DS_ADM_STUDataSet)WizardEnvironment.State[AdmissionStateItems.AdmissionStudent];
                }
                else
                {
                    ds_adm_stu = new DS_ADM_STUDataSet();
                }
                bsAdmissionNotes.DataSource = ds_adm_stu.TT_ADM_NOTES;
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
                string temperror = Proxy.Admissions.Save_Admission_Notes(ds_adm_stu);
                if (!string.IsNullOrEmpty(temperror))
                {
                    MessageBox.Show(temperror, "Admissions", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            catch (Exception ex)
            {
                Utils.HandleException(ExceptionSource.Admissions, ex);
                return false;
            }
            return true;
        }

        public void Back()
        {
            
        }

        #endregion

        #region TextBox Events

        void txtNotes_GotFocus(object sender, System.EventArgs e)
        {
            txtNotes.SelectAll();
        }

        #endregion
    }
}

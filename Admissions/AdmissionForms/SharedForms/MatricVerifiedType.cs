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
    public partial class MatricVerifiedType : UserControl, IWizard
    {
        DS_ADM_STUDataSet ds_adm_stu;

        public MatricVerifiedType()
        {
            InitializeComponent();
        }


        #region IWizard Members

        public bool ShowView()
        {
              try
              {
                  PopulateBoxes();
                  LoadDetails();
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
                   ds_adm_stu.TT_ADM_STU[0].MATVER = chbxVerified.Checked;
                   ds_adm_stu.TT_ADM_STU[0].MAT_TYPE = cbxType.SelectedValue.ToString();
                   string temperror = Proxy.Admissions.Save_Matric_verified_type(ref ds_adm_stu);
                    if (!string.IsNullOrEmpty(temperror) && !temperror.StartsWith("NOTICE"))
                       {
                           MessageBox.Show(temperror, "Admissions", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                           return false;
                       }
                    if (temperror.StartsWith("NOTICE")) MessageBox.Show(temperror, "Admissions", MessageBoxButtons.OK, MessageBoxIcon.Information);
     
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

        void PopulateBoxes()
        {
            NS_System.StrongTypesNS.ds_genDataSet ds_entry = Proxy.System.Get_Gen("*", "MT");
            bs_gen.DataSource = ds_entry.TT_GEN;
            cbxType.SelectedIndex = 0;
        }

        void LoadDetails()
        {
            if (WizardEnvironment.State.ContainsKey(AdmissionStateItems.AdmissionStudent) && WizardEnvironment.State[AdmissionStateItems.AdmissionStudent] != null)
            {
                ds_adm_stu = (DS_ADM_STUDataSet)WizardEnvironment.State[AdmissionStateItems.AdmissionStudent];
            }
            else
            {
                ds_adm_stu = new DS_ADM_STUDataSet();
            }
            if (ds_adm_stu != null && ds_adm_stu.TT_ADM_STU.Rows.Count > 0)
            {
                chbxVerified.Checked = ds_adm_stu.TT_ADM_STU[0].MATVER;
                if (ds_adm_stu.TT_ADM_STU[0].MAT_TYPE.Equals(""))   cbxType.SelectedIndex = 0; else cbxType.SelectedValue = ds_adm_stu.TT_ADM_STU[0].MAT_TYPE.ToString();
            }
        }

        #endregion

    }
}

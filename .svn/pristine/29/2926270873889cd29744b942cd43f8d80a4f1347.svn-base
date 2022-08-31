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
    public partial class FinancialAid : UserControl, IWizard
    {
        DS_ADM_STUDataSet ds_adm_stu;

        public FinancialAid()
        {
            InitializeComponent();
        }

        #region IWizard Members

        public bool ShowView()
        {
            try
            {
                LoadFinancialAidRequest();
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
                
                bool nsfasIndicator = false;
                if (chkNSFAS.Checked)
                {
                    nsfasIndicator = true;
                }

                if (rdGross_Cat1.Checked)
                {
                    if (ds_adm_stu.TT_ADM_STU[0].GROSS_CAT2)
                    {
                        ds_adm_stu.TT_ADM_STU[0].GROSS_CAT2 = false;
                    }
                    if (ds_adm_stu.TT_ADM_STU[0].GROSS_CAT3)
                    {
                        ds_adm_stu.TT_ADM_STU[0].GROSS_CAT3 = false;
                    }
                }

                if (rdGross_Cat2.Checked)
                {
                    if (ds_adm_stu.TT_ADM_STU[0].GROSS_CAT1)
                    {
                        ds_adm_stu.TT_ADM_STU[0].GROSS_CAT1 = false;
                    }
                    if (ds_adm_stu.TT_ADM_STU[0].GROSS_CAT3)
                    {
                        ds_adm_stu.TT_ADM_STU[0].GROSS_CAT3 = false;
                    }
                }
                if (rdGross_Cat3.Checked)
                {
                    if (ds_adm_stu.TT_ADM_STU[0].GROSS_CAT2)
                    {
                        ds_adm_stu.TT_ADM_STU[0].GROSS_CAT2 = false;
                    }
                    if (ds_adm_stu.TT_ADM_STU[0].GROSS_CAT1)
                    {
                        ds_adm_stu.TT_ADM_STU[0].GROSS_CAT1 = false;
                    }
                }


                string temperror = Proxy.Admissions.Save_Financial_Aid_Request(ref ds_adm_stu, nsfasIndicator);
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

        void LoadFinancialAidRequest()
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
                bool nsfas = Proxy.Admissions.get_Financial_Indicator(ds_adm_stu.TT_ADM_STU[0].STUNO, "StandAlone");

                if (nsfas)
                {
                    chkNSFAS.Checked = nsfas;
                }

                bsAdmissions.DataSource = ds_adm_stu.TT_ADM;
                bsAdmStudent.DataSource = ds_adm_stu.TT_ADM_STU;
            }
        }

        #endregion

         

  
    }
}

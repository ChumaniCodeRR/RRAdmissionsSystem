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
using NS_System.StrongTypesNS;

namespace Admissions.AdmissionForms
{
    public partial class WizardEnd : UserControl, IWizard
    {
        ds_genDataSet ds_app_status;
        DS_ADM_STUDataSet ds_adm_stu;

        #region Constructors

        public WizardEnd()
        {
            InitializeComponent();
        }

        public WizardEnd(string wizardName)
            : this()
        {
            //lblEndMessage.Text = string.Concat("End of '", wizardName, "' wizard. Click 'Finish' to exit.");
        }

        #endregion

        #region IWizard Members

        public bool ShowView()
        {
            if (AdmissionUtilities.IsUndergradApplication())
            {
                gbApplicationStatus.Visible = false;
            }
            else
            {
                gbDegreeSelection.Visible = gbAppSummary.Visible = false;
                gbApplicationStatus.Location = gbDegreeSelection.Location;
            }

            LoadStudentDetails();
            return true;
        }

        public bool Next()
        {
            try
            {
                //int app_type = (int)WizardEnvironment.State[AdmissionStateItems.ApplicationType];
                //bool tempsession = (bool)WizardEnvironment.State[AdmissionStateItems.ApplicationSession];
                //bool stuoffer = (bool)WizardEnvironment.State[AdmissionStateItems.StudentOffer];
                //string temperror = Proxy.Admissions.System_Offer(app_type, tempsession, stuoffer, ref ds_adm_stu);
                //if (!string.IsNullOrEmpty(temperror))
                //{
                //    MessageBox.Show(temperror, "Admissions", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //    return false;
                //}
            }
            catch (Exception ex)
            {
                Utils.HandleException(ExceptionSource.HonoursSys, ex);
                return false;
            }
            return true;
        }

        public void Back()
        {

        }

        #endregion

        #region Local Methods

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

            lblFirstChoiceDeg.Text = lblSecondChoiceDeg.Text = ": ";

            if (ds_adm_stu.TT_ADM_STU.Rows.Count > 0)
            {
                lblProvUnwtd.Text = ds_adm_stu.TT_ADM_STU[0].P_UNWT_PTS.ToString("0.00");
                lblProvWtd.Text = ds_adm_stu.TT_ADM_STU[0].P_WT_PTS.ToString("0.00");

                lblFinalUnwt.Text = ds_adm_stu.TT_ADM_STU[0].UNWT_PTS.ToString("0.00");
                lblFinalWtd.Text = ds_adm_stu.TT_ADM_STU[0].WT_PTS.ToString("0.00");

            }

            if (ds_adm_stu.TT_ADM.Rows.Count > 0)
            {
                string deg_name1 = string.Empty, deg_name2 = string.Empty, temperror = string.Empty;
                int app_type = (int)WizardEnvironment.State[AdmissionStateItems.ApplicationType];
                if (app_type.Equals((int)Enumerations.AdmissionApplicationType.UG) || app_type.Equals((int)Enumerations.AdmissionApplicationType.International) || app_type.Equals((int)Enumerations.AdmissionApplicationType.ACE) || app_type.Equals((int)Enumerations.AdmissionApplicationType.Gadra))
                {
                    temperror = Proxy.Admissions.Get_Degrees_By_Code(ds_adm_stu.TT_ADM[0].DEGR1, ds_adm_stu.TT_ADM[0].DEGR2, out deg_name1, out deg_name2);
                }
                else if (app_type.Equals((int)Enumerations.AdmissionApplicationType.Hons_LLB_BBS) || app_type.Equals((int)Enumerations.AdmissionApplicationType.PG))
                {
                    temperror = Proxy.Admissions.Get_Degrees_By_Code(ds_adm_stu.TT_ADM[0].PG_DEGR1, ds_adm_stu.TT_ADM[0].PG_DEGR2, out deg_name1, out deg_name2);
                }
                else throw new ApplicationException("Could not resolve admission application type.");

                if (!string.IsNullOrEmpty(temperror))
                {
                    MessageBox.Show(temperror, "Admissions", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                lblFirstChoiceDeg.Text = string.Concat(lblFirstChoiceDeg.Text, deg_name1);
                lblSecondChoiceDeg.Text = string.Concat(lblSecondChoiceDeg.Text, deg_name2);
            }

            lblDeclineMessage.Text = lblApplicationStatus.Text = "Application Status : ";
            if (ds_app_status == null)
            {
                ds_app_status = Proxy.System.Get_Gen("TRUE", "AP");
            }

            if (ds_adm_stu.TT_ADM.Rows.Count > 0)
            {
                int index = new BindingSource(ds_app_status, "TT_GEN").Find("code", ds_adm_stu.TT_ADM[0].APP_STAT);
                if (index < 0) return;
                lblDeclineMessage.Text = lblApplicationStatus.Text = string.Concat(lblDeclineMessage.Text, ds_app_status.TT_GEN[index].descrip);
            }

        }

        #endregion
    }
}

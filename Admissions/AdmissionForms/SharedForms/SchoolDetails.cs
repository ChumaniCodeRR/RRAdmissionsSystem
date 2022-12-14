using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using RhodesWizard;
using NS_System.StrongTypesNS;
using Utilities;
using NS_Admissions.StrongTypesNS;
using Admissions.Utilities;
using Admissions.UtilityScreens;

namespace Admissions.AdmissionForms
{
    public partial class SchoolDetails : UserControl, IWizard
    {
        DS_ADM_STUDataSet ds_adm_stu;
        DS_SCHOOLDataSet ds_schools;
        //ds_genDataSet ds_matric_body;


        public SchoolDetails()
        {
            InitializeComponent();

        }

        #region IWizard Members

        public bool ShowView()
        {
            try
            {
                PopulateComboBoxes();
                PopulateSchoolDetails();
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
                errorProvider.Clear();
                if (AdmissionUtilities.IsUndergradApplication() && !IsValidSchoolDetails()) return false;

                int app_type = (int)WizardEnvironment.State[AdmissionStateItems.ApplicationType];
                bool tempsession = (bool)WizardEnvironment.State[AdmissionStateItems.ApplicationSession], add_school = false;


                /* Taken out RT Ticket #445153
                  
                string school_message = Proxy.Admissions.Validate_New_School_Code(cbSchoolName.SelectedValue.ToString());
                if (!string.IsNullOrEmpty(school_message))
                {
                    DialogResult result = MessageBox.Show(school_message, "Admissions", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                    if (result.Equals(DialogResult.Cancel)) return false;
                    else if (result.Equals(DialogResult.Yes))
                    {
                        NewSchoolDetails newSchool = new NewSchoolDetails();
                        if (newSchool.ShowDialog().Equals(DialogResult.OK))
                        {
                            DS_ADM_STUDataSet.TT_NOSCHOOLRow no_school;
                            if (ds_adm_stu.TT_NOSCHOOL.Rows.Count.Equals(0))
                            {
                                no_school = ds_adm_stu.TT_NOSCHOOL.NewTT_NOSCHOOLRow();
                                ds_adm_stu.TT_NOSCHOOL.AddTT_NOSCHOOLRow(no_school);
                            }
                            else no_school = ds_adm_stu.TT_NOSCHOOL[0];

                            no_school.STUNO = Global.Global.tempstu;
                            no_school.SCHOOL = cbSchoolName.SelectedValue.ToString();
                            no_school.SCHOOL_DET = newSchool.SchoolName;
                            no_school.SCHOOL_CITY = newSchool.SchoolCity;
                            no_school.SCHOOL_CELL = newSchool.CellNumber;

                            add_school = true;
                        }
                        else return false;
                    }
                }*/

                bsAdmissions.EndEdit();
                bsAdmStudent.EndEdit();

                string temperror = Proxy.Admissions.Save_School_Details(app_type, tempsession, ref ds_adm_stu, add_school, Global.Global.admissions_view);
                if (!string.IsNullOrEmpty(temperror))
                {
                    MessageBox.Show(temperror, "Admissions", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                WizardEnvironment.State[AdmissionStateItems.AdmissionStudent] = ds_adm_stu;
            }
            catch (Exception ex)
            {
                Utils.HandleException(ExceptionSource.Admissions, ex);
            }

            return true;
        }

        public void Back()
        {
            errorProvider.Clear();
        }

        #endregion

        #region Local Methods

        void PopulateComboBoxes()
        {
            if (cbSchoolName.Items.Count.Equals(0))
            {
                ds_schools = Proxy.Admissions.Get_Schools();
                DataView dvSchools = new DataView(ds_schools.TT_SCHOOL);
                if (Global.Global.IsGadra == true) dvSchools.RowFilter = string.Format("SCHOOL = '{0}'", "S00482");
                cbSchoolName.DataSource = dvSchools;
                if (Global.Global.IsGadra == true) cbSchoolName.SelectedIndex = 0;  
                else cbSchoolName.SelectedIndex = -1;
                

            }

            /*Removed dropdown for ticket #615982 RT */
            /*  if (cbMatricType.Items.Count.Equals(0))
              {
                  ds_genDataSet ds_matric_type = Proxy.System.Get_Gen("TRUE", "MT");
                  cbMatricType.DataSource = ds_matric_type.TT_GEN;
              }

              if (cbMatricBody.Items.Count.Equals(0))
              {
                  ds_matric_body = Proxy.System.Get_Gen("TRUE", "MB");
                  cbMatricBody.DataSource = ds_matric_body.TT_GEN;
              } */
        }

        void PopulateSchoolDetails()
        {
            if (WizardEnvironment.State.ContainsKey(AdmissionStateItems.AdmissionStudent) && WizardEnvironment.State[AdmissionStateItems.AdmissionStudent] != null)
            {
                ds_adm_stu = (DS_ADM_STUDataSet)WizardEnvironment.State[AdmissionStateItems.AdmissionStudent];
            }
            else
            {
                ds_adm_stu = new DS_ADM_STUDataSet();
            }

            bsAdmStudent.DataSource = ds_adm_stu.TT_ADM_STU;
            bsAdmissions.DataSource = ds_adm_stu.TT_ADM;

            cbSchoolName.Focus();
            cbSchoolName.SelectAll();
            if (ds_adm_stu.TT_ADM.Rows.Count > 0) lbl_school.Text = ds_adm_stu.TT_ADM[0].OTHER_SCHOOL;
            if (lbl_school.Text != string.Empty)
            {
                lbl_school.Visible = lbl_online.Visible = true;
                Admissions.Utilities.AdmissionStateItems.schoolname = lbl_school.Text;
            }
            else lbl_school.Visible = lbl_online.Visible = false;
        }

        bool IsValidSchoolDetails()
        {
            bool valid = true;

            if (cbSchoolName.SelectedValue == null)
            {
                valid = false;
                errorProvider.SetError(cbSchoolName, "You have to select school from the list.");
            }

            /*if (cbMatricType.SelectedValue == null)
            {
                valid = false;
                errorProvider.SetError(cbMatricType, "You have to select matric type from the list.");
            }

            if (cbMatricBody.SelectedValue == null)
            {
                valid = false;
                errorProvider.SetError(cbMatricBody, "You have to select matric body from the list.");
            }*/

            if (!txtMatricYear.Text.Trim().Length.Equals(4))
            {
                valid = false;
                errorProvider.SetError(txtMatricYear, "You have to enter a valid matric year.");
            }

            if (int.Parse(txtYearsAtSchools.Text.Trim()) <= 0)
            {
                valid = false;
                errorProvider.SetError(txtYearsAtSchools, "You have to enter a valid number of years in school.");
            }

            return valid;
        }

        #endregion

        #region ComboBox Events

        private void cbSchoolName_SelectedIndexChanged(object sender, EventArgs e)
        {
            errorProvider.SetError(cbSchoolName, string.Empty);
            if (cbSchoolName.SelectedValue != null)
            {
                int index = new BindingSource(ds_schools, "TT_SCHOOL").Find("SCHOOL", cbSchoolName.SelectedValue.ToString());

                if (index > 0 && !ds_schools.TT_SCHOOL[index].IsMAT_BODYNull())
                {
                    if (!(ds_schools.TT_SCHOOL[index].SCHOOL.ToString() == "N00001" && lbl_school.Text != string.Empty)) { }
                    //cbMatricBody.SelectedValue = ds_schools.TT_SCHOOL[index].MAT_BODY;
                }
            }
        }

        /* private void cbMatricType_SelectedIndexChanged(object sender, EventArgs e)
         {
             errorProvider.SetError(cbMatricType, string.Empty);
         }

         private void cbMatricBody_SelectedIndexChanged(object sender, EventArgs e)
         {
             errorProvider.SetError(cbMatricBody, string.Empty);
         } */

        void txtMatricYear_TextChanged(object sender, System.EventArgs e)
        {
            errorProvider.SetError(txtMatricYear, string.Empty);
        }

        void txtYearsAtSchools_TextChanged(object sender, System.EventArgs e)
        {
            errorProvider.SetError(txtYearsAtSchools, string.Empty);
        }

        #endregion

        #region Focus events

        void cbMatricBody_GotFocus(object sender, System.EventArgs e)
        {
            // cbMatricBody.SelectAll();
        }

        void txtMatricNo_GotFocus(object sender, System.EventArgs e)
        {
            txtMatricNo.SelectAll();
        }

        void txtMatricYear_GotFocus(object sender, System.EventArgs e)
        {
            txtMatricYear.SelectAll();
        }

        void txtYearsAtSchools_GotFocus(object sender, System.EventArgs e)
        {
            txtYearsAtSchools.SelectAll();
        }

        void cbSchoolName_GotFocus(object sender, System.EventArgs e)
        {
            cbSchoolName.SelectAll();
        }

        #endregion
    }
}

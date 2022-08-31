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
    public partial class FamilyAtRhodes : UserControl, IWizard
    {
        bool updateFamily;
        DS_ADM_STUDataSet ds_adm_stu;

        #region Construsctors

        public FamilyAtRhodes()
        {
            InitializeComponent();
        }

        public FamilyAtRhodes(bool updateFamily)
            : this()
        {
            this.updateFamily = updateFamily;
            if (updateFamily)
            {
                gbFinancialAid.Visible = false;
                lblTitle.Text = "Family at Rhodes";

                gbOldRhodian.Location = new Point(gbOldRhodian.Location.X, gbOldRhodian.Location.Y - gbFinancialAid.Height);
                gbCurrentlyAtRhodes.Location = new Point(gbCurrentlyAtRhodes.Location.X, gbCurrentlyAtRhodes.Location.Y - gbFinancialAid.Height);
            }
        }

        #endregion

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

                PopulateRhodesFamily();
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
                if (Global.Global.admissions_view & !updateFamily)
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
                        if(ds_adm_stu.TT_ADM_STU[0].GROSS_CAT3)
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
                }

                int app_type = (int)WizardEnvironment.State[AdmissionStateItems.ApplicationType];
                bool tempsession = (bool)WizardEnvironment.State[AdmissionStateItems.ApplicationSession];
                string temperror2 = Proxy.Admissions.Save_Rhodes_Relatives(Global.Global.FromWhere, app_type, tempsession, ref ds_adm_stu, Global.Global.admissions_view);
                if (!string.IsNullOrEmpty(temperror2))
                {
                    MessageBox.Show(temperror2, "Admissions", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                WizardEnvironment.State[AdmissionStateItems.AdmissionStudent] = ds_adm_stu;
                Global.Global.FromWhere = "";
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

        void PopulateRhodesFamily()
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
                bool nsfas = Proxy.Admissions.get_Financial_Indicator(ds_adm_stu.TT_ADM_STU[0].STUNO,"Wizard");       
                
                if(nsfas)
                {
                    chkNSFAS.Checked = nsfas;
                }
                
                bsAdmissions.DataSource = ds_adm_stu.TT_ADM;
                bsAdmStudent.DataSource = ds_adm_stu.TT_ADM_STU;
            }
            
            this.Invalidate();
            if (ds_adm_stu.TT_ADM_STU.Rows.Count.Equals(0)) return;

            string columnName = string.Empty;
            for (int i = 1; i <= 2; i++)
            {
                columnName = string.Concat("OR_NAMES", i);
                if (ds_adm_stu.TT_ADM_STU[0][columnName] == null || ds_adm_stu.TT_ADM_STU[0][columnName] == System.DBNull.Value)
                { PopulateTextBoxText(string.Concat("txtOldName", i), string.Empty); }
                else PopulateTextBoxText(string.Concat("txtOldName", i), ds_adm_stu.TT_ADM_STU[0][columnName].ToString());

                columnName = string.Concat("OR_STUNO", i);
                if (ds_adm_stu.TT_ADM_STU[0][columnName] == null || ds_adm_stu.TT_ADM_STU[0][columnName] == System.DBNull.Value)
                { PopulateTextBoxText(string.Concat("txtOldStuno", i), string.Empty); }
                PopulateTextBoxText(string.Concat("txtOldStuno", i), ds_adm_stu.TT_ADM_STU[0][columnName].ToString());
            }

            for (int i = 1; i <= 4; i++)
            {
                columnName = string.Concat("CR_STUNO", i);
                if (ds_adm_stu.TT_ADM_STU[0][columnName] == null || ds_adm_stu.TT_ADM_STU[0][columnName] == System.DBNull.Value)
                { PopulateTextBoxText(string.Concat("txtCurrent", i), string.Empty); }
                PopulateTextBoxText(string.Concat("txtCurrent", i), ds_adm_stu.TT_ADM_STU[0][columnName].ToString());
            }
        }

        void PopulateTextBoxText(string textBoxName, string textBoxValue)
        {
            Control[] controls = this.Controls.Find(textBoxName, true);
            if (controls != null && controls.Length > 0 && controls[0].GetType().Equals(typeof(TextBox)))
            { ((TextBox)controls[0]).Text = textBoxValue; }
        }

        #endregion

        #region CheckBox Events

        

        private void ckOldRhodian_CheckedChanged(object sender, EventArgs e)
        {
            if (ckOldRhodian.Checked)
            {
                txtOldName1.Enabled = txtOldName2.Enabled = true;
                txtOldStuno1.Enabled = txtOldStuno2.Enabled = true;
            }
            else
            {
                txtOldName1.Enabled = txtOldName2.Enabled = false;
                txtOldStuno1.Enabled = txtOldStuno2.Enabled = false;

                txtOldName1.Text = txtOldName2.Text = string.Empty;
                txtOldStuno1.Text = txtOldStuno2.Text = string.Empty;
            }
        }

        private void ckCurrentlyRegistered_CheckedChanged(object sender, EventArgs e)
        {
            if (ckCurrentlyRegistered.Checked)
            {
                txtCurrent1.Enabled = txtCurrent2.Enabled = txtCurrent3.Enabled = txtCurrent4.Enabled = true;
                btnCurrent1.Enabled = btnCurrent2.Enabled = btnCurrent3.Enabled = btnCurrent4.Enabled = true;
            }
            else
            {
                txtCurrent1.Enabled = txtCurrent2.Enabled = txtCurrent3.Enabled = txtCurrent4.Enabled = false;
                btnCurrent1.Enabled = btnCurrent2.Enabled = btnCurrent3.Enabled = btnCurrent4.Enabled = false;

                txtCurrent1.Text = txtCurrent2.Text = txtCurrent3.Text = txtCurrent4.Text = string.Empty;
            }
        }

        #endregion

        #region TextBox Events

        private void btnCurrent1_Click(object sender, EventArgs e)
        {
            SearchStudent(txtCurrent1);
        }

        private void btnCurrent2_Click(object sender, EventArgs e)
        {
            SearchStudent(txtCurrent2);
        }

        private void btnCurrent3_Click(object sender, EventArgs e)
        {
            SearchStudent(txtCurrent3);
        }

        private void btnCurrent4_Click(object sender, EventArgs e)
        {
            SearchStudent(txtCurrent4);
        }

        void SearchStudent(TextBox txt)
        {
            Search_Grid_Students.Search_Grid_Students frmStuSearch = new Search_Grid_Students.Search_Grid_Students(false);
            frmStuSearch.ShowDialog();
            txt.Text = frmStuSearch.Stuno;
            bsAdmStudent.EndEdit();
        }

        #endregion

        #region Control Focus Events

        void txtOldName2_GotFocus(object sender, System.EventArgs e)
        {
            txtOldName2.SelectAll();
        }

        void txtOldName1_GotFocus(object sender, System.EventArgs e)
        {
            txtOldName1.SelectAll();
        }

        void nudGrossIncome_GotFocus(object sender, System.EventArgs e)
        {
          //  nudGrossIncome.Select(0, nudGrossIncome.Value.ToString().Length);
        }

        #endregion

       
    }
}

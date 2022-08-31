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
using Admissions.UtilityScreens;
using System.IO;

namespace Admissions.AdmissionForms
{
    public partial class PreviousStudies : UserControl, IWizard
    {

        string apptype = "undergrad";
        bool startup = true;
        DS_ADM_STUDataSet ds_adm_stu;
        DS_DEG_LOOKUPDataSet ds_deg_lookup;

        public PreviousStudies()
        {
            InitializeComponent();
            dgvPrevStudies.AutoGenerateColumns = false;
        }

        #region IWizard Members

        public bool ShowView()
        {
            try
            {
                if (WizardEnvironment.State.ContainsKey(AdmissionStateItems.CurrentStudent))
                {
                    bool currentstudent = (bool)WizardEnvironment.State[AdmissionStateItems.CurrentStudent];
                    if (currentstudent) return false;
                }

                if (startup)
                {
                    ds_deg_lookup = Proxy.Admissions.Get_Degree_Lookup();
                    PopulateUniversities();
                    DisableUpdateMode();
                    PopulatePreviousDegrees();
                    startup = false;
                }

                
                string doctype = "TS";
                apptype = "undergrad";
                
                if(Global.Global.IsGadra == true)
                {
                    apptype = "undergrad";
                }
                
                if (Global.Global.app_stat == "E" || Global.Global.app_stat == "F" ||  Global.Global.app_stat == "H")
                {
                    apptype = "postgrad";
                    doctype = "TS1";
                }
                bool docfound = Proxy.System.CHECK_DOCUMENT("stuno", Global.Global.tempstu, doctype, apptype);

                if ((Global.Global.app_stat == "E" || Global.Global.app_stat == "F" || Global.Global.app_stat == "H") && !docfound)
                {
                    apptype = "postgrad";
                    doctype = "PG";
                    docfound = Proxy.System.CHECK_DOCUMENT("stuno", Global.Global.tempstu, doctype, apptype);
                    if (!docfound)
                    {
                        doctype = "PG1";
                        docfound = Proxy.System.CHECK_DOCUMENT("stuno", Global.Global.tempstu, doctype, apptype);
                    }
                }
                btn_trans.Visible = docfound;

                if (Global.Global.app_stat == string.Empty && docfound == false)
                {
                    apptype = "postgrad";
                    doctype = "TS1";
                    docfound = Proxy.System.CHECK_DOCUMENT("stuno", Global.Global.tempstu, doctype, apptype);
                    btn_trans.Visible = docfound;
                }

                docfound = false;                
                doctype = "PR1";
                docfound = Proxy.System.CHECK_DOCUMENT("stuno", Global.Global.tempstu, doctype, apptype);
                btn_thesis.Visible = docfound;

                docfound = false; 
                doctype = "CV";
                docfound = Proxy.System.CHECK_DOCUMENT("stuno", Global.Global.tempstu, doctype, apptype);
                if (!docfound)
                {
                    doctype = "CV1";
                    docfound = Proxy.System.CHECK_DOCUMENT("stuno", Global.Global.tempstu, doctype, apptype);

                    if (!docfound)
                    {
                        doctype = "PF";
                        docfound = Proxy.System.CHECK_DOCUMENT("stuno", Global.Global.tempstu, doctype, apptype);
                        if (!docfound)
                        {
                            doctype = "PF1";
                            docfound = Proxy.System.CHECK_DOCUMENT("stuno", Global.Global.tempstu, doctype, apptype);
                        }
                    }
                }
                btn_supporting_docs.Visible = docfound;

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
                if (!scPreviousStudies.Panel2Collapsed)
                {
                    string msg = "The view is currently in Add/Update mode. You have to Save or Cancel the current Add/Update before you go Next.";
                    MessageBox.Show(msg, AdmissionConstants.MessageBoxCaption, MessageBoxButtons.OK, MessageBoxIcon.Warning); return false;
                }

                string temperror = Proxy.Admissions.Save_Previous_Degrees(Global.Global.FromWhere, ref ds_adm_stu, Global.Global.admissions_view);
                if (!string.IsNullOrEmpty(temperror))
                {
                    MessageBox.Show(temperror, "Admissions", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                Global.Global.FromWhere = "";
            }
            catch (Exception ex)
            {
                Utils.HandleException(ExceptionSource.Admissions, ex);
            }
            return true;
        }

        public void Back()
        {
            
        }

        #endregion

        #region Local Methods

        void PopulateUniversities()
        {
            DataGridViewComboBoxColumn columnInstitution = (DataGridViewComboBoxColumn)dgvPrevStudies.Columns[cInstitution.Name];

            if (cbInstitution.Items.Count.Equals(0) || columnInstitution.Items.Count.Equals(0))
            {
                DS_UNIVDataSet ds_univ = Proxy.Admissions.Get_Universities();
                cbInstitution.DataSource = ds_univ.TT_UNIV;

                columnInstitution.ValueMember = "UNIV";
                columnInstitution.DisplayMember = "UNIV_NAME";
                columnInstitution.DataSource = ds_univ.TT_UNIV;
            }

           
        }

        void EnableUpdateMode()
        {
            scPreviousStudies.Panel1.Enabled = false;
            scPreviousStudies.Panel2Collapsed = false;
        }

        void DisableUpdateMode()
        {
            nudYear.Value = DateTime.Today.Year;
            cbInstitution.SelectedIndex = -1;
            txtQualification.Text = string.Empty;
            ckCompleted.Checked = false;
            txtStudentNo.Text = string.Empty;

            scPreviousStudies.Panel1.Enabled = true;
            scPreviousStudies.Panel2Collapsed = true;
        }

        void PopulatePreviousDegrees()
        {
            if (WizardEnvironment.State.ContainsKey(AdmissionStateItems.AdmissionStudent) && WizardEnvironment.State[AdmissionStateItems.AdmissionStudent] != null)
            {
                ds_adm_stu = (DS_ADM_STUDataSet)WizardEnvironment.State[AdmissionStateItems.AdmissionStudent];
            }
            else
            {
                ds_adm_stu = new DS_ADM_STUDataSet();
            }
            dgvPrevStudies.DataSource = ds_adm_stu.TT_PDEG;

            
        }

        bool IsValidPreviousStudies()
        {
            bool valid = true;
            errorProvider.Clear();

            if (cbInstitution.SelectedValue == null)
            {
                valid = false;
                errorProvider.SetError(cbInstitution, "Select a valid institution from the list.");
            }

            if (string.IsNullOrEmpty(txtQualification.Text.Trim()) && string.IsNullOrEmpty(txtNonRUDeg.Text.Trim()))
            {
                valid = false;
                errorProvider.SetError(btnRhodesDeg, "You have to enter qualification of select one from the list.");
            }

            return valid;
        }

        #endregion

        #region Button Events

        private void btnNew_Click(object sender, EventArgs e)
        {
            if (dgvPrevStudies.Rows.Count < 5)
            {
                EnableUpdateMode();
            }
            else
            {
                string msg = "You can add a maximum of 5 qualifications.";
                MessageBox.Show(msg, "Admissions", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                string msg = string.Empty;

                if (dgvPrevStudies.SelectedRows.Count.Equals(0))
                {
                    msg = "There is not selected qualification to remove.";
                    MessageBox.Show(msg, "Admissions", MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
                }

                msg = "Are you sure you want to remove the selected qualification?";
                if (!MessageBox.Show(msg, "Admissions", MessageBoxButtons.YesNo, MessageBoxIcon.Question).Equals(DialogResult.Yes)) return;

                int yr = (int)dgvPrevStudies[cYear.Name, dgvPrevStudies.SelectedRows[0].Index].Value;
                int inst = (int)dgvPrevStudies[cInstitution.Name, dgvPrevStudies.SelectedRows[0].Index].Value;
                string deg = dgvPrevStudies[cDegree.Name, dgvPrevStudies.SelectedRows[0].Index].Value.ToString();
                string nonRU = dgvPrevStudies[cNonRU.Name, dgvPrevStudies.SelectedRows[0].Index].Value.ToString();

                for (int i = 0; i < ds_adm_stu.TT_PDEG.Rows.Count; i++)
                {
                    DS_ADM_STUDataSet.TT_PDEGRow pdeg = ds_adm_stu.TT_PDEG[i];
                    if (pdeg.YR.Equals(yr) && pdeg.UNIV.Equals(inst) && pdeg.DEG.Equals(deg) && pdeg.NO_CODE_DETAIL.Equals(nonRU))
                    { ds_adm_stu.TT_PDEG.RemoveTT_PDEGRow(pdeg); i--; }
                }
                dgvPrevStudies.Refresh();
            }
            catch (Exception ex)
            {
                Utils.HandleException(ExceptionSource.Admissions, ex);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                errorProvider.Clear();
                if (!IsValidPreviousStudies()) return;

                DS_ADM_STUDataSet.TT_PDEGRow pdeg = ds_adm_stu.TT_PDEG.NewTT_PDEGRow();
                pdeg.STUNO = ds_adm_stu.TT_ADM_STU[0].STUNO;
                pdeg.YR = (int)nudYear.Value;
                pdeg.UNIV = (int)cbInstitution.SelectedValue;
                pdeg.DEG = txtQualification.Text.Trim();
                pdeg.UNIV_STUNO = txtStudentNo.Text.Trim();
                pdeg.OBTAINED = ckCompleted.Checked;
                pdeg.NO_CODE_DETAIL = txtNonRUDeg.Text.Trim();
                ds_adm_stu.TT_PDEG.AddTT_PDEGRow(pdeg);
                dgvPrevStudies.Refresh();

                DisableUpdateMode();
            }
            catch (Exception ex)
            {
                Utils.HandleException(ExceptionSource.Admissions, ex);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();
            DisableUpdateMode();
            Global.Global.FromWhere = "";
        }

        private void btnRhodesDeg_Click(object sender, EventArgs e)
        {
            RhodesDegree rhodesDegree = new RhodesDegree(ds_deg_lookup);
            if (rhodesDegree.ShowDialog().Equals(DialogResult.OK))
            {
                txtQualification.Text = rhodesDegree.Deg;
                Invoke(new EventHandler(txtQualification_Leave), sender, e);
            }
        }

        #endregion

        #region DataGridView Events

        void dgvPrevStudies_DataBindingComplete(object sender, System.Windows.Forms.DataGridViewBindingCompleteEventArgs e)
        {
            dgvPrevStudies.ClearSelection();
        }

        #endregion

        #region CheckBox Events

        private void ckNonRUDeg_CheckedChanged(object sender, EventArgs e)
        {
            if (ckNonRUDeg.Checked)
            {
                txtQualification.Enabled = btnRhodesDeg.Enabled = false;
                txtQualification.Text = string.Empty;

                txtNonRUDeg.Enabled = true;
            }
            else
            {
                txtNonRUDeg.Enabled = false;
                txtNonRUDeg.Text = string.Empty;

                txtQualification.Enabled = btnRhodesDeg.Enabled = true;
            }
        }

        #endregion

        #region TextBox Events

        void txtQualification_Leave(object sender, System.EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtQualification.Text.Trim()))
            {
                bool isRhodesDeg = Proxy.Admissions.Is_Rhodes_University_Degree(txtQualification.Text.Trim());
                if (!isRhodesDeg)
                {
                    ckNonRUDeg.Checked = true;
                    txtNonRUDeg.Focus();
                }
            }
        }

        private void txtQualification_TextChanged(object sender, EventArgs e)
        {
            errorProvider.SetError(btnRhodesDeg, string.Empty);
        }

        private void txtNonRUDeg_TextChanged(object sender, EventArgs e)
        {
            errorProvider.SetError(btnRhodesDeg, string.Empty);
        }

        #endregion

        #region ComboBox events

        private void cbInstitution_SelectedIndexChanged(object sender, EventArgs e)
        {
            errorProvider.SetError(cbInstitution, string.Empty);
        }

        #endregion

        #region Focus Events

        void txtStudentNo_GotFocus(object sender, System.EventArgs e)
        {
            txtStudentNo.SelectAll();
        }

        void txtNonRUDeg_GotFocus(object sender, System.EventArgs e)
        {
            txtNonRUDeg.SelectAll();
        }

        void txtQualification_GotFocus(object sender, System.EventArgs e)
        {
            txtQualification.SelectAll();
        }

        void cbInstitution_GotFocus(object sender, System.EventArgs e)
        {
            cbInstitution.SelectAll();
        }

        #endregion

        private void btn_trans_Click(object sender, EventArgs e)
        {
            int i = 0;
            do
            {
                i++;
                string docname = string.Empty;
                string doctype = "TS";            
                if (i > 1) doctype = "TS" + (i - 1).ToString();

                NS_System.StrongTypesNS.DS_DOCDataSet ds_doc = Proxy.System.Get_Documents("stuno", Global.Global.tempstu, doctype, apptype, out docname);
                if (docname != string.Empty) DMU.DisplayImages.display_picture(docname, ds_doc);
            } while (i < 8);


            i = 0;
            do
            {
                i++;
                string docname = string.Empty;
                string doctype = "PG";
                string apptype = "Postgrad";
                if (i > 1) doctype = "PG" + (i - 1).ToString();

                NS_System.StrongTypesNS.DS_DOCDataSet ds_doc = Proxy.System.Get_Documents("stuno", Global.Global.tempstu, doctype, apptype, out docname);
                if (docname != string.Empty) DMU.DisplayImages.display_picture(docname, ds_doc);
            } while (i < 8);

        }

        private void PreviousStudies_Load(object sender, EventArgs e)
        {
           
            
        }

        private void btn_thesis_Click(object sender, EventArgs e)
        {
            string docname = string.Empty;           
            string doctype = "PR1";

            docname = string.Empty;
            NS_System.StrongTypesNS.DS_DOCDataSet ds_doc = Proxy.System.Get_Documents("stuno", Global.Global.tempstu, doctype, apptype, out docname);
            if (docname != string.Empty) DMU.DisplayImages.display_picture(docname, ds_doc);      
        }

        private void btn_supporting_docs_Click(object sender, EventArgs e)
        {
            string doctype = string.Empty;            

            int i = 0;
            do
            {
                i++;
                string docname = string.Empty;
                doctype = "CV";
                if (i > 1) doctype = doctype + (i - 1).ToString();


                NS_System.StrongTypesNS.DS_DOCDataSet ds_doc = Proxy.System.Get_Documents("stuno", Global.Global.tempstu, doctype, apptype, out docname);
                if (docname != string.Empty) DMU.DisplayImages.display_picture(docname, ds_doc);
            } while (i < 8);

            i = 0;
            do
            {
                i++;
                string docname = string.Empty;
                doctype = "PF";
                if (i > 1) doctype = doctype + (i - 1).ToString();


                NS_System.StrongTypesNS.DS_DOCDataSet ds_doc = Proxy.System.Get_Documents("stuno", Global.Global.tempstu, doctype, apptype, out docname);
                if (docname != string.Empty) DMU.DisplayImages.display_picture(docname, ds_doc);
            } while (i < 8);
        }

    }
}

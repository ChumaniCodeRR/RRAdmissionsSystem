using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Utilities;

namespace Admissions.AdmissionForms
{
    public partial class CloseApplications : Form
    {
        NS_Admissions.StrongTypesNS.DS_XADMDataSet ds_xadm;
        NS_Admissions.StrongTypesNS.DS_XADMDataSet ds_xadm_up;

        DataView dv_list;
        public bool AddEdit;
        string tempdeg = string.Empty;
        DateTime tempstartdate;

        public CloseApplications()
        {
            InitializeComponent();
        }

        private void CloseApplications_Load(object sender, EventArgs e)
        {
            NS_System.StrongTypesNS.ds_degree_codesDataSet ds_degrees = Proxy.System.get_degrees();
            DataView dvDegrees = new DataView(ds_degrees.tt_degree_codes);
            bs_degs.DataSource = dvDegrees;

            refresh_data();
        }


       
        private void refresh_data()
        {
            try
            {
                sp_panel.Panel2Collapsed = true;
                sp_panel.Panel1.Enabled = true;

                ds_xadm = Proxy.Admissions.get_degree_adm_qual_full();
                dv_list = new DataView(ds_xadm.tt_adm_qual_deg);

                bs_list.DataSource = dv_list;
                sp_panel.Enabled = true;

                
            }
            catch (Exception ex)
            {
                Utils.HandleException(ExceptionSource.Admissions, ex);
            }
        }

     

        private void btn_add_Click(object sender, EventArgs e)
        {

            cbDegr.SelectedIndex = -1;
            nll_start_date.Value = null;
            cbDegr.Enabled = true;
            sp_panel.Panel2Collapsed = false;
            sp_panel.Panel1.Enabled = false;
            AddEdit = true;
 
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbDegr.SelectedIndex == -1) MessageBox.Show("Error - Select Degree", "Degree", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                else if (nll_start_date.Value == null) MessageBox.Show("Error - Insert Start Date", "Degree", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                else
                {
                    tempdeg = cbDegr.SelectedValue.ToString();
                    tempstartdate = DateTime.Parse(nll_start_date.Value.ToString());

                    string feedback = Proxy.Admissions.update_adm_qual_full(AddEdit, tempdeg, tempstartdate);
                    if (feedback != string.Empty) MessageBox.Show(feedback, "Add/Update", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (!feedback.Contains("Error"))
                    {
                        refresh_data();
                        
                        SetNonEditState();
                    }
                }
            }
            catch (Exception ex)
            {
                Utils.HandleException(ExceptionSource.DMU, ex);
            }
        }

        private void SetNonEditState()
        {
            sp_panel.Enabled = true;
            sp_panel.Panel2Collapsed = true;
            sp_panel.Panel1.Enabled = true;

            refresh_data();
        }

        private void btn_cancel_panel_Click(object sender, EventArgs e)
        {
            SetNonEditState();
        }

        private void dg_list_degree_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (dg_list_degree.SelectedRows.Count > 0)
                {
                    AddEdit = false;
                    cbDegr.SelectedValue = dg_list_degree.SelectedRows[0].Cells[cn_deg.Name].Value.ToString();
                    nll_start_date.Value = DateTime.Parse(dg_list_degree.SelectedRows[0].Cells[cn_start_dte.Name].Value.ToString());
                    cbDegr.Enabled = false;
                    sp_panel.Panel2Collapsed = false;
                    sp_panel.Panel1.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                Utils.HandleException(ExceptionSource.DMU, ex);
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if(dg_list_degree.SelectedRows.Count > 0)
            {
                if(MessageBox.Show("Are you sure you want to delete " + dg_list_degree.SelectedRows[0].Cells[cn_degree.Name].Value.ToString() + "" +
                    " from the Close online application list",
                    "Delete Close Online Application", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string tempdeg = dg_list_degree.SelectedRows[0].Cells[cn_deg.Name].Value.ToString();

                    string feedback = Proxy.Admissions.delete_adm_qual_full_degree(tempdeg);

                    if (feedback != "") MessageBox.Show(feedback, "Delete close online application", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    refresh_data();
                   
                }
            }
        }
    }
}

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
    public partial class CheckFeePayer : Form
    {
        public string MenuOption = "";
        public event EventHandler SelectOnlineApplication;
        string ref_no = string.Empty;
        string sap_lev = string.Empty;

        DataView dv_list;

        public CheckFeePayer()
        {
            InitializeComponent();
        }

        private void CheckFeePayer_Load(object sender, EventArgs e)
        {
           
            refresh_data();        }

        private void refresh_data()
        {
            try
            {
                NS_Admissions.StrongTypesNS.DS_XADMDataSet ds_xadm = Proxy.Admissions.get_unverified_feepayer();
                dv_list = new DataView(ds_xadm.tt_xadm);              
                
                filter();
            }
            catch (Exception ex)
            {
                Utils.HandleException(ExceptionSource.Admissions, ex);
            }
        }

        private void filter()
        {
            if (dv_list != null)
            {
                dv_list.RowFilter = "stuno like '" + txt_stuno.Text + "*' and ref_no like '" + txt_reference.Text + "*' and surn like '" + txt_surn.Text + "*'";              
                dv_list.Sort = "surn";
                bs_list.DataSource = dv_list;              
            }
        }

        private void txt_reference_TextChanged(object sender, EventArgs e)
        {
            filter();
        }

        private void txt_surn_TextChanged(object sender, EventArgs e)
        {
            filter();
        }

        private void dg_list_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (dg_list.SelectedRows.Count > 0)
                {
                    string docname = string.Empty;
                    string stuno = dg_list.SelectedRows[0].Cells[cnStuno.Name].Value.ToString();
                    string apptype = "ug-adm";
                    string doctype = "FP1";



                    NS_System.StrongTypesNS.DS_DOCDataSet ds_doc = Proxy.System.Get_Documents("refno", stuno, doctype, apptype, out docname);
                    if (docname != string.Empty) DMU.DisplayImages.display_picture(docname, ds_doc);    
                    
                }
            }
            catch (Exception ex)
            {
                Utils.HandleException(ExceptionSource.Admissions, ex);
            }

        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            if (dg_list.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Are you sure you want to set " + dg_list.SelectedRows[0].Cells[cnSurn.Name].Value.ToString() + ", " + dg_list.SelectedRows[0].Cells[cnName.Name].Value.ToString() + " form fee payer verified to true?", "Fee Payer", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string tempstuno = dg_list.SelectedRows[0].Cells[cnStuno.Name].Value.ToString();
                    int tempyr = int.Parse(dg_list.SelectedRows[0].Cells[cnAdm_yr.Name].Value.ToString());

                    string feedback = Proxy.Admissions.check_feepayer(tempstuno, tempyr);
                    MessageBox.Show(feedback, "Fee Payer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (!feedback.Contains("Error")) refresh_data();

                }
            }
        }

      

        private void dg_list_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                dg_list.ClearSelection();
                ContextMenu m = new ContextMenu();

                int currentMouseOverRow = dg_list.HitTest(e.X, e.Y).RowIndex;

                if (currentMouseOverRow >= 0)
                {
                    dg_list.Rows[currentMouseOverRow].Selected = true;
                    ref_no = dg_list.SelectedCells[1].Value.ToString();
                    sap_lev = dg_list.SelectedCells[20].Value.ToString();
                    string appname = dg_list.SelectedCells[0].Value.ToString() + " - " + dg_list.SelectedCells[2].Value.ToString() + " " + dg_list.SelectedCells[3].Value.ToString();
                    m.MenuItems.Add(appname);
                    m.MenuItems.Add("-");

                    //Add View Online Application option
                    MenuItem vo = new MenuItem("View Online Application");
                    vo.Click += vo_Click;
                    m.MenuItems.Add(vo);

                    m.Show(dg_list, new Point(e.X, e.Y));
                }
            }

        }
        void vo_Click(object sender, EventArgs e)
        {
            try
            {
                string regguid = Proxy.Admissions.update_xadm_regguid(ref_no);
                if (!regguid.Contains("Error"))
                {
                    if (sap_lev == "" | sap_lev == string.Empty) sap_lev = "U";
                    OnlineApplication frmOnlineApp = new OnlineApplication(ref_no, sap_lev, regguid);
                    frmOnlineApp.Show();
                }
                else MessageBox.Show(regguid, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                refresh_data();
            }
            catch (Exception ex)
            {
                Utils.HandleException(ExceptionSource.Admissions, ex);
            }
        }

        private void txt_stuno_TextChanged(object sender, EventArgs e)
        {
            filter();
        }

     

    }
}

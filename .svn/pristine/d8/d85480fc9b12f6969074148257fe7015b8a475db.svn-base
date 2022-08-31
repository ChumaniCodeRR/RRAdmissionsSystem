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
    public partial class PayConfirmation : Form
    {

        NS_Admissions.StrongTypesNS.DS_XADMDataSet ds_applicant = new NS_Admissions.StrongTypesNS.DS_XADMDataSet();

        DataView dv_list;
        string ref_no;
        string appname;

        public PayConfirmation()
        {
            InitializeComponent();
        }

        private void PayConfirmation_Load(object sender, EventArgs e)
        {

            refresh_data();
        }

        private void refresh_data()
        {
            try
            {
                NS_Admissions.StrongTypesNS.DS_XADMDataSet ds_xadm = Proxy.Admissions.get_payment_confirmation_list();
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
            dv_list.RowFilter = "ref_no like '" + txt_reference.Text + "*' and surn like '" + txt_surn.Text + "*' and id like '" + txt_id.Text.ToString() + "*'";
            dv_list.Sort = "surn";
            bs_list.DataSource = dv_list;
        }

        private void txt_reference_TextChanged(object sender, EventArgs e)
        {
            filter();
        }

        private void txt_surn_TextChanged(object sender, EventArgs e)
        {
            filter();
        }

        private void txt_id_TextChanged(object sender, EventArgs e)
        {
            filter();
        }

        private void dg_list_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (dg_list.SelectedRows.Count > 0)
                {
                    if (MessageBox.Show("Are you sure you want to confirm " + dg_list.SelectedRows[0].Cells[cn_refno.Name].Value.ToString() + " " +
                        dg_list.SelectedRows[0].Cells[cn_surn.Name].Value.ToString() + " " + dg_list.SelectedRows[0].Cells[cn_namestr.Name].Value.ToString() + " payment?",
                        "Confirm Payment", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) 
                    {
                        string tempref = dg_list.SelectedRows[0].Cells[cn_refno.Name].Value.ToString();
                        string feedback = Proxy.Admissions.confirm_payments(tempref);
                        MessageBox.Show(feedback, "Confirm Payment", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if(!feedback.Contains("Error")) refresh_data();
                    }
                }
            }
            catch (Exception ex)
            {
                Utils.HandleException(ExceptionSource.Admissions, ex);
            }

        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            if (dv_list.Count > 0)
            {

                OnlineApps.OnlineReportForm frmReport = new OnlineApps.OnlineReportForm("PayConfirmation", dv_list);
                frmReport.Show();

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
                    appname = (string.Format("{0} - {1} {2}", dg_list.SelectedCells[0].Value.ToString(), dg_list.SelectedCells[2].Value.ToString(),dg_list.SelectedCells[3].Value.ToString()));
                    ref_no = dg_list.SelectedCells[0].Value.ToString();
                    
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
                string feedback = Proxy.Admissions.get_online_applicant(ref_no, out ds_applicant);
                if (feedback == string.Empty)
                {
                    string regguid = Proxy.Admissions.update_xadm_regguid(ref_no);
                    if (!regguid.Contains("Error"))
                    {
                        OnlineApplication frmOnlineApp = new OnlineApplication(ref_no, ds_applicant.tt_xadm[0].sap_lev, regguid);
                        frmOnlineApp.Show();
                    }
                    else MessageBox.Show(regguid, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else MessageBox.Show(feedback, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            catch (Exception ex)
            {
                Utils.HandleException(ExceptionSource.Admissions, ex);
            }
        }        
    }
}

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
    public partial class UnCheckedForms : Form
    {
        public string MenuOption = "";
        public event EventHandler SelectOnlineApplication;
        string ref_no = string.Empty;
        string sap_lev = string.Empty;

        DataView dv_list;

        public UnCheckedForms()
        {
            InitializeComponent();
        }

        private void PayConfirmation_Load(object sender, EventArgs e)
        {
            Dictionary<string, string> userCache = new Dictionary<string, string>
                {
                  {"All", "*"},
                  {"UG Applications", "U"},
                  {"Honours Applications", "E"},                  
                  {"Masters Applications", "F"},
                  {"PhD Applications", "H"}
                };
            cb_acad_level.DataSource = new BindingSource(userCache, null);
            cb_acad_level.DisplayMember = "Key";
            cb_acad_level.ValueMember = "Value";
            cb_acad_level.SelectedIndex = 0;


            refresh_data();
        }

        private void refresh_data()
        {
            try
            {
                string tempstatus;
                NS_Admissions.StrongTypesNS.DS_XADMDataSet ds_xadm = Proxy.Admissions.get_unchecked_forms(out tempstatus);
                dv_list = new DataView(ds_xadm.tt_xadm);              
                txt_status.Text = tempstatus;
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
                if (!rbAll.Checked) dv_list.RowFilter = dv_list.RowFilter + " and online_app = " + rbOnline.Checked.ToString();
                if (cb_acad_level.SelectedValue.ToString() != "*") dv_list.RowFilter = dv_list.RowFilter + " and sap_lev like '" + cb_acad_level.SelectedValue.ToString() + "'";
                dv_list.Sort = "surn";
                bs_unchecked.DataSource = dv_list;
                if (dv_list.Count > 0) btn_print.Enabled = true;
                else btn_print.Enabled = false;
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
                    string ref_no = dg_list.SelectedRows[0].Cells[cnrefno.Name].Value.ToString();
                    string tempstuno = dg_list.SelectedRows[0].Cells[cnstuno.Name].Value.ToString();
                    string saplev = dg_list.SelectedRows[0].Cells[cnsaplev.Name].Value.ToString();
                    int tempyr = int.Parse(dg_list.SelectedRows[0].Cells[cn_adm_yr.Name].Value.ToString());

                    if (saplev == "U")
                    {
                        DialogResult dialog = MessageBox.Show("Are you sure you want to set " + tempstuno + " " +
                            dg_list.SelectedRows[0].Cells[cnsurn.Name].Value.ToString() + " " + dg_list.SelectedRows[0].Cells[cnnamestr.Name].Value.ToString() + " form as checked?",
                            "Form Checked", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (dialog == DialogResult.Yes)

                      //if (MessageBox.Show("Are you sure you want to set " + tempstuno + " " +
                      //          dg_list.SelectedRows[0].Cells[cnsurn.Name].Value.ToString() + " " + dg_list.SelectedRows[0].Cells[cnnamestr.Name].Value.ToString() + " form as checked?",
                      //          "Form Checked", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            string feedback = Proxy.Admissions.check_adm_form(tempstuno, tempyr);
                            MessageBox.Show(feedback, "Form Checked", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            if (!feedback.Contains("Error")) refresh_data();
                        }
                    }
                    else
                    {
                        AppOverview frmOverview = new AppOverview(tempstuno, tempyr);
                        frmOverview.ShowDialog();
                        refresh_data();
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
                OnlineApps.OnlineReportForm frmReport = new OnlineApps.OnlineReportForm("UncheckedForms", dv_list);
                frmReport.Show();
            }
        }

        private void cb_acad_level_SelectedIndexChanged(object sender, EventArgs e)
        {
            filter();            
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

        private void rbOnline_CheckedChanged(object sender, EventArgs e)
        {
            filter();
        }

        private void rbAll_CheckedChanged(object sender, EventArgs e)
        {
            filter();
        }

     

    }
}

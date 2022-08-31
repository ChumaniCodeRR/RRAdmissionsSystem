using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Utilities;

namespace Admissions.AdmissionForms.OnlineApps
{
    public partial class ViewOnLineApp : Form
    {

        bool ViewCancell;

        NS_Admissions.StrongTypesNS.DS_XADMDataSet ds_applicant = new NS_Admissions.StrongTypesNS.DS_XADMDataSet();

        public ViewOnLineApp(bool _ViewCancell)
        {
            InitializeComponent();
            ViewCancell = _ViewCancell;
        }

        private void btn_proceed_Click(object sender, EventArgs e)
        {
            proceed();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_reference_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) proceed();
        }

        private void proceed()
        {
            try
            {
                if (txt_reference.Text != "")
                {
                    string feedback = Proxy.Admissions.get_online_applicant(txt_reference.Text, out ds_applicant);
                    if (feedback == string.Empty)
                    {
                        if (ViewCancell == true)
                        {
                            string regguid = Proxy.Admissions.update_xadm_regguid(txt_reference.Text);
                            if (!regguid.Contains("Error"))
                            {
                                OnlineApplication frmOnlineApp = new OnlineApplication(txt_reference.Text, ds_applicant.tt_xadm[0].sap_lev, regguid);
                                frmOnlineApp.Show();
                            }
                            else MessageBox.Show(regguid, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        if (ViewCancell == false)
                        {
                            if (MessageBox.Show("Please confirm that the application for " + ds_applicant.tt_xadm[0].titl + " " + ds_applicant.tt_xadm[0].namestr + " (ID/Passport No: " +  ds_applicant.tt_xadm[0].id + ") must be deleted?",  "Delete Application", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                string DelOnlineApp = Proxy.Admissions.delete_online_applicant(txt_reference.Text);
                                MessageBox.Show(DelOnlineApp, "Delete Online App", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                if (!DelOnlineApp.Contains("Error")) txt_reference.Text = string.Empty;

                            }
                        }

                    }
                    else MessageBox.Show(feedback, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else MessageBox.Show("Please enter reference number to continue", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                Utils.HandleException(ExceptionSource.Admissions, ex);
            }
        }

        private void ViewOnLineApp_Load(object sender, EventArgs e)
        {
            try
            {   if (ViewCancell == true) this.Text = "View OnLine Application";
                else this.Text = "Delete Online Application";
            
            
                if (Global.Global.tempstu != string.Empty)
                {
                    string tempref = Proxy.Admissions.get_online_reference_number(Global.Global.tempstu);
                    txt_reference.Text = tempref;
                }
             }
            catch (Exception ex)
            {
                Utils.HandleException(ExceptionSource.Admissions, ex);
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            SearchAdmission frmSearch = new SearchAdmission("*", "*");
            frmSearch.ShowDialog();
            if (!string.IsNullOrEmpty(frmSearch.Refno)) txt_reference.Text = frmSearch.Refno.ToString();
            else txt_reference.Text = string.Empty;
        }

    }
}

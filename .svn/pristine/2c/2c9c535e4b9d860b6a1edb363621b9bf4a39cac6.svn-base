using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utilities;
using NS_Admissions.StrongTypesNS;

namespace Admissions.AdmissionReports
{
    public partial class AdmBalances : Form
    {
        public AdmBalances()
        {
            InitializeComponent();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AdmBalances_Load(object sender, EventArgs e)
        {
            NS_System.StrongTypesNS.ds_genDataSet ds_appstat = Proxy.System.Get_Gen("*", "AP");
            DataRow newrow = ds_appstat.TT_GEN.NewRow();
            newrow["code"] = "*";
            newrow["descrip"] = "All";
            ds_appstat.TT_GEN.Rows.InsertAt(newrow, 0);
            DataView dvData = new DataView(ds_appstat.TT_GEN);
            dvData.Sort = "code";
            bs_appstatus.DataSource = dvData;
            cb_status.SelectedIndex = 0;


            Dictionary<string, string> userCache = new Dictionary<string, string>
                {
                  {"All", "*"},
                  {"Yes", "Y"},
                  {"No", "N"},

                };
            cb_payment.DataSource = new BindingSource(userCache, null);
            cb_payment.DisplayMember = "Key";
            cb_payment.ValueMember = "Value";
            cb_payment.SelectedIndex = 0;

        }

        private void btn_proceed_Click(object sender, EventArgs e)
        {
            try
            {
                ds_admrep_fileDataSet ds_admin = Proxy.Admissions.find_admissions_balances(cb_status.SelectedValue.ToString(), cb_payment.SelectedValue.ToString());
                if (ds_admin.tt_admission_balances.Rows.Count > 0)
                {
                    StudentDetails.Admissions.AdmReports report = new StudentDetails.Admissions.AdmReports("FinAdmissions", ds_admin);
                    report.Show();
                }
                else MessageBox.Show("No Data To Display", "Error Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                Utils.HandleException(ExceptionSource.RegistrarsSystem, ex);
            }

        }
    }
}

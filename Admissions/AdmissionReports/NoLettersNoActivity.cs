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
    public partial class NoLettersNoActivity : Form
    {
        public NoLettersNoActivity()
        {
            InitializeComponent();
        }

        private void NoLettersNoActivity_Load(object sender, EventArgs e)
        {
            NS_System.StrongTypesNS.ds_genDataSet ds_appstat = Proxy.System.Get_Gen("*", "AP");
            DataView dvData = new DataView(ds_appstat.TT_GEN);
            dvData.Sort = "code";
            bs_appstatus.DataSource = dvData;
            cb_app.SelectedIndex = 0;
        }

        private void btn_proceed_Click(object sender, EventArgs e)
        {
            try
            {
                string temptitle = "";
                if (cb_app.SelectedValue.ToString() == "DE") temptitle = "STUDENTS WITH DE STATUS LONGER THAN 1 WEEK";
                else temptitle = "LIST OF ADMISSIONS WITH NO LETTERS";
                ds_admrep_fileDataSet ds_admin = Proxy.Admissions.find_no_letters_no_activity(cb_app.SelectedValue.ToString());
                if (ds_admin.tt_no_activity.Rows.Count > 0)
                {
                    StudentDetails.Admissions.AdmReports report = new StudentDetails.Admissions.AdmReports("NoActivityNoLetter", ds_admin, temptitle);
                    report.Show();
                }
                else MessageBox.Show("No Data To Display", "Error Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                Utils.HandleException(ExceptionSource.RegistrarsSystem, ex);
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

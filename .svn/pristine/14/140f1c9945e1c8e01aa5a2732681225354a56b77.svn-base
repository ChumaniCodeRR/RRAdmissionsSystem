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
    public partial class AdmStatusbyDate : Form
    {
        private string tempfac;


        public AdmStatusbyDate()
        {
            InitializeComponent();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AdmStatusbyDate_Load(object sender, EventArgs e)
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
                  {"South African", "S"},
                  {"International", "I"},

                };
            cb_nationality.DataSource = new BindingSource(userCache, null);
            cb_nationality.DisplayMember = "Key";
            cb_nationality.ValueMember = "Value";
            cb_nationality.SelectedIndex = 0;

            NS_System.StrongTypesNS.ds_genDataSet ds_faculty = Proxy.System.Get_Gen("true", "FA");
            DataView dvData2 = new DataView(ds_faculty.TT_GEN);
            dvData2.Sort = "descrip";
            bs_faculty.DataSource = dvData2;
            cb_faculty.SelectedIndex = 0;
            lblFaculty.Enabled = false;
            cb_faculty.Enabled = false;

            dtpDate.MaxDate = DateTime.Today;
            dtpDate.Value = DateTime.Today;
        }

        private void btn_proceed_Click(object sender, EventArgs e)
        {
            try
            {
                string titledate = dtpDate.Value.ToString("dd/MM/yyyy");
                if (cb_faculty.Enabled == true) tempfac = cb_faculty.SelectedValue.ToString().ToUpper();
                else tempfac = "*";
                ds_admrep_fileDataSet ds_admin = Proxy.Admissions.check_admission_app_status_by_date(cb_status.SelectedValue.ToString(), cb_nationality.SelectedValue.ToString(), dtpDate.Value.Date, tempfac);
                if (ds_admin.tt_adm_status_by_date.Rows.Count > 0)
                {
                    StudentDetails.Admissions.AdmReports report = new StudentDetails.Admissions.AdmReports("AdmStatusByDate", ds_admin, titledate);
                    report.Show();
                }
                else MessageBox.Show("No Data To Display", "Error Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                Utils.HandleException(ExceptionSource.RegistrarsSystem, ex);
            }

        }

        private void cb_status_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_status.Items.Count > 0)
            {
                if ((cb_status.SelectedValue.Equals("OF")) || (cb_status.SelectedValue.Equals("OH")) || (cb_status.SelectedValue.Equals("PD")) || (cb_status.SelectedValue.Equals("PH")))
                {
                    lblFaculty.Enabled = true;
                    cb_faculty.Enabled = true;
                }
                else
                {
                    lblFaculty.Enabled = false;
                    cb_faculty.Enabled = false;
                }

            }
        }
    }
}

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
    public partial class WeeklyMatricType : Form
    {
        public WeeklyMatricType()
        {
            InitializeComponent();
        }

        private void WeeklyMatricType_Load(object sender, EventArgs e)
        {
            NS_System.StrongTypesNS.ds_genDataSet ds_appstat = Proxy.System.Get_Gen("*", "AP");
            DataRow newrow = ds_appstat.TT_GEN.NewRow();
            newrow["code"] = "*";
            newrow["descrip"] = "All";
            ds_appstat.TT_GEN.Rows.InsertAt(newrow, 0);
            DataView dvData = new DataView(ds_appstat.TT_GEN);
            dvData.Sort = "code";
            bs_status.DataSource = dvData;
            cb_status.SelectedIndex = 0;

            NS_System.StrongTypesNS.ds_genDataSet ds_type = Proxy.System.Get_Gen("*", "MT");
            DataRow newtype = ds_type.TT_GEN.NewRow();
            newtype["code"] = "*";
            newtype["descrip"] = "All";
            ds_type.TT_GEN.Rows.InsertAt(newtype, 0);
            DataView dvData2 = new DataView(ds_type.TT_GEN);
            dvData2.Sort = "code";
            bs_type.DataSource = dvData2;
            cb_type.SelectedIndex = 0;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_proceed_Click(object sender, EventArgs e)
        {
            try
            {
                ds_admrep_fileDataSet ds_admin = Proxy.Admissions.Find_Matric_Stat_Type(cb_status.SelectedValue.ToString(), cb_type.SelectedValue.ToString());
                if (ds_admin.tt_matric_types.Rows.Count > 0)
                {
                    StudentDetails.Admissions.AdmReports report = new StudentDetails.Admissions.AdmReports("MatricReports", ds_admin);
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

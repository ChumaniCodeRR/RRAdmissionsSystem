using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace Admissions.AdmissionForms
{
    public partial class OnlineApplication : Form
    {
        string sap_lev;
      

        string url;
        string urllink;
        public OnlineApplication(string ref_no, string sap_lev,string _regguid)
        {
            InitializeComponent();
            urllink = ref_no + _regguid;
            this.sap_lev = sap_lev;
        }        

        private void Manual_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

            if (this.sap_lev == "U")
            {
                if (Proxy.Info.username.StartsWith("test")) url = "https://ross-dev.ru.ac.za/ugadmissions?sb=" + urllink;
                else url = "https://ross.ru.ac.za/ugadmissions?sb=" + urllink;
            }
            else
            {
                if (this.sap_lev  == "E" | this.sap_lev == "F" | this.sap_lev  == "H")
                {
                    if (Proxy.Info.username.StartsWith("test")) url = "https://ross-dev.ru.ac.za/pgadmissions?sb=" + urllink;
                    else url = "https://ross.ru.ac.za/pgadmissions?sb=" + urllink;
                }
            }
            new Task(seturl).Start();            
        }
        private void seturl()
        {
            
            webBrowser1.Url = new Uri(url);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Admissions.AdmissionForms.OnlineApps
{
    public partial class OnlineReportForm : Form
    {

        public string action;

        public Microsoft.Reporting.WinForms.ReportParameter[] p;
        int parameters;

        DataView ReportData;

        public OnlineReportForm(string _action, DataView _report_data)
        {
            InitializeComponent();
            action = _action;
            ReportData = _report_data;
        }

        private void OnlineReportForm_Load(object sender, EventArgs e)
        {
            try
            {
                string rootNamespace = System.Reflection.Assembly.GetEntryAssembly().EntryPoint.DeclaringType.Namespace;

                Microsoft.Reporting.WinForms.ReportDataSource rds = new
                Microsoft.Reporting.WinForms.ReportDataSource();

                Microsoft.Reporting.WinForms.ReportDataSource rds1 = new
                Microsoft.Reporting.WinForms.ReportDataSource();

                parameters = 0;



                p = new Microsoft.Reporting.WinForms.ReportParameter[parameters];
                reportViewer1.LocalReport.DataSources.Clear();

                if (action == "UncheckedForms")
                {
                    rds.Name = "ds_report";
                    rds.Value = ReportData;
                    reportViewer1.LocalReport.ReportEmbeddedResource = string.Concat(rootNamespace, ".Reports.OnlineApps.Unchecked.rdlc");
                }

                if (action == "PayConfirmation")
                {
                    rds.Name = "ds_report";
                    rds.Value = ReportData;
                    reportViewer1.LocalReport.ReportEmbeddedResource = string.Concat(rootNamespace, ".Reports.OnlineApps.PayConfirmation.rdlc");
                }
               

                if (action == "OnlineStats")
                {
                    rds.Name = "ds_report";
                    rds.Value = ReportData;
                    reportViewer1.LocalReport.ReportEmbeddedResource = string.Concat(rootNamespace, ".Reports.OnlineApps.OnlineStats.rdlc");
                }

                
                rds1.Name = "DS_PHOTODataSet_TT_PHOTO";
                rds1.Value = Global.Global.ds_logo.TT_PHOTO;

                reportViewer1.LocalReport.DataSources.Add(rds);
                reportViewer1.LocalReport.DataSources.Add(rds1);

                reportViewer1.LocalReport.EnableExternalImages = true;
                this.reportViewer1.LocalReport.SetParameters(p);

                this.reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                //Utilities.Utils.HandleException(Utilities.ExceptionSource.Admission, ex);
            }
        }
    }
}

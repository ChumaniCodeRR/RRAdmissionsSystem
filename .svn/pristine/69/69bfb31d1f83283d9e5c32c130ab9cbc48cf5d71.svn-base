using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Utilities;

namespace Admissions.UtilityScreens
{
    public partial class pse_results : Form
    {
        NS_Admissions.StrongTypesNS.ds_nbt_fileDataSet ds_transcript = new NS_Admissions.StrongTypesNS.ds_nbt_fileDataSet();


        public pse_results()
        {
            InitializeComponent();
        }

        private void pse_results_Load(object sender, EventArgs e)
        {
            try
            {
                string feedback = Proxy.Admissions.get_transcript_details(Global.Global.tempstu, out ds_transcript);
                if (feedback != "")
                {
                    MessageBox.Show(feedback, "Error Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
                else bs_transcript_info.DataSource = ds_transcript.tt_pse_results;
            }
            catch (Exception ex)
            {
                Utils.HandleException(ExceptionSource.Admissions, ex);
            }            
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                bool ask_dean;
                string feedback = Proxy.Admissions.update_transcript(Global.Global.tempstu, ds_transcript, out ask_dean);
                MessageBox.Show(feedback, "Update Transcript", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (!feedback.Contains("Error"))
                {
                    if (ask_dean == true)
                    {
                        if (MessageBox.Show("Send to Dean?", "Dean", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                         Proxy.Admissions.send_to_dean(Global.Global.tempstu);                        
                    }
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                Utils.HandleException(ExceptionSource.Admissions, ex);
            }            
        }
    }
}

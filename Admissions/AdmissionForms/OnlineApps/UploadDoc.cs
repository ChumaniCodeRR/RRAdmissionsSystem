using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Utilities;
using System.IO;
using System.Data.Common;
using System.Data.OleDb;

namespace Admissions.AdmissionForms.OnlineApps
{
    public partial class UploadDoc : Form
    {
        byte[] file;
        string varFilePath;
        MemoryStream ms = new MemoryStream();
       

        string newfilename = string.Empty;
        string newfileextension = string.Empty;

        NS_Admissions.StrongTypesNS.DS_XADMDataSet ds_applicant = new NS_Admissions.StrongTypesNS.DS_XADMDataSet();
       

        public UploadDoc()
        {
            InitializeComponent();
            
        }

        private void btn_proceed_Click(object sender, EventArgs e)
        {
            if (txt_reference.Text != "")
            {
                if (txt_path.Text.ToString() != "")
                {
                    if (cb_filetype.SelectedValue.ToString() == "TS") upload_file();
                    else
                    {
                        bool docfound = Proxy.System.CHECK_DOCUMENT("refno", txt_reference.Text.ToString(), cb_filetype.SelectedValue.ToString(), cb_apptype.SelectedValue.ToString());
                        if (docfound)
                        {
                            string docname = string.Empty;
                            NS_System.StrongTypesNS.DS_DOCDataSet ds_doc = Proxy.System.Get_Documents("refno", txt_reference.Text.ToString(), cb_filetype.SelectedValue.ToString(), cb_apptype.SelectedValue.ToString(), out docname);
                            DMU.DisplayImages.display_picture(docname, ds_doc);
                            if (MessageBox.Show("Do you want to overwrite " + docname + " with " + newfilename + "?", "Overwrite", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) upload_file();
                        }
                        else upload_file();
                    }
                }
                else MessageBox.Show("Please select document to be uploaded  to continue", "Error Document", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else MessageBox.Show("Please enter reference number to continue", "Error Reference", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


      



        private void upload_file()
        {
            byte[] file;
            using (var stream = new FileStream(txt_path.Text, FileMode.Open, FileAccess.Read))
            {
                using (var reader = new BinaryReader(stream))
                {
                    NS_System.StrongTypesNS.DS_DOCDataSet ds_Doc = new NS_System.StrongTypesNS.DS_DOCDataSet();
                    file = reader.ReadBytes((int)stream.Length);
                    DataRow dr = ds_Doc.TT_DOCUMENT.NewRow();
                    dr["DOC"] = file;
                    ds_Doc.TT_DOCUMENT.Rows.Add(dr);
                    string folder = txt_reference.Text.ToString().Substring(txt_reference.Text.ToString().Length - 2);

                    string feedback = Proxy.System.uploadFiles(newfilename, ds_Doc, cb_apptype.SelectedValue.ToString(), txt_reference.Text, folder, cb_filetype.SelectedValue.ToString());
                    MessageBox.Show(feedback, "Updload Document", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_reference.Text = string.Empty; txt_namestring.Text = string.Empty; txt_path.Text = string.Empty;
                }
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_reference_KeyDown(object sender, KeyEventArgs e)
        {
            if (txt_reference.Text != string.Empty) if (e.KeyCode == Keys.Enter) get_applicant();
        }

     
        private void UploadDoc_Load(object sender, EventArgs e)
        {
            NS_System.StrongTypesNS.ds_genDataSet ds_filetypes = Proxy.System.Get_Gen("TRUE", "S2");
            bs_filetype.DataSource = ds_filetypes.TT_GEN;
            cb_filetype.SelectedIndex = 0;

            SortedDictionary<string, string> userCache = new SortedDictionary<string, string>
            {
	            {"Undergrad", "Undergrad"},
	            {"Postgrad", "Postgrad"},               
            };
            cb_apptype.DataSource = new BindingSource(userCache, null);
            cb_apptype.DisplayMember = "Key";
            cb_apptype.ValueMember = "Value";
            cb_apptype.SelectedIndex = 0;

            if (Global.Global.tempstu != string.Empty)
            {
                string tempref = Proxy.Admissions.get_online_reference_number(Global.Global.tempstu);
                txt_reference.Text = tempref;
            }           
        }

        private void txt_reference_Leave(object sender, EventArgs e)
        {
            if (txt_reference.Text != string.Empty) get_applicant();
        }

        private void get_applicant()
        {

            string feedback = Proxy.Admissions.get_online_applicant(txt_reference.Text.ToString(), out ds_applicant);
            if (feedback == "") txt_namestring.Text = ds_applicant.tt_xadm[0].namestr;
            else
            {
                MessageBox.Show(feedback, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_reference.Text = string.Empty;
            }
        }

        private void txt_browse_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "Pdf Files (*.pdf)|*.pdf|Jpeg Files (*.jpeg)|*.jpeg|Jpg Files (*.jpg)|*.jpg";
            DialogResult result = openFileDialog.ShowDialog();
            if (!result.Equals(DialogResult.OK)) return;

            if (!File.Exists(openFileDialog.FileName))
            {
                MessageBox.Show("File doesnt not exist.", "Admissions System", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_path.Text = string.Empty;
                return;
            }
            else
            { txt_path.Text = openFileDialog.FileName; newfilename = openFileDialog.SafeFileName; }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            SearchAdmission frmSearch = new SearchAdmission("*","*");
            frmSearch.ShowDialog();
            if (!string.IsNullOrEmpty(frmSearch.Refno))
            {
                txt_reference.Text = frmSearch.Refno.ToString();
                get_applicant();
            }
        }

    }
}

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
    public partial class AppOverview : Form
    {
        public bool FormChecked;
        string tempstuno;
        int tempyr;
        string namestring;
        string attention_string;
        NS_Admissions.StrongTypesNS.ds_overviewDataSet ds_overview = new NS_Admissions.StrongTypesNS.ds_overviewDataSet();



        public AppOverview(string _tempstuno, int _tempyr)
        {
            InitializeComponent();
            tempstuno = _tempstuno;
            tempyr = _tempyr;
        }

        private void AppOverview_Load(object sender, EventArgs e)
        {
            try
            {
                string feedback = Proxy.Admissions.get_app_overview(tempstuno, out namestring, out attention_string, out ds_overview);
                if (feedback != string.Empty) { MessageBox.Show(feedback,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error); this.Close();}
                else
                {
                     bs_overview.DataSource = ds_overview.tt_overview;
                     txt_attention_notes.Text = attention_string;
                     txt_namestring.Text = namestring;



                      string apptype = "postgrad";

                      string doctype = "TS";
                      bool docfound = Proxy.System.CHECK_DOCUMENT("stuno", tempstuno, doctype, apptype);
                      if (!docfound)
                      {
                          doctype = "TS1";
                          docfound = Proxy.System.CHECK_DOCUMENT("stuno", tempstuno, doctype, apptype);
                          if (!docfound)
                          {
                              doctype = "PG";
                              docfound = Proxy.System.CHECK_DOCUMENT("stuno", tempstuno, doctype, apptype);
                          
                                if (!docfound)
                                {
                                   doctype = "PG1";
                                      docfound = Proxy.System.CHECK_DOCUMENT("stuno", tempstuno, doctype, apptype);
                                }                        
                          }

                      }
                      btn_trans.Enabled = docfound;

                     doctype = "CV";
                     docfound = Proxy.System.CHECK_DOCUMENT("stuno", tempstuno, doctype, apptype);
                     if (!docfound)
                     {
                         doctype = "CV1";
                         docfound = Proxy.System.CHECK_DOCUMENT("stuno", tempstuno, doctype, apptype);

                         if (!docfound)
                         {
                             doctype = "PF";
                             docfound = Proxy.System.CHECK_DOCUMENT("stuno", tempstuno, doctype, apptype);
                             if (!docfound)
                             {
                                 doctype = "PF1";
                                 docfound = Proxy.System.CHECK_DOCUMENT("stuno", tempstuno, doctype, apptype);
                             }
                         }
                     }
                     btn_supporting_docs.Enabled = docfound;

                     doctype = "PR1";
                     docfound = Proxy.System.CHECK_DOCUMENT("stuno", tempstuno, doctype, apptype);
                     btn_thesis.Enabled = docfound;

                }
            }
            catch (Exception ex)
            {
                Utils.HandleException(ExceptionSource.Admissions, ex);
            }           
        }

        private void btn_check_Click(object sender, EventArgs e)
        {
            try 
            {
                if (MessageBox.Show("Are you sure you want to set " + namestring + " form as checked?","Form Checked", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string feedback = Proxy.Admissions.check_adm_form(tempstuno, tempyr);
                    MessageBox.Show(feedback, "Form Checked", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                Utils.HandleException(ExceptionSource.Admissions, ex);             
            }           
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_thesis_Click(object sender, EventArgs e)
        {
            try 
            {
                string docname = string.Empty;
                string apptype = "postgrad";
                string doctype = "PR1";

                docname = string.Empty;
                NS_System.StrongTypesNS.DS_DOCDataSet ds_doc = Proxy.System.Get_Documents("stuno", tempstuno, doctype, apptype, out docname);
                if (docname != string.Empty) DMU.DisplayImages.display_picture(docname, ds_doc);
            }
            catch (Exception ex)
            {
                Utils.HandleException(ExceptionSource.Admissions, ex);
            }

        }

        private void btn_trans_Click(object sender, EventArgs e)
        {
            try
            {
                int i = 0;
                do
                {
                    i++;
                    string docname = string.Empty;
                    string doctype = "TS";
                    string apptype = "Postgrad";
                    if (i > 1) doctype = "TS" + (i - 1).ToString();

                    NS_System.StrongTypesNS.DS_DOCDataSet ds_doc = Proxy.System.Get_Documents("stuno", tempstuno, doctype, apptype, out docname);
                    if (docname != string.Empty) DMU.DisplayImages.display_picture(docname, ds_doc);
                } while (i < 8);


                i = 0;
                do
                {
                    i++;
                    string docname = string.Empty;
                    string doctype = "PG";
                    string apptype = "Postgrad";
                    if (i > 1) doctype = "PG" + (i - 1).ToString();

                    NS_System.StrongTypesNS.DS_DOCDataSet ds_doc = Proxy.System.Get_Documents("stuno", tempstuno, doctype, apptype, out docname);
                    if (docname != string.Empty) DMU.DisplayImages.display_picture(docname, ds_doc);
                } while (i < 8);

            }
            catch (Exception ex)
            {
                Utils.HandleException(ExceptionSource.Admissions, ex);             
            }           


        }

        private void btn_supporting_docs_Click(object sender, EventArgs e)
        {
            try
            {
                string doctype = string.Empty;
                string apptype = "postgrad";

                int i = 0;
                do
                {
                    i++;
                    string docname = string.Empty;
                    doctype = "CV";
                    if (i > 1) doctype = doctype + (i - 1).ToString();


                    NS_System.StrongTypesNS.DS_DOCDataSet ds_doc = Proxy.System.Get_Documents("stuno", tempstuno, doctype, apptype, out docname);
                    if (docname != string.Empty) DMU.DisplayImages.display_picture(docname, ds_doc);
                } while (i < 8);

                i = 0;
                do
                {
                    i++;
                    string docname = string.Empty;
                    doctype = "PF";
                    if (i > 1) doctype = doctype + (i - 1).ToString();


                    NS_System.StrongTypesNS.DS_DOCDataSet ds_doc = Proxy.System.Get_Documents("stuno", tempstuno, doctype, apptype, out docname);
                    if (docname != string.Empty) DMU.DisplayImages.display_picture(docname, ds_doc);
                } while (i < 8);
            }
            catch (Exception ex)
            {
                Utils.HandleException(ExceptionSource.Admissions, ex);             
            }           
        }        

    }
}

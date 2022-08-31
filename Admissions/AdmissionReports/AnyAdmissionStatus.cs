﻿using System;
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
using System.Reflection;
using System.IO;

using Excel = Microsoft.Office.Interop.Excel;



namespace Admissions.AdmissionReports
{
    public partial class AnyAdmissionStatus : Form
    {
        int year = DateTime.Today.Year;
        bool hasPhone = false;
        bool hasAddress = false;
        bool hasMail = false;
        string TEMPSTAT = "*";
        string TEMPDEGREE = "*";
	    string TEMPFACULTY = "*";
        string TEMPENTRY = "*";
	    DateTime START_DTE;
	    DateTime END_DTE;
        string TEMPCITIZEN = "*";
        string ReplyOffer = "DATE";
        bool FNDTNCRS = false;
        bool TEMPCANCEL = false;
        bool TEMPDEPOSIT = false;
        bool TEMPUCLETTER = false;
        string TEMPSORT = "";
        bool DEANREQUEST = false;
        bool DEANHASFORM = false;
        bool DEANCOMMENTS = false;

        public AnyAdmissionStatus()
        {
            InitializeComponent();
        }

        private void cb_status_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_status.Items.Count > 0)
            {
                if (cb_status.SelectedValue.Equals("PD")) { chbxDeposit.Enabled = false; chbxDeposit.Checked = false; }

                if ((cb_status.SelectedValue.Equals("OF")) || (cb_status.SelectedValue.Equals("PD"))) chbxFoundation.Enabled = true;

                if ((cb_status.SelectedValue.Equals("OF")) || (cb_status.SelectedValue.Equals("OH")) || (cb_status.SelectedValue.Equals("PD")) || (cb_status.SelectedValue.Equals("PH")))
                {
                    lblDegree.Enabled = true;
                    lblStartDte.Enabled = true;
                    lblEndDte.Enabled = true;
                    lblEntry.Enabled = true;
                    lblFaculty.Enabled = true;

                    cb_Degree.Enabled = true;
                    dtpStart.Enabled = true;
                    dtpEnd.Enabled = true;
                    cb_faculty.Enabled = true;
                    cb_Entry.Enabled = true;

                    if ((cb_status.SelectedValue.Equals("OF")) || (cb_status.SelectedValue.Equals("OH"))) dtpStart.Value = new DateTime(year, 01, 01);
                    else dtpStart.Value = new DateTime(year-1, 06, 01);
                }
                else
                {
                    lblDegree.Enabled = false;
                    lblStartDte.Enabled = false;
                    lblEndDte.Enabled = false;
                    lblEntry.Enabled = false;
                    lblFaculty.Enabled = false;

                    cb_Degree.Enabled = false;
                    dtpStart.Enabled = false;
                    dtpEnd.Enabled = false;
                    cb_faculty.Enabled = false;
                    cb_Entry.Enabled = false;
                    chbxFoundation.Enabled = false;
                    chbxFoundation.Checked = false;
                    chbxDeposit.Enabled = true;
                }
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AnyAdmissionStatus_Load(object sender, EventArgs e)
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

            NS_System.StrongTypesNS.ds_deg_facultyDataSet ds_deg_faculty = Proxy.System.Get_Degrees_By_Faculty(TEMPFACULTY, "U");
            DataRow newrow2 = ds_deg_faculty.tt_deg_by_faculty.NewRow();
            newrow2["degr"] = "*";
            newrow2["degree"] = "All";
            newrow2["faculty"] = "*";
            ds_deg_faculty.tt_deg_by_faculty.Rows.InsertAt(newrow2, 0);
            DataView dvData2 = new DataView(ds_deg_faculty.tt_deg_by_faculty);
            dvData2.Sort = "degr";
            bs_degree.DataSource = dvData2;
            cb_Degree.SelectedIndex = 0;
            lblDegree.Enabled = false;
            cb_Degree.Enabled = false;

            NS_System.StrongTypesNS.ds_genDataSet ds_faculty = Proxy.System.Get_Gen("true", "FA");
            DataRow newrow3 = ds_faculty.TT_GEN.NewRow();
            newrow3["code"] = "*";
            newrow3["descrip"] = "All";
            ds_faculty.TT_GEN.Rows.InsertAt(newrow3, 0);
            DataView dvData3 = new DataView(ds_faculty.TT_GEN);
            dvData3.Sort = "descrip";
            bs_faculty.DataSource = dvData3;
            cb_faculty.SelectedIndex = 0;
            lblFaculty.Enabled = false;
            cb_faculty.Enabled = false;

            Dictionary<string, string> userCache = new Dictionary<string, string>
                {
                  {"All", "*"},
                  {"Entering New Degree (Same U/P Level As Last)", "E"},
                  {"First TIme Entering (This U/P Level)", "F"},
                  {"Non-Entering (Returning Same Degree)", "N"},
                  {"Transfer", "T"},

                };
            cb_Entry.DataSource = new BindingSource(userCache, null);
            cb_Entry.DisplayMember = "Key";
            cb_Entry.ValueMember = "Value";
            cb_Entry.SelectedIndex = 0;

            Dictionary<string, string> userCache2 = new Dictionary<string, string>
                {
                  {"Both", "*"},
                  {"International", "I"},
                  {"South African", "S"},
                };
            cb_nationality.DataSource = new BindingSource(userCache2, null);
            cb_nationality.DisplayMember = "Key";
            cb_nationality.ValueMember = "Value";
            cb_nationality.SelectedIndex = 0;

            dtpStart.MaxDate = DateTime.Today;
            dtpStart.Value = DateTime.Today;
            dtpEnd.MaxDate = DateTime.Today;
            dtpEnd.Value = DateTime.Today;

            lblDegree.Enabled = false;
            lblStartDte.Enabled = false;
            lblEndDte.Enabled = false;
            lblEntry.Enabled = false;
            lblFaculty.Enabled = false;

            cb_Degree.Enabled = false;
            dtpStart.Enabled = false;
            dtpEnd.Enabled = false;
            cb_faculty.Enabled = false;
            cb_Entry.Enabled = false;
            chbxFoundation.Enabled = false;

            TEMPSORT = "namestr";
        }

        private void btn_proceed_Click(object sender, EventArgs e)
        {
            PrintExport("Proceed");
        }


        private void PrintExport(string Operation)
        {
                hasPhone = chbxPhone.Checked;
                hasAddress = chbxHomeAdress.Checked;
                hasMail = chbxEmail.Checked;
                TEMPSTAT = cb_status.SelectedValue.ToString();
	            TEMPCITIZEN = cb_nationality.SelectedValue.ToString();
                TEMPCANCEL = chbxCancel.Checked;
                TEMPDEPOSIT = chbxDeposit.Checked;
                TEMPUCLETTER = chbxUC.Checked;
                DEANREQUEST = chbxDeanRequest.Checked;
                DEANHASFORM = chbxDeanHasForm.Checked;
                if (chbxDeanComment.Enabled == true) { DEANCOMMENTS = chbxDeanComment.Checked; }


                if (cb_status.Items.Count > 0)
                {
                    if (((cb_status.SelectedValue.Equals("OF")) || (cb_status.SelectedValue.Equals("OH")) || (cb_status.SelectedValue.Equals("PD")) || (cb_status.SelectedValue.Equals("PH"))))
                    {
                        TEMPDEGREE = cb_Degree.SelectedValue.ToString();
                        TEMPFACULTY = cb_faculty.SelectedValue.ToString();
                        TEMPENTRY = cb_Entry.SelectedValue.ToString();
                        START_DTE = dtpStart.Value;
                        END_DTE = dtpEnd.Value;

                        if ((cb_status.SelectedValue.Equals("OF")) || (cb_status.SelectedValue.Equals("OH"))) ReplyOffer = "OFFER DATE";
                        if ((cb_status.SelectedValue.Equals("PD")) || (cb_status.SelectedValue.Equals("PH"))) ReplyOffer = "REPLY DATE";

                        if ((cb_status.SelectedValue.Equals("OF")) || (cb_status.SelectedValue.Equals("PD"))) FNDTNCRS = chbxFoundation.Checked;

                        if ((cb_status.SelectedValue.Equals("OF")) || (cb_status.SelectedValue.Equals("PD"))) chbxFoundation.Enabled = true;
                    }
                }

                if (TEMPFACULTY.Equals("All")) TEMPFACULTY = "*";


                if (rbtnName.Checked == true) TEMPSORT = "namestr";
                else if (rbtnDegree.Checked == true) TEMPSORT = "DEGR";
                else if (rbtnFaculty.Checked == true) TEMPSORT = "FACULTY";
                else if (rbtnApp.Checked == true) TEMPSORT = "APP_STAT";
                else if (rbtnEntry.Checked == true) TEMPSORT = "ENTRY_STAT";
                else if (rbtnCitizen.Checked == true) TEMPSORT = "SA";

                if (Operation.Equals("Proceed"))
                {
                    ds_admrep_fileDataSet ds_admin = Proxy.Admissions.any_admission_status(TEMPSTAT, TEMPDEGREE, TEMPFACULTY, TEMPENTRY, START_DTE, END_DTE, TEMPCITIZEN, hasPhone, hasAddress, hasMail, FNDTNCRS, TEMPUCLETTER, TEMPDEPOSIT, TEMPCANCEL, DEANREQUEST, DEANHASFORM, DEANCOMMENTS);
                    if (ds_admin.tt_any_admissions_status.Rows.Count > 0)
                    {
                        StudentDetails.Admissions.AdmReports report = new StudentDetails.Admissions.AdmReports("AnyAdmStatus", ds_admin, ReplyOffer, hasPhone, hasAddress, FNDTNCRS, TEMPUCLETTER, TEMPCANCEL, TEMPSORT, hasMail, DEANCOMMENTS);
                        report.Show();
                    }
                    else MessageBox.Show("No Data To Display", "Error Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


                if (Operation.Equals("Export"))
                {
                    ds_admrep_fileDataSet ds_admin = Proxy.Admissions.any_admission_status(TEMPSTAT, TEMPDEGREE, TEMPFACULTY, TEMPENTRY, START_DTE, END_DTE, TEMPCITIZEN, hasPhone, hasAddress, hasMail, FNDTNCRS, TEMPUCLETTER, TEMPDEPOSIT, TEMPCANCEL, DEANREQUEST, DEANHASFORM, DEANCOMMENTS);
                    if (ds_admin.tt_any_admissions_status.Rows.Count < 1) MessageBox.Show("Your query returned no data", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                    {
                        try
                        {

                            string filename = System.IO.Path.GetTempPath() + "AnyAdmissionsStatus.xls";

                            FileInfo fi1 = new FileInfo(filename);
                            if (File.Exists(filename) && Utils.IsFileLocked(fi1))
                            {
                                MessageBox.Show("Error - The file " + filename + " is already in use. Please close it or save the open file with a different name before running this extract", "Error Reading File", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                                return;
                            }

                            RhodesControl.ThinkManager.StartThink("Generating Excel File - Please Wait");

                            try
                            {

                                Excel.Application oXL;
                                Excel.Workbook oWB;
                                Excel.Worksheet oSheet;
                                Excel.Range oRange;

                                // Start Excel and get Application object.
                                oXL = new Excel.Application();

                                // Set some properties
                                oXL.DisplayAlerts = false;

                                // Get a new workbook.
                                oWB = oXL.Workbooks.Add(Missing.Value);

                                // Get the active sheet
                                oSheet = (Excel.Worksheet)oWB.ActiveSheet;
                                oSheet.Name = "ADMISSION STATUS LIST";

                                // Process the DataTable

                                DataView dv_data = new DataView(ds_admin.tt_any_admissions_status);
                                dv_data.Sort = TEMPSORT;

                                DataTable dtList = dv_data.ToTable();
                                DataTable dtDetails = ds_admin.tt_any_admissions_status;

                                int i = 6;

                                oSheet.Cells[1, 1] = "Student Number";
                                oSheet.Cells[1, 2] = "Name";
                                oSheet.Cells[1, 3] = "Title";
                                oSheet.Cells[1, 4] = "UNWT-PTS P"; 
                                oSheet.Cells[1, 5] = "UNWT-PTS F";
                                if (FNDTNCRS == true)
                                {
                                    oSheet.Cells[1, i] = "WT-PTS P";
                                    i++;
                                    oSheet.Cells[1, i] = "WT-PTS F";
                                    i++;
                                }

                                oSheet.Cells[1, i] = "Degree";
                                i++;
                                oSheet.Cells[1, i] = "Faculty";
                                i++;

                                oSheet.Columns[i].NumberFormat = "@";
                                if ((cb_status.SelectedValue.Equals("OF")) || (cb_status.SelectedValue.Equals("OH"))) oSheet.Cells[1, i] = "Offer Date";
                                else if ((cb_status.SelectedValue.Equals("PD")) || (cb_status.SelectedValue.Equals("PH"))) oSheet.Cells[1, i] = "Reply Date";
                                else oSheet.Cells[1, i] = "Date";
                                i++;

                                if (hasPhone == true)
                                {
                                    oSheet.Columns[i].NumberFormat = "@";
                                    oSheet.Cells[1, i] = "Cell Phone";
                                    i++;
                                    oSheet.Columns[i].NumberFormat = "@";
                                    oSheet.Cells[1, i] = "Home Phone";
                                    i++;
                                }

                                oSheet.Cells[1, i] = "App Status"; 
                                i++;
                                oSheet.Cells[1, i] = "Entry Status";
                                i++;
                                oSheet.Cells[1, i] = "Race"; 
                                i++;
                                oSheet.Cells[1, i] = "Citizen"; 
                                i++;
                                oSheet.Cells[1, i] = "Financial Apply";
                                i++;
                                oSheet.Cells[1, i] = "Financial Award"; 
                                i++;
                                oSheet.Columns[i].NumberFormat = "@";
                                oSheet.Cells[1, i] = "ID Number"; 
                                i++;

                                if (hasMail == true)
                                {
                                    oSheet.Cells[1, i] = "E-Mail";
                                    i++;
                                }
                                
                                oSheet.Cells[1, i] = "Province";
                                i++;

                                if (hasAddress == true)
                                {
                                    oSheet.Cells[1, i] = "Home Address";
                                    i++;
                                }

                                if (FNDTNCRS == true)
                                {
                                oSheet.Cells[1, i] = "Student Comment";
                                i++;
                                }

                                if (TEMPCANCEL == true)
                                {
                                    oSheet.Cells[1, i] = "Cancel Reason";
                                    i++;
                                }

                                if (TEMPUCLETTER == true)
                                {
                                    oSheet.Columns[i].NumberFormat = "@";
                                    oSheet.Cells[1, i] = "University Code";
                                    i++;
                                    oSheet.Cells[1, i] = "University name";
                                    i++;
                                    oSheet.Columns[i].NumberFormat = "@";
                                    oSheet.Cells[1, i] = "Previous Student Number";
                                    i++;
                                }

                                if (DEANCOMMENTS == true)
                                {
                                    oSheet.Cells[1, i] = "Dean Comments";
                                    i++;
                                }


                                int rowCount = 1;
                                int TotalStuCount = 0;

                                foreach (DataRow dr in dtList.Rows)
                                {

                                    rowCount += 1;
                                    TotalStuCount += 1;

                                    int a = 6;
                                    oSheet.Cells[rowCount, 1] = dr[0].ToString();
                                    oSheet.Cells[rowCount, 2] = dr[1].ToString();
                                    oSheet.Cells[rowCount, 3] = dr[2].ToString();
                                    oSheet.Cells[rowCount, 4] = dr[3].ToString();
                                    oSheet.Cells[rowCount, 5] = dr[4].ToString();

                                    if (FNDTNCRS == true)
                                    {
                                        oSheet.Cells[rowCount, a] = dr[5].ToString();
                                        a++;
                                        oSheet.Cells[rowCount, a] = dr[6].ToString();
                                        a++;
                                    }

                                    oSheet.Cells[rowCount, a] = dr[7].ToString();
                                    a++;
                                    oSheet.Cells[rowCount, a] = dr[8].ToString();
                                    a++;
                                    oSheet.Cells[rowCount, a] = dr[9].ToString();
                                    a++;

                                    if (hasPhone == true)
                                    {
                                        oSheet.Cells[rowCount, a] = dr[10].ToString();
                                        a++;
                                        oSheet.Cells[rowCount, a] = dr[11].ToString();
                                        a++;
                                    }

                                    oSheet.Cells[rowCount, a] = dr[12].ToString();
                                    a++;
                                    oSheet.Cells[rowCount, a] = dr[13].ToString();
                                    a++;
                                    oSheet.Cells[rowCount, a] = dr[14].ToString();
                                    a++;
                                    oSheet.Cells[rowCount, a] = dr[15].ToString();
                                    a++;
                                    oSheet.Cells[rowCount, a] = dr[16].ToString();
                                    a++;
                                    oSheet.Cells[rowCount, a] = dr[17].ToString();
                                    a++;
                                    oSheet.Cells[rowCount, a] = dr[18].ToString();
                                    a++;


                                    if (hasMail == true)
                                    {
                                        oSheet.Cells[rowCount, a] = dr[19].ToString();
                                        a++;
                                    }

                                    oSheet.Cells[rowCount, a] = dr[20].ToString();
                                    a++;

                                    if (hasAddress == true)
                                    {
                                        oSheet.Cells[rowCount, a] = dr[21].ToString();
                                        a++;
                                    }

                                    if (FNDTNCRS == true)
                                    {
                                        oSheet.Cells[rowCount, a] = dr[22].ToString();
                                        a++;
                                    }

                                    if (TEMPCANCEL == true)
                                    {
                                        oSheet.Cells[rowCount, a] = dr[23].ToString();
                                        a++;
                                    }

                                    if (TEMPUCLETTER == true)
                                    {
                                        oSheet.Cells[rowCount, a] = dr[24].ToString();
                                        a++;
                                        oSheet.Cells[rowCount, a] = dr[25].ToString();
                                        a++;
                                        oSheet.Cells[rowCount, a] = dr[26].ToString();
                                        a++;
                                    }

                                    if (DEANCOMMENTS == true)
                                    {
                                        oSheet.Cells[rowCount, a] = dr[27].ToString();
                                        a++;
                                    }

                                }
                                if (TotalStuCount != 0) oSheet.Cells[rowCount + 2, 1] = "Total Students: " + TotalStuCount.ToString();
                                else oSheet.Cells[2, 1] = "No students found";

                                // Resize the columns
                                oRange = oSheet.Range[oSheet.Cells[1, 1], oSheet.Cells[rowCount + 2, 27]];
                                oRange.EntireColumn.AutoFit();

                                // Save the sheet and close
                                oSheet = null;
                                oRange = null;

                                oWB.SaveAs(filename, Excel.XlFileFormat.xlWorkbookNormal,
                                    Missing.Value, Missing.Value, Missing.Value, Missing.Value,
                                    Excel.XlSaveAsAccessMode.xlExclusive,
                                    Missing.Value, Missing.Value, Missing.Value,
                                    Missing.Value, Missing.Value);

                                oWB = null;
                                oXL.Visible = true;

                                // Clean up
                                // NOTE: When in release mode, this does the trick
                                GC.WaitForPendingFinalizers();
                                GC.Collect();
                                GC.WaitForPendingFinalizers();
                                GC.Collect();
                            }
                            catch (Exception Ex)
                            {
                                MessageBox.Show(Ex.Message, "Error with Export", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            }
                        }
                        finally
                        {
                            RhodesControl.ThinkManager.EndThink();
                            this.BringToFront();
                        }
                    }
                }

            }


        private void cb_faculty_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_faculty.Items.Count > 0)
            {
                NS_System.StrongTypesNS.ds_deg_facultyDataSet ds_deg_faculty;

                if (cb_faculty.SelectedValue.ToString().Equals("All")) ds_deg_faculty = Proxy.System.Get_Degrees_By_Faculty("*", "U");
                else ds_deg_faculty = Proxy.System.Get_Degrees_By_Faculty(cb_faculty.SelectedValue.ToString(), "U");

                DataRow newrow = ds_deg_faculty.tt_deg_by_faculty.NewRow();
                newrow["degr"] = "*";
                newrow["degree"] = "All";
                newrow["faculty"] = "*";
                ds_deg_faculty.tt_deg_by_faculty.Rows.InsertAt(newrow, 0);
                DataView dvData = new DataView(ds_deg_faculty.tt_deg_by_faculty);
                dvData.Sort = "degr";
                bs_degree.DataSource = dvData;
                cb_Degree.SelectedIndex = 0;
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            PrintExport("Export");
        }

        private void chbxDeanRequest_CheckedChanged(object sender, EventArgs e)
        {
            if (chbxDeanRequest.Checked == true)
            {
                chbxDeanComment.Enabled = true;
            }
            else
            {
                if (chbxDeanHasForm.Checked == true)
                {
                    chbxDeanComment.Enabled = true;
                }
                else
                {
                    chbxDeanComment.Enabled = false;
                    chbxDeanComment.Checked = false;
                }
            }
        }

        private void chbxDeanHasForm_CheckedChanged(object sender, EventArgs e)
        {
            if (chbxDeanHasForm.Checked == true)
            {
                chbxDeanComment.Enabled = true;
            }
            else
            {
                if (chbxDeanRequest.Checked == true)
                {
                    chbxDeanComment.Enabled = true;
                }
                else
                {
                    chbxDeanComment.Enabled = false;
                    chbxDeanComment.Checked = false;
                }
            }
        }

    }
}

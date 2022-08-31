using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using RhodesControl;
using Utilities;
using RhodesWizard;
using Admissions.Utilities;
using Admissions.EventArguments;
using NS_Admissions.StrongTypesNS;

namespace Admissions
{
    public partial class MainForm : Form
    {
        #region Local Variables

        BackgroundWorker bw;
        SplashScreen splash;

        Wizard wizard = null;

        #endregion

        #region Constructor

        public MainForm()
        {
            InitializeComponent();

            bw = new BackgroundWorker();
            bw.DoWork += new DoWorkEventHandler(bw_DoWork);
            bw.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bw_RunWorkerCompleted);
        }

        #endregion

        #region BackgroundWorker

        void bw_DoWork(object sender, DoWorkEventArgs e)
        {
            Global.Global.ds_Stu = Proxy.System.Get_Reg_Stu_By_Res(0);
            //Global.Global.ds_control = Proxy.StudentDepartment.Get_Faculties_And_Departments();
            Global.Global.ds_control = Proxy.Honours.Get_Faculties_And_Departments();
        }

        void bw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (splash != null)
            {
                splash.Dispose();
            }

            if (e.Error != null)
            {
                MessageBox.Show(e.Error.Message, "Admission System", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        #endregion

        #region Form Load Handler

        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                bool validlogin = AppServer.AppServer.initial_Login(Proxy.Info.username, false, "StudentDetails", false, "StudentDetails", false);
                if (validlogin == true)
                {
                    if (Proxy.Info.username.StartsWith("test")) statusStrip1.BackColor = menuStrip1.BackColor = Color.LightGreen;

                    Global.Global.tempyr = DateTime.Today.Year;

                    Global.Global.ds_logo = new NS_System.StrongTypesNS.DS_PHOTODataSet();

                    Bitmap image = new Bitmap(Admissions.Properties.Resources.RULogo);
                    DataRow row = Global.Global.ds_logo.TT_PHOTO.NewRow();
                    row["image"] = (byte[])TypeDescriptor.GetConverter(image).ConvertTo(image, typeof(byte[]));

                    Global.Global.ds_logo.TT_PHOTO.Rows.Add(row);

                    SetLoggedInUsername();
                    pichousecrest.Image = Admissions.Properties.Resources.RUpurple;
                    WindowState = FormWindowState.Normal;
                    Global.Global.admissions_view = true;

                    AdmissionForms.XADMList frmXADM = new AdmissionForms.XADMList();
                    frmXADM.MdiParent = this;
                    frmXADM.Dock = DockStyle.Fill;
                    frmXADM.SelectOnlineApplication += new EventHandler(UG_ADM);
                    frmXADM.Show();

                    if (!bw.IsBusy)
                    {
                        splash = new SplashScreen("Loading admissions cache data. Please wait...");
                        bw.RunWorkerAsync();
                        splash.ShowDialog();
                    }
                }
            }
            catch (Exception ex)
            {
                Utils.HandleException(ExceptionSource.Admissions, ex);
            }
        }

        #endregion

        #region File Menu Items

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #endregion

        #region Local Methods

        void SetLoggedInUsername()
        {
            string name = Proxy.Info.fullname.Trim();
            string username = Proxy.Info.username.Trim();
            string time = string.Format("{0:dddd dd-MMM-yyyy hh:mm tt}", DateTime.Now);
            tsslUser.Text = string.Format("{0} {1} ({2}) Since {3}", tsslUser.Text, name, username, time);
        }

        void LoadReportLogo()
        {
            Global.Global.ds_logo = new NS_System.StrongTypesNS.DS_PHOTODataSet();

            Bitmap image = new Bitmap(Admissions.Properties.Resources.RULogo);
            DataRow row = Global.Global.ds_logo.TT_PHOTO.NewRow();
            row["image"] = (byte[])TypeDescriptor.GetConverter(image).ConvertTo(image, typeof(byte[]));

            Global.Global.ds_logo.TT_PHOTO.Rows.Add(row);
        }

        void LoadStudentDetails()
        {
            try
            {
                picStudent.Image = null;
                NS_System.StrongTypesNS.DS_PHOTODataSet ds_image = new NS_System.StrongTypesNS.DS_PHOTODataSet();
                NS_StuInfo.StrongTypesNS.DS_STUINFODataSet ds_stuinfo = Proxy.StudentInfo.Get_Students_Name(txtstuno.Text);

                if (ds_stuinfo.TT_STUNAME.Rows.Count >= 1)
                {
                    Global.Global.tempstu = txtstuno.Text;
                    string stu_photo = @"/db/1/live/programs/photos/" + txtstuno.Text.ToUpper() + ".jpg";
                    ds_image = Proxy.System.Get_Photos(stu_photo);

                    int c = ds_image.TT_PHOTO.Rows.Count;

                    if (c >= 1)
                    {
                        try
                        {
                            Byte[] byteBLOBData = new Byte[0];
                            byteBLOBData = (Byte[])(ds_image.TT_PHOTO.Rows[c - 1]["image"]);
                            MemoryStream stmBLOBData = new MemoryStream(byteBLOBData);
                            picStudent.Image = Image.FromStream(stmBLOBData);
                        }
                        catch
                        { picStudent.Image = null; }
                    }

                    else picStudent.Image = Admissions.Properties.Resources.no_photo;

                    if (!string.IsNullOrEmpty(ds_stuinfo.TT_STUNAME[0].PREFER_NAME)) txt_prefer_name.Text = string.Concat("Preferred Name: ", ds_stuinfo.TT_STUNAME[0].PREFER_NAME);
                    else txt_prefer_name.Text = "";
                    txtname.Text = ds_stuinfo.TT_STUNAME[0].name;
                    txtsurn.Text = ds_stuinfo.TT_STUNAME[0].SURNAME;
                    txtdegr.Text = ds_stuinfo.TT_STUNAME[0].TEMPDEGREE;
                    txtstatus.Text = ds_stuinfo.TT_STUNAME[0].TEMPSTATUS;

                    pnlStudentDetails.Visible = true;

                    //Load_Form();
                }
                else
                {
                    MessageBox.Show("Student Number Does Not Exist");
                    picStudent.Image = null;
                    pnlStudentDetails.Visible = false;
                }
            }
            catch (Exception ex)
            {
                Utils.HandleException(ExceptionSource.ResSystem, ex);
            }
        }

        void ClearStudentDetails()
        {
            Global.Global.tempstu = string.Empty;
            picStudent.Image = null;
            pnlStudentDetails.Visible = false;
        }

        void LoadWizard(string name, List<WizardView> views)
        {
            wizard = new Wizard(name, views, false);
            wizard.MdiParent = this;
            wizard.Dock = DockStyle.Fill;
            wizard.DisposeWizardEventHandler += new EventHandler(wizard_DisposeWizardEventHandler);
            wizard.Show();
            wizard.BringToFront();
        }
        
        void wizard_DisposeWizardEventHandler(object sender, EventArgs e)
        {
            if (wizard != null)
            {
                wizard.Close();
                wizard = null;
            }
            txtstuno.Enabled = btnsearch.Enabled = true;
        }
        
        #endregion

        #region TextBox Events

        void txtstuno_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter) && !string.IsNullOrEmpty(txtstuno.Text.Trim()))
            {
                LoadStudentDetails();
            }
            else if (e.KeyCode.Equals(Keys.Enter) && string.IsNullOrEmpty(txtstuno.Text.Trim()))
            {
                ClearStudentDetails();
            }
        }
        #endregion

        #region Button Events

        private void btnsearch_Click(object sender, EventArgs e)
        {
            Search_Grid_Students.Search_Grid_Students frmStuSearch = new Search_Grid_Students.Search_Grid_Students(true);
            frmStuSearch.ShowDialog();
            txtstuno.Text = frmStuSearch.Stuno;
            if (!string.IsNullOrEmpty(txtstuno.Text.Trim())) LoadStudentDetails();
        }

        #endregion

        #region Admission Forms

        private void undergraduateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Global.Global.adm_yr = 0;
            Global.Global.oldstuno = string.Empty;
            Global.Global.ref_no = string.Empty; 
            UG_ADM(sender, e);
        }

        private void UG_ADM(object sender, EventArgs e)
        {
            if (wizard == null)
            {
                if (Global.Global.app_stat == "U")
                {
                    AdmissionWizardViewBuilder.AdmissionStudentLoaded += new EventHandler<AdmissionStudentEventArgs>(WizardViewBuilder_AdmissionStudentLoaded);
                    LoadWizard(WizardName.UGCaptureAdminForm, AdmissionWizardViewBuilder.GetUndergraduateCaptureFormWizard(Global.Global.adm_yr, Global.Global.oldstuno, Global.Global.ref_no));
                }
                else if (Global.Global.app_stat == "E")
                {
                    AdmissionWizardViewBuilder.AdmissionStudentLoaded += new EventHandler<AdmissionStudentEventArgs>(WizardViewBuilder_AdmissionStudentLoaded);
                    LoadWizard(WizardName.HonsCaptureAdminForm, AdmissionWizardViewBuilder.GetHonsLLBBBS4CaptureFormWizard(Global.Global.adm_yr, Global.Global.oldstuno, Global.Global.ref_no));
                }
            }
            else
            {
                wizard.Show();
                wizard.BringToFront();

                string msg = "There is currently a wizard running. Please finish or cancel the current wizard before you can start another one.";
                MessageBox.Show(msg, AdmissionConstants.MessageBoxCaption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void honsLLBBBS4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (wizard == null)
            {
                AdmissionWizardViewBuilder.AdmissionStudentLoaded += new EventHandler<AdmissionStudentEventArgs>(WizardViewBuilder_AdmissionStudentLoaded);
                LoadWizard(WizardName.HonsCaptureAdminForm, AdmissionWizardViewBuilder.GetHonsLLBBBS4CaptureFormWizard(Global.Global.adm_yr, Global.Global.oldstuno, Global.Global.ref_no));
            }
            else
            {
                wizard.Show();
                wizard.BringToFront();

                string msg = "There is currently a wizard running. Please finish or cancel the current wizard before you can start another one.";
                MessageBox.Show(msg, AdmissionConstants.MessageBoxCaption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void postgraduateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (wizard == null)
            {
                AdmissionWizardViewBuilder.AdmissionStudentLoaded += new EventHandler<AdmissionStudentEventArgs>(WizardViewBuilder_AdmissionStudentLoaded);
                LoadWizard(WizardName.PGCaptureAdminForm, AdmissionWizardViewBuilder.GetPostgraduateCaptureFormWizard(Global.Global.adm_yr, Global.Global.oldstuno, Global.Global.ref_no));
            }
            else
            {
                wizard.Show();
                wizard.BringToFront();

                string msg = "There is currently a wizard running. Please finish or cancel the current wizard before you can start another one.";
                MessageBox.Show(msg, AdmissionConstants.MessageBoxCaption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void inTernationalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (wizard == null)
            {
                AdmissionWizardViewBuilder.AdmissionStudentLoaded += new EventHandler<AdmissionStudentEventArgs>(WizardViewBuilder_AdmissionStudentLoaded);
                LoadWizard(WizardName.IntCaptureAdminForm, AdmissionWizardViewBuilder.GetInternationalCaptureFormWizard());
            }
            else
            {
                wizard.Show();
                wizard.BringToFront();

                string msg = "There is currently a wizard running. Please finish or cancel the current wizard before you can start another one.";
                MessageBox.Show(msg, AdmissionConstants.MessageBoxCaption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void aCEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (wizard == null)
            {
                AdmissionWizardViewBuilder.AdmissionStudentLoaded += new EventHandler<AdmissionStudentEventArgs>(WizardViewBuilder_AdmissionStudentLoaded);
                LoadWizard(WizardName.ACECaptureAdminForm, AdmissionWizardViewBuilder.GetAdvCertInEducCaptureFormWizard());
            }
            else
            {
                wizard.Show();
                wizard.BringToFront();

                string msg = "There is currently a wizard running. Please finish or cancel the current wizard before you can start another one.";
                MessageBox.Show(msg, AdmissionConstants.MessageBoxCaption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        void WizardViewBuilder_AdmissionStudentLoaded(object sender, AdmissionStudentEventArgs e)
        {
            txtstuno.Text = e.Stuno;
            Invoke(new EventHandler<KeyEventArgs>(txtstuno_KeyDown), sender, new KeyEventArgs(Keys.Enter));
            txtstuno.Enabled = btnsearch.Enabled = false;
        }

        #endregion

        #region Student Updates

        private void personalDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (wizard == null)
            {
                if (!ValidAdmissionsStudent()) return;
                LoadWizard(WizardName.AdmissionsPersonalDetails, AdmissionWizardViewBuilder.GetAdmissionsPersonalDetails());
            }
            else
            {
                wizard.Show();
                wizard.BringToFront();

                string msg = "There is currently a wizard running. Please finish or cancel the current wizard before you can start another one.";
                MessageBox.Show(msg, AdmissionConstants.MessageBoxCaption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void addressDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (wizard == null)
            {
                if (!ValidAdmissionsStudent()) return;
                LoadWizard(WizardName.AdmissionsAddressDetails, AdmissionWizardViewBuilder.GetAdmissionsAddressDetails());
            }
            else
            {
                wizard.Show();
                wizard.BringToFront();

                string msg = "There is currently a wizard running. Please finish or cancel the current wizard before you can start another one.";
                MessageBox.Show(msg, AdmissionConstants.MessageBoxCaption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void matricResultsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (wizard == null)
            {
                if (!ValidAdmissionsStudent()) return;
                LoadWizard(WizardName.AdmissionsMatricSubjects, AdmissionWizardViewBuilder.GetAdmissionMatricSubjects());
            }
            else
            {
                wizard.Show();
                wizard.BringToFront();

                string msg = "There is currently a wizard running. Please finish or cancel the current wizard before you can start another one.";
                MessageBox.Show(msg, AdmissionConstants.MessageBoxCaption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void studentFamilyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (wizard == null)
            {
                if (!ValidAdmissionsStudent()) return;
                LoadWizard(WizardName.AdmissionsStudentFamily, AdmissionWizardViewBuilder.GetAdmissionsStudentFamily());
            }
            else
            {
                wizard.Show();
                wizard.BringToFront();

                string msg = "There is currently a wizard running. Please finish or cancel the current wizard before you can start another one.";
                MessageBox.Show(msg, AdmissionConstants.MessageBoxCaption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void schoolDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (wizard == null)
            {
                if (!ValidAdmissionsStudent()) return;
                LoadWizard(WizardName.AdmissionsSchoolDetails, AdmissionWizardViewBuilder.GetAdmissionsSchoolDetails());
            }
            else
            {
                wizard.Show();
                wizard.BringToFront();

                string msg = "There is currently a wizard running. Please finish or cancel the current wizard before you can start another one.";
                MessageBox.Show(msg, AdmissionConstants.MessageBoxCaption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void accountFeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (wizard == null)
            {
                if (!ValidAdmissionsStudent()) return;
                LoadWizard(WizardName.AdmissionsAccountFees, AdmissionWizardViewBuilder.GetAdmissionsAccountFeesDetails());
            }
            else
            {
                wizard.Show();
                wizard.BringToFront();

                string msg = "There is currently a wizard running. Please finish or cancel the current wizard before you can start another one.";
                MessageBox.Show(msg, AdmissionConstants.MessageBoxCaption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        #endregion

        #region Other Admission Updates

        private void admissionNotesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (wizard == null)
            {
                if (!ValidAdmissionsStudent()) return;
                LoadWizard(WizardName.AdmissionsNotesUpdate, AdmissionWizardViewBuilder.GetAdmissionNotesUpdate());
            }
            else
            {
                wizard.Show();
                wizard.BringToFront();

                string msg = "There is currently a wizard running. Please finish or cancel the current wizard before you can start another one.";
                MessageBox.Show(msg, AdmissionConstants.MessageBoxCaption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void financialAidToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (wizard == null)
            {
                if (!ValidAdmissionsStudent()) return;
                LoadWizard(WizardName.AdmissionsFinancialAidDetails, AdmissionWizardViewBuilder.GetAdmissionFinancialAidDetails());
            }
            else
            {
                wizard.Show();
                wizard.BringToFront();

                string msg = "There is currently a wizard running. Please finish or cancel the current wizard before you can start another one.";
                MessageBox.Show(msg, AdmissionConstants.MessageBoxCaption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void residenceDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (wizard == null)
            {
                if (!ValidAdmissionsStudent()) return;
                LoadWizard(WizardName.AdmissionsResidenceDetails, AdmissionWizardViewBuilder.GetAdmissionResidenceDetails());
            }
            else
            {
                wizard.Show();
                wizard.BringToFront();

                string msg = "There is currently a wizard running. Please finish or cancel the current wizard before you can start another one.";
                MessageBox.Show(msg, AdmissionConstants.MessageBoxCaption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void previousDegreesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (wizard == null)
            {
                if (!ValidAdmissionsStudent()) return;
                LoadWizard(WizardName.AdmissionsPreviousDegrees, AdmissionWizardViewBuilder.GetAdmissionsPreviousDegrees());
            }
            else
            {
                wizard.Show();
                wizard.BringToFront();

                string msg = "There is currently a wizard running. Please finish or cancel the current wizard before you can start another one.";
                MessageBox.Show(msg, AdmissionConstants.MessageBoxCaption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void degreeInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (wizard == null)
            {
                if (!ValidAdmissionsStudent()) return;
                LoadWizard(WizardName.AdmissionsDegreeInformation, AdmissionWizardViewBuilder.GetAdmissionsDegreeInformation());
            }
            else
            {
                wizard.Show();
                wizard.BringToFront();

                string msg = "There is currently a wizard running. Please finish or cancel the current wizard before you can start another one.";
                MessageBox.Show(msg, AdmissionConstants.MessageBoxCaption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void principalSCIBursaryMiscToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (wizard == null)
            {
                if (!ValidAdmissionsStudent()) return;
                LoadWizard(WizardName.AdmissionsPrincipalDetails, AdmissionWizardViewBuilder.GetAdmissionsSchoolPrincipalDetails());
            }
            else
            {
                wizard.Show();
                wizard.BringToFront();

                string msg = "There is currently a wizard running. Please finish or cancel the current wizard before you can start another one.";
                MessageBox.Show(msg, AdmissionConstants.MessageBoxCaption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void signedAttentionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (wizard == null)
            {
                if (!ValidAdmissionsStudent()) return;
                LoadWizard(WizardName.AdmissionsSignedAttention, AdmissionWizardViewBuilder.GetAdmissionsSignedAppAndAttentionInfo());
            }
            else
            {
                wizard.Show();
                wizard.BringToFront();

                string msg = "There is currently a wizard running. Please finish or cancel the current wizard before you can start another one.";
                MessageBox.Show(msg, AdmissionConstants.MessageBoxCaption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void transcriptsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try { throw new NotImplementedException(); }
            catch (Exception ex)
            { Utils.HandleException(ExceptionSource.Admissions, ex); }
        }

        private void staffInternationalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try { throw new NotImplementedException(); }
            catch (Exception ex)
            { Utils.HandleException(ExceptionSource.Admissions, ex); }
        }

        #endregion

        bool ValidAdmissionsStudent()
        {
            try
            {
                if (string.IsNullOrEmpty(txtstuno.Text.Trim()))
                {
                    string msg = "Please enter admissions student first.";
                    MessageBox.Show(msg, "Admissions", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                int app_type = (int)Enumerations.AdmissionApplicationType.UG;
                bool adm_session = true;

                DS_VALIDATIONDataSet ds_validations;
                DS_ADM_STUDataSet ds_adm_stu = Proxy.Admissions.Validate_Previous_Rhodes_Number(Global.Global.tempstu, app_type, adm_session, Global.Global.admissions_view, string.Empty, out ds_validations);

                if (ds_validations.TT_VALIDATION.Rows.Count > 0)
                {
                    bool stop_msg = false;
                    StringBuilder msg = new StringBuilder(string.Concat("The following validations failed for the given student number:", Environment.NewLine));
                    foreach (DS_VALIDATIONDataSet.TT_VALIDATIONRow validation in ds_validations.TT_VALIDATION)
                    {
                        msg.Append(string.Concat(Environment.NewLine, validation.VAL_MSG));
                        if (validation.IS_STOP) stop_msg = true;
                    }

                    if (stop_msg)
                    {
                        MessageBox.Show(msg.ToString(), AdmissionConstants.MessageBoxCaption, MessageBoxButtons.OK, MessageBoxIcon.Warning); return false;
                    }
                    else
                    {
                        msg.Append(string.Concat(Environment.NewLine, Environment.NewLine, "Do you want to continue anyway?"));
                        if (!MessageBox.Show(msg.ToString(), AdmissionConstants.MessageBoxCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question).Equals(DialogResult.Yes)) return true;
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                Utils.HandleException(ExceptionSource.Admissions, ex);
                return false;
            }
        }

        private void confirmPaymentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Admissions.AdmissionForms.PayConfirmation frmPayments = new Admissions.AdmissionForms.PayConfirmation();
            frmPayments.ShowDialog();

        }

        private void onlineApplicationsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void nationalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Global.Global.tempstu != "")
            {
                try
                {


                    string namestring = "";
                    string tempnbtref = "";
                    string feedback = Proxy.Admissions.check_nbt_results(Global.Global.tempstu, out namestring, out tempnbtref);
                    if (feedback.Contains("Error"))
                    {
                        MessageBox.Show(feedback, "Error Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        bool proceed = true;
                        if (feedback != "")
                        {
                            proceed = false;
                            if (MessageBox.Show(feedback, "Create NBT Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                proceed = true;
                            }
                        }
                        if (proceed == true)
                        {
                            Admissions.UtilityScreens.NbtResults frmNbt = new Admissions.UtilityScreens.NbtResults(namestring);
                            frmNbt.ShowDialog();
                        }
                    }
                }
                catch (Exception ex)
                {
                    Utils.HandleException(ExceptionSource.Admissions, ex);
                }
            }
        }

        private void transcriptsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
              if (Global.Global.tempstu != "" && Global.Global.tempstu != null)
            {
                try
                {
                    if (MessageBox.Show("Transfer applications: Do not capture transcript information here until final transcript is received. Final Transcript Received?" , "Transcript", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Admissions.UtilityScreens.pse_results frmTranscript = new Admissions.UtilityScreens.pse_results();
                        frmTranscript.ShowDialog();
                    }

                }
                catch (Exception ex)
                {
                    Utils.HandleException(ExceptionSource.Admissions, ex);
                }
            }
        }
      
        private void viewOnlineApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdmissionForms.OnlineApps.ViewOnLineApp frmOnline = new AdmissionForms.OnlineApps.ViewOnLineApp(true);
            frmOnline.ShowDialog();
        }

        private void uploadDocumentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Admissions.AdmissionForms.OnlineApps.UploadDoc frmUpLoad = new AdmissionForms.OnlineApps.UploadDoc();
            frmUpLoad.ShowDialog();

        }

        private void deleteStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistrarsSystem.AcademicAdmin.DeleteStu frmDelStu = new RegistrarsSystem.AcademicAdmin.DeleteStu("A", Global.Global.tempstu);
            frmDelStu.ShowDialog();
        }
       
        private void feePayerUncheckedToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Admissions.AdmissionForms.CheckFeePayer frmFeePayer = new AdmissionForms.CheckFeePayer();
            frmFeePayer.ShowDialog();
        }

        private void uncheckedFormsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Admissions.AdmissionForms.UnCheckedForms frmUnChecked = new Admissions.AdmissionForms.UnCheckedForms();
            frmUnChecked.ShowDialog();
        }

        private void captureAcceptanceOfOfferToolStripMenuItem_Click(object sender, EventArgs e)
        {


                Admissions.AdmissionForms.Undergraduate.AcceptanceOffer frm_Acceptance = new AdmissionForms.Undergraduate.AcceptanceOffer();
                frm_Acceptance.ShowDialog();
        }

    }
}

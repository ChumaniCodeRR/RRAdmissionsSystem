namespace Admissions.AdmissionForms
{
    partial class SchoolDetails
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblTitle = new System.Windows.Forms.Label();
            this.gbSchoolDetails = new System.Windows.Forms.GroupBox();
            this.lbl_online = new System.Windows.Forms.Label();
            this.lbl_school = new System.Windows.Forms.Label();
            this.bsAdmissions = new System.Windows.Forms.BindingSource(this.components);
            this.ckPrincipalReport = new System.Windows.Forms.CheckBox();
            this.txtYearsAtSchools = new System.Windows.Forms.MaskedTextBox();
            this.txtMatricYear = new System.Windows.Forms.MaskedTextBox();
            this.bsAdmStudent = new System.Windows.Forms.BindingSource(this.components);
            this.txtMatricNo = new System.Windows.Forms.TextBox();
            this.lblMatricNo = new System.Windows.Forms.Label();
            this.lblMatricYear = new System.Windows.Forms.Label();
            this.lblYearsAtSchool = new System.Windows.Forms.Label();
            this.cbSchoolName = new System.Windows.Forms.ComboBox();
            this.lblSchoolName = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbSchoolDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsAdmissions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAdmStudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(579, 24);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Text = "School Details";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // gbSchoolDetails
            // 
            this.gbSchoolDetails.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gbSchoolDetails.Controls.Add(this.lbl_online);
            this.gbSchoolDetails.Controls.Add(this.lbl_school);
            this.gbSchoolDetails.Controls.Add(this.ckPrincipalReport);
            this.gbSchoolDetails.Controls.Add(this.txtYearsAtSchools);
            this.gbSchoolDetails.Controls.Add(this.txtMatricYear);
            this.gbSchoolDetails.Controls.Add(this.txtMatricNo);
            this.gbSchoolDetails.Controls.Add(this.lblMatricNo);
            this.gbSchoolDetails.Controls.Add(this.lblMatricYear);
            this.gbSchoolDetails.Controls.Add(this.lblYearsAtSchool);
            this.gbSchoolDetails.Controls.Add(this.cbSchoolName);
            this.gbSchoolDetails.Controls.Add(this.lblSchoolName);
            this.gbSchoolDetails.Location = new System.Drawing.Point(4, 41);
            this.gbSchoolDetails.Name = "gbSchoolDetails";
            this.gbSchoolDetails.Size = new System.Drawing.Size(572, 198);
            this.gbSchoolDetails.TabIndex = 6;
            this.gbSchoolDetails.TabStop = false;
            this.gbSchoolDetails.Text = "School Details";
            // 
            // lbl_online
            // 
            this.lbl_online.AutoSize = true;
            this.lbl_online.Location = new System.Drawing.Point(7, 27);
            this.lbl_online.Name = "lbl_online";
            this.lbl_online.Size = new System.Drawing.Size(119, 13);
            this.lbl_online.TabIndex = 14;
            this.lbl_online.Text = "Other School Specified:";
            this.lbl_online.Visible = false;
            // 
            // lbl_school
            // 
            this.lbl_school.AutoSize = true;
            this.lbl_school.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsAdmissions, "OTHER_SCHOOL", true));
            this.lbl_school.Location = new System.Drawing.Point(132, 27);
            this.lbl_school.Name = "lbl_school";
            this.lbl_school.Size = new System.Drawing.Size(95, 13);
            this.lbl_school.TabIndex = 13;
            this.lbl_school.Text = "<<School Name>>";
            this.lbl_school.Visible = false;
            // 
            // bsAdmissions
            // 
            this.bsAdmissions.DataMember = "TT_ADM";
            this.bsAdmissions.DataSource = typeof(NS_Admissions.StrongTypesNS.DS_ADM_STUDataSet);
            // 
            // ckPrincipalReport
            // 
            this.ckPrincipalReport.AutoSize = true;
            this.ckPrincipalReport.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ckPrincipalReport.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bsAdmissions, "PRINCP", true));
            this.ckPrincipalReport.Location = new System.Drawing.Point(194, 119);
            this.ckPrincipalReport.Name = "ckPrincipalReport";
            this.ckPrincipalReport.Size = new System.Drawing.Size(185, 17);
            this.ckPrincipalReport.TabIndex = 12;
            this.ckPrincipalReport.Text = "Principal Report Received? (Y/N)";
            this.ckPrincipalReport.UseVisualStyleBackColor = true;
            this.ckPrincipalReport.Visible = false;
            // 
            // txtYearsAtSchools
            // 
            this.txtYearsAtSchools.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludePrompt;
            this.txtYearsAtSchools.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsAdmissions, "YRS_SCHO", true));
            this.txtYearsAtSchools.Location = new System.Drawing.Point(95, 75);
            this.txtYearsAtSchools.Mask = "99";
            this.txtYearsAtSchools.Name = "txtYearsAtSchools";
            this.txtYearsAtSchools.Size = new System.Drawing.Size(64, 20);
            this.txtYearsAtSchools.TabIndex = 3;
            this.txtYearsAtSchools.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txtYearsAtSchools.TextChanged += new System.EventHandler(this.txtYearsAtSchools_TextChanged);
            this.txtYearsAtSchools.GotFocus += new System.EventHandler(this.txtYearsAtSchools_GotFocus);
            // 
            // txtMatricYear
            // 
            this.txtMatricYear.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludePrompt;
            this.txtMatricYear.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsAdmStudent, "MATYR", true));
            this.txtMatricYear.Location = new System.Drawing.Point(261, 75);
            this.txtMatricYear.Mask = "0000";
            this.txtMatricYear.Name = "txtMatricYear";
            this.txtMatricYear.Size = new System.Drawing.Size(69, 20);
            this.txtMatricYear.TabIndex = 5;
            this.txtMatricYear.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txtMatricYear.TextChanged += new System.EventHandler(this.txtMatricYear_TextChanged);
            this.txtMatricYear.GotFocus += new System.EventHandler(this.txtMatricYear_GotFocus);
            // 
            // bsAdmStudent
            // 
            this.bsAdmStudent.DataMember = "TT_ADM_STU";
            this.bsAdmStudent.DataSource = typeof(NS_Admissions.StrongTypesNS.DS_ADM_STUDataSet);
            // 
            // txtMatricNo
            // 
            this.txtMatricNo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsAdmissions, "MATNO", true));
            this.txtMatricNo.Location = new System.Drawing.Point(453, 75);
            this.txtMatricNo.Name = "txtMatricNo";
            this.txtMatricNo.Size = new System.Drawing.Size(100, 20);
            this.txtMatricNo.TabIndex = 7;
            this.txtMatricNo.GotFocus += new System.EventHandler(this.txtMatricNo_GotFocus);
            // 
            // lblMatricNo
            // 
            this.lblMatricNo.AutoSize = true;
            this.lblMatricNo.Location = new System.Drawing.Point(365, 78);
            this.lblMatricNo.Name = "lblMatricNo";
            this.lblMatricNo.Size = new System.Drawing.Size(76, 13);
            this.lblMatricNo.TabIndex = 6;
            this.lblMatricNo.Text = "Matric Number";
            // 
            // lblMatricYear
            // 
            this.lblMatricYear.AutoSize = true;
            this.lblMatricYear.Location = new System.Drawing.Point(194, 78);
            this.lblMatricYear.Name = "lblMatricYear";
            this.lblMatricYear.Size = new System.Drawing.Size(61, 13);
            this.lblMatricYear.TabIndex = 4;
            this.lblMatricYear.Text = "Matric Year";
            // 
            // lblYearsAtSchool
            // 
            this.lblYearsAtSchool.AutoSize = true;
            this.lblYearsAtSchool.Location = new System.Drawing.Point(7, 78);
            this.lblYearsAtSchool.Name = "lblYearsAtSchool";
            this.lblYearsAtSchool.Size = new System.Drawing.Size(82, 13);
            this.lblYearsAtSchool.TabIndex = 2;
            this.lblYearsAtSchool.Text = "Years at School";
            // 
            // cbSchoolName
            // 
            this.cbSchoolName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbSchoolName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbSchoolName.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsAdmStudent, "SCHOOL", true));
            this.cbSchoolName.DisplayMember = "SCH_DESCRIP";
            this.cbSchoolName.FormattingEnabled = true;
            this.cbSchoolName.Location = new System.Drawing.Point(95, 48);
            this.cbSchoolName.Name = "cbSchoolName";
            this.cbSchoolName.Size = new System.Drawing.Size(458, 21);
            this.cbSchoolName.TabIndex = 1;
            this.cbSchoolName.ValueMember = "SCHOOL";
            this.cbSchoolName.SelectedIndexChanged += new System.EventHandler(this.cbSchoolName_SelectedIndexChanged);
            this.cbSchoolName.GotFocus += new System.EventHandler(this.cbSchoolName_GotFocus);
            // 
            // lblSchoolName
            // 
            this.lblSchoolName.AutoSize = true;
            this.lblSchoolName.Location = new System.Drawing.Point(7, 51);
            this.lblSchoolName.Name = "lblSchoolName";
            this.lblSchoolName.Size = new System.Drawing.Size(71, 13);
            this.lblSchoolName.TabIndex = 0;
            this.lblSchoolName.Text = "School Name";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // SchoolDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.gbSchoolDetails);
            this.Controls.Add(this.lblTitle);
            this.Name = "SchoolDetails";
            this.Size = new System.Drawing.Size(579, 189);
            this.gbSchoolDetails.ResumeLayout(false);
            this.gbSchoolDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsAdmissions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAdmStudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox gbSchoolDetails;
        private System.Windows.Forms.Label lblSchoolName;
        private System.Windows.Forms.TextBox txtMatricNo;
        private System.Windows.Forms.Label lblMatricNo;
        private System.Windows.Forms.Label lblMatricYear;
        private System.Windows.Forms.Label lblYearsAtSchool;
        private System.Windows.Forms.ComboBox cbSchoolName;
        private System.Windows.Forms.MaskedTextBox txtYearsAtSchools;
        private System.Windows.Forms.MaskedTextBox txtMatricYear;
        private System.Windows.Forms.BindingSource bsAdmStudent;
        private System.Windows.Forms.BindingSource bsAdmissions;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.CheckBox ckPrincipalReport;
        private System.Windows.Forms.Label lbl_online;
        private System.Windows.Forms.Label lbl_school;
    }
}

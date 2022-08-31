﻿namespace Admissions.AdmissionForms
{
    partial class StudentPersonalDetails
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
            this.gbStudentDetails = new System.Windows.Forms.GroupBox();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.bsAdmStudent = new System.Windows.Forms.BindingSource(this.components);
            this.lblID = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblDOB = new System.Windows.Forms.Label();
            this.txtInitials = new System.Windows.Forms.TextBox();
            this.lblInitials = new System.Windows.Forms.Label();
            this.cbStuTitle = new System.Windows.Forms.ComboBox();
            this.lblStuTitle = new System.Windows.Forms.Label();
            this.txtMaidenName = new System.Windows.Forms.TextBox();
            this.lblMaidenName = new System.Windows.Forms.Label();
            this.lblOtherNames = new System.Windows.Forms.Label();
            this.txtOtherNames = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.lblSurname = new System.Windows.Forms.Label();
            this.gbDemographics = new System.Windows.Forms.GroupBox();
            this.lblDisability = new System.Windows.Forms.Label();
            this.cbDisability = new System.Windows.Forms.ComboBox();
            this.lblNationality = new System.Windows.Forms.Label();
            this.cbNationality = new System.Windows.Forms.ComboBox();
            this.lblCitizen = new System.Windows.Forms.Label();
            this.cbCitizen = new System.Windows.Forms.ComboBox();
            this.lblLanguage = new System.Windows.Forms.Label();
            this.cbLanguage = new System.Windows.Forms.ComboBox();
            this.cbRace = new System.Windows.Forms.ComboBox();
            this.lblRace = new System.Windows.Forms.Label();
            this.cbGender = new System.Windows.Forms.ComboBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbStudentDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsAdmStudent)).BeginInit();
            this.gbDemographics.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(397, 24);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "Student Personal Details";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // gbStudentDetails
            // 
            this.gbStudentDetails.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gbStudentDetails.Controls.Add(this.dtpDOB);
            this.gbStudentDetails.Controls.Add(this.lblID);
            this.gbStudentDetails.Controls.Add(this.txtID);
            this.gbStudentDetails.Controls.Add(this.lblDOB);
            this.gbStudentDetails.Controls.Add(this.txtInitials);
            this.gbStudentDetails.Controls.Add(this.lblInitials);
            this.gbStudentDetails.Controls.Add(this.cbStuTitle);
            this.gbStudentDetails.Controls.Add(this.lblStuTitle);
            this.gbStudentDetails.Controls.Add(this.txtMaidenName);
            this.gbStudentDetails.Controls.Add(this.lblMaidenName);
            this.gbStudentDetails.Controls.Add(this.lblOtherNames);
            this.gbStudentDetails.Controls.Add(this.txtOtherNames);
            this.gbStudentDetails.Controls.Add(this.txtFirstName);
            this.gbStudentDetails.Controls.Add(this.lblFirstName);
            this.gbStudentDetails.Controls.Add(this.txtSurname);
            this.gbStudentDetails.Controls.Add(this.lblSurname);
            this.gbStudentDetails.Location = new System.Drawing.Point(4, 39);
            this.gbStudentDetails.Name = "gbStudentDetails";
            this.gbStudentDetails.Size = new System.Drawing.Size(390, 194);
            this.gbStudentDetails.TabIndex = 4;
            this.gbStudentDetails.TabStop = false;
            this.gbStudentDetails.Text = "Student Details";
            // 
            // dtpDOB
            // 
            this.dtpDOB.CustomFormat = "dd / MM / yyyy";
            this.dtpDOB.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsAdmStudent, "DOB", true));
            this.dtpDOB.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDOB.Location = new System.Drawing.Point(87, 156);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(137, 20);
            this.dtpDOB.TabIndex = 13;
            // 
            // bsAdmStudent
            // 
            this.bsAdmStudent.DataMember = "TT_ADM_STU";
            this.bsAdmStudent.DataSource = typeof(NS_Admissions.StrongTypesNS.DS_ADM_STUDataSet);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(248, 160);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(16, 13);
            this.lblID.TabIndex = 15;
            this.lblID.Text = "Id";
            // 
            // txtID
            // 
            this.txtID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsAdmStudent, "ID", true));
            this.txtID.Location = new System.Drawing.Point(272, 154);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(93, 20);
            this.txtID.TabIndex = 14;
            this.txtID.GotFocus += new System.EventHandler(this.txtID_GotFocus);
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Location = new System.Drawing.Point(6, 160);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(66, 13);
            this.lblDOB.TabIndex = 12;
            this.lblDOB.Text = "Date of Birth";
            // 
            // txtInitials
            // 
            this.txtInitials.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtInitials.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsAdmStudent, "INITIALS", true));
            this.txtInitials.Location = new System.Drawing.Point(272, 128);
            this.txtInitials.Name = "txtInitials";
            this.txtInitials.Size = new System.Drawing.Size(93, 20);
            this.txtInitials.TabIndex = 11;
            this.txtInitials.GotFocus += new System.EventHandler(this.txtInitials_GotFocus);
            // 
            // lblInitials
            // 
            this.lblInitials.AutoSize = true;
            this.lblInitials.Location = new System.Drawing.Point(230, 135);
            this.lblInitials.Name = "lblInitials";
            this.lblInitials.Size = new System.Drawing.Size(36, 13);
            this.lblInitials.TabIndex = 10;
            this.lblInitials.Text = "Initials";
            // 
            // cbStuTitle
            // 
            this.cbStuTitle.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsAdmStudent, "TITL", true));
            this.cbStuTitle.DisplayMember = "DESCRIP";
            this.cbStuTitle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStuTitle.FormattingEnabled = true;
            this.cbStuTitle.Location = new System.Drawing.Point(87, 129);
            this.cbStuTitle.Name = "cbStuTitle";
            this.cbStuTitle.Size = new System.Drawing.Size(137, 21);
            this.cbStuTitle.TabIndex = 9;
            this.cbStuTitle.ValueMember = "TVALUE";
            this.cbStuTitle.SelectedIndexChanged += new System.EventHandler(this.cbStuTitle_SelectedIndexChanged);
            // 
            // lblStuTitle
            // 
            this.lblStuTitle.AutoSize = true;
            this.lblStuTitle.Location = new System.Drawing.Point(6, 132);
            this.lblStuTitle.Name = "lblStuTitle";
            this.lblStuTitle.Size = new System.Drawing.Size(67, 13);
            this.lblStuTitle.TabIndex = 8;
            this.lblStuTitle.Text = "Student Title";
            // 
            // txtMaidenName
            // 
            this.txtMaidenName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMaidenName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsAdmStudent, "MAIDEN", true));
            this.txtMaidenName.Location = new System.Drawing.Point(87, 102);
            this.txtMaidenName.Name = "txtMaidenName";
            this.txtMaidenName.Size = new System.Drawing.Size(278, 20);
            this.txtMaidenName.TabIndex = 7;
            this.txtMaidenName.GotFocus += new System.EventHandler(this.txtMaidenName_GotFocus);
            // 
            // lblMaidenName
            // 
            this.lblMaidenName.AutoSize = true;
            this.lblMaidenName.Location = new System.Drawing.Point(6, 105);
            this.lblMaidenName.Name = "lblMaidenName";
            this.lblMaidenName.Size = new System.Drawing.Size(73, 13);
            this.lblMaidenName.TabIndex = 6;
            this.lblMaidenName.Text = "Maiden Name";
            // 
            // lblOtherNames
            // 
            this.lblOtherNames.AutoSize = true;
            this.lblOtherNames.Location = new System.Drawing.Point(6, 79);
            this.lblOtherNames.Name = "lblOtherNames";
            this.lblOtherNames.Size = new System.Drawing.Size(75, 13);
            this.lblOtherNames.TabIndex = 5;
            this.lblOtherNames.Text = "Other Name(s)";
            // 
            // txtOtherNames
            // 
            this.txtOtherNames.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtOtherNames.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsAdmStudent, "NAME2", true));
            this.txtOtherNames.Location = new System.Drawing.Point(87, 76);
            this.txtOtherNames.Name = "txtOtherNames";
            this.txtOtherNames.Size = new System.Drawing.Size(278, 20);
            this.txtOtherNames.TabIndex = 4;
            this.txtOtherNames.GotFocus += new System.EventHandler(this.txtOtherNames_GotFocus);
            // 
            // txtFirstName
            // 
            this.txtFirstName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtFirstName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsAdmStudent, "NAME1", true));
            this.txtFirstName.Location = new System.Drawing.Point(87, 50);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(278, 20);
            this.txtFirstName.TabIndex = 3;
            this.txtFirstName.GotFocus += new System.EventHandler(this.txtFirstName_GotFocus);
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(6, 53);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(57, 13);
            this.lblFirstName.TabIndex = 2;
            this.lblFirstName.Text = "First Name";
            // 
            // txtSurname
            // 
            this.txtSurname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSurname.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsAdmStudent, "SURN", true));
            this.txtSurname.Location = new System.Drawing.Point(87, 24);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(278, 20);
            this.txtSurname.TabIndex = 1;
            this.txtSurname.TextChanged += new System.EventHandler(this.txtSurname_TextChanged);
            this.txtSurname.GotFocus += new System.EventHandler(this.txtSurname_GotFocus);
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(6, 27);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(49, 13);
            this.lblSurname.TabIndex = 0;
            this.lblSurname.Text = "Surname";
            // 
            // gbDemographics
            // 
            this.gbDemographics.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gbDemographics.Controls.Add(this.lblDisability);
            this.gbDemographics.Controls.Add(this.cbDisability);
            this.gbDemographics.Controls.Add(this.lblNationality);
            this.gbDemographics.Controls.Add(this.cbNationality);
            this.gbDemographics.Controls.Add(this.lblCitizen);
            this.gbDemographics.Controls.Add(this.cbCitizen);
            this.gbDemographics.Controls.Add(this.lblLanguage);
            this.gbDemographics.Controls.Add(this.cbLanguage);
            this.gbDemographics.Controls.Add(this.cbRace);
            this.gbDemographics.Controls.Add(this.lblRace);
            this.gbDemographics.Controls.Add(this.cbGender);
            this.gbDemographics.Controls.Add(this.lblGender);
            this.gbDemographics.Location = new System.Drawing.Point(4, 239);
            this.gbDemographics.Name = "gbDemographics";
            this.gbDemographics.Size = new System.Drawing.Size(390, 168);
            this.gbDemographics.TabIndex = 5;
            this.gbDemographics.TabStop = false;
            this.gbDemographics.Text = "Student Demographics";
            // 
            // lblDisability
            // 
            this.lblDisability.AutoSize = true;
            this.lblDisability.Location = new System.Drawing.Point(6, 138);
            this.lblDisability.Name = "lblDisability";
            this.lblDisability.Size = new System.Drawing.Size(48, 13);
            this.lblDisability.TabIndex = 20;
            this.lblDisability.Text = "Disability";
            // 
            // cbDisability
            // 
            this.cbDisability.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsAdmStudent, "DISAB", true));
            this.cbDisability.DisplayMember = "DESCRIP";
            this.cbDisability.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDisability.FormattingEnabled = true;
            this.cbDisability.Location = new System.Drawing.Point(87, 135);
            this.cbDisability.Name = "cbDisability";
            this.cbDisability.Size = new System.Drawing.Size(278, 21);
            this.cbDisability.TabIndex = 19;
            this.cbDisability.ValueMember = "CODE";
            this.cbDisability.SelectedIndexChanged += new System.EventHandler(this.cbDisability_SelectedIndexChanged);
            // 
            // lblNationality
            // 
            this.lblNationality.AutoSize = true;
            this.lblNationality.Location = new System.Drawing.Point(6, 111);
            this.lblNationality.Name = "lblNationality";
            this.lblNationality.Size = new System.Drawing.Size(56, 13);
            this.lblNationality.TabIndex = 18;
            this.lblNationality.Text = "Nationality";
            // 
            // cbNationality
            // 
            this.cbNationality.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbNationality.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbNationality.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsAdmStudent, "NAT", true));
            this.cbNationality.DisplayMember = "nat_descr";
            this.cbNationality.FormattingEnabled = true;
            this.cbNationality.Location = new System.Drawing.Point(87, 108);
            this.cbNationality.Name = "cbNationality";
            this.cbNationality.Size = new System.Drawing.Size(278, 21);
            this.cbNationality.TabIndex = 17;
            this.cbNationality.ValueMember = "ncode";
            this.cbNationality.SelectedIndexChanged += new System.EventHandler(this.cbNationality_SelectedIndexChanged);
            this.cbNationality.GotFocus += new System.EventHandler(this.cbNationality_GotFocus);
            // 
            // lblCitizen
            // 
            this.lblCitizen.AutoSize = true;
            this.lblCitizen.Location = new System.Drawing.Point(6, 84);
            this.lblCitizen.Name = "lblCitizen";
            this.lblCitizen.Size = new System.Drawing.Size(38, 13);
            this.lblCitizen.TabIndex = 16;
            this.lblCitizen.Text = "Citizen";
            // 
            // cbCitizen
            // 
            this.cbCitizen.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsAdmStudent, "CITIZEN", true));
            this.cbCitizen.DisplayMember = "DESCRIP";
            this.cbCitizen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCitizen.FormattingEnabled = true;
            this.cbCitizen.Location = new System.Drawing.Point(87, 81);
            this.cbCitizen.Name = "cbCitizen";
            this.cbCitizen.Size = new System.Drawing.Size(278, 21);
            this.cbCitizen.TabIndex = 15;
            this.cbCitizen.ValueMember = "CODE";
            this.cbCitizen.SelectedIndexChanged += new System.EventHandler(this.cbCitizen_SelectedIndexChanged);
            // 
            // lblLanguage
            // 
            this.lblLanguage.AutoSize = true;
            this.lblLanguage.Location = new System.Drawing.Point(6, 57);
            this.lblLanguage.Name = "lblLanguage";
            this.lblLanguage.Size = new System.Drawing.Size(55, 13);
            this.lblLanguage.TabIndex = 14;
            this.lblLanguage.Text = "Language";
            // 
            // cbLanguage
            // 
            this.cbLanguage.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsAdmStudent, "LANG", true));
            this.cbLanguage.DisplayMember = "DESCRIP";
            this.cbLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLanguage.FormattingEnabled = true;
            this.cbLanguage.Location = new System.Drawing.Point(87, 54);
            this.cbLanguage.Name = "cbLanguage";
            this.cbLanguage.Size = new System.Drawing.Size(278, 21);
            this.cbLanguage.TabIndex = 13;
            this.cbLanguage.ValueMember = "CODE";
            this.cbLanguage.SelectedIndexChanged += new System.EventHandler(this.cbLanguage_SelectedIndexChanged);
            // 
            // cbRace
            // 
            this.cbRace.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsAdmStudent, "RACE", true));
            this.cbRace.DisplayMember = "DESCRIP";
            this.cbRace.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRace.FormattingEnabled = true;
            this.cbRace.Location = new System.Drawing.Point(272, 27);
            this.cbRace.Name = "cbRace";
            this.cbRace.Size = new System.Drawing.Size(93, 21);
            this.cbRace.TabIndex = 12;
            this.cbRace.ValueMember = "CODE";
            this.cbRace.SelectedIndexChanged += new System.EventHandler(this.cbRace_SelectedIndexChanged);
            // 
            // lblRace
            // 
            this.lblRace.AutoSize = true;
            this.lblRace.Location = new System.Drawing.Point(230, 30);
            this.lblRace.Name = "lblRace";
            this.lblRace.Size = new System.Drawing.Size(33, 13);
            this.lblRace.TabIndex = 11;
            this.lblRace.Text = "Race";
            // 
            // cbGender
            // 
            this.cbGender.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsAdmStudent, "SEX", true));
            this.cbGender.DisplayMember = "Description";
            this.cbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGender.FormattingEnabled = true;
            this.cbGender.Location = new System.Drawing.Point(87, 27);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(137, 21);
            this.cbGender.TabIndex = 10;
            this.cbGender.ValueMember = "Id";
            this.cbGender.SelectedIndexChanged += new System.EventHandler(this.cbGender_SelectedIndexChanged);
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(6, 30);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(42, 13);
            this.lblGender.TabIndex = 0;
            this.lblGender.Text = "Gender";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // StudentPersonalDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.gbDemographics);
            this.Controls.Add(this.gbStudentDetails);
            this.Controls.Add(this.lblTitle);
            this.Name = "StudentPersonalDetails";
            this.Size = new System.Drawing.Size(397, 414);
            this.Load += new System.EventHandler(this.StudentPersonalDetails_Load);
            this.gbStudentDetails.ResumeLayout(false);
            this.gbStudentDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsAdmStudent)).EndInit();
            this.gbDemographics.ResumeLayout(false);
            this.gbDemographics.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox gbStudentDetails;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.TextBox txtInitials;
        private System.Windows.Forms.Label lblInitials;
        private System.Windows.Forms.ComboBox cbStuTitle;
        private System.Windows.Forms.Label lblStuTitle;
        private System.Windows.Forms.TextBox txtMaidenName;
        private System.Windows.Forms.Label lblMaidenName;
        private System.Windows.Forms.Label lblOtherNames;
        private System.Windows.Forms.TextBox txtOtherNames;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.GroupBox gbDemographics;
        private System.Windows.Forms.Label lblDisability;
        private System.Windows.Forms.ComboBox cbDisability;
        private System.Windows.Forms.Label lblNationality;
        private System.Windows.Forms.ComboBox cbNationality;
        private System.Windows.Forms.Label lblCitizen;
        private System.Windows.Forms.ComboBox cbCitizen;
        private System.Windows.Forms.Label lblLanguage;
        private System.Windows.Forms.ComboBox cbLanguage;
        private System.Windows.Forms.ComboBox cbRace;
        private System.Windows.Forms.Label lblRace;
        private System.Windows.Forms.ComboBox cbGender;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.BindingSource bsAdmStudent;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.DateTimePicker dtpDOB;
    }
}

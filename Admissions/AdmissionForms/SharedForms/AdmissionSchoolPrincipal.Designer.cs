namespace Admissions.AdmissionForms
{
    partial class AdmissionSchoolPrincipal
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
            this.gbMiscellaneous = new System.Windows.Forms.GroupBox();
            this.ckPrincipalReport = new System.Windows.Forms.CheckBox();
            this.txtPosition = new System.Windows.Forms.TextBox();
            this.lblPosition = new System.Windows.Forms.Label();
            this.gbContact = new System.Windows.Forms.GroupBox();
            this.txtContactPhone = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtContactEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.gbOther = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblNBTNumber = new System.Windows.Forms.Label();
            this.ckHeadStudent = new System.Windows.Forms.CheckBox();
            this.ckECSchoolVisit = new System.Windows.Forms.CheckBox();
            this.ckSpecialScienceVisit = new System.Windows.Forms.CheckBox();
            this.ckSpecialSchoolsVisit = new System.Windows.Forms.CheckBox();
            this.bsAdmissions = new System.Windows.Forms.BindingSource(this.components);
            this.bsAdmStudent = new System.Windows.Forms.BindingSource(this.components);
            this.gbMiscellaneous.SuspendLayout();
            this.gbContact.SuspendLayout();
            this.gbOther.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsAdmissions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAdmStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(345, 24);
            this.lblTitle.TabIndex = 6;
            this.lblTitle.Text = "Principal/Miscellaneous Info";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // gbMiscellaneous
            // 
            this.gbMiscellaneous.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gbMiscellaneous.Controls.Add(this.ckPrincipalReport);
            this.gbMiscellaneous.Controls.Add(this.txtPosition);
            this.gbMiscellaneous.Controls.Add(this.lblPosition);
            this.gbMiscellaneous.Location = new System.Drawing.Point(3, 37);
            this.gbMiscellaneous.Name = "gbMiscellaneous";
            this.gbMiscellaneous.Size = new System.Drawing.Size(337, 74);
            this.gbMiscellaneous.TabIndex = 7;
            this.gbMiscellaneous.TabStop = false;
            this.gbMiscellaneous.Text = "Miscellaneous";
            // 
            // ckPrincipalReport
            // 
            this.ckPrincipalReport.AutoSize = true;
            this.ckPrincipalReport.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ckPrincipalReport.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bsAdmissions, "PRINCP", true));
            this.ckPrincipalReport.Location = new System.Drawing.Point(8, 51);
            this.ckPrincipalReport.Name = "ckPrincipalReport";
            this.ckPrincipalReport.Size = new System.Drawing.Size(136, 17);
            this.ckPrincipalReport.TabIndex = 2;
            this.ckPrincipalReport.Text = "Principal Report? (Y/N)";
            this.ckPrincipalReport.UseVisualStyleBackColor = true;
            // 
            // txtPosition
            // 
            this.txtPosition.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsAdmissions, "STD_POS", true));
            this.txtPosition.Location = new System.Drawing.Point(117, 20);
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.Size = new System.Drawing.Size(197, 20);
            this.txtPosition.TabIndex = 1;
            this.txtPosition.GotFocus += new System.EventHandler(this.txtPosition_GotFocus);
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Location = new System.Drawing.Point(10, 23);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(101, 13);
            this.lblPosition.TabIndex = 0;
            this.lblPosition.Text = "Position in Standard";
            // 
            // gbContact
            // 
            this.gbContact.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gbContact.Controls.Add(this.txtContactPhone);
            this.gbContact.Controls.Add(this.lblPhone);
            this.gbContact.Controls.Add(this.txtContactEmail);
            this.gbContact.Controls.Add(this.lblEmail);
            this.gbContact.Location = new System.Drawing.Point(3, 117);
            this.gbContact.Name = "gbContact";
            this.gbContact.Size = new System.Drawing.Size(337, 81);
            this.gbContact.TabIndex = 8;
            this.gbContact.TabStop = false;
            this.gbContact.Text = "Contact Person";
            // 
            // txtContactPhone
            // 
            this.txtContactPhone.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsAdmissions, "SCHO_CONTACT_PHONE", true));
            this.txtContactPhone.Location = new System.Drawing.Point(47, 48);
            this.txtContactPhone.Name = "txtContactPhone";
            this.txtContactPhone.Size = new System.Drawing.Size(267, 20);
            this.txtContactPhone.TabIndex = 5;
            this.txtContactPhone.GotFocus += new System.EventHandler(this.txtContactPhone_GotFocus);
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(6, 51);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(38, 13);
            this.lblPhone.TabIndex = 4;
            this.lblPhone.Text = "Phone";
            // 
            // txtContactEmail
            // 
            this.txtContactEmail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsAdmissions, "SCHO_CONTACT_EMAIL", true));
            this.txtContactEmail.Location = new System.Drawing.Point(47, 22);
            this.txtContactEmail.Name = "txtContactEmail";
            this.txtContactEmail.Size = new System.Drawing.Size(267, 20);
            this.txtContactEmail.TabIndex = 3;
            this.txtContactEmail.GotFocus += new System.EventHandler(this.txtContactEmail_GotFocus);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(6, 25);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "Email";
            // 
            // gbOther
            // 
            this.gbOther.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gbOther.Controls.Add(this.textBox1);
            this.gbOther.Controls.Add(this.lblNBTNumber);
            this.gbOther.Controls.Add(this.ckHeadStudent);
            this.gbOther.Controls.Add(this.ckECSchoolVisit);
            this.gbOther.Controls.Add(this.ckSpecialScienceVisit);
            this.gbOther.Controls.Add(this.ckSpecialSchoolsVisit);
            this.gbOther.Location = new System.Drawing.Point(3, 204);
            this.gbOther.Name = "gbOther";
            this.gbOther.Size = new System.Drawing.Size(337, 141);
            this.gbOther.TabIndex = 9;
            this.gbOther.TabStop = false;
            this.gbOther.Text = "Other";
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsAdmStudent, "NBT_REF", true));
            this.textBox1.Location = new System.Drawing.Point(85, 114);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(84, 20);
            this.textBox1.TabIndex = 7;
            this.textBox1.GotFocus += new System.EventHandler(this.textBox1_GotFocus);
            // 
            // lblNBTNumber
            // 
            this.lblNBTNumber.AutoSize = true;
            this.lblNBTNumber.Location = new System.Drawing.Point(10, 117);
            this.lblNBTNumber.Name = "lblNBTNumber";
            this.lblNBTNumber.Size = new System.Drawing.Size(69, 13);
            this.lblNBTNumber.TabIndex = 6;
            this.lblNBTNumber.Text = "NBT Number";
            // 
            // ckHeadStudent
            // 
            this.ckHeadStudent.AutoSize = true;
            this.ckHeadStudent.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ckHeadStudent.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bsAdmissions, "HEADSTU", true));
            this.ckHeadStudent.Location = new System.Drawing.Point(41, 91);
            this.ckHeadStudent.Name = "ckHeadStudent";
            this.ckHeadStudent.Size = new System.Drawing.Size(127, 17);
            this.ckHeadStudent.TabIndex = 5;
            this.ckHeadStudent.Text = "Head Student? (Y/N)";
            this.ckHeadStudent.UseVisualStyleBackColor = true;
            // 
            // ckECSchoolVisit
            // 
            this.ckECSchoolVisit.AutoSize = true;
            this.ckECSchoolVisit.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ckECSchoolVisit.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bsAdmissions, "SPEC_EC", true));
            this.ckECSchoolVisit.Location = new System.Drawing.Point(35, 68);
            this.ckECSchoolVisit.Name = "ckECSchoolVisit";
            this.ckECSchoolVisit.Size = new System.Drawing.Size(133, 17);
            this.ckECSchoolVisit.TabIndex = 4;
            this.ckECSchoolVisit.Text = "EC School Visit? (Y/N)";
            this.ckECSchoolVisit.UseVisualStyleBackColor = true;
            // 
            // ckSpecialScienceVisit
            // 
            this.ckSpecialScienceVisit.AutoSize = true;
            this.ckSpecialScienceVisit.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ckSpecialScienceVisit.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bsAdmissions, "SPEC_SCI_VISIT", true));
            this.ckSpecialScienceVisit.Location = new System.Drawing.Point(9, 45);
            this.ckSpecialScienceVisit.Name = "ckSpecialScienceVisit";
            this.ckSpecialScienceVisit.Size = new System.Drawing.Size(160, 17);
            this.ckSpecialScienceVisit.TabIndex = 3;
            this.ckSpecialScienceVisit.Text = "Special Science Visit? (Y/N)";
            this.ckSpecialScienceVisit.UseVisualStyleBackColor = true;
            // 
            // ckSpecialSchoolsVisit
            // 
            this.ckSpecialSchoolsVisit.AutoSize = true;
            this.ckSpecialSchoolsVisit.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ckSpecialSchoolsVisit.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bsAdmissions, "SCIBUR_APP", true));
            this.ckSpecialSchoolsVisit.Location = new System.Drawing.Point(10, 22);
            this.ckSpecialSchoolsVisit.Name = "ckSpecialSchoolsVisit";
            this.ckSpecialSchoolsVisit.Size = new System.Drawing.Size(159, 17);
            this.ckSpecialSchoolsVisit.TabIndex = 2;
            this.ckSpecialSchoolsVisit.Text = "Special Schools Visit? (Y/N)";
            this.ckSpecialSchoolsVisit.UseVisualStyleBackColor = true;
            // 
            // bsAdmissions
            // 
            this.bsAdmissions.DataMember = "TT_ADM";
            this.bsAdmissions.DataSource = typeof(NS_Admissions.StrongTypesNS.DS_ADM_STUDataSet);
            // 
            // bsAdmStudent
            // 
            this.bsAdmStudent.DataMember = "TT_ADM_STU";
            this.bsAdmStudent.DataSource = typeof(NS_Admissions.StrongTypesNS.DS_ADM_STUDataSet);
            // 
            // AdmissionSchoolPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.gbOther);
            this.Controls.Add(this.gbContact);
            this.Controls.Add(this.gbMiscellaneous);
            this.Controls.Add(this.lblTitle);
            this.Name = "AdmissionSchoolPrincipal";
            this.Size = new System.Drawing.Size(345, 354);
            this.gbMiscellaneous.ResumeLayout(false);
            this.gbMiscellaneous.PerformLayout();
            this.gbContact.ResumeLayout(false);
            this.gbContact.PerformLayout();
            this.gbOther.ResumeLayout(false);
            this.gbOther.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsAdmissions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAdmStudent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox gbMiscellaneous;
        private System.Windows.Forms.CheckBox ckPrincipalReport;
        private System.Windows.Forms.TextBox txtPosition;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.GroupBox gbContact;
        private System.Windows.Forms.TextBox txtContactPhone;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtContactEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.GroupBox gbOther;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblNBTNumber;
        private System.Windows.Forms.CheckBox ckHeadStudent;
        private System.Windows.Forms.CheckBox ckECSchoolVisit;
        private System.Windows.Forms.CheckBox ckSpecialScienceVisit;
        private System.Windows.Forms.CheckBox ckSpecialSchoolsVisit;
        private System.Windows.Forms.BindingSource bsAdmissions;
        private System.Windows.Forms.BindingSource bsAdmStudent;
    }
}

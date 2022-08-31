namespace Admissions.AdmissionForms
{
    partial class HonsAdmissionCheck
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.gbAdmDetails = new System.Windows.Forms.GroupBox();
            this.rbNextYear = new System.Windows.Forms.RadioButton();
            this.rbThisYr = new System.Windows.Forms.RadioButton();
            this.lblAdmissionYear = new System.Windows.Forms.Label();
            this.gbStudentDetails = new System.Windows.Forms.GroupBox();
            this.txtStuNo = new System.Windows.Forms.TextBox();
            this.lblStuNo = new System.Windows.Forms.Label();
            this.gbAdmDetails.SuspendLayout();
            this.gbStudentDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(283, 24);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "Hons/LLB/BBS 4 Admissions";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // gbAdmDetails
            // 
            this.gbAdmDetails.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gbAdmDetails.Controls.Add(this.rbNextYear);
            this.gbAdmDetails.Controls.Add(this.rbThisYr);
            this.gbAdmDetails.Controls.Add(this.lblAdmissionYear);
            this.gbAdmDetails.Location = new System.Drawing.Point(4, 27);
            this.gbAdmDetails.Name = "gbAdmDetails";
            this.gbAdmDetails.Size = new System.Drawing.Size(274, 83);
            this.gbAdmDetails.TabIndex = 4;
            this.gbAdmDetails.TabStop = false;
            this.gbAdmDetails.Text = "Admission Details";
            // 
            // rbNextYear
            // 
            this.rbNextYear.AutoSize = true;
            this.rbNextYear.Checked = true;
            this.rbNextYear.Location = new System.Drawing.Point(160, 50);
            this.rbNextYear.Name = "rbNextYear";
            this.rbNextYear.Size = new System.Drawing.Size(80, 17);
            this.rbNextYear.TabIndex = 2;
            this.rbNextYear.TabStop = true;
            this.rbNextYear.Text = "Next Period";
            this.rbNextYear.UseVisualStyleBackColor = true;
            // 
            // rbThisYr
            // 
            this.rbThisYr.AutoSize = true;
            this.rbThisYr.Location = new System.Drawing.Point(9, 50);
            this.rbThisYr.Name = "rbThisYr";
            this.rbThisYr.Size = new System.Drawing.Size(78, 17);
            this.rbThisYr.TabIndex = 1;
            this.rbThisYr.Text = "This Period";
            this.rbThisYr.UseVisualStyleBackColor = true;
            // 
            // lblAdmissionYear
            // 
            this.lblAdmissionYear.AutoSize = true;
            this.lblAdmissionYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdmissionYear.Location = new System.Drawing.Point(6, 23);
            this.lblAdmissionYear.Name = "lblAdmissionYear";
            this.lblAdmissionYear.Size = new System.Drawing.Size(248, 13);
            this.lblAdmissionYear.TabIndex = 0;
            this.lblAdmissionYear.Text = "We are now processing [yyyy] applications";
            // 
            // gbStudentDetails
            // 
            this.gbStudentDetails.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gbStudentDetails.Controls.Add(this.txtStuNo);
            this.gbStudentDetails.Controls.Add(this.lblStuNo);
            this.gbStudentDetails.Location = new System.Drawing.Point(4, 116);
            this.gbStudentDetails.Name = "gbStudentDetails";
            this.gbStudentDetails.Size = new System.Drawing.Size(274, 57);
            this.gbStudentDetails.TabIndex = 5;
            this.gbStudentDetails.TabStop = false;
            this.gbStudentDetails.Text = "Student Details";
            // 
            // txtStuNo
            // 
            this.txtStuNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtStuNo.Location = new System.Drawing.Point(198, 23);
            this.txtStuNo.Name = "txtStuNo";
            this.txtStuNo.Size = new System.Drawing.Size(70, 20);
            this.txtStuNo.TabIndex = 1;
            // 
            // lblStuNo
            // 
            this.lblStuNo.AutoSize = true;
            this.lblStuNo.Location = new System.Drawing.Point(6, 26);
            this.lblStuNo.Name = "lblStuNo";
            this.lblStuNo.Size = new System.Drawing.Size(187, 13);
            this.lblStuNo.TabIndex = 0;
            this.lblStuNo.Text = "Previous Rhodes Number (if available)";
            // 
            // HonsAdmissionCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.gbStudentDetails);
            this.Controls.Add(this.gbAdmDetails);
            this.Controls.Add(this.lblTitle);
            this.Name = "HonsAdmissionCheck";
            this.Size = new System.Drawing.Size(283, 180);
            this.gbAdmDetails.ResumeLayout(false);
            this.gbAdmDetails.PerformLayout();
            this.gbStudentDetails.ResumeLayout(false);
            this.gbStudentDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox gbAdmDetails;
        private System.Windows.Forms.RadioButton rbNextYear;
        private System.Windows.Forms.RadioButton rbThisYr;
        private System.Windows.Forms.Label lblAdmissionYear;
        private System.Windows.Forms.GroupBox gbStudentDetails;
        private System.Windows.Forms.TextBox txtStuNo;
        private System.Windows.Forms.Label lblStuNo;
    }
}

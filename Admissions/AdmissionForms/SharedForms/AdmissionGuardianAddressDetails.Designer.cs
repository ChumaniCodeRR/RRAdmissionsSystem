namespace Admissions.AdmissionForms
{
    partial class AdmissionGuardianAddressDetails
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
            this.gb = new System.Windows.Forms.GroupBox();
            this.txtGuardianAddressLine5 = new System.Windows.Forms.TextBox();
            this.bsAdmStudent = new System.Windows.Forms.BindingSource(this.components);
            this.txtGuardianAddressPostalCode = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtGuardianAddressLine4 = new System.Windows.Forms.TextBox();
            this.txtGuardianAddressLine3 = new System.Windows.Forms.TextBox();
            this.txtGuardianAddressLine2 = new System.Windows.Forms.TextBox();
            this.txtGuardianAddressLine1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCopyToTermPostal = new System.Windows.Forms.Button();
            this.cbGuardianCopyFrom = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblCopyTermPostalAdd = new System.Windows.Forms.Label();
            this.gbContactDetails = new System.Windows.Forms.GroupBox();
            this.txtKinEmail = new System.Windows.Forms.TextBox();
            this.lblKinEmail = new System.Windows.Forms.Label();
            this.txtKinCell = new System.Windows.Forms.TextBox();
            this.lblKinCell = new System.Windows.Forms.Label();
            this.txtKinFax = new System.Windows.Forms.TextBox();
            this.lblKinFax = new System.Windows.Forms.Label();
            this.txtKinTel = new System.Windows.Forms.TextBox();
            this.lblKinTel = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.gb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsAdmStudent)).BeginInit();
            this.gbContactDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(554, 24);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "Guardian Address Details";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // gb
            // 
            this.gb.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gb.Controls.Add(this.txtGuardianAddressLine5);
            this.gb.Controls.Add(this.txtGuardianAddressPostalCode);
            this.gb.Controls.Add(this.label5);
            this.gb.Controls.Add(this.txtGuardianAddressLine4);
            this.gb.Controls.Add(this.txtGuardianAddressLine3);
            this.gb.Controls.Add(this.txtGuardianAddressLine2);
            this.gb.Controls.Add(this.txtGuardianAddressLine1);
            this.gb.Controls.Add(this.label6);
            this.gb.Controls.Add(this.btnCopyToTermPostal);
            this.gb.Controls.Add(this.cbGuardianCopyFrom);
            this.gb.Controls.Add(this.label7);
            this.gb.Controls.Add(this.lblCopyTermPostalAdd);
            this.gb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb.Location = new System.Drawing.Point(3, 34);
            this.gb.Name = "gb";
            this.gb.Size = new System.Drawing.Size(543, 194);
            this.gb.TabIndex = 1;
            this.gb.TabStop = false;
            this.gb.Text = "Guardian/Parent Address";
            // 
            // txtGuardianAddressLine5
            // 
            this.txtGuardianAddressLine5.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtGuardianAddressLine5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsAdmStudent, "KIN_ADDR5", true));
            this.txtGuardianAddressLine5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGuardianAddressLine5.Location = new System.Drawing.Point(77, 141);
            this.txtGuardianAddressLine5.Name = "txtGuardianAddressLine5";
            this.txtGuardianAddressLine5.Size = new System.Drawing.Size(375, 20);
            this.txtGuardianAddressLine5.TabIndex = 7;
            // 
            // bsAdmStudent
            // 
            this.bsAdmStudent.DataMember = "TT_ADM_STU";
            this.bsAdmStudent.DataSource = typeof(NS_Admissions.StrongTypesNS.DS_ADM_STUDataSet);
            // 
            // txtGuardianAddressPostalCode
            // 
            this.txtGuardianAddressPostalCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtGuardianAddressPostalCode.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsAdmStudent, "KIN_POST", true));
            this.txtGuardianAddressPostalCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGuardianAddressPostalCode.Location = new System.Drawing.Point(77, 167);
            this.txtGuardianAddressPostalCode.Name = "txtGuardianAddressPostalCode";
            this.txtGuardianAddressPostalCode.Size = new System.Drawing.Size(115, 20);
            this.txtGuardianAddressPostalCode.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Postal Code";
            // 
            // txtGuardianAddressLine4
            // 
            this.txtGuardianAddressLine4.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtGuardianAddressLine4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsAdmStudent, "KIN_ADDR4", true));
            this.txtGuardianAddressLine4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGuardianAddressLine4.Location = new System.Drawing.Point(77, 115);
            this.txtGuardianAddressLine4.Name = "txtGuardianAddressLine4";
            this.txtGuardianAddressLine4.Size = new System.Drawing.Size(375, 20);
            this.txtGuardianAddressLine4.TabIndex = 6;
            // 
            // txtGuardianAddressLine3
            // 
            this.txtGuardianAddressLine3.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtGuardianAddressLine3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsAdmStudent, "KIN_ADDR3", true));
            this.txtGuardianAddressLine3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGuardianAddressLine3.Location = new System.Drawing.Point(77, 89);
            this.txtGuardianAddressLine3.Name = "txtGuardianAddressLine3";
            this.txtGuardianAddressLine3.Size = new System.Drawing.Size(375, 20);
            this.txtGuardianAddressLine3.TabIndex = 5;
            // 
            // txtGuardianAddressLine2
            // 
            this.txtGuardianAddressLine2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtGuardianAddressLine2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsAdmStudent, "KIN_ADDR2", true));
            this.txtGuardianAddressLine2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGuardianAddressLine2.Location = new System.Drawing.Point(77, 63);
            this.txtGuardianAddressLine2.Name = "txtGuardianAddressLine2";
            this.txtGuardianAddressLine2.Size = new System.Drawing.Size(375, 20);
            this.txtGuardianAddressLine2.TabIndex = 4;
            // 
            // txtGuardianAddressLine1
            // 
            this.txtGuardianAddressLine1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtGuardianAddressLine1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsAdmStudent, "KIN_ADDR1", true));
            this.txtGuardianAddressLine1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGuardianAddressLine1.Location = new System.Drawing.Point(77, 40);
            this.txtGuardianAddressLine1.Name = "txtGuardianAddressLine1";
            this.txtGuardianAddressLine1.Size = new System.Drawing.Size(375, 20);
            this.txtGuardianAddressLine1.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(7, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Address";
            // 
            // btnCopyToTermPostal
            // 
            this.btnCopyToTermPostal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCopyToTermPostal.Location = new System.Drawing.Point(328, 11);
            this.btnCopyToTermPostal.Name = "btnCopyToTermPostal";
            this.btnCopyToTermPostal.Size = new System.Drawing.Size(75, 23);
            this.btnCopyToTermPostal.TabIndex = 2;
            this.btnCopyToTermPostal.Text = "Copy";
            this.btnCopyToTermPostal.UseVisualStyleBackColor = true;
            this.btnCopyToTermPostal.Click += new System.EventHandler(this.btnCopyToTermPostal_Click);
            // 
            // cbGuardianCopyFrom
            // 
            this.cbGuardianCopyFrom.DisplayMember = "Description";
            this.cbGuardianCopyFrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGuardianCopyFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGuardianCopyFrom.FormattingEnabled = true;
            this.cbGuardianCopyFrom.Location = new System.Drawing.Point(113, 13);
            this.cbGuardianCopyFrom.Name = "cbGuardianCopyFrom";
            this.cbGuardianCopyFrom.Size = new System.Drawing.Size(191, 21);
            this.cbGuardianCopyFrom.TabIndex = 1;
            this.cbGuardianCopyFrom.ValueMember = "Id";
            this.cbGuardianCopyFrom.SelectedIndexChanged += new System.EventHandler(this.cbGuardianCopyFrom_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Location = new System.Drawing.Point(6, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(530, 2);
            this.label7.TabIndex = 2;
            // 
            // lblCopyTermPostalAdd
            // 
            this.lblCopyTermPostalAdd.AutoSize = true;
            this.lblCopyTermPostalAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCopyTermPostalAdd.Location = new System.Drawing.Point(6, 16);
            this.lblCopyTermPostalAdd.Name = "lblCopyTermPostalAdd";
            this.lblCopyTermPostalAdd.Size = new System.Drawing.Size(101, 13);
            this.lblCopyTermPostalAdd.TabIndex = 0;
            this.lblCopyTermPostalAdd.Text = "Copy Address From:";
            // 
            // gbContactDetails
            // 
            this.gbContactDetails.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gbContactDetails.Controls.Add(this.txtKinEmail);
            this.gbContactDetails.Controls.Add(this.lblKinEmail);
            this.gbContactDetails.Controls.Add(this.txtKinCell);
            this.gbContactDetails.Controls.Add(this.lblKinCell);
            this.gbContactDetails.Controls.Add(this.txtKinFax);
            this.gbContactDetails.Controls.Add(this.lblKinFax);
            this.gbContactDetails.Controls.Add(this.txtKinTel);
            this.gbContactDetails.Controls.Add(this.lblKinTel);
            this.gbContactDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbContactDetails.Location = new System.Drawing.Point(3, 234);
            this.gbContactDetails.Name = "gbContactDetails";
            this.gbContactDetails.Size = new System.Drawing.Size(543, 132);
            this.gbContactDetails.TabIndex = 2;
            this.gbContactDetails.TabStop = false;
            this.gbContactDetails.Text = "Contact Details";
            // 
            // txtKinEmail
            // 
            this.txtKinEmail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsAdmStudent, "KIN_EMAIL", true));
            this.txtKinEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKinEmail.Location = new System.Drawing.Point(77, 104);
            this.txtKinEmail.Name = "txtKinEmail";
            this.txtKinEmail.Size = new System.Drawing.Size(375, 20);
            this.txtKinEmail.TabIndex = 4;
            // 
            // lblKinEmail
            // 
            this.lblKinEmail.AutoSize = true;
            this.lblKinEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKinEmail.Location = new System.Drawing.Point(2, 107);
            this.lblKinEmail.Name = "lblKinEmail";
            this.lblKinEmail.Size = new System.Drawing.Size(50, 13);
            this.lblKinEmail.TabIndex = 12;
            this.lblKinEmail.Text = "Kin Email";
            // 
            // txtKinCell
            // 
            this.txtKinCell.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtKinCell.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsAdmStudent, "KIN_CELL", true));
            this.txtKinCell.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKinCell.Location = new System.Drawing.Point(77, 78);
            this.txtKinCell.Name = "txtKinCell";
            this.txtKinCell.Size = new System.Drawing.Size(115, 20);
            this.txtKinCell.TabIndex = 3;
            // 
            // lblKinCell
            // 
            this.lblKinCell.AutoSize = true;
            this.lblKinCell.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKinCell.Location = new System.Drawing.Point(2, 81);
            this.lblKinCell.Name = "lblKinCell";
            this.lblKinCell.Size = new System.Drawing.Size(42, 13);
            this.lblKinCell.TabIndex = 10;
            this.lblKinCell.Text = "Kin Cell";
            // 
            // txtKinFax
            // 
            this.txtKinFax.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtKinFax.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsAdmStudent, "KIN_FAX", true));
            this.txtKinFax.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKinFax.Location = new System.Drawing.Point(77, 52);
            this.txtKinFax.Name = "txtKinFax";
            this.txtKinFax.Size = new System.Drawing.Size(115, 20);
            this.txtKinFax.TabIndex = 2;
            // 
            // lblKinFax
            // 
            this.lblKinFax.AutoSize = true;
            this.lblKinFax.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKinFax.Location = new System.Drawing.Point(2, 55);
            this.lblKinFax.Name = "lblKinFax";
            this.lblKinFax.Size = new System.Drawing.Size(42, 13);
            this.lblKinFax.TabIndex = 8;
            this.lblKinFax.Text = "Kin Fax";
            // 
            // txtKinTel
            // 
            this.txtKinTel.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtKinTel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsAdmStudent, "KIN_PHONE", true));
            this.txtKinTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKinTel.Location = new System.Drawing.Point(77, 26);
            this.txtKinTel.Name = "txtKinTel";
            this.txtKinTel.Size = new System.Drawing.Size(115, 20);
            this.txtKinTel.TabIndex = 1;
            // 
            // lblKinTel
            // 
            this.lblKinTel.AutoSize = true;
            this.lblKinTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKinTel.Location = new System.Drawing.Point(2, 29);
            this.lblKinTel.Name = "lblKinTel";
            this.lblKinTel.Size = new System.Drawing.Size(40, 13);
            this.lblKinTel.TabIndex = 0;
            this.lblKinTel.Text = "Kin Tel";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // AdmissionGuardianAddressDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.gbContactDetails);
            this.Controls.Add(this.gb);
            this.Controls.Add(this.lblTitle);
            this.Name = "AdmissionGuardianAddressDetails";
            this.Size = new System.Drawing.Size(554, 375);
            this.gb.ResumeLayout(false);
            this.gb.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsAdmStudent)).EndInit();
            this.gbContactDetails.ResumeLayout(false);
            this.gbContactDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox gb;
        private System.Windows.Forms.TextBox txtGuardianAddressLine5;
        private System.Windows.Forms.TextBox txtGuardianAddressPostalCode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtGuardianAddressLine4;
        private System.Windows.Forms.TextBox txtGuardianAddressLine3;
        private System.Windows.Forms.TextBox txtGuardianAddressLine2;
        private System.Windows.Forms.TextBox txtGuardianAddressLine1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCopyToTermPostal;
        private System.Windows.Forms.ComboBox cbGuardianCopyFrom;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblCopyTermPostalAdd;
        private System.Windows.Forms.GroupBox gbContactDetails;
        private System.Windows.Forms.TextBox txtKinEmail;
        private System.Windows.Forms.Label lblKinEmail;
        private System.Windows.Forms.TextBox txtKinCell;
        private System.Windows.Forms.Label lblKinCell;
        private System.Windows.Forms.TextBox txtKinFax;
        private System.Windows.Forms.Label lblKinFax;
        private System.Windows.Forms.TextBox txtKinTel;
        private System.Windows.Forms.Label lblKinTel;
        private System.Windows.Forms.BindingSource bsAdmStudent;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}

namespace Admissions.AdmissionForms
{
    partial class AccountPayer
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
            this.gbSameAsStudent = new System.Windows.Forms.GroupBox();
            this.txtIdNumber = new System.Windows.Forms.TextBox();
            this.lblIdNumber = new System.Windows.Forms.Label();
            this.ckStudentPaying = new System.Windows.Forms.CheckBox();
            this.gbAccountPayer = new System.Windows.Forms.GroupBox();
            this.cb_fee_verified = new System.Windows.Forms.CheckBox();
            this.btnCopyToAccountPayer = new System.Windows.Forms.Button();
            this.cbAccountPayerCopyFrom = new System.Windows.Forms.ComboBox();
            this.lblCopyAccPayerAdd = new System.Windows.Forms.Label();
            this.lblCopyFromLine = new System.Windows.Forms.Label();
            this.txtFeePayerId = new System.Windows.Forms.TextBox();
            this.bsAdmStudent = new System.Windows.Forms.BindingSource(this.components);
            this.lblFeePayerId = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtFaxNo = new System.Windows.Forms.TextBox();
            this.lblFax = new System.Windows.Forms.Label();
            this.lblCell = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtCell = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtPostalCode = new System.Windows.Forms.TextBox();
            this.txtAddress5 = new System.Windows.Forms.TextBox();
            this.txtAddress4 = new System.Windows.Forms.TextBox();
            this.txtAddress3 = new System.Windows.Forms.TextBox();
            this.txtAddress2 = new System.Windows.Forms.TextBox();
            this.txtAddress1 = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.lblSurname = new System.Windows.Forms.Label();
            this.txtInitials = new System.Windows.Forms.TextBox();
            this.lblInitials = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblTitile = new System.Windows.Forms.Label();
            this.lblEmpNo = new System.Windows.Forms.Label();
            this.txtEmpNo = new System.Windows.Forms.TextBox();
            this.ckStaffRebate = new System.Windows.Forms.CheckBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbStaffRebates = new System.Windows.Forms.GroupBox();
            this.gbSameAsStudent.SuspendLayout();
            this.gbAccountPayer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsAdmStudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.gbStaffRebates.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(358, 24);
            this.lblTitle.TabIndex = 9;
            this.lblTitle.Text = "Account Payer Details";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // gbSameAsStudent
            // 
            this.gbSameAsStudent.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gbSameAsStudent.Controls.Add(this.txtIdNumber);
            this.gbSameAsStudent.Controls.Add(this.lblIdNumber);
            this.gbSameAsStudent.Controls.Add(this.ckStudentPaying);
            this.gbSameAsStudent.Location = new System.Drawing.Point(4, 27);
            this.gbSameAsStudent.Name = "gbSameAsStudent";
            this.gbSameAsStudent.Size = new System.Drawing.Size(347, 75);
            this.gbSameAsStudent.TabIndex = 1;
            this.gbSameAsStudent.TabStop = false;
            this.gbSameAsStudent.Text = "Same as Student";
            // 
            // txtIdNumber
            // 
            this.txtIdNumber.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtIdNumber.Enabled = false;
            this.txtIdNumber.Location = new System.Drawing.Point(69, 46);
            this.txtIdNumber.Name = "txtIdNumber";
            this.txtIdNumber.Size = new System.Drawing.Size(138, 20);
            this.txtIdNumber.TabIndex = 3;
            this.txtIdNumber.GotFocus += new System.EventHandler(this.txtIdNumber_GotFocus);
            // 
            // lblIdNumber
            // 
            this.lblIdNumber.AutoSize = true;
            this.lblIdNumber.Enabled = false;
            this.lblIdNumber.Location = new System.Drawing.Point(7, 49);
            this.lblIdNumber.Name = "lblIdNumber";
            this.lblIdNumber.Size = new System.Drawing.Size(56, 13);
            this.lblIdNumber.TabIndex = 2;
            this.lblIdNumber.Text = "Id Number";
            // 
            // ckStudentPaying
            // 
            this.ckStudentPaying.AutoSize = true;
            this.ckStudentPaying.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ckStudentPaying.Location = new System.Drawing.Point(6, 23);
            this.ckStudentPaying.Name = "ckStudentPaying";
            this.ckStudentPaying.Size = new System.Drawing.Size(201, 17);
            this.ckStudentPaying.TabIndex = 1;
            this.ckStudentPaying.Text = "Is student paying the account (Y/N)?";
            this.ckStudentPaying.UseVisualStyleBackColor = true;
            this.ckStudentPaying.CheckedChanged += new System.EventHandler(this.ckResidenceRequired_CheckedChanged);
            // 
            // gbAccountPayer
            // 
            this.gbAccountPayer.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gbAccountPayer.Controls.Add(this.cb_fee_verified);
            this.gbAccountPayer.Controls.Add(this.btnCopyToAccountPayer);
            this.gbAccountPayer.Controls.Add(this.cbAccountPayerCopyFrom);
            this.gbAccountPayer.Controls.Add(this.lblCopyAccPayerAdd);
            this.gbAccountPayer.Controls.Add(this.lblCopyFromLine);
            this.gbAccountPayer.Controls.Add(this.txtFeePayerId);
            this.gbAccountPayer.Controls.Add(this.lblFeePayerId);
            this.gbAccountPayer.Controls.Add(this.txtEmail);
            this.gbAccountPayer.Controls.Add(this.lblEmail);
            this.gbAccountPayer.Controls.Add(this.txtFaxNo);
            this.gbAccountPayer.Controls.Add(this.lblFax);
            this.gbAccountPayer.Controls.Add(this.lblCell);
            this.gbAccountPayer.Controls.Add(this.txtPhone);
            this.gbAccountPayer.Controls.Add(this.txtCell);
            this.gbAccountPayer.Controls.Add(this.lblPhone);
            this.gbAccountPayer.Controls.Add(this.txtPostalCode);
            this.gbAccountPayer.Controls.Add(this.txtAddress5);
            this.gbAccountPayer.Controls.Add(this.txtAddress4);
            this.gbAccountPayer.Controls.Add(this.txtAddress3);
            this.gbAccountPayer.Controls.Add(this.txtAddress2);
            this.gbAccountPayer.Controls.Add(this.txtAddress1);
            this.gbAccountPayer.Controls.Add(this.lblAddress);
            this.gbAccountPayer.Controls.Add(this.txtSurname);
            this.gbAccountPayer.Controls.Add(this.lblSurname);
            this.gbAccountPayer.Controls.Add(this.txtInitials);
            this.gbAccountPayer.Controls.Add(this.lblInitials);
            this.gbAccountPayer.Controls.Add(this.txtTitle);
            this.gbAccountPayer.Controls.Add(this.lblTitile);
            this.gbAccountPayer.Location = new System.Drawing.Point(4, 109);
            this.gbAccountPayer.Name = "gbAccountPayer";
            this.gbAccountPayer.Size = new System.Drawing.Size(347, 422);
            this.gbAccountPayer.TabIndex = 2;
            this.gbAccountPayer.TabStop = false;
            this.gbAccountPayer.Text = "Account Payer Details";
            // 
            // cb_fee_verified
            // 
            this.cb_fee_verified.AutoSize = true;
            this.cb_fee_verified.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cb_fee_verified.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bsAdmStudent, "FEE_PAYER_VERIFIED", true));
            this.cb_fee_verified.Location = new System.Drawing.Point(6, 399);
            this.cb_fee_verified.Name = "cb_fee_verified";
            this.cb_fee_verified.Size = new System.Drawing.Size(234, 17);
            this.cb_fee_verified.TabIndex = 31;
            this.cb_fee_verified.Text = "Has the fee payer information been verified?";
            this.cb_fee_verified.UseVisualStyleBackColor = true;
            // 
            // btnCopyToAccountPayer
            // 
            this.btnCopyToAccountPayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCopyToAccountPayer.Location = new System.Drawing.Point(266, 122);
            this.btnCopyToAccountPayer.Name = "btnCopyToAccountPayer";
            this.btnCopyToAccountPayer.Size = new System.Drawing.Size(75, 23);
            this.btnCopyToAccountPayer.TabIndex = 11;
            this.btnCopyToAccountPayer.Text = "Copy";
            this.btnCopyToAccountPayer.UseVisualStyleBackColor = true;
            this.btnCopyToAccountPayer.Click += new System.EventHandler(this.btnCopyToAccountPayer_Click);
            // 
            // cbAccountPayerCopyFrom
            // 
            this.cbAccountPayerCopyFrom.DisplayMember = "Description";
            this.cbAccountPayerCopyFrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAccountPayerCopyFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAccountPayerCopyFrom.FormattingEnabled = true;
            this.cbAccountPayerCopyFrom.Location = new System.Drawing.Point(112, 124);
            this.cbAccountPayerCopyFrom.Name = "cbAccountPayerCopyFrom";
            this.cbAccountPayerCopyFrom.Size = new System.Drawing.Size(132, 21);
            this.cbAccountPayerCopyFrom.TabIndex = 10;
            this.cbAccountPayerCopyFrom.ValueMember = "Id";
            this.cbAccountPayerCopyFrom.SelectedIndexChanged += new System.EventHandler(this.cbAccountPayerCopyFrom_SelectedIndexChanged);
            // 
            // lblCopyAccPayerAdd
            // 
            this.lblCopyAccPayerAdd.AutoSize = true;
            this.lblCopyAccPayerAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCopyAccPayerAdd.Location = new System.Drawing.Point(5, 127);
            this.lblCopyAccPayerAdd.Name = "lblCopyAccPayerAdd";
            this.lblCopyAccPayerAdd.Size = new System.Drawing.Size(101, 13);
            this.lblCopyAccPayerAdd.TabIndex = 30;
            this.lblCopyAccPayerAdd.Text = "Copy Address From:";
            // 
            // lblCopyFromLine
            // 
            this.lblCopyFromLine.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCopyFromLine.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCopyFromLine.Location = new System.Drawing.Point(6, 148);
            this.lblCopyFromLine.Name = "lblCopyFromLine";
            this.lblCopyFromLine.Size = new System.Drawing.Size(335, 2);
            this.lblCopyFromLine.TabIndex = 29;
            // 
            // txtFeePayerId
            // 
            this.txtFeePayerId.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtFeePayerId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsAdmStudent, "FEES_ID", true));
            this.txtFeePayerId.Location = new System.Drawing.Point(69, 81);
            this.txtFeePayerId.Name = "txtFeePayerId";
            this.txtFeePayerId.Size = new System.Drawing.Size(245, 20);
            this.txtFeePayerId.TabIndex = 8;
            this.txtFeePayerId.GotFocus += new System.EventHandler(this.txtFeePayerId_GotFocus);
            // 
            // bsAdmStudent
            // 
            this.bsAdmStudent.DataMember = "TT_ADM_STU";
            this.bsAdmStudent.DataSource = typeof(NS_Admissions.StrongTypesNS.DS_ADM_STUDataSet);
            // 
            // lblFeePayerId
            // 
            this.lblFeePayerId.AutoSize = true;
            this.lblFeePayerId.Location = new System.Drawing.Point(7, 84);
            this.lblFeePayerId.Name = "lblFeePayerId";
            this.lblFeePayerId.Size = new System.Drawing.Size(56, 13);
            this.lblFeePayerId.TabIndex = 27;
            this.lblFeePayerId.Text = "Id Number";
            // 
            // txtEmail
            // 
            this.txtEmail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsAdmStudent, "ACCT_EMAIL", true));
            this.txtEmail.Location = new System.Drawing.Point(69, 359);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(245, 20);
            this.txtEmail.TabIndex = 26;
            this.txtEmail.GotFocus += new System.EventHandler(this.txtEmail_GotFocus);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(7, 362);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 22;
            this.lblEmail.Text = "Email";
            // 
            // txtFaxNo
            // 
            this.txtFaxNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtFaxNo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsAdmStudent, "ACCT_FAX", true));
            this.txtFaxNo.Location = new System.Drawing.Point(69, 333);
            this.txtFaxNo.Name = "txtFaxNo";
            this.txtFaxNo.Size = new System.Drawing.Size(85, 20);
            this.txtFaxNo.TabIndex = 24;
            this.txtFaxNo.GotFocus += new System.EventHandler(this.txtFaxNo_GotFocus);
            // 
            // lblFax
            // 
            this.lblFax.AutoSize = true;
            this.lblFax.Location = new System.Drawing.Point(7, 333);
            this.lblFax.Name = "lblFax";
            this.lblFax.Size = new System.Drawing.Size(44, 13);
            this.lblFax.TabIndex = 20;
            this.lblFax.Text = "Fax No.";
            // 
            // lblCell
            // 
            this.lblCell.AutoSize = true;
            this.lblCell.Location = new System.Drawing.Point(179, 310);
            this.lblCell.Name = "lblCell";
            this.lblCell.Size = new System.Drawing.Size(44, 13);
            this.lblCell.TabIndex = 19;
            this.lblCell.Text = "Cell No.";
            // 
            // txtPhone
            // 
            this.txtPhone.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPhone.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsAdmStudent, "ACCT_PHONE", true));
            this.txtPhone.Location = new System.Drawing.Point(69, 307);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(85, 20);
            this.txtPhone.TabIndex = 20;
            this.txtPhone.GotFocus += new System.EventHandler(this.txtPhone_GotFocus);
            // 
            // txtCell
            // 
            this.txtCell.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCell.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsAdmStudent, "ACCT_CELL", true));
            this.txtCell.Location = new System.Drawing.Point(229, 307);
            this.txtCell.Name = "txtCell";
            this.txtCell.Size = new System.Drawing.Size(85, 20);
            this.txtCell.TabIndex = 22;
            this.txtCell.GotFocus += new System.EventHandler(this.txtCell_GotFocus);
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(7, 310);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(58, 13);
            this.lblPhone.TabIndex = 16;
            this.lblPhone.Text = "Phone No.";
            // 
            // txtPostalCode
            // 
            this.txtPostalCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPostalCode.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsAdmStudent, "ACCT_POST", true));
            this.txtPostalCode.Location = new System.Drawing.Point(69, 281);
            this.txtPostalCode.Name = "txtPostalCode";
            this.txtPostalCode.Size = new System.Drawing.Size(85, 20);
            this.txtPostalCode.TabIndex = 18;
            this.txtPostalCode.GotFocus += new System.EventHandler(this.txtPostalCode_GotFocus);
            // 
            // txtAddress5
            // 
            this.txtAddress5.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtAddress5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsAdmStudent, "ACCT_ADDR5", true));
            this.txtAddress5.Location = new System.Drawing.Point(69, 257);
            this.txtAddress5.Name = "txtAddress5";
            this.txtAddress5.Size = new System.Drawing.Size(245, 20);
            this.txtAddress5.TabIndex = 17;
            this.txtAddress5.GotFocus += new System.EventHandler(this.txtAddress5_GotFocus);
            // 
            // txtAddress4
            // 
            this.txtAddress4.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtAddress4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsAdmStudent, "ACCT_ADDR4", true));
            this.txtAddress4.Location = new System.Drawing.Point(69, 231);
            this.txtAddress4.Name = "txtAddress4";
            this.txtAddress4.Size = new System.Drawing.Size(245, 20);
            this.txtAddress4.TabIndex = 16;
            this.txtAddress4.GotFocus += new System.EventHandler(this.txtAddress4_GotFocus);
            // 
            // txtAddress3
            // 
            this.txtAddress3.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtAddress3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsAdmStudent, "ACCT_ADDR3", true));
            this.txtAddress3.Location = new System.Drawing.Point(69, 205);
            this.txtAddress3.Name = "txtAddress3";
            this.txtAddress3.Size = new System.Drawing.Size(245, 20);
            this.txtAddress3.TabIndex = 15;
            this.txtAddress3.GotFocus += new System.EventHandler(this.txtAddress3_GotFocus);
            // 
            // txtAddress2
            // 
            this.txtAddress2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtAddress2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsAdmStudent, "ACCT_ADDR2", true));
            this.txtAddress2.Location = new System.Drawing.Point(69, 179);
            this.txtAddress2.Name = "txtAddress2";
            this.txtAddress2.Size = new System.Drawing.Size(245, 20);
            this.txtAddress2.TabIndex = 14;
            this.txtAddress2.GotFocus += new System.EventHandler(this.txtAddress2_GotFocus);
            // 
            // txtAddress1
            // 
            this.txtAddress1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtAddress1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsAdmStudent, "ACCT_ADDR1", true));
            this.txtAddress1.Location = new System.Drawing.Point(69, 153);
            this.txtAddress1.Name = "txtAddress1";
            this.txtAddress1.Size = new System.Drawing.Size(245, 20);
            this.txtAddress1.TabIndex = 13;
            this.txtAddress1.GotFocus += new System.EventHandler(this.txtAddress1_GotFocus);
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(7, 156);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(45, 13);
            this.lblAddress.TabIndex = 9;
            this.lblAddress.Text = "Address";
            // 
            // txtSurname
            // 
            this.txtSurname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSurname.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsAdmStudent, "ACCT_SURN", true));
            this.txtSurname.Location = new System.Drawing.Point(69, 55);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(245, 20);
            this.txtSurname.TabIndex = 6;
            this.txtSurname.GotFocus += new System.EventHandler(this.txtSurname_GotFocus);
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(7, 58);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(49, 13);
            this.lblSurname.TabIndex = 7;
            this.lblSurname.Text = "Surname";
            // 
            // txtInitials
            // 
            this.txtInitials.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtInitials.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsAdmStudent, "ACCT_INIT", true));
            this.txtInitials.Location = new System.Drawing.Point(213, 29);
            this.txtInitials.Name = "txtInitials";
            this.txtInitials.Size = new System.Drawing.Size(101, 20);
            this.txtInitials.TabIndex = 4;
            this.txtInitials.GotFocus += new System.EventHandler(this.txtInitials_GotFocus);
            // 
            // lblInitials
            // 
            this.lblInitials.AutoSize = true;
            this.lblInitials.Location = new System.Drawing.Point(171, 32);
            this.lblInitials.Name = "lblInitials";
            this.lblInitials.Size = new System.Drawing.Size(36, 13);
            this.lblInitials.TabIndex = 5;
            this.lblInitials.Text = "Initials";
            // 
            // txtTitle
            // 
            this.txtTitle.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTitle.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsAdmStudent, "ACCT_TITLE", true));
            this.txtTitle.Location = new System.Drawing.Point(69, 29);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(85, 20);
            this.txtTitle.TabIndex = 2;
            this.txtTitle.GotFocus += new System.EventHandler(this.txtTitle_GotFocus);
            // 
            // lblTitile
            // 
            this.lblTitile.AutoSize = true;
            this.lblTitile.Location = new System.Drawing.Point(7, 32);
            this.lblTitile.Name = "lblTitile";
            this.lblTitile.Size = new System.Drawing.Size(27, 13);
            this.lblTitile.TabIndex = 3;
            this.lblTitile.Text = "Title";
            // 
            // lblEmpNo
            // 
            this.lblEmpNo.AutoSize = true;
            this.lblEmpNo.Location = new System.Drawing.Point(175, 25);
            this.lblEmpNo.Name = "lblEmpNo";
            this.lblEmpNo.Size = new System.Drawing.Size(48, 13);
            this.lblEmpNo.TabIndex = 26;
            this.lblEmpNo.Text = "Emp No.";
            // 
            // txtEmpNo
            // 
            this.txtEmpNo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsAdmStudent, "EMP_NO", true));
            this.txtEmpNo.Location = new System.Drawing.Point(229, 21);
            this.txtEmpNo.Name = "txtEmpNo";
            this.txtEmpNo.Size = new System.Drawing.Size(85, 20);
            this.txtEmpNo.TabIndex = 30;
            // 
            // ckStaffRebate
            // 
            this.ckStaffRebate.AutoSize = true;
            this.ckStaffRebate.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ckStaffRebate.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bsAdmStudent, "STAFF", true));
            this.ckStaffRebate.Location = new System.Drawing.Point(6, 23);
            this.ckStaffRebate.Name = "ckStaffRebate";
            this.ckStaffRebate.Size = new System.Drawing.Size(121, 17);
            this.ckStaffRebate.TabIndex = 28;
            this.ckStaffRebate.Text = "Staff Rebate (Y/N)?";
            this.ckStaffRebate.UseVisualStyleBackColor = true;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // gbStaffRebates
            // 
            this.gbStaffRebates.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gbStaffRebates.Controls.Add(this.ckStaffRebate);
            this.gbStaffRebates.Controls.Add(this.txtEmpNo);
            this.gbStaffRebates.Controls.Add(this.lblEmpNo);
            this.gbStaffRebates.Enabled = false;
            this.gbStaffRebates.Location = new System.Drawing.Point(4, 537);
            this.gbStaffRebates.Name = "gbStaffRebates";
            this.gbStaffRebates.Size = new System.Drawing.Size(347, 54);
            this.gbStaffRebates.TabIndex = 10;
            this.gbStaffRebates.TabStop = false;
            this.gbStaffRebates.Text = "Staff Rebates";
            // 
            // AccountPayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.gbStaffRebates);
            this.Controls.Add(this.gbAccountPayer);
            this.Controls.Add(this.gbSameAsStudent);
            this.Controls.Add(this.lblTitle);
            this.Name = "AccountPayer";
            this.Size = new System.Drawing.Size(358, 597);
            this.gbSameAsStudent.ResumeLayout(false);
            this.gbSameAsStudent.PerformLayout();
            this.gbAccountPayer.ResumeLayout(false);
            this.gbAccountPayer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsAdmStudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.gbStaffRebates.ResumeLayout(false);
            this.gbStaffRebates.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox gbSameAsStudent;
        private System.Windows.Forms.TextBox txtIdNumber;
        private System.Windows.Forms.Label lblIdNumber;
        private System.Windows.Forms.CheckBox ckStudentPaying;
        private System.Windows.Forms.GroupBox gbAccountPayer;
        private System.Windows.Forms.Label lblEmpNo;
        private System.Windows.Forms.TextBox txtEmpNo;
        private System.Windows.Forms.CheckBox ckStaffRebate;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtFaxNo;
        private System.Windows.Forms.Label lblFax;
        private System.Windows.Forms.Label lblCell;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtCell;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtPostalCode;
        private System.Windows.Forms.TextBox txtAddress5;
        private System.Windows.Forms.TextBox txtAddress4;
        private System.Windows.Forms.TextBox txtAddress3;
        private System.Windows.Forms.TextBox txtAddress2;
        private System.Windows.Forms.TextBox txtAddress1;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.TextBox txtInitials;
        private System.Windows.Forms.Label lblInitials;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lblTitile;
        private System.Windows.Forms.TextBox txtFeePayerId;
        private System.Windows.Forms.Label lblFeePayerId;
        private System.Windows.Forms.BindingSource bsAdmStudent;
        private System.Windows.Forms.Label lblCopyFromLine;
        private System.Windows.Forms.Button btnCopyToAccountPayer;
        private System.Windows.Forms.ComboBox cbAccountPayerCopyFrom;
        private System.Windows.Forms.Label lblCopyAccPayerAdd;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.GroupBox gbStaffRebates;
        private System.Windows.Forms.CheckBox cb_fee_verified;
    }
}

namespace Admissions.AdmissionForms.Undergraduate
{
    partial class AcceptanceOffer
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.bs_studentoffer = new System.Windows.Forms.BindingSource(this.components);
            this.txtstuno = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.gpbxAddress = new System.Windows.Forms.GroupBox();
            this.txtAccAddr5 = new System.Windows.Forms.TextBox();
            this.txtAccAddr4 = new System.Windows.Forms.TextBox();
            this.txtAccAddr3 = new System.Windows.Forms.TextBox();
            this.txtAccAddr2 = new System.Windows.Forms.TextBox();
            this.txtAccPost = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtAccAddr1 = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.gpbxKin = new System.Windows.Forms.GroupBox();
            this.txtKinAddr5 = new System.Windows.Forms.TextBox();
            this.txtKinAddr4 = new System.Windows.Forms.TextBox();
            this.txtKinAddr3 = new System.Windows.Forms.TextBox();
            this.txtKinAddr2 = new System.Windows.Forms.TextBox();
            this.txtKinPost = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtKinAddr1 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtMatNum = new System.Windows.Forms.TextBox();
            this.txtCell = new System.Windows.Forms.TextBox();
            this.txtDegr = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSurn = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.chkID = new System.Windows.Forms.CheckBox();
            this.chkform = new System.Windows.Forms.CheckBox();
            this.gpbxMedAid = new System.Windows.Forms.GroupBox();
            this.txtMANum = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtMAName = new System.Windows.Forms.TextBox();
            this.txtMAPlan = new System.Windows.Forms.TextBox();
            this.txtPrincipal = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bs_studentoffer)).BeginInit();
            this.pnlMain.SuspendLayout();
            this.gpbxAddress.SuspendLayout();
            this.gpbxKin.SuspendLayout();
            this.gpbxMedAid.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label1.Location = new System.Drawing.Point(46, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student Number: ";
            // 
            // bs_studentoffer
            // 
            this.bs_studentoffer.DataSource = typeof(NS_Admissions.StrongTypesNS.ds_stuofferDataSet.tt_stu_offerDataTable);
            // 
            // txtstuno
            // 
            this.txtstuno.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs_studentoffer, "stuno", true));
            this.txtstuno.Location = new System.Drawing.Point(140, 18);
            this.txtstuno.Name = "txtstuno";
            this.txtstuno.Size = new System.Drawing.Size(175, 20);
            this.txtstuno.TabIndex = 1;
            this.txtstuno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtstuno_KeyPress);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(174, 683);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 80;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(272, 683);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 85;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(323, 16);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(32, 23);
            this.btnSearch.TabIndex = 10;
            this.btnSearch.Text = "...";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(370, 683);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 90;
            this.btnExit.Text = "Close";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pnlMain
            // 
            this.pnlMain.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlMain.Controls.Add(this.gpbxAddress);
            this.pnlMain.Controls.Add(this.gpbxKin);
            this.pnlMain.Controls.Add(this.txtMatNum);
            this.pnlMain.Controls.Add(this.txtCell);
            this.pnlMain.Controls.Add(this.txtDegr);
            this.pnlMain.Controls.Add(this.txtName);
            this.pnlMain.Controls.Add(this.txtSurn);
            this.pnlMain.Controls.Add(this.txtID);
            this.pnlMain.Controls.Add(this.chkID);
            this.pnlMain.Controls.Add(this.chkform);
            this.pnlMain.Controls.Add(this.gpbxMedAid);
            this.pnlMain.Controls.Add(this.label9);
            this.pnlMain.Controls.Add(this.label8);
            this.pnlMain.Controls.Add(this.label7);
            this.pnlMain.Controls.Add(this.label6);
            this.pnlMain.Controls.Add(this.label5);
            this.pnlMain.Controls.Add(this.label4);
            this.pnlMain.Controls.Add(this.label3);
            this.pnlMain.Controls.Add(this.label2);
            this.pnlMain.Location = new System.Drawing.Point(1, 44);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(622, 633);
            this.pnlMain.TabIndex = 321;
            // 
            // gpbxAddress
            // 
            this.gpbxAddress.Controls.Add(this.txtAccAddr5);
            this.gpbxAddress.Controls.Add(this.txtAccAddr4);
            this.gpbxAddress.Controls.Add(this.txtAccAddr3);
            this.gpbxAddress.Controls.Add(this.txtAccAddr2);
            this.gpbxAddress.Controls.Add(this.txtAccPost);
            this.gpbxAddress.Controls.Add(this.label16);
            this.gpbxAddress.Controls.Add(this.txtAccAddr1);
            this.gpbxAddress.Controls.Add(this.label17);
            this.gpbxAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.gpbxAddress.Location = new System.Drawing.Point(312, 391);
            this.gpbxAddress.Name = "gpbxAddress";
            this.gpbxAddress.Size = new System.Drawing.Size(293, 232);
            this.gpbxAddress.TabIndex = 70;
            this.gpbxAddress.TabStop = false;
            this.gpbxAddress.Text = "Account Address";
            // 
            // txtAccAddr5
            // 
            this.txtAccAddr5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs_studentoffer, "acct_addr5", true));
            this.txtAccAddr5.Location = new System.Drawing.Point(103, 165);
            this.txtAccAddr5.Name = "txtAccAddr5";
            this.txtAccAddr5.Size = new System.Drawing.Size(175, 20);
            this.txtAccAddr5.TabIndex = 75;
            // 
            // txtAccAddr4
            // 
            this.txtAccAddr4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs_studentoffer, "acct_addr4", true));
            this.txtAccAddr4.Location = new System.Drawing.Point(103, 134);
            this.txtAccAddr4.Name = "txtAccAddr4";
            this.txtAccAddr4.Size = new System.Drawing.Size(175, 20);
            this.txtAccAddr4.TabIndex = 74;
            // 
            // txtAccAddr3
            // 
            this.txtAccAddr3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs_studentoffer, "acct_addr3", true));
            this.txtAccAddr3.Location = new System.Drawing.Point(103, 103);
            this.txtAccAddr3.Name = "txtAccAddr3";
            this.txtAccAddr3.Size = new System.Drawing.Size(175, 20);
            this.txtAccAddr3.TabIndex = 73;
            // 
            // txtAccAddr2
            // 
            this.txtAccAddr2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs_studentoffer, "acct_addr2", true));
            this.txtAccAddr2.Location = new System.Drawing.Point(103, 72);
            this.txtAccAddr2.Name = "txtAccAddr2";
            this.txtAccAddr2.Size = new System.Drawing.Size(175, 20);
            this.txtAccAddr2.TabIndex = 72;
            // 
            // txtAccPost
            // 
            this.txtAccPost.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs_studentoffer, "acct_post", true));
            this.txtAccPost.Location = new System.Drawing.Point(103, 196);
            this.txtAccPost.Name = "txtAccPost";
            this.txtAccPost.Size = new System.Drawing.Size(175, 20);
            this.txtAccPost.TabIndex = 76;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(66, 199);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(31, 13);
            this.label16.TabIndex = 26;
            this.label16.Text = "Post:";
            // 
            // txtAccAddr1
            // 
            this.txtAccAddr1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs_studentoffer, "acct_addr1", true));
            this.txtAccAddr1.Location = new System.Drawing.Point(103, 41);
            this.txtAccAddr1.Name = "txtAccAddr1";
            this.txtAccAddr1.Size = new System.Drawing.Size(175, 20);
            this.txtAccAddr1.TabIndex = 71;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 44);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(91, 13);
            this.label17.TabIndex = 24;
            this.label17.Text = "Account Address:";
            // 
            // gpbxKin
            // 
            this.gpbxKin.Controls.Add(this.txtKinAddr5);
            this.gpbxKin.Controls.Add(this.txtKinAddr4);
            this.gpbxKin.Controls.Add(this.txtKinAddr3);
            this.gpbxKin.Controls.Add(this.txtKinAddr2);
            this.gpbxKin.Controls.Add(this.txtKinPost);
            this.gpbxKin.Controls.Add(this.label15);
            this.gpbxKin.Controls.Add(this.txtKinAddr1);
            this.gpbxKin.Controls.Add(this.label14);
            this.gpbxKin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.gpbxKin.Location = new System.Drawing.Point(18, 391);
            this.gpbxKin.Name = "gpbxKin";
            this.gpbxKin.Size = new System.Drawing.Size(270, 232);
            this.gpbxKin.TabIndex = 60;
            this.gpbxKin.TabStop = false;
            this.gpbxKin.Text = "Next-of-Kin Address - No Post Boxes";
            // 
            // txtKinAddr5
            // 
            this.txtKinAddr5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs_studentoffer, "kin_addr5", true));
            this.txtKinAddr5.Location = new System.Drawing.Point(74, 161);
            this.txtKinAddr5.Name = "txtKinAddr5";
            this.txtKinAddr5.Size = new System.Drawing.Size(175, 20);
            this.txtKinAddr5.TabIndex = 65;
            // 
            // txtKinAddr4
            // 
            this.txtKinAddr4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs_studentoffer, "kin_addr4", true));
            this.txtKinAddr4.Location = new System.Drawing.Point(74, 131);
            this.txtKinAddr4.Name = "txtKinAddr4";
            this.txtKinAddr4.Size = new System.Drawing.Size(175, 20);
            this.txtKinAddr4.TabIndex = 64;
            // 
            // txtKinAddr3
            // 
            this.txtKinAddr3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs_studentoffer, "kin_addr3", true));
            this.txtKinAddr3.Location = new System.Drawing.Point(74, 101);
            this.txtKinAddr3.Name = "txtKinAddr3";
            this.txtKinAddr3.Size = new System.Drawing.Size(175, 20);
            this.txtKinAddr3.TabIndex = 63;
            // 
            // txtKinAddr2
            // 
            this.txtKinAddr2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs_studentoffer, "kin_addr2", true));
            this.txtKinAddr2.Location = new System.Drawing.Point(74, 71);
            this.txtKinAddr2.Name = "txtKinAddr2";
            this.txtKinAddr2.Size = new System.Drawing.Size(175, 20);
            this.txtKinAddr2.TabIndex = 62;
            // 
            // txtKinPost
            // 
            this.txtKinPost.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs_studentoffer, "kin_post", true));
            this.txtKinPost.Location = new System.Drawing.Point(74, 191);
            this.txtKinPost.Name = "txtKinPost";
            this.txtKinPost.Size = new System.Drawing.Size(175, 20);
            this.txtKinPost.TabIndex = 66;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(37, 194);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(31, 13);
            this.label15.TabIndex = 26;
            this.label15.Text = "Post:";
            // 
            // txtKinAddr1
            // 
            this.txtKinAddr1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs_studentoffer, "kin_addr1", true));
            this.txtKinAddr1.Location = new System.Drawing.Point(74, 41);
            this.txtKinAddr1.Name = "txtKinAddr1";
            this.txtKinAddr1.Size = new System.Drawing.Size(175, 20);
            this.txtKinAddr1.TabIndex = 61;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 44);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(62, 13);
            this.label14.TabIndex = 24;
            this.label14.Text = "Next-of-Kin:";
            // 
            // txtMatNum
            // 
            this.txtMatNum.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs_studentoffer, "matnum", true));
            this.txtMatNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtMatNum.Location = new System.Drawing.Point(424, 335);
            this.txtMatNum.Name = "txtMatNum";
            this.txtMatNum.Size = new System.Drawing.Size(175, 20);
            this.txtMatNum.TabIndex = 55;
            // 
            // txtCell
            // 
            this.txtCell.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs_studentoffer, "cell_phone", true));
            this.txtCell.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtCell.Location = new System.Drawing.Point(142, 335);
            this.txtCell.Name = "txtCell";
            this.txtCell.Size = new System.Drawing.Size(175, 20);
            this.txtCell.TabIndex = 50;
            // 
            // txtDegr
            // 
            this.txtDegr.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs_studentoffer, "degr", true));
            this.txtDegr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtDegr.Location = new System.Drawing.Point(142, 114);
            this.txtDegr.Name = "txtDegr";
            this.txtDegr.Size = new System.Drawing.Size(175, 20);
            this.txtDegr.TabIndex = 40;
            // 
            // txtName
            // 
            this.txtName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs_studentoffer, "name1", true));
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtName.Location = new System.Drawing.Point(142, 81);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(175, 20);
            this.txtName.TabIndex = 35;
            this.txtName.TabStop = false;
            // 
            // txtSurn
            // 
            this.txtSurn.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs_studentoffer, "surn", true));
            this.txtSurn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtSurn.Location = new System.Drawing.Point(142, 48);
            this.txtSurn.Name = "txtSurn";
            this.txtSurn.ReadOnly = true;
            this.txtSurn.Size = new System.Drawing.Size(175, 20);
            this.txtSurn.TabIndex = 30;
            this.txtSurn.TabStop = false;
            // 
            // txtID
            // 
            this.txtID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs_studentoffer, "id", true));
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtID.Location = new System.Drawing.Point(424, 10);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(175, 20);
            this.txtID.TabIndex = 25;
            // 
            // chkID
            // 
            this.chkID.AutoSize = true;
            this.chkID.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.bs_studentoffer, "id_verified", true));
            this.chkID.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkID.Location = new System.Drawing.Point(257, 14);
            this.chkID.Name = "chkID";
            this.chkID.Size = new System.Drawing.Size(15, 14);
            this.chkID.TabIndex = 20;
            this.chkID.UseVisualStyleBackColor = true;
            // 
            // chkform
            // 
            this.chkform.AutoSize = true;
            this.chkform.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.bs_studentoffer, "accept_offer", true));
            this.chkform.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkform.Location = new System.Drawing.Point(144, 13);
            this.chkform.Name = "chkform";
            this.chkform.Size = new System.Drawing.Size(15, 14);
            this.chkform.TabIndex = 15;
            this.chkform.UseVisualStyleBackColor = true;
            // 
            // gpbxMedAid
            // 
            this.gpbxMedAid.Controls.Add(this.txtMANum);
            this.gpbxMedAid.Controls.Add(this.label13);
            this.gpbxMedAid.Controls.Add(this.txtMAName);
            this.gpbxMedAid.Controls.Add(this.txtMAPlan);
            this.gpbxMedAid.Controls.Add(this.txtPrincipal);
            this.gpbxMedAid.Controls.Add(this.label10);
            this.gpbxMedAid.Controls.Add(this.label11);
            this.gpbxMedAid.Controls.Add(this.label12);
            this.gpbxMedAid.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.gpbxMedAid.Location = new System.Drawing.Point(18, 154);
            this.gpbxMedAid.Name = "gpbxMedAid";
            this.gpbxMedAid.Size = new System.Drawing.Size(311, 163);
            this.gpbxMedAid.TabIndex = 45;
            this.gpbxMedAid.TabStop = false;
            this.gpbxMedAid.Text = "Medical Aid";
            // 
            // txtMANum
            // 
            this.txtMANum.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs_studentoffer, "med_number", true));
            this.txtMANum.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtMANum.Location = new System.Drawing.Point(117, 125);
            this.txtMANum.Name = "txtMANum";
            this.txtMANum.Size = new System.Drawing.Size(175, 20);
            this.txtMANum.TabIndex = 49;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label13.Location = new System.Drawing.Point(6, 128);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(105, 13);
            this.label13.TabIndex = 24;
            this.label13.Text = "Medical Aid Number:";
            // 
            // txtMAName
            // 
            this.txtMAName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs_studentoffer, "med_name", true));
            this.txtMAName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtMAName.Location = new System.Drawing.Point(117, 93);
            this.txtMAName.Name = "txtMAName";
            this.txtMAName.Size = new System.Drawing.Size(175, 20);
            this.txtMAName.TabIndex = 48;
            // 
            // txtMAPlan
            // 
            this.txtMAPlan.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs_studentoffer, "med_plan", true));
            this.txtMAPlan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtMAPlan.Location = new System.Drawing.Point(117, 61);
            this.txtMAPlan.Name = "txtMAPlan";
            this.txtMAPlan.Size = new System.Drawing.Size(175, 20);
            this.txtMAPlan.TabIndex = 47;
            // 
            // txtPrincipal
            // 
            this.txtPrincipal.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs_studentoffer, "med_principle", true));
            this.txtPrincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtPrincipal.Location = new System.Drawing.Point(117, 29);
            this.txtPrincipal.Name = "txtPrincipal";
            this.txtPrincipal.Size = new System.Drawing.Size(175, 20);
            this.txtPrincipal.TabIndex = 46;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label10.Location = new System.Drawing.Point(15, 96);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Medical Aid Name:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label11.Location = new System.Drawing.Point(22, 64);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(89, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = "Medical Aid Plan:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label12.Location = new System.Drawing.Point(20, 32);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(91, 13);
            this.label12.TabIndex = 18;
            this.label12.Text = "Principal Member:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label9.Location = new System.Drawing.Point(339, 338);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 13);
            this.label9.TabIndex = 238;
            this.label9.Text = "Matric Number:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label8.Location = new System.Drawing.Point(77, 338);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 13);
            this.label8.TabIndex = 237;
            this.label8.Text = "Cell Phone:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label7.Location = new System.Drawing.Point(93, 117);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 236;
            this.label7.Text = "Degree:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label6.Location = new System.Drawing.Point(95, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 235;
            this.label6.Text = "Names:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label5.Location = new System.Drawing.Point(86, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 234;
            this.label5.Text = "Surname:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label4.Location = new System.Drawing.Point(357, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 233;
            this.label4.Text = "ID Number:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label3.Location = new System.Drawing.Point(192, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 232;
            this.label3.Text = "ID Verified:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label2.Location = new System.Drawing.Point(69, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 231;
            this.label2.Text = "Form Signed:";
            // 
            // AcceptanceOffer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(625, 718);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtstuno);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AcceptanceOffer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Capture Acceptance of Offer";
            this.Load += new System.EventHandler(this.AcceptanceOffer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bs_studentoffer)).EndInit();
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.gpbxAddress.ResumeLayout(false);
            this.gpbxAddress.PerformLayout();
            this.gpbxKin.ResumeLayout(false);
            this.gpbxKin.PerformLayout();
            this.gpbxMedAid.ResumeLayout(false);
            this.gpbxMedAid.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtstuno;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.BindingSource bs_studentoffer;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.GroupBox gpbxAddress;
        private System.Windows.Forms.TextBox txtAccAddr5;
        private System.Windows.Forms.TextBox txtAccAddr4;
        private System.Windows.Forms.TextBox txtAccAddr3;
        private System.Windows.Forms.TextBox txtAccAddr2;
        private System.Windows.Forms.TextBox txtAccPost;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtAccAddr1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.GroupBox gpbxKin;
        private System.Windows.Forms.TextBox txtKinAddr5;
        private System.Windows.Forms.TextBox txtKinAddr4;
        private System.Windows.Forms.TextBox txtKinAddr3;
        private System.Windows.Forms.TextBox txtKinAddr2;
        private System.Windows.Forms.TextBox txtKinPost;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtKinAddr1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtMatNum;
        private System.Windows.Forms.TextBox txtCell;
        private System.Windows.Forms.TextBox txtDegr;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSurn;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.CheckBox chkID;
        private System.Windows.Forms.CheckBox chkform;
        private System.Windows.Forms.GroupBox gpbxMedAid;
        private System.Windows.Forms.TextBox txtMANum;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtMAName;
        private System.Windows.Forms.TextBox txtMAPlan;
        private System.Windows.Forms.TextBox txtPrincipal;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}
namespace Admissions.AdmissionForms
{
    partial class StudentDegreeDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentDegreeDetails));
            this.lblTitle = new System.Windows.Forms.Label();
            this.gbProposedReg = new System.Windows.Forms.GroupBox();
            this.btnEntryInfo = new System.Windows.Forms.Button();
            this.cbAcademicStatus = new System.Windows.Forms.ComboBox();
            this.bsAdmStudent = new System.Windows.Forms.BindingSource(this.components);
            this.lblAcadStatus = new System.Windows.Forms.Label();
            this.cbEntryStatus = new System.Windows.Forms.ComboBox();
            this.cbRegStatus = new System.Windows.Forms.ComboBox();
            this.lblEntryStatus = new System.Windows.Forms.Label();
            this.lblRegStatus = new System.Windows.Forms.Label();
            this.btnRemovePossSubj2 = new System.Windows.Forms.Button();
            this.btnAddPossSubj2 = new System.Windows.Forms.Button();
            this.dgvPossibleSubj2 = new System.Windows.Forms.DataGridView();
            this.cPossCode2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPossDescrip2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblPossibleSubj2 = new System.Windows.Forms.Label();
            this.lblDegree2 = new System.Windows.Forms.Label();
            this.cbDeg2 = new System.Windows.Forms.ComboBox();
            this.txtDeg2 = new System.Windows.Forms.TextBox();
            this.btnRemovePossSubj1 = new System.Windows.Forms.Button();
            this.btnAddPossSubj1 = new System.Windows.Forms.Button();
            this.dgvPossibleSubj1 = new System.Windows.Forms.DataGridView();
            this.cPossCode1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPossDescrip1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblPossibleSubj1 = new System.Windows.Forms.Label();
            this.lblDegree1 = new System.Windows.Forms.Label();
            this.cbDeg1 = new System.Windows.Forms.ComboBox();
            this.txtDeg1 = new System.Windows.Forms.TextBox();
            this.bsAdmissions = new System.Windows.Forms.BindingSource(this.components);
            this.gbFirstDegree = new System.Windows.Forms.GroupBox();
            this.gbSecondDegree = new System.Windows.Forms.GroupBox();
            this.pnlProposedRegCheck = new System.Windows.Forms.Panel();
            this.ckProposedReg = new System.Windows.Forms.CheckBox();
            this.pnlFirstDegreeCheck = new System.Windows.Forms.Panel();
            this.ckFirstDegree = new System.Windows.Forms.CheckBox();
            this.pnlSecondDegreeCheck = new System.Windows.Forms.Panel();
            this.ckSecondDegree = new System.Windows.Forms.CheckBox();
            this.gbAdditionalInfo = new System.Windows.Forms.GroupBox();
            this.ckLwaStream2 = new System.Windows.Forms.CheckBox();
            this.ckBComIS = new System.Windows.Forms.CheckBox();
            this.ckMusicProof = new System.Windows.Forms.CheckBox();
            this.ckFineArt = new System.Windows.Forms.CheckBox();
            this.ckLwaStream1 = new System.Windows.Forms.CheckBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbProposedReg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsAdmStudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPossibleSubj2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPossibleSubj1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAdmissions)).BeginInit();
            this.gbFirstDegree.SuspendLayout();
            this.gbSecondDegree.SuspendLayout();
            this.pnlProposedRegCheck.SuspendLayout();
            this.pnlFirstDegreeCheck.SuspendLayout();
            this.pnlSecondDegreeCheck.SuspendLayout();
            this.gbAdditionalInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(578, 24);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "Degree Details";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // gbProposedReg
            // 
            this.gbProposedReg.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gbProposedReg.Controls.Add(this.btnEntryInfo);
            this.gbProposedReg.Controls.Add(this.cbAcademicStatus);
            this.gbProposedReg.Controls.Add(this.lblAcadStatus);
            this.gbProposedReg.Controls.Add(this.cbEntryStatus);
            this.gbProposedReg.Controls.Add(this.cbRegStatus);
            this.gbProposedReg.Controls.Add(this.lblEntryStatus);
            this.gbProposedReg.Controls.Add(this.lblRegStatus);
            this.gbProposedReg.Location = new System.Drawing.Point(4, 40);
            this.gbProposedReg.Name = "gbProposedReg";
            this.gbProposedReg.Size = new System.Drawing.Size(539, 82);
            this.gbProposedReg.TabIndex = 5;
            this.gbProposedReg.TabStop = false;
            this.gbProposedReg.Text = "Proposed Registration";
            // 
            // btnEntryInfo
            // 
            this.btnEntryInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEntryInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEntryInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEntryInfo.FlatAppearance.BorderSize = 0;
            this.btnEntryInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntryInfo.Image = ((System.Drawing.Image)(resources.GetObject("btnEntryInfo.Image")));
            this.btnEntryInfo.Location = new System.Drawing.Point(514, 49);
            this.btnEntryInfo.Name = "btnEntryInfo";
            this.btnEntryInfo.Size = new System.Drawing.Size(19, 19);
            this.btnEntryInfo.TabIndex = 32;
            this.btnEntryInfo.UseVisualStyleBackColor = true;
            this.btnEntryInfo.Click += new System.EventHandler(this.btnEntryInfo_Click);
            // 
            // cbAcademicStatus
            // 
            this.cbAcademicStatus.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsAdmStudent, "ACAD_STAT", true));
            this.cbAcademicStatus.DisplayMember = "Description";
            this.cbAcademicStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAcademicStatus.FormattingEnabled = true;
            this.cbAcademicStatus.Location = new System.Drawing.Point(383, 22);
            this.cbAcademicStatus.Name = "cbAcademicStatus";
            this.cbAcademicStatus.Size = new System.Drawing.Size(123, 21);
            this.cbAcademicStatus.TabIndex = 11;
            this.cbAcademicStatus.ValueMember = "Id";
            // 
            // bsAdmStudent
            // 
            this.bsAdmStudent.DataMember = "TT_ADM_STU";
            this.bsAdmStudent.DataSource = typeof(NS_Admissions.StrongTypesNS.DS_ADM_STUDataSet);
            // 
            // lblAcadStatus
            // 
            this.lblAcadStatus.AutoSize = true;
            this.lblAcadStatus.Location = new System.Drawing.Point(290, 25);
            this.lblAcadStatus.Name = "lblAcadStatus";
            this.lblAcadStatus.Size = new System.Drawing.Size(87, 13);
            this.lblAcadStatus.TabIndex = 12;
            this.lblAcadStatus.Text = "Academic Status";
            // 
            // cbEntryStatus
            // 
            this.cbEntryStatus.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsAdmStudent, "ENTRY_STAT", true));
            this.cbEntryStatus.DisplayMember = "DESCRIP";
            this.cbEntryStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEntryStatus.FormattingEnabled = true;
            this.cbEntryStatus.Location = new System.Drawing.Point(118, 49);
            this.cbEntryStatus.Name = "cbEntryStatus";
            this.cbEntryStatus.Size = new System.Drawing.Size(388, 21);
            this.cbEntryStatus.TabIndex = 13;
            this.cbEntryStatus.ValueMember = "CODE";
            // 
            // cbRegStatus
            // 
            this.cbRegStatus.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsAdmStudent, "REG_STAT", true));
            this.cbRegStatus.DisplayMember = "DESCRIP";
            this.cbRegStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRegStatus.FormattingEnabled = true;
            this.cbRegStatus.Location = new System.Drawing.Point(118, 22);
            this.cbRegStatus.Name = "cbRegStatus";
            this.cbRegStatus.Size = new System.Drawing.Size(123, 21);
            this.cbRegStatus.TabIndex = 10;
            this.cbRegStatus.ValueMember = "CODE";
            // 
            // lblEntryStatus
            // 
            this.lblEntryStatus.AutoSize = true;
            this.lblEntryStatus.Location = new System.Drawing.Point(6, 52);
            this.lblEntryStatus.Name = "lblEntryStatus";
            this.lblEntryStatus.Size = new System.Drawing.Size(64, 13);
            this.lblEntryStatus.TabIndex = 4;
            this.lblEntryStatus.Text = "Entry Status";
            // 
            // lblRegStatus
            // 
            this.lblRegStatus.AutoSize = true;
            this.lblRegStatus.Location = new System.Drawing.Point(6, 25);
            this.lblRegStatus.Name = "lblRegStatus";
            this.lblRegStatus.Size = new System.Drawing.Size(96, 13);
            this.lblRegStatus.TabIndex = 0;
            this.lblRegStatus.Text = "Registration Status";
            // 
            // btnRemovePossSubj2
            // 
            this.btnRemovePossSubj2.Location = new System.Drawing.Point(448, 154);
            this.btnRemovePossSubj2.Name = "btnRemovePossSubj2";
            this.btnRemovePossSubj2.Size = new System.Drawing.Size(75, 23);
            this.btnRemovePossSubj2.TabIndex = 18;
            this.btnRemovePossSubj2.Text = "Remove";
            this.btnRemovePossSubj2.UseVisualStyleBackColor = true;
            this.btnRemovePossSubj2.Click += new System.EventHandler(this.btnRemovePossSubj2_Click);
            // 
            // btnAddPossSubj2
            // 
            this.btnAddPossSubj2.Location = new System.Drawing.Point(6, 154);
            this.btnAddPossSubj2.Name = "btnAddPossSubj2";
            this.btnAddPossSubj2.Size = new System.Drawing.Size(75, 23);
            this.btnAddPossSubj2.TabIndex = 17;
            this.btnAddPossSubj2.Text = "Add";
            this.btnAddPossSubj2.UseVisualStyleBackColor = true;
            this.btnAddPossSubj2.Click += new System.EventHandler(this.btnAddPossSubj2_Click);
            // 
            // dgvPossibleSubj2
            // 
            this.dgvPossibleSubj2.AllowUserToAddRows = false;
            this.dgvPossibleSubj2.AllowUserToDeleteRows = false;
            this.dgvPossibleSubj2.BackgroundColor = System.Drawing.Color.White;
            this.dgvPossibleSubj2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPossibleSubj2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cPossCode2,
            this.cPossDescrip2});
            this.dgvPossibleSubj2.Location = new System.Drawing.Point(6, 73);
            this.dgvPossibleSubj2.MultiSelect = false;
            this.dgvPossibleSubj2.Name = "dgvPossibleSubj2";
            this.dgvPossibleSubj2.ReadOnly = true;
            this.dgvPossibleSubj2.RowHeadersVisible = false;
            this.dgvPossibleSubj2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPossibleSubj2.Size = new System.Drawing.Size(517, 75);
            this.dgvPossibleSubj2.TabIndex = 16;
            this.dgvPossibleSubj2.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvPossibleSubj2_DataBindingComplete);
            // 
            // cPossCode2
            // 
            this.cPossCode2.DataPropertyName = "code";
            this.cPossCode2.HeaderText = "Code";
            this.cPossCode2.Name = "cPossCode2";
            this.cPossCode2.ReadOnly = true;
            this.cPossCode2.Width = 80;
            // 
            // cPossDescrip2
            // 
            this.cPossDescrip2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cPossDescrip2.DataPropertyName = "descrip";
            this.cPossDescrip2.HeaderText = "Description";
            this.cPossDescrip2.Name = "cPossDescrip2";
            this.cPossDescrip2.ReadOnly = true;
            // 
            // lblPossibleSubj2
            // 
            this.lblPossibleSubj2.AutoSize = true;
            this.lblPossibleSubj2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPossibleSubj2.Location = new System.Drawing.Point(6, 57);
            this.lblPossibleSubj2.Name = "lblPossibleSubj2";
            this.lblPossibleSubj2.Size = new System.Drawing.Size(150, 13);
            this.lblPossibleSubj2.TabIndex = 15;
            this.lblPossibleSubj2.Text = "Possible Subject Choices";
            // 
            // lblDegree2
            // 
            this.lblDegree2.AutoSize = true;
            this.lblDegree2.Location = new System.Drawing.Point(6, 29);
            this.lblDegree2.Name = "lblDegree2";
            this.lblDegree2.Size = new System.Drawing.Size(42, 13);
            this.lblDegree2.TabIndex = 14;
            this.lblDegree2.Text = "Degree";
            // 
            // cbDeg2
            // 
            this.cbDeg2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbDeg2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbDeg2.DisplayMember = "descrip";
            this.cbDeg2.FormattingEnabled = true;
            this.cbDeg2.Location = new System.Drawing.Point(118, 26);
            this.cbDeg2.Name = "cbDeg2";
            this.cbDeg2.Size = new System.Drawing.Size(383, 21);
            this.cbDeg2.TabIndex = 13;
            this.cbDeg2.ValueMember = "degr";
            this.cbDeg2.SelectedIndexChanged += new System.EventHandler(this.cbDeg2_SelectedIndexChanged);
            // 
            // txtDeg2
            // 
            this.txtDeg2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDeg2.Location = new System.Drawing.Point(54, 26);
            this.txtDeg2.Name = "txtDeg2";
            this.txtDeg2.Size = new System.Drawing.Size(58, 20);
            this.txtDeg2.TabIndex = 12;
            this.txtDeg2.GotFocus += new System.EventHandler(this.txtDeg2_GotFocus);
            this.txtDeg2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDeg2_KeyPress);
            this.txtDeg2.Leave += new System.EventHandler(this.txtDeg2_Leave);
            // 
            // btnRemovePossSubj1
            // 
            this.btnRemovePossSubj1.Location = new System.Drawing.Point(448, 154);
            this.btnRemovePossSubj1.Name = "btnRemovePossSubj1";
            this.btnRemovePossSubj1.Size = new System.Drawing.Size(75, 23);
            this.btnRemovePossSubj1.TabIndex = 18;
            this.btnRemovePossSubj1.Text = "Remove";
            this.btnRemovePossSubj1.UseVisualStyleBackColor = true;
            this.btnRemovePossSubj1.Click += new System.EventHandler(this.btnRemovePossSubj1_Click);
            // 
            // btnAddPossSubj1
            // 
            this.btnAddPossSubj1.Location = new System.Drawing.Point(6, 154);
            this.btnAddPossSubj1.Name = "btnAddPossSubj1";
            this.btnAddPossSubj1.Size = new System.Drawing.Size(75, 23);
            this.btnAddPossSubj1.TabIndex = 17;
            this.btnAddPossSubj1.Text = "Add";
            this.btnAddPossSubj1.UseVisualStyleBackColor = true;
            this.btnAddPossSubj1.Click += new System.EventHandler(this.btnAddPossSubj1_Click);
            // 
            // dgvPossibleSubj1
            // 
            this.dgvPossibleSubj1.AllowUserToAddRows = false;
            this.dgvPossibleSubj1.AllowUserToDeleteRows = false;
            this.dgvPossibleSubj1.BackgroundColor = System.Drawing.Color.White;
            this.dgvPossibleSubj1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPossibleSubj1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cPossCode1,
            this.cPossDescrip1});
            this.dgvPossibleSubj1.Location = new System.Drawing.Point(6, 73);
            this.dgvPossibleSubj1.MultiSelect = false;
            this.dgvPossibleSubj1.Name = "dgvPossibleSubj1";
            this.dgvPossibleSubj1.ReadOnly = true;
            this.dgvPossibleSubj1.RowHeadersVisible = false;
            this.dgvPossibleSubj1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPossibleSubj1.Size = new System.Drawing.Size(517, 75);
            this.dgvPossibleSubj1.TabIndex = 16;
            this.dgvPossibleSubj1.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvPossibleSubj1_DataBindingComplete);
            // 
            // cPossCode1
            // 
            this.cPossCode1.DataPropertyName = "code";
            this.cPossCode1.HeaderText = "Code";
            this.cPossCode1.Name = "cPossCode1";
            this.cPossCode1.ReadOnly = true;
            this.cPossCode1.Width = 80;
            // 
            // cPossDescrip1
            // 
            this.cPossDescrip1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cPossDescrip1.DataPropertyName = "descrip";
            this.cPossDescrip1.HeaderText = "Description";
            this.cPossDescrip1.Name = "cPossDescrip1";
            this.cPossDescrip1.ReadOnly = true;
            // 
            // lblPossibleSubj1
            // 
            this.lblPossibleSubj1.AutoSize = true;
            this.lblPossibleSubj1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPossibleSubj1.Location = new System.Drawing.Point(6, 57);
            this.lblPossibleSubj1.Name = "lblPossibleSubj1";
            this.lblPossibleSubj1.Size = new System.Drawing.Size(150, 13);
            this.lblPossibleSubj1.TabIndex = 15;
            this.lblPossibleSubj1.Text = "Possible Subject Choices";
            // 
            // lblDegree1
            // 
            this.lblDegree1.AutoSize = true;
            this.lblDegree1.Location = new System.Drawing.Point(6, 29);
            this.lblDegree1.Name = "lblDegree1";
            this.lblDegree1.Size = new System.Drawing.Size(42, 13);
            this.lblDegree1.TabIndex = 14;
            this.lblDegree1.Text = "Degree";
            // 
            // cbDeg1
            // 
            this.cbDeg1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbDeg1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbDeg1.DisplayMember = "descrip";
            this.cbDeg1.FormattingEnabled = true;
            this.cbDeg1.Location = new System.Drawing.Point(118, 26);
            this.cbDeg1.Name = "cbDeg1";
            this.cbDeg1.Size = new System.Drawing.Size(383, 21);
            this.cbDeg1.TabIndex = 13;
            this.cbDeg1.ValueMember = "degr";
            this.cbDeg1.SelectedIndexChanged += new System.EventHandler(this.cbDeg1_SelectedIndexChanged);
            // 
            // txtDeg1
            // 
            this.txtDeg1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDeg1.Location = new System.Drawing.Point(54, 26);
            this.txtDeg1.Name = "txtDeg1";
            this.txtDeg1.Size = new System.Drawing.Size(58, 20);
            this.txtDeg1.TabIndex = 12;
            this.txtDeg1.GotFocus += new System.EventHandler(this.txtDeg1_GotFocus);
            this.txtDeg1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDeg1_KeyPress);
            this.txtDeg1.Leave += new System.EventHandler(this.txtDeg1_Leave);
            // 
            // bsAdmissions
            // 
            this.bsAdmissions.DataMember = "TT_ADM";
            this.bsAdmissions.DataSource = typeof(NS_Admissions.StrongTypesNS.DS_ADM_STUDataSet);
            // 
            // gbFirstDegree
            // 
            this.gbFirstDegree.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gbFirstDegree.Controls.Add(this.btnRemovePossSubj1);
            this.gbFirstDegree.Controls.Add(this.lblDegree1);
            this.gbFirstDegree.Controls.Add(this.btnAddPossSubj1);
            this.gbFirstDegree.Controls.Add(this.txtDeg1);
            this.gbFirstDegree.Controls.Add(this.dgvPossibleSubj1);
            this.gbFirstDegree.Controls.Add(this.cbDeg1);
            this.gbFirstDegree.Controls.Add(this.lblPossibleSubj1);
            this.gbFirstDegree.Location = new System.Drawing.Point(4, 128);
            this.gbFirstDegree.Name = "gbFirstDegree";
            this.gbFirstDegree.Size = new System.Drawing.Size(539, 186);
            this.gbFirstDegree.TabIndex = 19;
            this.gbFirstDegree.TabStop = false;
            this.gbFirstDegree.Text = "First Degree Choice";
            // 
            // gbSecondDegree
            // 
            this.gbSecondDegree.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gbSecondDegree.Controls.Add(this.btnRemovePossSubj2);
            this.gbSecondDegree.Controls.Add(this.lblDegree2);
            this.gbSecondDegree.Controls.Add(this.btnAddPossSubj2);
            this.gbSecondDegree.Controls.Add(this.txtDeg2);
            this.gbSecondDegree.Controls.Add(this.dgvPossibleSubj2);
            this.gbSecondDegree.Controls.Add(this.cbDeg2);
            this.gbSecondDegree.Controls.Add(this.lblPossibleSubj2);
            this.gbSecondDegree.Location = new System.Drawing.Point(4, 320);
            this.gbSecondDegree.Name = "gbSecondDegree";
            this.gbSecondDegree.Size = new System.Drawing.Size(539, 186);
            this.gbSecondDegree.TabIndex = 20;
            this.gbSecondDegree.TabStop = false;
            this.gbSecondDegree.Text = "Second Degree Choice";
            // 
            // pnlProposedRegCheck
            // 
            this.pnlProposedRegCheck.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnlProposedRegCheck.BackColor = System.Drawing.Color.Purple;
            this.pnlProposedRegCheck.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlProposedRegCheck.Controls.Add(this.ckProposedReg);
            this.pnlProposedRegCheck.Location = new System.Drawing.Point(549, 46);
            this.pnlProposedRegCheck.Name = "pnlProposedRegCheck";
            this.pnlProposedRegCheck.Size = new System.Drawing.Size(25, 25);
            this.pnlProposedRegCheck.TabIndex = 21;
            // 
            // ckProposedReg
            // 
            this.ckProposedReg.AutoSize = true;
            this.ckProposedReg.Location = new System.Drawing.Point(4, 4);
            this.ckProposedReg.Name = "ckProposedReg";
            this.ckProposedReg.Size = new System.Drawing.Size(15, 14);
            this.ckProposedReg.TabIndex = 0;
            this.ckProposedReg.UseVisualStyleBackColor = true;
            this.ckProposedReg.CheckedChanged += new System.EventHandler(this.ckProposedReg_CheckedChanged);
            // 
            // pnlFirstDegreeCheck
            // 
            this.pnlFirstDegreeCheck.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnlFirstDegreeCheck.BackColor = System.Drawing.Color.Purple;
            this.pnlFirstDegreeCheck.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlFirstDegreeCheck.Controls.Add(this.ckFirstDegree);
            this.pnlFirstDegreeCheck.Location = new System.Drawing.Point(549, 134);
            this.pnlFirstDegreeCheck.Name = "pnlFirstDegreeCheck";
            this.pnlFirstDegreeCheck.Size = new System.Drawing.Size(25, 25);
            this.pnlFirstDegreeCheck.TabIndex = 22;
            // 
            // ckFirstDegree
            // 
            this.ckFirstDegree.AutoSize = true;
            this.ckFirstDegree.Location = new System.Drawing.Point(4, 4);
            this.ckFirstDegree.Name = "ckFirstDegree";
            this.ckFirstDegree.Size = new System.Drawing.Size(15, 14);
            this.ckFirstDegree.TabIndex = 0;
            this.ckFirstDegree.UseVisualStyleBackColor = true;
            this.ckFirstDegree.CheckedChanged += new System.EventHandler(this.ckFirstDegree_CheckedChanged);
            // 
            // pnlSecondDegreeCheck
            // 
            this.pnlSecondDegreeCheck.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnlSecondDegreeCheck.BackColor = System.Drawing.Color.Purple;
            this.pnlSecondDegreeCheck.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlSecondDegreeCheck.Controls.Add(this.ckSecondDegree);
            this.pnlSecondDegreeCheck.Location = new System.Drawing.Point(549, 326);
            this.pnlSecondDegreeCheck.Name = "pnlSecondDegreeCheck";
            this.pnlSecondDegreeCheck.Size = new System.Drawing.Size(25, 25);
            this.pnlSecondDegreeCheck.TabIndex = 23;
            // 
            // ckSecondDegree
            // 
            this.ckSecondDegree.AutoSize = true;
            this.ckSecondDegree.Location = new System.Drawing.Point(4, 4);
            this.ckSecondDegree.Name = "ckSecondDegree";
            this.ckSecondDegree.Size = new System.Drawing.Size(15, 14);
            this.ckSecondDegree.TabIndex = 0;
            this.ckSecondDegree.UseVisualStyleBackColor = true;
            this.ckSecondDegree.CheckedChanged += new System.EventHandler(this.ckSecondDegree_CheckedChanged);
            // 
            // gbAdditionalInfo
            // 
            this.gbAdditionalInfo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gbAdditionalInfo.Controls.Add(this.ckLwaStream2);
            this.gbAdditionalInfo.Controls.Add(this.ckBComIS);
            this.gbAdditionalInfo.Controls.Add(this.ckMusicProof);
            this.gbAdditionalInfo.Controls.Add(this.ckFineArt);
            this.gbAdditionalInfo.Controls.Add(this.ckLwaStream1);
            this.gbAdditionalInfo.Location = new System.Drawing.Point(4, 512);
            this.gbAdditionalInfo.Name = "gbAdditionalInfo";
            this.gbAdditionalInfo.Size = new System.Drawing.Size(539, 73);
            this.gbAdditionalInfo.TabIndex = 24;
            this.gbAdditionalInfo.TabStop = false;
            this.gbAdditionalInfo.Text = "Other Details";
            // 
            // ckLwaStream2
            // 
            this.ckLwaStream2.AutoSize = true;
            this.ckLwaStream2.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bsAdmissions, "LAW_STU2", true));
            this.ckLwaStream2.Enabled = false;
            this.ckLwaStream2.Location = new System.Drawing.Point(153, 20);
            this.ckLwaStream2.Name = "ckLwaStream2";
            this.ckLwaStream2.Size = new System.Drawing.Size(140, 17);
            this.ckLwaStream2.TabIndex = 4;
            this.ckLwaStream2.Text = "Applied for LLB Choice2";
            this.ckLwaStream2.UseVisualStyleBackColor = true;
            // 
            // ckBComIS
            // 
            this.ckBComIS.AutoSize = true;
            this.ckBComIS.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bsAdmStudent, "COMM_IS", true));
            this.ckBComIS.Enabled = false;
            this.ckBComIS.Location = new System.Drawing.Point(93, 43);
            this.ckBComIS.Name = "ckBComIS";
            this.ckBComIS.Size = new System.Drawing.Size(67, 17);
            this.ckBComIS.TabIndex = 3;
            this.ckBComIS.Text = "BCom IS";
            this.ckBComIS.UseVisualStyleBackColor = true;
            // 
            // ckMusicProof
            // 
            this.ckMusicProof.AutoSize = true;
            this.ckMusicProof.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bsAdmissions, "BMUS_OK", true));
            this.ckMusicProof.Enabled = false;
            this.ckMusicProof.Location = new System.Drawing.Point(6, 43);
            this.ckMusicProof.Name = "ckMusicProof";
            this.ckMusicProof.Size = new System.Drawing.Size(81, 17);
            this.ckMusicProof.TabIndex = 2;
            this.ckMusicProof.Text = "Music proof";
            this.ckMusicProof.UseVisualStyleBackColor = true;
            // 
            // ckFineArt
            // 
            this.ckFineArt.AutoSize = true;
            this.ckFineArt.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bsAdmissions, "PORTFOLIO_OK", true));
            this.ckFineArt.Enabled = false;
            this.ckFineArt.Location = new System.Drawing.Point(166, 43);
            this.ckFineArt.Name = "ckFineArt";
            this.ckFineArt.Size = new System.Drawing.Size(102, 17);
            this.ckFineArt.TabIndex = 1;
            this.ckFineArt.Text = "Fine Art portfolio";
            this.ckFineArt.UseVisualStyleBackColor = true;
            // 
            // ckLwaStream1
            // 
            this.ckLwaStream1.AutoSize = true;
            this.ckLwaStream1.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bsAdmissions, "LAW_STU1", true));
            this.ckLwaStream1.Enabled = false;
            this.ckLwaStream1.Location = new System.Drawing.Point(7, 20);
            this.ckLwaStream1.Name = "ckLwaStream1";
            this.ckLwaStream1.Size = new System.Drawing.Size(140, 17);
            this.ckLwaStream1.TabIndex = 0;
            this.ckLwaStream1.Text = "Applied for LLB Choice1";
            this.ckLwaStream1.UseVisualStyleBackColor = true;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // StudentDegreeDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.gbAdditionalInfo);
            this.Controls.Add(this.pnlSecondDegreeCheck);
            this.Controls.Add(this.pnlFirstDegreeCheck);
            this.Controls.Add(this.pnlProposedRegCheck);
            this.Controls.Add(this.gbSecondDegree);
            this.Controls.Add(this.gbFirstDegree);
            this.Controls.Add(this.gbProposedReg);
            this.Controls.Add(this.lblTitle);
            this.Name = "StudentDegreeDetails";
            this.Size = new System.Drawing.Size(578, 594);
            this.gbProposedReg.ResumeLayout(false);
            this.gbProposedReg.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsAdmStudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPossibleSubj2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPossibleSubj1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAdmissions)).EndInit();
            this.gbFirstDegree.ResumeLayout(false);
            this.gbFirstDegree.PerformLayout();
            this.gbSecondDegree.ResumeLayout(false);
            this.gbSecondDegree.PerformLayout();
            this.pnlProposedRegCheck.ResumeLayout(false);
            this.pnlProposedRegCheck.PerformLayout();
            this.pnlFirstDegreeCheck.ResumeLayout(false);
            this.pnlFirstDegreeCheck.PerformLayout();
            this.pnlSecondDegreeCheck.ResumeLayout(false);
            this.pnlSecondDegreeCheck.PerformLayout();
            this.gbAdditionalInfo.ResumeLayout(false);
            this.gbAdditionalInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox gbProposedReg;
        private System.Windows.Forms.Label lblRegStatus;
        private System.Windows.Forms.Button btnRemovePossSubj1;
        private System.Windows.Forms.Button btnAddPossSubj1;
        private System.Windows.Forms.DataGridView dgvPossibleSubj1;
        private System.Windows.Forms.Label lblPossibleSubj1;
        private System.Windows.Forms.Label lblDegree1;
        private System.Windows.Forms.ComboBox cbDeg1;
        private System.Windows.Forms.TextBox txtDeg1;
        private System.Windows.Forms.ComboBox cbRegStatus;
        private System.Windows.Forms.Button btnRemovePossSubj2;
        private System.Windows.Forms.Button btnAddPossSubj2;
        private System.Windows.Forms.DataGridView dgvPossibleSubj2;
        private System.Windows.Forms.Label lblPossibleSubj2;
        private System.Windows.Forms.Label lblDegree2;
        private System.Windows.Forms.ComboBox cbDeg2;
        private System.Windows.Forms.TextBox txtDeg2;
        private System.Windows.Forms.ComboBox cbAcademicStatus;
        private System.Windows.Forms.Label lblAcadStatus;
        private System.Windows.Forms.ComboBox cbEntryStatus;
        private System.Windows.Forms.Label lblEntryStatus;
        private System.Windows.Forms.Button btnEntryInfo;
        private System.Windows.Forms.BindingSource bsAdmStudent;
        private System.Windows.Forms.BindingSource bsAdmissions;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPossCode2;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPossDescrip2;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPossCode1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPossDescrip1;
        private System.Windows.Forms.GroupBox gbFirstDegree;
        private System.Windows.Forms.GroupBox gbSecondDegree;
        private System.Windows.Forms.Panel pnlProposedRegCheck;
        private System.Windows.Forms.CheckBox ckProposedReg;
        private System.Windows.Forms.Panel pnlFirstDegreeCheck;
        private System.Windows.Forms.CheckBox ckFirstDegree;
        private System.Windows.Forms.Panel pnlSecondDegreeCheck;
        private System.Windows.Forms.CheckBox ckSecondDegree;
        private System.Windows.Forms.GroupBox gbAdditionalInfo;
        private System.Windows.Forms.CheckBox ckBComIS;
        private System.Windows.Forms.CheckBox ckMusicProof;
        private System.Windows.Forms.CheckBox ckFineArt;
        private System.Windows.Forms.CheckBox ckLwaStream1;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.CheckBox ckLwaStream2;
    }
}

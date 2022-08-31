namespace Admissions.AdmissionForms
{
    partial class PGCEChoices
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
            this.lblDegNum = new System.Windows.Forms.Label();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.gbPGCEDegreeDetails = new System.Windows.Forms.GroupBox();
            this.lblPGChoice = new System.Windows.Forms.Label();
            this.lblDepartment2 = new System.Windows.Forms.Label();
            this.lblDepartment1 = new System.Windows.Forms.Label();
            this.lblDegreeName = new System.Windows.Forms.Label();
            this.lblChoice = new System.Windows.Forms.Label();
            this.lblDept2 = new System.Windows.Forms.Label();
            this.lblDept1 = new System.Windows.Forms.Label();
            this.lblDegree = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.gbPGCEChoices = new System.Windows.Forms.GroupBox();
            this.scPGCE = new System.Windows.Forms.SplitContainer();
            this.dgvPGCEChoice = new System.Windows.Forms.DataGridView();
            this.pnlAddRemove = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnDone = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cbPGCEChoice = new System.Windows.Forms.ComboBox();
            this.lblPGCEChoice = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cChoiceCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPGCEChoice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cMnemoci = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbPGCEDegreeDetails.SuspendLayout();
            this.gbPGCEChoices.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scPGCE)).BeginInit();
            this.scPGCE.Panel1.SuspendLayout();
            this.scPGCE.Panel2.SuspendLayout();
            this.scPGCE.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPGCEChoice)).BeginInit();
            this.pnlAddRemove.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(689, 24);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Text = "PGCE Choices";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblDegNum
            // 
            this.lblDegNum.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDegNum.Location = new System.Drawing.Point(70, 40);
            this.lblDegNum.Name = "lblDegNum";
            this.lblDegNum.Size = new System.Drawing.Size(40, 23);
            this.lblDegNum.TabIndex = 19;
            this.lblDegNum.Text = "0 of 0";
            this.lblDegNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLast
            // 
            this.btnLast.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnLast.Location = new System.Drawing.Point(149, 40);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(27, 23);
            this.btnLast.TabIndex = 17;
            this.btnLast.Text = ">>";
            this.toolTip.SetToolTip(this.btnLast, "Last");
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // btnNext
            // 
            this.btnNext.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnNext.Location = new System.Drawing.Point(116, 40);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(27, 23);
            this.btnNext.TabIndex = 16;
            this.btnNext.Text = ">";
            this.toolTip.SetToolTip(this.btnNext, "Next");
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnPrev.Location = new System.Drawing.Point(37, 40);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(27, 23);
            this.btnPrev.TabIndex = 15;
            this.btnPrev.Text = "<";
            this.toolTip.SetToolTip(this.btnPrev, "Previous");
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnFirst.Location = new System.Drawing.Point(4, 40);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(27, 23);
            this.btnFirst.TabIndex = 14;
            this.btnFirst.Text = "<<";
            this.toolTip.SetToolTip(this.btnFirst, "First");
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // gbPGCEDegreeDetails
            // 
            this.gbPGCEDegreeDetails.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gbPGCEDegreeDetails.Controls.Add(this.lblPGChoice);
            this.gbPGCEDegreeDetails.Controls.Add(this.lblDepartment2);
            this.gbPGCEDegreeDetails.Controls.Add(this.lblDepartment1);
            this.gbPGCEDegreeDetails.Controls.Add(this.lblDegreeName);
            this.gbPGCEDegreeDetails.Controls.Add(this.lblChoice);
            this.gbPGCEDegreeDetails.Controls.Add(this.lblDept2);
            this.gbPGCEDegreeDetails.Controls.Add(this.lblDept1);
            this.gbPGCEDegreeDetails.Controls.Add(this.lblDegree);
            this.gbPGCEDegreeDetails.Location = new System.Drawing.Point(4, 69);
            this.gbPGCEDegreeDetails.Name = "gbPGCEDegreeDetails";
            this.gbPGCEDegreeDetails.Size = new System.Drawing.Size(682, 99);
            this.gbPGCEDegreeDetails.TabIndex = 18;
            this.gbPGCEDegreeDetails.TabStop = false;
            this.gbPGCEDegreeDetails.Text = "PGCE Degree Details";
            // 
            // lblPGChoice
            // 
            this.lblPGChoice.AutoSize = true;
            this.lblPGChoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPGChoice.Location = new System.Drawing.Point(70, 72);
            this.lblPGChoice.Name = "lblPGChoice";
            this.lblPGChoice.Size = new System.Drawing.Size(75, 13);
            this.lblPGChoice.TabIndex = 7;
            this.lblPGChoice.Text = "[PG Choice]";
            // 
            // lblDepartment2
            // 
            this.lblDepartment2.AutoSize = true;
            this.lblDepartment2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartment2.Location = new System.Drawing.Point(356, 49);
            this.lblDepartment2.Name = "lblDepartment2";
            this.lblDepartment2.Size = new System.Drawing.Size(91, 13);
            this.lblDepartment2.TabIndex = 6;
            this.lblDepartment2.Text = "[Department 2]";
            // 
            // lblDepartment1
            // 
            this.lblDepartment1.AutoSize = true;
            this.lblDepartment1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartment1.Location = new System.Drawing.Point(70, 49);
            this.lblDepartment1.Name = "lblDepartment1";
            this.lblDepartment1.Size = new System.Drawing.Size(91, 13);
            this.lblDepartment1.TabIndex = 5;
            this.lblDepartment1.Text = "[Department 1]";
            // 
            // lblDegreeName
            // 
            this.lblDegreeName.AutoSize = true;
            this.lblDegreeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDegreeName.Location = new System.Drawing.Point(70, 26);
            this.lblDegreeName.Name = "lblDegreeName";
            this.lblDegreeName.Size = new System.Drawing.Size(92, 13);
            this.lblDegreeName.TabIndex = 4;
            this.lblDegreeName.Text = "[Degree Name]";
            // 
            // lblChoice
            // 
            this.lblChoice.AutoSize = true;
            this.lblChoice.Location = new System.Drawing.Point(6, 72);
            this.lblChoice.Name = "lblChoice";
            this.lblChoice.Size = new System.Drawing.Size(58, 13);
            this.lblChoice.TabIndex = 3;
            this.lblChoice.Text = "PG Choice";
            // 
            // lblDept2
            // 
            this.lblDept2.AutoSize = true;
            this.lblDept2.Location = new System.Drawing.Point(311, 49);
            this.lblDept2.Name = "lblDept2";
            this.lblDept2.Size = new System.Drawing.Size(39, 13);
            this.lblDept2.TabIndex = 2;
            this.lblDept2.Text = "Dept 2";
            // 
            // lblDept1
            // 
            this.lblDept1.AutoSize = true;
            this.lblDept1.Location = new System.Drawing.Point(6, 49);
            this.lblDept1.Name = "lblDept1";
            this.lblDept1.Size = new System.Drawing.Size(39, 13);
            this.lblDept1.TabIndex = 1;
            this.lblDept1.Text = "Dept 1";
            // 
            // lblDegree
            // 
            this.lblDegree.AutoSize = true;
            this.lblDegree.Location = new System.Drawing.Point(6, 26);
            this.lblDegree.Name = "lblDegree";
            this.lblDegree.Size = new System.Drawing.Size(42, 13);
            this.lblDegree.TabIndex = 0;
            this.lblDegree.Text = "Degree";
            // 
            // gbPGCEChoices
            // 
            this.gbPGCEChoices.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gbPGCEChoices.Controls.Add(this.scPGCE);
            this.gbPGCEChoices.Location = new System.Drawing.Point(4, 174);
            this.gbPGCEChoices.Name = "gbPGCEChoices";
            this.gbPGCEChoices.Size = new System.Drawing.Size(685, 209);
            this.gbPGCEChoices.TabIndex = 20;
            this.gbPGCEChoices.TabStop = false;
            this.gbPGCEChoices.Text = "PGCE Subject";
            // 
            // scPGCE
            // 
            this.scPGCE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scPGCE.Location = new System.Drawing.Point(3, 16);
            this.scPGCE.Name = "scPGCE";
            this.scPGCE.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // scPGCE.Panel1
            // 
            this.scPGCE.Panel1.Controls.Add(this.dgvPGCEChoice);
            this.scPGCE.Panel1.Controls.Add(this.pnlAddRemove);
            // 
            // scPGCE.Panel2
            // 
            this.scPGCE.Panel2.Controls.Add(this.btnDone);
            this.scPGCE.Panel2.Controls.Add(this.btnAdd);
            this.scPGCE.Panel2.Controls.Add(this.cbPGCEChoice);
            this.scPGCE.Panel2.Controls.Add(this.lblPGCEChoice);
            this.scPGCE.Size = new System.Drawing.Size(679, 190);
            this.scPGCE.SplitterDistance = 111;
            this.scPGCE.TabIndex = 0;
            // 
            // dgvPGCEChoice
            // 
            this.dgvPGCEChoice.AllowUserToAddRows = false;
            this.dgvPGCEChoice.AllowUserToDeleteRows = false;
            this.dgvPGCEChoice.BackgroundColor = System.Drawing.Color.White;
            this.dgvPGCEChoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPGCEChoice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cChoiceCode,
            this.cPGCEChoice,
            this.cMnemoci});
            this.dgvPGCEChoice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPGCEChoice.Location = new System.Drawing.Point(0, 0);
            this.dgvPGCEChoice.MultiSelect = false;
            this.dgvPGCEChoice.Name = "dgvPGCEChoice";
            this.dgvPGCEChoice.RowHeadersVisible = false;
            this.dgvPGCEChoice.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPGCEChoice.Size = new System.Drawing.Size(679, 77);
            this.dgvPGCEChoice.TabIndex = 18;
            this.dgvPGCEChoice.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPGCEChoice_CellDoubleClick);
            this.dgvPGCEChoice.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvPGCEChoice_DataBindingComplete);
            // 
            // pnlAddRemove
            // 
            this.pnlAddRemove.Controls.Add(this.btnDelete);
            this.pnlAddRemove.Controls.Add(this.btnNew);
            this.pnlAddRemove.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlAddRemove.Location = new System.Drawing.Point(0, 77);
            this.pnlAddRemove.Name = "pnlAddRemove";
            this.pnlAddRemove.Size = new System.Drawing.Size(679, 34);
            this.pnlAddRemove.TabIndex = 1;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(601, 6);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(3, 6);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 0;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnDone
            // 
            this.btnDone.Location = new System.Drawing.Point(343, 40);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(75, 23);
            this.btnDone.TabIndex = 35;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(262, 40);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 34;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cbPGCEChoice
            // 
            this.cbPGCEChoice.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbPGCEChoice.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbPGCEChoice.DisplayMember = "subjname";
            this.cbPGCEChoice.FormattingEnabled = true;
            this.cbPGCEChoice.Location = new System.Drawing.Point(54, 13);
            this.cbPGCEChoice.Name = "cbPGCEChoice";
            this.cbPGCEChoice.Size = new System.Drawing.Size(565, 21);
            this.cbPGCEChoice.TabIndex = 21;
            this.cbPGCEChoice.ValueMember = "subj";
            this.cbPGCEChoice.SelectedIndexChanged += new System.EventHandler(this.cbPGCEChoice_SelectedIndexChanged);
            // 
            // lblPGCEChoice
            // 
            this.lblPGCEChoice.AutoSize = true;
            this.lblPGCEChoice.Location = new System.Drawing.Point(5, 16);
            this.lblPGCEChoice.Name = "lblPGCEChoice";
            this.lblPGCEChoice.Size = new System.Drawing.Size(43, 13);
            this.lblPGCEChoice.TabIndex = 20;
            this.lblPGCEChoice.Text = "Subject";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "PG_DEGR";
            this.dataGridViewTextBoxColumn1.HeaderText = "Code";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 80;
            // 
            // cChoiceCode
            // 
            this.cChoiceCode.DataPropertyName = "subj";
            this.cChoiceCode.HeaderText = "Code";
            this.cChoiceCode.Name = "cChoiceCode";
            this.cChoiceCode.ReadOnly = true;
            this.cChoiceCode.Width = 80;
            // 
            // cPGCEChoice
            // 
            this.cPGCEChoice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cPGCEChoice.DataPropertyName = "subjname";
            this.cPGCEChoice.HeaderText = "Description";
            this.cPGCEChoice.Name = "cPGCEChoice";
            this.cPGCEChoice.ReadOnly = true;
            this.cPGCEChoice.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // cMnemoci
            // 
            this.cMnemoci.DataPropertyName = "mnemonic";
            this.cMnemoci.HeaderText = "Mnemocis";
            this.cMnemoci.Name = "cMnemoci";
            // 
            // PGCEChoices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.gbPGCEChoices);
            this.Controls.Add(this.lblDegNum);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.btnFirst);
            this.Controls.Add(this.gbPGCEDegreeDetails);
            this.Controls.Add(this.lblTitle);
            this.Name = "PGCEChoices";
            this.Size = new System.Drawing.Size(689, 386);
            this.gbPGCEDegreeDetails.ResumeLayout(false);
            this.gbPGCEDegreeDetails.PerformLayout();
            this.gbPGCEChoices.ResumeLayout(false);
            this.scPGCE.Panel1.ResumeLayout(false);
            this.scPGCE.Panel2.ResumeLayout(false);
            this.scPGCE.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scPGCE)).EndInit();
            this.scPGCE.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPGCEChoice)).EndInit();
            this.pnlAddRemove.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDegNum;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.GroupBox gbPGCEDegreeDetails;
        private System.Windows.Forms.Label lblPGChoice;
        private System.Windows.Forms.Label lblDepartment2;
        private System.Windows.Forms.Label lblDepartment1;
        private System.Windows.Forms.Label lblDegreeName;
        private System.Windows.Forms.Label lblChoice;
        private System.Windows.Forms.Label lblDept2;
        private System.Windows.Forms.Label lblDept1;
        private System.Windows.Forms.Label lblDegree;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.GroupBox gbPGCEChoices;
        private System.Windows.Forms.SplitContainer scPGCE;
        private System.Windows.Forms.Panel pnlAddRemove;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.ComboBox cbPGCEChoice;
        private System.Windows.Forms.Label lblPGCEChoice;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.DataGridView dgvPGCEChoice;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cChoiceCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPGCEChoice;
        private System.Windows.Forms.DataGridViewTextBoxColumn cMnemoci;
    }
}

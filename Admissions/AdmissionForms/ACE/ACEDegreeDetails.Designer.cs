namespace Admissions.AdmissionForms
{
    partial class ACEDegreeDetails
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
            this.gbDegreeChoice = new System.Windows.Forms.GroupBox();
            this.cbChoice = new System.Windows.Forms.ComboBox();
            this.bsAdmStudent = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.txtChoice = new System.Windows.Forms.TextBox();
            this.lblChoice = new System.Windows.Forms.Label();
            this.cbDegreeName = new System.Windows.Forms.ComboBox();
            this.bsAdmissions = new System.Windows.Forms.BindingSource(this.components);
            this.lblDegreeName = new System.Windows.Forms.Label();
            this.txtDegree = new System.Windows.Forms.TextBox();
            this.lblDegree = new System.Windows.Forms.Label();
            this.cbRegStatus = new System.Windows.Forms.ComboBox();
            this.lblRegStatus = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.cbEntryStatus = new System.Windows.Forms.ComboBox();
            this.lblEntryStatus = new System.Windows.Forms.Label();
            this.gbDegreeChoice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsAdmStudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAdmissions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(589, 24);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Text = "Degree Details";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // gbDegreeChoice
            // 
            this.gbDegreeChoice.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gbDegreeChoice.Controls.Add(this.cbEntryStatus);
            this.gbDegreeChoice.Controls.Add(this.lblEntryStatus);
            this.gbDegreeChoice.Controls.Add(this.cbChoice);
            this.gbDegreeChoice.Controls.Add(this.label1);
            this.gbDegreeChoice.Controls.Add(this.txtChoice);
            this.gbDegreeChoice.Controls.Add(this.lblChoice);
            this.gbDegreeChoice.Controls.Add(this.cbDegreeName);
            this.gbDegreeChoice.Controls.Add(this.lblDegreeName);
            this.gbDegreeChoice.Controls.Add(this.txtDegree);
            this.gbDegreeChoice.Controls.Add(this.lblDegree);
            this.gbDegreeChoice.Controls.Add(this.cbRegStatus);
            this.gbDegreeChoice.Controls.Add(this.lblRegStatus);
            this.gbDegreeChoice.Location = new System.Drawing.Point(4, 28);
            this.gbDegreeChoice.Name = "gbDegreeChoice";
            this.gbDegreeChoice.Size = new System.Drawing.Size(582, 159);
            this.gbDegreeChoice.TabIndex = 6;
            this.gbDegreeChoice.TabStop = false;
            this.gbDegreeChoice.Text = "Degree Choice";
            // 
            // cbChoice
            // 
            this.cbChoice.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbChoice.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbChoice.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsAdmStudent, "SUBJECT11", true));
            this.cbChoice.DisplayMember = "DESCRIP";
            this.cbChoice.FormattingEnabled = true;
            this.cbChoice.Location = new System.Drawing.Point(253, 122);
            this.cbChoice.Name = "cbChoice";
            this.cbChoice.Size = new System.Drawing.Size(306, 21);
            this.cbChoice.TabIndex = 35;
            this.cbChoice.ValueMember = "CODE";
            this.cbChoice.SelectedIndexChanged += new System.EventHandler(this.cbChoice_SelectedIndexChanged);
            // 
            // bsAdmStudent
            // 
            this.bsAdmStudent.DataMember = "TT_ADM_STU";
            this.bsAdmStudent.DataSource = typeof(NS_Admissions.StrongTypesNS.DS_ADM_STUDataSet);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(168, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "Choice Descrip";
            // 
            // txtChoice
            // 
            this.txtChoice.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtChoice.Location = new System.Drawing.Point(76, 122);
            this.txtChoice.Name = "txtChoice";
            this.txtChoice.Size = new System.Drawing.Size(68, 20);
            this.txtChoice.TabIndex = 33;
            this.txtChoice.Leave += new System.EventHandler(this.txtChoice_Leave);
            // 
            // lblChoice
            // 
            this.lblChoice.AutoSize = true;
            this.lblChoice.Location = new System.Drawing.Point(8, 125);
            this.lblChoice.Name = "lblChoice";
            this.lblChoice.Size = new System.Drawing.Size(40, 13);
            this.lblChoice.TabIndex = 32;
            this.lblChoice.Text = "Choice";
            // 
            // cbDegreeName
            // 
            this.cbDegreeName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbDegreeName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbDegreeName.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsAdmissions, "DEGR1", true));
            this.cbDegreeName.DisplayMember = "DESCRIP";
            this.cbDegreeName.FormattingEnabled = true;
            this.cbDegreeName.Location = new System.Drawing.Point(253, 96);
            this.cbDegreeName.Name = "cbDegreeName";
            this.cbDegreeName.Size = new System.Drawing.Size(306, 21);
            this.cbDegreeName.TabIndex = 23;
            this.cbDegreeName.ValueMember = "DEGR";
            this.cbDegreeName.SelectedIndexChanged += new System.EventHandler(this.cbDegreeName_SelectedIndexChanged);
            // 
            // bsAdmissions
            // 
            this.bsAdmissions.DataMember = "TT_ADM";
            this.bsAdmissions.DataSource = typeof(NS_Admissions.StrongTypesNS.DS_ADM_STUDataSet);
            // 
            // lblDegreeName
            // 
            this.lblDegreeName.AutoSize = true;
            this.lblDegreeName.Location = new System.Drawing.Point(168, 99);
            this.lblDegreeName.Name = "lblDegreeName";
            this.lblDegreeName.Size = new System.Drawing.Size(73, 13);
            this.lblDegreeName.TabIndex = 22;
            this.lblDegreeName.Text = "Degree Name";
            // 
            // txtDegree
            // 
            this.txtDegree.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDegree.Location = new System.Drawing.Point(76, 96);
            this.txtDegree.Name = "txtDegree";
            this.txtDegree.Size = new System.Drawing.Size(68, 20);
            this.txtDegree.TabIndex = 21;
            this.txtDegree.Leave += new System.EventHandler(this.txtDegree_Leave);
            // 
            // lblDegree
            // 
            this.lblDegree.AutoSize = true;
            this.lblDegree.Location = new System.Drawing.Point(6, 99);
            this.lblDegree.Name = "lblDegree";
            this.lblDegree.Size = new System.Drawing.Size(42, 13);
            this.lblDegree.TabIndex = 20;
            this.lblDegree.Text = "Degree";
            // 
            // cbRegStatus
            // 
            this.cbRegStatus.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsAdmStudent, "REG_STAT", true));
            this.cbRegStatus.DisplayMember = "DESCRIP";
            this.cbRegStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRegStatus.FormattingEnabled = true;
            this.cbRegStatus.Location = new System.Drawing.Point(76, 22);
            this.cbRegStatus.Name = "cbRegStatus";
            this.cbRegStatus.Size = new System.Drawing.Size(169, 21);
            this.cbRegStatus.TabIndex = 14;
            this.cbRegStatus.ValueMember = "CODE";
            // 
            // lblRegStatus
            // 
            this.lblRegStatus.AutoSize = true;
            this.lblRegStatus.Location = new System.Drawing.Point(6, 25);
            this.lblRegStatus.Name = "lblRegStatus";
            this.lblRegStatus.Size = new System.Drawing.Size(60, 13);
            this.lblRegStatus.TabIndex = 13;
            this.lblRegStatus.Text = "Reg Status";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // cbEntryStatus
            // 
            this.cbEntryStatus.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsAdmStudent, "ENTRY_STAT", true));
            this.cbEntryStatus.DisplayMember = "DESCRIP";
            this.cbEntryStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEntryStatus.FormattingEnabled = true;
            this.cbEntryStatus.Location = new System.Drawing.Point(76, 49);
            this.cbEntryStatus.Name = "cbEntryStatus";
            this.cbEntryStatus.Size = new System.Drawing.Size(483, 21);
            this.cbEntryStatus.TabIndex = 15;
            this.cbEntryStatus.ValueMember = "CODE";
            // 
            // lblEntryStatus
            // 
            this.lblEntryStatus.AutoSize = true;
            this.lblEntryStatus.Location = new System.Drawing.Point(6, 52);
            this.lblEntryStatus.Name = "lblEntryStatus";
            this.lblEntryStatus.Size = new System.Drawing.Size(64, 13);
            this.lblEntryStatus.TabIndex = 36;
            this.lblEntryStatus.Text = "Entry Status";
            // 
            // ACEDegreeDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.gbDegreeChoice);
            this.Controls.Add(this.lblTitle);
            this.Name = "ACEDegreeDetails";
            this.Size = new System.Drawing.Size(589, 202);
            this.gbDegreeChoice.ResumeLayout(false);
            this.gbDegreeChoice.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsAdmStudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAdmissions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox gbDegreeChoice;
        private System.Windows.Forms.ComboBox cbRegStatus;
        private System.Windows.Forms.Label lblRegStatus;
        private System.Windows.Forms.ComboBox cbDegreeName;
        private System.Windows.Forms.Label lblDegreeName;
        private System.Windows.Forms.TextBox txtDegree;
        private System.Windows.Forms.Label lblDegree;
        private System.Windows.Forms.ComboBox cbChoice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtChoice;
        private System.Windows.Forms.Label lblChoice;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.BindingSource bsAdmStudent;
        private System.Windows.Forms.BindingSource bsAdmissions;
        private System.Windows.Forms.ComboBox cbEntryStatus;
        private System.Windows.Forms.Label lblEntryStatus;
    }
}

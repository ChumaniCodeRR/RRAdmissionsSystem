﻿namespace Admissions.AdmissionForms
{
    partial class AdditionalInfo
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
            this.bsAdmissions = new System.Windows.Forms.BindingSource(this.components);
            this.gbAdults = new System.Windows.Forms.GroupBox();
            this.scAdults = new System.Windows.Forms.SplitContainer();
            this.dgvAdults = new System.Windows.Forms.DataGridView();
            this.cRelationship = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cOccupation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cEducation = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.pnlNewDelete = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cbRelationship = new System.Windows.Forms.ComboBox();
            this.cbEducation = new System.Windows.Forms.ComboBox();
            this.lblRelationship = new System.Windows.Forms.Label();
            this.lblEducation = new System.Windows.Forms.Label();
            this.lblOccupation = new System.Windows.Forms.Label();
            this.txtOccupation = new System.Windows.Forms.TextBox();
            this.gbFormDetails = new System.Windows.Forms.GroupBox();
            this.ckAttentionDetails = new System.Windows.Forms.CheckBox();
            this.ckSignedApp = new System.Windows.Forms.CheckBox();
            this.bsAdmStudent = new System.Windows.Forms.BindingSource(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnViewDocument = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bsAdmissions)).BeginInit();
            this.gbAdults.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scAdults)).BeginInit();
            this.scAdults.Panel1.SuspendLayout();
            this.scAdults.Panel2.SuspendLayout();
            this.scAdults.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdults)).BeginInit();
            this.pnlNewDelete.SuspendLayout();
            this.gbFormDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsAdmStudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(516, 24);
            this.lblTitle.TabIndex = 11;
            this.lblTitle.Text = "Additional Information";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // bsAdmissions
            // 
            this.bsAdmissions.DataMember = "TT_ADM";
            this.bsAdmissions.DataSource = typeof(NS_Admissions.StrongTypesNS.DS_ADM_STUDataSet);
            // 
            // gbAdults
            // 
            this.gbAdults.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gbAdults.Controls.Add(this.scAdults);
            this.gbAdults.Location = new System.Drawing.Point(7, 138);
            this.gbAdults.Name = "gbAdults";
            this.gbAdults.Size = new System.Drawing.Size(509, 229);
            this.gbAdults.TabIndex = 13;
            this.gbAdults.TabStop = false;
            this.gbAdults.Text = "Adults Living With:";
            this.gbAdults.Visible = false;
            // 
            // scAdults
            // 
            this.scAdults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scAdults.Location = new System.Drawing.Point(3, 16);
            this.scAdults.Name = "scAdults";
            this.scAdults.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // scAdults.Panel1
            // 
            this.scAdults.Panel1.Controls.Add(this.dgvAdults);
            this.scAdults.Panel1.Controls.Add(this.pnlNewDelete);
            // 
            // scAdults.Panel2
            // 
            this.scAdults.Panel2.Controls.Add(this.btnCancel);
            this.scAdults.Panel2.Controls.Add(this.btnAdd);
            this.scAdults.Panel2.Controls.Add(this.cbRelationship);
            this.scAdults.Panel2.Controls.Add(this.cbEducation);
            this.scAdults.Panel2.Controls.Add(this.lblRelationship);
            this.scAdults.Panel2.Controls.Add(this.lblEducation);
            this.scAdults.Panel2.Controls.Add(this.lblOccupation);
            this.scAdults.Panel2.Controls.Add(this.txtOccupation);
            this.scAdults.Size = new System.Drawing.Size(503, 210);
            this.scAdults.SplitterDistance = 94;
            this.scAdults.TabIndex = 23;
            // 
            // dgvAdults
            // 
            this.dgvAdults.AllowUserToAddRows = false;
            this.dgvAdults.AllowUserToDeleteRows = false;
            this.dgvAdults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdults.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cRelationship,
            this.cOccupation,
            this.cEducation});
            this.dgvAdults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAdults.Location = new System.Drawing.Point(0, 0);
            this.dgvAdults.MultiSelect = false;
            this.dgvAdults.Name = "dgvAdults";
            this.dgvAdults.ReadOnly = true;
            this.dgvAdults.RowHeadersVisible = false;
            this.dgvAdults.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAdults.Size = new System.Drawing.Size(503, 61);
            this.dgvAdults.TabIndex = 1;
            this.dgvAdults.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAdults_CellDoubleClick);
            this.dgvAdults.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvAdults_DataBindingComplete);
            // 
            // cRelationship
            // 
            this.cRelationship.DataPropertyName = "RELATION";
            this.cRelationship.HeaderText = "Relationship";
            this.cRelationship.Name = "cRelationship";
            this.cRelationship.ReadOnly = true;
            this.cRelationship.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cRelationship.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cRelationship.Width = 120;
            // 
            // cOccupation
            // 
            this.cOccupation.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cOccupation.DataPropertyName = "OCC_REL";
            this.cOccupation.HeaderText = "Occupation";
            this.cOccupation.Name = "cOccupation";
            this.cOccupation.ReadOnly = true;
            // 
            // cEducation
            // 
            this.cEducation.DataPropertyName = "EDU_REL";
            this.cEducation.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.cEducation.HeaderText = "Education";
            this.cEducation.Name = "cEducation";
            this.cEducation.ReadOnly = true;
            this.cEducation.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cEducation.Width = 170;
            // 
            // pnlNewDelete
            // 
            this.pnlNewDelete.Controls.Add(this.btnDelete);
            this.pnlNewDelete.Controls.Add(this.btnNew);
            this.pnlNewDelete.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlNewDelete.Location = new System.Drawing.Point(0, 61);
            this.pnlNewDelete.Name = "pnlNewDelete";
            this.pnlNewDelete.Size = new System.Drawing.Size(503, 33);
            this.pnlNewDelete.TabIndex = 0;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Location = new System.Drawing.Point(425, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 26;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(3, 5);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 25;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCancel.Location = new System.Drawing.Point(246, 84);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 24;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAdd.Location = new System.Drawing.Point(165, 84);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 23;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cbRelationship
            // 
            this.cbRelationship.DisplayMember = "descrip";
            this.cbRelationship.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRelationship.FormattingEnabled = true;
            this.cbRelationship.Location = new System.Drawing.Point(75, 3);
            this.cbRelationship.Name = "cbRelationship";
            this.cbRelationship.Size = new System.Drawing.Size(405, 21);
            this.cbRelationship.TabIndex = 1;
            this.cbRelationship.ValueMember = "code";
            // 
            // cbEducation
            // 
            this.cbEducation.DisplayMember = "descrip";
            this.cbEducation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEducation.FormattingEnabled = true;
            this.cbEducation.Location = new System.Drawing.Point(75, 56);
            this.cbEducation.Name = "cbEducation";
            this.cbEducation.Size = new System.Drawing.Size(405, 21);
            this.cbEducation.TabIndex = 22;
            this.cbEducation.ValueMember = "code";
            // 
            // lblRelationship
            // 
            this.lblRelationship.AutoSize = true;
            this.lblRelationship.Location = new System.Drawing.Point(4, 6);
            this.lblRelationship.Name = "lblRelationship";
            this.lblRelationship.Size = new System.Drawing.Size(65, 13);
            this.lblRelationship.TabIndex = 0;
            this.lblRelationship.Text = "Relationship";
            // 
            // lblEducation
            // 
            this.lblEducation.AutoSize = true;
            this.lblEducation.Location = new System.Drawing.Point(4, 59);
            this.lblEducation.Name = "lblEducation";
            this.lblEducation.Size = new System.Drawing.Size(55, 13);
            this.lblEducation.TabIndex = 21;
            this.lblEducation.Text = "Education";
            // 
            // lblOccupation
            // 
            this.lblOccupation.AutoSize = true;
            this.lblOccupation.Location = new System.Drawing.Point(4, 33);
            this.lblOccupation.Name = "lblOccupation";
            this.lblOccupation.Size = new System.Drawing.Size(62, 13);
            this.lblOccupation.TabIndex = 19;
            this.lblOccupation.Text = "Occupation";
            // 
            // txtOccupation
            // 
            this.txtOccupation.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtOccupation.Location = new System.Drawing.Point(75, 30);
            this.txtOccupation.Name = "txtOccupation";
            this.txtOccupation.Size = new System.Drawing.Size(405, 20);
            this.txtOccupation.TabIndex = 20;
            this.txtOccupation.TextChanged += new System.EventHandler(this.txtOccupation_TextChanged);
            this.txtOccupation.GotFocus += new System.EventHandler(this.txtOccupation_GotFocus);
            // 
            // gbFormDetails
            // 
            this.gbFormDetails.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gbFormDetails.Controls.Add(this.btnViewDocument);
            this.gbFormDetails.Controls.Add(this.ckAttentionDetails);
            this.gbFormDetails.Controls.Add(this.ckSignedApp);
            this.gbFormDetails.Location = new System.Drawing.Point(7, 39);
            this.gbFormDetails.Name = "gbFormDetails";
            this.gbFormDetails.Size = new System.Drawing.Size(509, 93);
            this.gbFormDetails.TabIndex = 14;
            this.gbFormDetails.TabStop = false;
            this.gbFormDetails.Text = "Form Details";
            // 
            // ckAttentionDetails
            // 
            this.ckAttentionDetails.AutoSize = true;
            this.ckAttentionDetails.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ckAttentionDetails.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bsAdmissions, "ATTENTION", true));
            this.ckAttentionDetails.Location = new System.Drawing.Point(6, 46);
            this.ckAttentionDetails.Name = "ckAttentionDetails";
            this.ckAttentionDetails.Size = new System.Drawing.Size(218, 17);
            this.ckAttentionDetails.TabIndex = 3;
            this.ckAttentionDetails.Text = "Capture/Update Attention Details (Y/N)?";
            this.ckAttentionDetails.UseVisualStyleBackColor = true;
            // 
            // ckSignedApp
            // 
            this.ckSignedApp.AutoSize = true;
            this.ckSignedApp.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ckSignedApp.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bsAdmStudent, "SIGNED_APP", true));
            this.ckSignedApp.Location = new System.Drawing.Point(6, 23);
            this.ckSignedApp.Name = "ckSignedApp";
            this.ckSignedApp.Size = new System.Drawing.Size(149, 17);
            this.ckSignedApp.TabIndex = 2;
            this.ckSignedApp.Text = "Signed Application (Y/N)?";
            this.ckSignedApp.UseVisualStyleBackColor = true;
            // 
            // bsAdmStudent
            // 
            this.bsAdmStudent.DataMember = "TT_ADM_STU";
            this.bsAdmStudent.DataSource = typeof(NS_Admissions.StrongTypesNS.DS_ADM_STUDataSet);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnViewDocument
            // 
            this.btnViewDocument.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnViewDocument.Location = new System.Drawing.Point(197, 64);
            this.btnViewDocument.Name = "btnViewDocument";
            this.btnViewDocument.Size = new System.Drawing.Size(115, 23);
            this.btnViewDocument.TabIndex = 25;
            this.btnViewDocument.Text = "View Documents";
            this.btnViewDocument.UseVisualStyleBackColor = true;
            this.btnViewDocument.Click += new System.EventHandler(this.btnViewDocument_Click);
            // 
            // AdditionalInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.gbFormDetails);
            this.Controls.Add(this.gbAdults);
            this.Controls.Add(this.lblTitle);
            this.Name = "AdditionalInfo";
            this.Size = new System.Drawing.Size(516, 380);
            this.Load += new System.EventHandler(this.AdditionalInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsAdmissions)).EndInit();
            this.gbAdults.ResumeLayout(false);
            this.scAdults.Panel1.ResumeLayout(false);
            this.scAdults.Panel2.ResumeLayout(false);
            this.scAdults.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scAdults)).EndInit();
            this.scAdults.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdults)).EndInit();
            this.pnlNewDelete.ResumeLayout(false);
            this.gbFormDetails.ResumeLayout(false);
            this.gbFormDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsAdmStudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox gbAdults;
        private System.Windows.Forms.ComboBox cbRelationship;
        private System.Windows.Forms.Label lblRelationship;
        private System.Windows.Forms.ComboBox cbEducation;
        private System.Windows.Forms.Label lblEducation;
        private System.Windows.Forms.TextBox txtOccupation;
        private System.Windows.Forms.Label lblOccupation;
        private System.Windows.Forms.SplitContainer scAdults;
        private System.Windows.Forms.DataGridView dgvAdults;
        private System.Windows.Forms.Panel pnlNewDelete;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox gbFormDetails;
        private System.Windows.Forms.CheckBox ckAttentionDetails;
        private System.Windows.Forms.CheckBox ckSignedApp;
        private System.Windows.Forms.BindingSource bsAdmissions;
        private System.Windows.Forms.DataGridViewTextBoxColumn cRelationship;
        private System.Windows.Forms.DataGridViewTextBoxColumn cOccupation;
        private System.Windows.Forms.DataGridViewComboBoxColumn cEducation;
        private System.Windows.Forms.BindingSource bsAdmStudent;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnViewDocument;
    }
}

namespace Admissions.AdmissionForms
{
    partial class ACEAttentionIndicators
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
            this.dg_list = new CustomDataGridView();
            this.gbAttentionNotes = new System.Windows.Forms.GroupBox();
            this.txtattOther = new System.Windows.Forms.TextBox();
            this.bs_attentions = new System.Windows.Forms.BindingSource(this.components);
            this.attdescripDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.attentionDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.stunoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.attcodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bsAdmissions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_list)).BeginInit();
            this.gbAttentionNotes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bs_attentions)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(414, 24);
            this.lblTitle.TabIndex = 11;
            this.lblTitle.Text = "Attention Indicators";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // bsAdmissions
            // 
            this.bsAdmissions.DataMember = "TT_ADM";
            this.bsAdmissions.DataSource = typeof(NS_Admissions.StrongTypesNS.DS_ADM_STUDataSet);
            // 
            // dg_list
            // 
            this.dg_list.AllowUserToAddRows = false;
            this.dg_list.AllowUserToDeleteRows = false;
            this.dg_list.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dg_list.AutoGenerateColumns = false;
            this.dg_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_list.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.attdescripDataGridViewTextBoxColumn,
            this.attentionDataGridViewCheckBoxColumn,
            this.stunoDataGridViewTextBoxColumn,
            this.attcodeDataGridViewTextBoxColumn});
            this.dg_list.DataSource = this.bs_attentions;
            this.dg_list.Location = new System.Drawing.Point(10, 28);
            this.dg_list.MultiSelect = false;
            this.dg_list.Name = "dg_list";
            this.dg_list.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg_list.Size = new System.Drawing.Size(395, 427);
            this.dg_list.TabIndex = 172;
            // 
            // gbAttentionNotes
            // 
            this.gbAttentionNotes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbAttentionNotes.Controls.Add(this.txtattOther);
            this.gbAttentionNotes.Location = new System.Drawing.Point(3, 461);
            this.gbAttentionNotes.Name = "gbAttentionNotes";
            this.gbAttentionNotes.Size = new System.Drawing.Size(407, 73);
            this.gbAttentionNotes.TabIndex = 173;
            this.gbAttentionNotes.TabStop = false;
            this.gbAttentionNotes.Text = "Other Attention Things";
            // 
            // txtattOther
            // 
            this.txtattOther.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtattOther.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsAdmissions, "attn_other", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtattOther.Location = new System.Drawing.Point(6, 19);
            this.txtattOther.Multiline = true;
            this.txtattOther.Name = "txtattOther";
            this.txtattOther.Size = new System.Drawing.Size(395, 45);
            this.txtattOther.TabIndex = 0;
            // 
            // bs_attentions
            // 
            this.bs_attentions.DataSource = typeof(NS_Admissions.StrongTypesNS.DS_ADM_STUDataSet.tt_attentionsDataTable);
            // 
            // attdescripDataGridViewTextBoxColumn
            // 
            this.attdescripDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.attdescripDataGridViewTextBoxColumn.DataPropertyName = "att_descrip";
            this.attdescripDataGridViewTextBoxColumn.HeaderText = "Description";
            this.attdescripDataGridViewTextBoxColumn.Name = "attdescripDataGridViewTextBoxColumn";
            // 
            // attentionDataGridViewCheckBoxColumn
            // 
            this.attentionDataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.attentionDataGridViewCheckBoxColumn.DataPropertyName = "attention";
            this.attentionDataGridViewCheckBoxColumn.HeaderText = "FF";
            this.attentionDataGridViewCheckBoxColumn.Name = "attentionDataGridViewCheckBoxColumn";
            this.attentionDataGridViewCheckBoxColumn.Width = 25;
            // 
            // stunoDataGridViewTextBoxColumn
            // 
            this.stunoDataGridViewTextBoxColumn.DataPropertyName = "stuno";
            this.stunoDataGridViewTextBoxColumn.HeaderText = "stuno";
            this.stunoDataGridViewTextBoxColumn.Name = "stunoDataGridViewTextBoxColumn";
            this.stunoDataGridViewTextBoxColumn.Visible = false;
            // 
            // attcodeDataGridViewTextBoxColumn
            // 
            this.attcodeDataGridViewTextBoxColumn.DataPropertyName = "att_code";
            this.attcodeDataGridViewTextBoxColumn.HeaderText = "att_code";
            this.attcodeDataGridViewTextBoxColumn.Name = "attcodeDataGridViewTextBoxColumn";
            this.attcodeDataGridViewTextBoxColumn.Visible = false;
            // 
            // ACEAttentionIndicators
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.gbAttentionNotes);
            this.Controls.Add(this.dg_list);
            this.Controls.Add(this.lblTitle);
            this.Name = "ACEAttentionIndicators";
            this.Size = new System.Drawing.Size(414, 537);
            ((System.ComponentModel.ISupportInitialize)(this.bsAdmissions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_list)).EndInit();
            this.gbAttentionNotes.ResumeLayout(false);
            this.gbAttentionNotes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bs_attentions)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.BindingSource bsAdmissions;
        private CustomDataGridView dg_list;
        private System.Windows.Forms.GroupBox gbAttentionNotes;
        private System.Windows.Forms.TextBox txtattOther;
        private System.Windows.Forms.DataGridViewTextBoxColumn attdescripDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn attentionDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stunoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn attcodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bs_attentions;
    }
}

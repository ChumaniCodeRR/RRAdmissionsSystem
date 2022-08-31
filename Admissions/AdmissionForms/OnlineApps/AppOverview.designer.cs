namespace Admissions.AdmissionForms
{
    partial class AppOverview
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppOverview));
            this.btn_check = new System.Windows.Forms.Button();
            this.cn_stuno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_ref_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_surn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_namestr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.p_unwt_pts = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unwt_pts = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_appstat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox22 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_supporting_docs = new System.Windows.Forms.Button();
            this.btn_trans = new System.Windows.Forms.Button();
            this.btn_thesis = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_attention_notes = new System.Windows.Forms.TextBox();
            this.bs_overview = new System.Windows.Forms.BindingSource(this.components);
            this.dg_subj_choices = new CustomDataGridView();
            this.pGDEGRDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pGDEGREEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pGDEPT1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pGDEPT2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pGCHOICEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_namestring = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.bs_overview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_subj_choices)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_check
            // 
            this.btn_check.Location = new System.Drawing.Point(214, 362);
            this.btn_check.Name = "btn_check";
            this.btn_check.Size = new System.Drawing.Size(160, 23);
            this.btn_check.TabIndex = 179;
            this.btn_check.Text = "Mark The Form As Checked";
            this.btn_check.UseVisualStyleBackColor = true;
            this.btn_check.Click += new System.EventHandler(this.btn_check_Click);
            // 
            // cn_stuno
            // 
            this.cn_stuno.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.cn_stuno.DataPropertyName = "stuno";
            this.cn_stuno.HeaderText = "Stuno";
            this.cn_stuno.Name = "cn_stuno";
            // 
            // cn_ref_no
            // 
            this.cn_ref_no.DataPropertyName = "ref_no";
            this.cn_ref_no.HeaderText = "Reference Number";
            this.cn_ref_no.Name = "cn_ref_no";
            // 
            // cn_surn
            // 
            this.cn_surn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cn_surn.DataPropertyName = "surn";
            this.cn_surn.HeaderText = "Surname";
            this.cn_surn.Name = "cn_surn";
            // 
            // cn_namestr
            // 
            this.cn_namestr.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cn_namestr.DataPropertyName = "namestr";
            this.cn_namestr.HeaderText = "Name";
            this.cn_namestr.Name = "cn_namestr";
            // 
            // p_unwt_pts
            // 
            this.p_unwt_pts.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.p_unwt_pts.DataPropertyName = "p_unwt_pts";
            this.p_unwt_pts.HeaderText = "Provisional Points";
            this.p_unwt_pts.Name = "p_unwt_pts";
            // 
            // unwt_pts
            // 
            this.unwt_pts.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.unwt_pts.DataPropertyName = "unwt_pts";
            this.unwt_pts.HeaderText = "Final Points";
            this.unwt_pts.Name = "unwt_pts";
            // 
            // cn_appstat
            // 
            this.cn_appstat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cn_appstat.DataPropertyName = "app_stat";
            this.cn_appstat.HeaderText = "Application Status";
            this.cn_appstat.Name = "cn_appstat";
            // 
            // textBox22
            // 
            this.textBox22.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox22.BackColor = System.Drawing.SystemColors.Window;
            this.textBox22.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox22.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox22.ForeColor = System.Drawing.Color.Purple;
            this.textBox22.Location = new System.Drawing.Point(151, 12);
            this.textBox22.Name = "textBox22";
            this.textBox22.Size = new System.Drawing.Size(367, 19);
            this.textBox22.TabIndex = 169;
            this.textBox22.TabStop = false;
            this.textBox22.Text = "PG Admission Form Overview";
            this.textBox22.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 173;
            this.label1.Text = "Subject Choices:";
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(380, 362);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 184;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_supporting_docs
            // 
            this.btn_supporting_docs.Enabled = false;
            this.btn_supporting_docs.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_supporting_docs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_supporting_docs.Location = new System.Drawing.Point(387, 322);
            this.btn_supporting_docs.Name = "btn_supporting_docs";
            this.btn_supporting_docs.Size = new System.Drawing.Size(193, 23);
            this.btn_supporting_docs.TabIndex = 186;
            this.btn_supporting_docs.Text = "View Supporting Document(s)";
            this.btn_supporting_docs.UseVisualStyleBackColor = true;
            this.btn_supporting_docs.Click += new System.EventHandler(this.btn_supporting_docs_Click);
            // 
            // btn_trans
            // 
            this.btn_trans.Enabled = false;
            this.btn_trans.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_trans.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_trans.Location = new System.Drawing.Point(246, 322);
            this.btn_trans.Name = "btn_trans";
            this.btn_trans.Size = new System.Drawing.Size(135, 23);
            this.btn_trans.TabIndex = 185;
            this.btn_trans.Text = "View Transcript(s)";
            this.btn_trans.UseVisualStyleBackColor = true;
            this.btn_trans.Click += new System.EventHandler(this.btn_trans_Click);
            // 
            // btn_thesis
            // 
            this.btn_thesis.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_thesis.Enabled = false;
            this.btn_thesis.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thesis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_thesis.Location = new System.Drawing.Point(89, 322);
            this.btn_thesis.Name = "btn_thesis";
            this.btn_thesis.Size = new System.Drawing.Size(151, 23);
            this.btn_thesis.TabIndex = 187;
            this.btn_thesis.Text = "View Thesis Summary";
            this.btn_thesis.UseVisualStyleBackColor = true;
            this.btn_thesis.Click += new System.EventHandler(this.btn_thesis_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 188;
            this.label2.Text = "Attention Notes:";
            // 
            // txt_attention_notes
            // 
            this.txt_attention_notes.Location = new System.Drawing.Point(12, 238);
            this.txt_attention_notes.Multiline = true;
            this.txt_attention_notes.Name = "txt_attention_notes";
            this.txt_attention_notes.ReadOnly = true;
            this.txt_attention_notes.Size = new System.Drawing.Size(645, 78);
            this.txt_attention_notes.TabIndex = 189;
            // 
            // bs_overview
            // 
            this.bs_overview.DataSource = typeof(NS_Admissions.StrongTypesNS.ds_overviewDataSet.tt_overviewDataTable);
            // 
            // dg_subj_choices
            // 
            this.dg_subj_choices.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dg_subj_choices.AllowUserToAddRows = false;
            this.dg_subj_choices.AllowUserToDeleteRows = false;
            this.dg_subj_choices.AutoGenerateColumns = false;
            this.dg_subj_choices.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dg_subj_choices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_subj_choices.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pGDEGRDataGridViewTextBoxColumn,
            this.pGDEGREEDataGridViewTextBoxColumn,
            this.pGDEPT1DataGridViewTextBoxColumn,
            this.pGDEPT2DataGridViewTextBoxColumn,
            this.pGCHOICEDataGridViewTextBoxColumn});
            this.dg_subj_choices.DataSource = this.bs_overview;
            this.dg_subj_choices.Location = new System.Drawing.Point(12, 85);
            this.dg_subj_choices.MultiSelect = false;
            this.dg_subj_choices.Name = "dg_subj_choices";
            this.dg_subj_choices.ReadOnly = true;
            this.dg_subj_choices.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg_subj_choices.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_subj_choices.Size = new System.Drawing.Size(645, 134);
            this.dg_subj_choices.TabIndex = 170;
            // 
            // pGDEGRDataGridViewTextBoxColumn
            // 
            this.pGDEGRDataGridViewTextBoxColumn.DataPropertyName = "PG_DEGR";
            this.pGDEGRDataGridViewTextBoxColumn.HeaderText = "Degree";
            this.pGDEGRDataGridViewTextBoxColumn.Name = "pGDEGRDataGridViewTextBoxColumn";
            this.pGDEGRDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pGDEGREEDataGridViewTextBoxColumn
            // 
            this.pGDEGREEDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.pGDEGREEDataGridViewTextBoxColumn.DataPropertyName = "PG_DEGREE";
            this.pGDEGREEDataGridViewTextBoxColumn.HeaderText = "Degree Name";
            this.pGDEGREEDataGridViewTextBoxColumn.Name = "pGDEGREEDataGridViewTextBoxColumn";
            this.pGDEGREEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pGDEPT1DataGridViewTextBoxColumn
            // 
            this.pGDEPT1DataGridViewTextBoxColumn.DataPropertyName = "PG_DEPT1";
            this.pGDEPT1DataGridViewTextBoxColumn.HeaderText = "Dept 1";
            this.pGDEPT1DataGridViewTextBoxColumn.Name = "pGDEPT1DataGridViewTextBoxColumn";
            this.pGDEPT1DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pGDEPT2DataGridViewTextBoxColumn
            // 
            this.pGDEPT2DataGridViewTextBoxColumn.DataPropertyName = "PG_DEPT2";
            this.pGDEPT2DataGridViewTextBoxColumn.HeaderText = "Dept 2";
            this.pGDEPT2DataGridViewTextBoxColumn.Name = "pGDEPT2DataGridViewTextBoxColumn";
            this.pGDEPT2DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pGCHOICEDataGridViewTextBoxColumn
            // 
            this.pGCHOICEDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.pGCHOICEDataGridViewTextBoxColumn.DataPropertyName = "PG_CHOICE";
            this.pGCHOICEDataGridViewTextBoxColumn.HeaderText = "PG Choice";
            this.pGCHOICEDataGridViewTextBoxColumn.Name = "pGCHOICEDataGridViewTextBoxColumn";
            this.pGCHOICEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(56, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 191;
            this.label3.Text = "Student:";
            // 
            // txt_namestring
            // 
            this.txt_namestring.BackColor = System.Drawing.SystemColors.Window;
            this.txt_namestring.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_namestring.Location = new System.Drawing.Point(117, 46);
            this.txt_namestring.Name = "txt_namestring";
            this.txt_namestring.ReadOnly = true;
            this.txt_namestring.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_namestring.Size = new System.Drawing.Size(540, 13);
            this.txt_namestring.TabIndex = 192;
            // 
            // AppOverview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(669, 388);
            this.Controls.Add(this.txt_namestring);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_attention_notes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_thesis);
            this.Controls.Add(this.btn_supporting_docs);
            this.Controls.Add(this.btn_trans);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_check);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dg_subj_choices);
            this.Controls.Add(this.textBox22);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AppOverview";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Unchecked Forms Screen";
            this.Load += new System.EventHandler(this.AppOverview_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bs_overview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_subj_choices)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomDataGridView dg_subj_choices;
        private System.Windows.Forms.Button btn_check;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_stuno;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_ref_no;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_surn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_namestr;
        private System.Windows.Forms.DataGridViewTextBoxColumn p_unwt_pts;
        private System.Windows.Forms.DataGridViewTextBoxColumn unwt_pts;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_appstat;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cnfeepayerverified;
        private System.Windows.Forms.TextBox textBox22;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_supporting_docs;
        private System.Windows.Forms.Button btn_trans;
        private System.Windows.Forms.Button btn_thesis;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_attention_notes;
        private System.Windows.Forms.DataGridViewTextBoxColumn pGDEGRDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pGDEGREEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pGDEPT1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pGDEPT2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pGCHOICEDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bs_overview;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_namestring;
    }
}
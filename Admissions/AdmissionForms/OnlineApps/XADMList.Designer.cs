namespace Admissions.AdmissionForms
{
    partial class XADMList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XADMList));
            this.dg_xadm = new System.Windows.Forms.DataGridView();
            this.cn_ref_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_surn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_titl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_old_stuno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adm_yr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.degr1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.degr2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bs_xadm = new System.Windows.Forms.BindingSource(this.components);
            this.dS_XADMDataSet = new NS_Admissions.StrongTypesNS.DS_XADMDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.lbl_updated = new System.Windows.Forms.Label();
            this.lbl_total = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_acad_level = new System.Windows.Forms.ComboBox();
            this.lbl_status = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dg_xadm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_xadm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_XADMDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dg_xadm
            // 
            this.dg_xadm.AllowUserToAddRows = false;
            this.dg_xadm.AllowUserToDeleteRows = false;
            this.dg_xadm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dg_xadm.AutoGenerateColumns = false;
            this.dg_xadm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_xadm.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cn_ref_no,
            this.cn_surn,
            this.cn_name,
            this.cn_titl,
            this.id,
            this.cn_old_stuno,
            this.adm_yr,
            this.degr1,
            this.degr2});
            this.dg_xadm.DataSource = this.bs_xadm;
            this.dg_xadm.Location = new System.Drawing.Point(12, 72);
            this.dg_xadm.Name = "dg_xadm";
            this.dg_xadm.ReadOnly = true;
            this.dg_xadm.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_xadm.Size = new System.Drawing.Size(746, 454);
            this.dg_xadm.TabIndex = 0;
            this.dg_xadm.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            this.dg_xadm.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dg_xadm_MouseClick);
            // 
            // cn_ref_no
            // 
            this.cn_ref_no.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.cn_ref_no.DataPropertyName = "ref_no";
            this.cn_ref_no.HeaderText = "Ref No";
            this.cn_ref_no.Name = "cn_ref_no";
            this.cn_ref_no.ReadOnly = true;
            this.cn_ref_no.Width = 49;
            // 
            // cn_surn
            // 
            this.cn_surn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cn_surn.DataPropertyName = "surn";
            this.cn_surn.HeaderText = "Surname";
            this.cn_surn.MinimumWidth = 99;
            this.cn_surn.Name = "cn_surn";
            this.cn_surn.ReadOnly = true;
            // 
            // cn_name
            // 
            this.cn_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.cn_name.DataPropertyName = "namestr";
            this.cn_name.HeaderText = "Name";
            this.cn_name.Name = "cn_name";
            this.cn_name.ReadOnly = true;
            this.cn_name.Width = 60;
            // 
            // cn_titl
            // 
            this.cn_titl.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.cn_titl.DataPropertyName = "titl";
            this.cn_titl.HeaderText = "Title";
            this.cn_titl.Name = "cn_titl";
            this.cn_titl.ReadOnly = true;
            this.cn_titl.Width = 52;
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 43;
            // 
            // cn_old_stuno
            // 
            this.cn_old_stuno.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.cn_old_stuno.DataPropertyName = "oldstuno";
            this.cn_old_stuno.HeaderText = "Old Student Number";
            this.cn_old_stuno.Name = "cn_old_stuno";
            this.cn_old_stuno.ReadOnly = true;
            this.cn_old_stuno.Width = 117;
            // 
            // adm_yr
            // 
            this.adm_yr.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.adm_yr.DataPropertyName = "adm_yr";
            this.adm_yr.HeaderText = "Adm Year";
            this.adm_yr.Name = "adm_yr";
            this.adm_yr.ReadOnly = true;
            this.adm_yr.Width = 72;
            // 
            // degr1
            // 
            this.degr1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.degr1.DataPropertyName = "degr1";
            this.degr1.HeaderText = "Degree 1";
            this.degr1.Name = "degr1";
            this.degr1.ReadOnly = true;
            this.degr1.Width = 70;
            // 
            // degr2
            // 
            this.degr2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.degr2.DataPropertyName = "degr2";
            this.degr2.HeaderText = "Degree 2";
            this.degr2.Name = "degr2";
            this.degr2.ReadOnly = true;
            this.degr2.Width = 70;
            // 
            // bs_xadm
            // 
            this.bs_xadm.DataMember = "tt_xadm";
            this.bs_xadm.DataSource = this.dS_XADMDataSet;
            // 
            // dS_XADMDataSet
            // 
            this.dS_XADMDataSet.DataSetName = "DS_XADMDataSet";
            this.dS_XADMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Purple;
            this.label1.Location = new System.Drawing.Point(302, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Online Applications";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_refresh
            // 
            this.btn_refresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_refresh.Image = ((System.Drawing.Image)(resources.GetObject("btn_refresh.Image")));
            this.btn_refresh.Location = new System.Drawing.Point(12, 532);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(42, 37);
            this.btn_refresh.TabIndex = 2;
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // lbl_updated
            // 
            this.lbl_updated.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_updated.Location = new System.Drawing.Point(60, 544);
            this.lbl_updated.Name = "lbl_updated";
            this.lbl_updated.Size = new System.Drawing.Size(330, 13);
            this.lbl_updated.TabIndex = 3;
            this.lbl_updated.Text = "<<Last Updated>>";
            // 
            // lbl_total
            // 
            this.lbl_total.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_total.Location = new System.Drawing.Point(608, 544);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(150, 13);
            this.lbl_total.TabIndex = 4;
            this.lbl_total.Text = "<<Total Records>>";
            this.lbl_total.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Academic Level:";
            // 
            // cb_acad_level
            // 
            this.cb_acad_level.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_acad_level.FormattingEnabled = true;
            this.cb_acad_level.Location = new System.Drawing.Point(104, 44);
            this.cb_acad_level.Name = "cb_acad_level";
            this.cb_acad_level.Size = new System.Drawing.Size(174, 21);
            this.cb_acad_level.TabIndex = 6;
            this.cb_acad_level.SelectedIndexChanged += new System.EventHandler(this.cb_acad_level_SelectedIndexChanged);
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.Location = new System.Drawing.Point(284, 47);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(59, 13);
            this.lbl_status.TabIndex = 7;
            this.lbl_status.Text = "<<status>>";
            // 
            // XADMList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(770, 581);
            this.Controls.Add(this.lbl_status);
            this.Controls.Add(this.cb_acad_level);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_total);
            this.Controls.Add(this.lbl_updated);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dg_xadm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "XADMList";
            this.Text = "XADMList";
            this.Load += new System.EventHandler(this.XADMList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_xadm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_xadm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_XADMDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dg_xadm;
        private System.Windows.Forms.BindingSource bs_xadm;
        private NS_Admissions.StrongTypesNS.DS_XADMDataSet dS_XADMDataSet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_ref_no;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_surn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_titl;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_old_stuno;
        private System.Windows.Forms.DataGridViewTextBoxColumn adm_yr;
        private System.Windows.Forms.DataGridViewTextBoxColumn degr1;
        private System.Windows.Forms.DataGridViewTextBoxColumn degr2;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.Label lbl_updated;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_acad_level;
        private System.Windows.Forms.Label lbl_status;
    }
}
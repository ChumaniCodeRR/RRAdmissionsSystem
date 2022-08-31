namespace Admissions.AdmissionForms
{
    partial class UnCheckedForms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UnCheckedForms));
            this.textBox22 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_surn = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_reference = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_print = new System.Windows.Forms.Button();
            this.cb_acad_level = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_status = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_stuno = new System.Windows.Forms.TextBox();
            this.rbOnline = new System.Windows.Forms.RadioButton();
            this.rbPaper = new System.Windows.Forms.RadioButton();
            this.bs_unchecked = new System.Windows.Forms.BindingSource(this.components);
            this.dS_XADMDataSet = new NS_Admissions.StrongTypesNS.DS_XADMDataSet();
            this.rbAll = new System.Windows.Forms.RadioButton();
            this.dg_list = new CustomDataGridView();
            this.cnstuno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cnrefno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cnsurn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cnnamestr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cnpunwtpts = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cnunwtpts = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cnappstat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cnadmyr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cndegr1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cndegr2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cntitl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cnoldstuno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cndob = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cnid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cnmatricverified = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cnoffdte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cnsubmitdte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cnnationality = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cnpoints = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cnsaplev = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cnugpg = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cn_adm_yr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_stuno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_ref_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_surn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_namestr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.p_unwt_pts = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unwt_pts = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_appstat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bs_unchecked)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_XADMDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_list)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox22
            // 
            this.textBox22.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox22.BackColor = System.Drawing.SystemColors.Window;
            this.textBox22.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox22.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox22.ForeColor = System.Drawing.Color.Purple;
            this.textBox22.Location = new System.Drawing.Point(330, 2);
            this.textBox22.Name = "textBox22";
            this.textBox22.Size = new System.Drawing.Size(367, 19);
            this.textBox22.TabIndex = 169;
            this.textBox22.TabStop = false;
            this.textBox22.Text = "Unchecked Admission Forms";
            this.textBox22.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(645, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 175;
            this.label6.Text = "Surname:";
            // 
            // txt_surn
            // 
            this.txt_surn.Location = new System.Drawing.Point(703, 27);
            this.txt_surn.Name = "txt_surn";
            this.txt_surn.Size = new System.Drawing.Size(98, 20);
            this.txt_surn.TabIndex = 172;
            this.txt_surn.TextChanged += new System.EventHandler(this.txt_surn_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(492, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 174;
            this.label3.Text = "Ref. Number:";
            // 
            // txt_reference
            // 
            this.txt_reference.Location = new System.Drawing.Point(568, 27);
            this.txt_reference.Name = "txt_reference";
            this.txt_reference.Size = new System.Drawing.Size(71, 20);
            this.txt_reference.TabIndex = 171;
            this.txt_reference.TextChanged += new System.EventHandler(this.txt_reference_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 173;
            this.label1.Text = "Filter By: ";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(340, 424);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(347, 13);
            this.label4.TabIndex = 178;
            this.label4.Text = "Double Click A Record Above To Confirm The Form Has Been Checked";
            // 
            // btn_print
            // 
            this.btn_print.Location = new System.Drawing.Point(476, 440);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(75, 23);
            this.btn_print.TabIndex = 179;
            this.btn_print.Text = "Print List";
            this.btn_print.UseVisualStyleBackColor = true;
            this.btn_print.Click += new System.EventHandler(this.btn_print_Click);
            // 
            // cb_acad_level
            // 
            this.cb_acad_level.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_acad_level.FormattingEnabled = true;
            this.cb_acad_level.Location = new System.Drawing.Point(880, 27);
            this.cb_acad_level.Name = "cb_acad_level";
            this.cb_acad_level.Size = new System.Drawing.Size(135, 21);
            this.cb_acad_level.TabIndex = 181;
            this.cb_acad_level.SelectedIndexChanged += new System.EventHandler(this.cb_acad_level_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(807, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 180;
            this.label2.Text = "Acad. Level:";
            // 
            // txt_status
            // 
            this.txt_status.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_status.Location = new System.Drawing.Point(1, 53);
            this.txt_status.Name = "txt_status";
            this.txt_status.Size = new System.Drawing.Size(1023, 13);
            this.txt_status.TabIndex = 183;
            this.txt_status.Text = "<<summary>>";
            this.txt_status.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(314, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 184;
            this.label5.Text = "Student Number:";
            // 
            // txt_stuno
            // 
            this.txt_stuno.Location = new System.Drawing.Point(407, 27);
            this.txt_stuno.Name = "txt_stuno";
            this.txt_stuno.Size = new System.Drawing.Size(79, 20);
            this.txt_stuno.TabIndex = 185;
            this.txt_stuno.TextChanged += new System.EventHandler(this.txt_stuno_TextChanged);
            // 
            // rbOnline
            // 
            this.rbOnline.AutoSize = true;
            this.rbOnline.Location = new System.Drawing.Point(140, 28);
            this.rbOnline.Name = "rbOnline";
            this.rbOnline.Size = new System.Drawing.Size(82, 17);
            this.rbOnline.TabIndex = 186;
            this.rbOnline.Text = "Online Apps";
            this.rbOnline.UseVisualStyleBackColor = true;
            this.rbOnline.CheckedChanged += new System.EventHandler(this.rbOnline_CheckedChanged);
            // 
            // rbPaper
            // 
            this.rbPaper.AutoSize = true;
            this.rbPaper.Location = new System.Drawing.Point(228, 27);
            this.rbPaper.Name = "rbPaper";
            this.rbPaper.Size = new System.Drawing.Size(80, 17);
            this.rbPaper.TabIndex = 187;
            this.rbPaper.Text = "Paper Apps";
            this.rbPaper.UseVisualStyleBackColor = true;
            // 
            // bs_unchecked
            // 
            this.bs_unchecked.DataMember = "tt_xadm";
            this.bs_unchecked.DataSource = this.dS_XADMDataSet;
            // 
            // dS_XADMDataSet
            // 
            this.dS_XADMDataSet.DataSetName = "DS_XADMDataSet";
            this.dS_XADMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rbAll
            // 
            this.rbAll.AutoSize = true;
            this.rbAll.Checked = true;
            this.rbAll.Location = new System.Drawing.Point(71, 27);
            this.rbAll.Name = "rbAll";
            this.rbAll.Size = new System.Drawing.Size(63, 17);
            this.rbAll.TabIndex = 188;
            this.rbAll.TabStop = true;
            this.rbAll.Text = "All Apps";
            this.rbAll.UseVisualStyleBackColor = true;
            this.rbAll.CheckedChanged += new System.EventHandler(this.rbAll_CheckedChanged);
            // 
            // dg_list
            // 
            this.dg_list.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dg_list.AllowUserToAddRows = false;
            this.dg_list.AllowUserToDeleteRows = false;
            this.dg_list.AutoGenerateColumns = false;
            this.dg_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_list.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cnstuno,
            this.cnrefno,
            this.cnsurn,
            this.cnnamestr,
            this.cnpunwtpts,
            this.cnunwtpts,
            this.cnappstat,
            this.cnadmyr,
            this.cndegr1,
            this.cndegr2,
            this.cntitl,
            this.cnoldstuno,
            this.cndob,
            this.cnid,
            this.cnmatricverified,
            this.cnoffdte,
            this.cnsubmitdte,
            this.cnnationality,
            this.cnpoints,
            this.cnsaplev,
            this.cnugpg,
            this.cn_adm_yr});
            this.dg_list.DataSource = this.bs_unchecked;
            this.dg_list.Location = new System.Drawing.Point(1, 72);
            this.dg_list.MultiSelect = false;
            this.dg_list.Name = "dg_list";
            this.dg_list.ReadOnly = true;
            this.dg_list.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg_list.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_list.Size = new System.Drawing.Size(1023, 349);
            this.dg_list.TabIndex = 170;
            this.dg_list.DoubleClick += new System.EventHandler(this.dg_list_DoubleClick);
            this.dg_list.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dg_list_MouseClick);
            // 
            // cnstuno
            // 
            this.cnstuno.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.cnstuno.DataPropertyName = "stuno";
            this.cnstuno.HeaderText = "Stuno";
            this.cnstuno.Name = "cnstuno";
            this.cnstuno.ReadOnly = true;
            this.cnstuno.Width = 60;
            // 
            // cnrefno
            // 
            this.cnrefno.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.cnrefno.DataPropertyName = "ref_no";
            this.cnrefno.HeaderText = "Reference No";
            this.cnrefno.Name = "cnrefno";
            this.cnrefno.ReadOnly = true;
            this.cnrefno.Width = 99;
            // 
            // cnsurn
            // 
            this.cnsurn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cnsurn.DataPropertyName = "surn";
            this.cnsurn.HeaderText = "Surname";
            this.cnsurn.Name = "cnsurn";
            this.cnsurn.ReadOnly = true;
            // 
            // cnnamestr
            // 
            this.cnnamestr.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cnnamestr.DataPropertyName = "namestr";
            this.cnnamestr.HeaderText = "Name";
            this.cnnamestr.Name = "cnnamestr";
            this.cnnamestr.ReadOnly = true;
            // 
            // cnpunwtpts
            // 
            this.cnpunwtpts.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.cnpunwtpts.DataPropertyName = "p_unwt_pts";
            this.cnpunwtpts.HeaderText = "Prov Points";
            this.cnpunwtpts.Name = "cnpunwtpts";
            this.cnpunwtpts.ReadOnly = true;
            this.cnpunwtpts.Width = 86;
            // 
            // cnunwtpts
            // 
            this.cnunwtpts.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.cnunwtpts.DataPropertyName = "unwt_pts";
            this.cnunwtpts.HeaderText = "Final Points";
            this.cnunwtpts.Name = "cnunwtpts";
            this.cnunwtpts.ReadOnly = true;
            this.cnunwtpts.Width = 86;
            // 
            // cnappstat
            // 
            this.cnappstat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.cnappstat.DataPropertyName = "app_stat";
            this.cnappstat.HeaderText = "App Status";
            this.cnappstat.Name = "cnappstat";
            this.cnappstat.ReadOnly = true;
            this.cnappstat.Width = 84;
            // 
            // cnadmyr
            // 
            this.cnadmyr.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.cnadmyr.DataPropertyName = "adm_yr";
            this.cnadmyr.HeaderText = "Adm Year";
            this.cnadmyr.Name = "cnadmyr";
            this.cnadmyr.ReadOnly = true;
            this.cnadmyr.Width = 78;
            // 
            // cndegr1
            // 
            this.cndegr1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.cndegr1.DataPropertyName = "degr1";
            this.cndegr1.HeaderText = "Degree 1";
            this.cndegr1.Name = "cndegr1";
            this.cndegr1.ReadOnly = true;
            this.cndegr1.Width = 76;
            // 
            // cndegr2
            // 
            this.cndegr2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.cndegr2.DataPropertyName = "degr2";
            this.cndegr2.HeaderText = "Degree 2";
            this.cndegr2.Name = "cndegr2";
            this.cndegr2.ReadOnly = true;
            this.cndegr2.Width = 76;
            // 
            // cntitl
            // 
            this.cntitl.DataPropertyName = "titl";
            this.cntitl.HeaderText = "titl";
            this.cntitl.Name = "cntitl";
            this.cntitl.ReadOnly = true;
            this.cntitl.Visible = false;
            // 
            // cnoldstuno
            // 
            this.cnoldstuno.DataPropertyName = "oldstuno";
            this.cnoldstuno.HeaderText = "oldstuno";
            this.cnoldstuno.Name = "cnoldstuno";
            this.cnoldstuno.ReadOnly = true;
            this.cnoldstuno.Visible = false;
            // 
            // cndob
            // 
            this.cndob.DataPropertyName = "dob";
            this.cndob.HeaderText = "dob";
            this.cndob.Name = "cndob";
            this.cndob.ReadOnly = true;
            this.cndob.Visible = false;
            // 
            // cnid
            // 
            this.cnid.DataPropertyName = "id";
            this.cnid.HeaderText = "id";
            this.cnid.Name = "cnid";
            this.cnid.ReadOnly = true;
            this.cnid.Visible = false;
            // 
            // cnmatricverified
            // 
            this.cnmatricverified.DataPropertyName = "matric_verified";
            this.cnmatricverified.HeaderText = "matric_verified";
            this.cnmatricverified.Name = "cnmatricverified";
            this.cnmatricverified.ReadOnly = true;
            this.cnmatricverified.Visible = false;
            // 
            // cnoffdte
            // 
            this.cnoffdte.DataPropertyName = "off_dte";
            this.cnoffdte.HeaderText = "off_dte";
            this.cnoffdte.Name = "cnoffdte";
            this.cnoffdte.ReadOnly = true;
            this.cnoffdte.Visible = false;
            // 
            // cnsubmitdte
            // 
            this.cnsubmitdte.DataPropertyName = "submit_dte";
            this.cnsubmitdte.HeaderText = "submit_dte";
            this.cnsubmitdte.Name = "cnsubmitdte";
            this.cnsubmitdte.ReadOnly = true;
            this.cnsubmitdte.Visible = false;
            // 
            // cnnationality
            // 
            this.cnnationality.DataPropertyName = "nationality";
            this.cnnationality.HeaderText = "nationality";
            this.cnnationality.Name = "cnnationality";
            this.cnnationality.ReadOnly = true;
            this.cnnationality.Visible = false;
            // 
            // cnpoints
            // 
            this.cnpoints.DataPropertyName = "points";
            this.cnpoints.HeaderText = "points";
            this.cnpoints.Name = "cnpoints";
            this.cnpoints.ReadOnly = true;
            this.cnpoints.Visible = false;
            // 
            // cnsaplev
            // 
            this.cnsaplev.DataPropertyName = "sap_lev";
            this.cnsaplev.HeaderText = "sap_lev";
            this.cnsaplev.Name = "cnsaplev";
            this.cnsaplev.ReadOnly = true;
            this.cnsaplev.Visible = false;
            // 
            // cnugpg
            // 
            this.cnugpg.DataPropertyName = "ug_pg";
            this.cnugpg.HeaderText = "ug_pg";
            this.cnugpg.Name = "cnugpg";
            this.cnugpg.ReadOnly = true;
            this.cnugpg.Visible = false;
            // 
            // cn_adm_yr
            // 
            this.cn_adm_yr.DataPropertyName = "adm_yr";
            this.cn_adm_yr.HeaderText = "adm_yr";
            this.cn_adm_yr.Name = "cn_adm_yr";
            this.cn_adm_yr.ReadOnly = true;
            this.cn_adm_yr.Visible = false;
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
            // UnCheckedForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1027, 467);
            this.Controls.Add(this.rbAll);
            this.Controls.Add(this.rbPaper);
            this.Controls.Add(this.rbOnline);
            this.Controls.Add(this.txt_stuno);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_status);
            this.Controls.Add(this.cb_acad_level);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_print);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_surn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_reference);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dg_list);
            this.Controls.Add(this.textBox22);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UnCheckedForms";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Unchecked Forms Screen";
            this.Load += new System.EventHandler(this.PayConfirmation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bs_unchecked)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS_XADMDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_list)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox22;
        private CustomDataGridView dg_list;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_surn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_reference;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource bs_unchecked;
        private NS_Admissions.StrongTypesNS.DS_XADMDataSet dS_XADMDataSet;
        private System.Windows.Forms.Button btn_print;
        private System.Windows.Forms.ComboBox cb_acad_level;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_status;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_stuno;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_ref_no;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_surn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_namestr;
        private System.Windows.Forms.DataGridViewTextBoxColumn p_unwt_pts;
        private System.Windows.Forms.DataGridViewTextBoxColumn unwt_pts;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_appstat;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cnfeepayerverified;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_stuno;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnstuno;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnrefno;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnsurn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnnamestr;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnpunwtpts;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnunwtpts;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnappstat;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnadmyr;
        private System.Windows.Forms.DataGridViewTextBoxColumn cndegr1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cndegr2;
        private System.Windows.Forms.DataGridViewTextBoxColumn cntitl;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnoldstuno;
        private System.Windows.Forms.DataGridViewTextBoxColumn cndob;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnid;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cnmatricverified;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnoffdte;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnsubmitdte;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnnationality;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnpoints;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnsaplev;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cnugpg;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_adm_yr;
        private System.Windows.Forms.RadioButton rbOnline;
        private System.Windows.Forms.RadioButton rbPaper;
        private System.Windows.Forms.RadioButton rbAll;
    }
}
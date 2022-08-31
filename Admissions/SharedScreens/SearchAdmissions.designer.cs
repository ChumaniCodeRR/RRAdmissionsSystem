﻿namespace Admissions
{
    partial class SearchAdmission
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchAdmission));
            this.textBox22 = new System.Windows.Forms.TextBox();
            this.bs_list = new System.Windows.Forms.BindingSource(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.txt_surn = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_reference = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.rb_all = new System.Windows.Forms.RadioButton();
            this.rb_mastphd = new System.Windows.Forms.RadioButton();
            this.rb_ug = new System.Windows.Forms.RadioButton();
            this.rb_honours = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_stu = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.dg_list = new CustomDataGridView();
            this.admyrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_stuno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_refno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_submit_dte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_surn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_namestr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_points = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_nationality = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dobDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tempacad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cntempactive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.verified = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.oldstunoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.degr1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.degr2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bs_list)).BeginInit();
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
            this.textBox22.Location = new System.Drawing.Point(357, 2);
            this.textBox22.Name = "textBox22";
            this.textBox22.Size = new System.Drawing.Size(367, 19);
            this.textBox22.TabIndex = 169;
            this.textBox22.TabStop = false;
            this.textBox22.Text = "Admissions";
            this.textBox22.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bs_list
            // 
            this.bs_list.DataSource = typeof(NS_Admissions.StrongTypesNS.DS_XADMDataSet.tt_xadmDataTable);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(258, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 175;
            this.label6.Text = "Surname:";
            // 
            // txt_surn
            // 
            this.txt_surn.Location = new System.Drawing.Point(316, 55);
            this.txt_surn.Name = "txt_surn";
            this.txt_surn.Size = new System.Drawing.Size(115, 20);
            this.txt_surn.TabIndex = 172;
            this.txt_surn.TextChanged += new System.EventHandler(this.txt_surn_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(135, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 174;
            this.label3.Text = "Ref No:";
            // 
            // txt_reference
            // 
            this.txt_reference.Location = new System.Drawing.Point(185, 55);
            this.txt_reference.Name = "txt_reference";
            this.txt_reference.Size = new System.Drawing.Size(67, 20);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(437, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 177;
            this.label2.Text = "ID:";
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(464, 55);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(145, 20);
            this.txt_id.TabIndex = 176;
            this.txt_id.TextChanged += new System.EventHandler(this.txt_id_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(418, 465);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(244, 13);
            this.label4.TabIndex = 178;
            this.label4.Text = "Double click on an item above to select it";
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(996, 455);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(83, 23);
            this.btn_cancel.TabIndex = 179;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(989, 53);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(90, 23);
            this.btn_search.TabIndex = 180;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(80, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 181;
            this.label5.Text = "Acad Stat:";
            // 
            // rb_all
            // 
            this.rb_all.AutoSize = true;
            this.rb_all.Checked = true;
            this.rb_all.Location = new System.Drawing.Point(143, 28);
            this.rb_all.Name = "rb_all";
            this.rb_all.Size = new System.Drawing.Size(36, 17);
            this.rb_all.TabIndex = 182;
            this.rb_all.TabStop = true;
            this.rb_all.Text = "All";
            this.rb_all.UseVisualStyleBackColor = true;
            this.rb_all.CheckedChanged += new System.EventHandler(this.rb_all_CheckedChanged);
            // 
            // rb_mastphd
            // 
            this.rb_mastphd.AutoSize = true;
            this.rb_mastphd.Location = new System.Drawing.Point(385, 28);
            this.rb_mastphd.Name = "rb_mastphd";
            this.rb_mastphd.Size = new System.Drawing.Size(136, 17);
            this.rb_mastphd.TabIndex = 183;
            this.rb_mastphd.Text = "Masters and Phd\'s Only";
            this.rb_mastphd.UseVisualStyleBackColor = true;
            this.rb_mastphd.CheckedChanged += new System.EventHandler(this.rb_pg_CheckedChanged);
            // 
            // rb_ug
            // 
            this.rb_ug.AutoSize = true;
            this.rb_ug.Location = new System.Drawing.Point(185, 28);
            this.rb_ug.Name = "rb_ug";
            this.rb_ug.Size = new System.Drawing.Size(99, 17);
            this.rb_ug.TabIndex = 184;
            this.rb_ug.Text = "Undergrad Only";
            this.rb_ug.UseVisualStyleBackColor = true;
            this.rb_ug.CheckedChanged += new System.EventHandler(this.rb_ug_CheckedChanged);
            // 
            // rb_honours
            // 
            this.rb_honours.AutoSize = true;
            this.rb_honours.Location = new System.Drawing.Point(290, 28);
            this.rb_honours.Name = "rb_honours";
            this.rb_honours.Size = new System.Drawing.Size(89, 17);
            this.rb_honours.TabIndex = 185;
            this.rb_honours.Text = "Honours Only";
            this.rb_honours.UseVisualStyleBackColor = true;
            this.rb_honours.CheckedChanged += new System.EventHandler(this.rb_honours_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 188;
            this.label7.Text = "Stu No:";
            // 
            // txt_stu
            // 
            this.txt_stu.Location = new System.Drawing.Point(54, 55);
            this.txt_stu.Name = "txt_stu";
            this.txt_stu.Size = new System.Drawing.Size(83, 20);
            this.txt_stu.TabIndex = 187;
            this.txt_stu.TextChanged += new System.EventHandler(this.txt_stu_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(617, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 190;
            this.label8.Text = "Email:";
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(658, 55);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(152, 20);
            this.txt_email.TabIndex = 189;
            this.txt_email.TextChanged += new System.EventHandler(this.txt_email_TextChanged);
            // 
            // dg_list
            // 
            this.dg_list.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dg_list.AllowUserToAddRows = false;
            this.dg_list.AllowUserToDeleteRows = false;
            this.dg_list.AutoGenerateColumns = false;
            this.dg_list.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dg_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_list.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.admyrDataGridViewTextBoxColumn,
            this.cn_stuno,
            this.cn_refno,
            this.cn_submit_dte,
            this.cn_surn,
            this.cn_namestr,
            this.cn_points,
            this.cn_nationality,
            this.dobDataGridViewTextBoxColumn,
            this.idDataGridViewTextBoxColumn,
            this.tempacad,
            this.cntempactive,
            this.verified,
            this.oldstunoDataGridViewTextBoxColumn,
            this.degr1DataGridViewTextBoxColumn,
            this.degr2DataGridViewTextBoxColumn});
            this.dg_list.DataSource = this.bs_list;
            this.dg_list.Location = new System.Drawing.Point(1, 81);
            this.dg_list.MultiSelect = false;
            this.dg_list.Name = "dg_list";
            this.dg_list.ReadOnly = true;
            this.dg_list.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg_list.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_list.Size = new System.Drawing.Size(1078, 373);
            this.dg_list.TabIndex = 170;
            this.dg_list.DoubleClick += new System.EventHandler(this.dg_list_DoubleClick);
            // 
            // admyrDataGridViewTextBoxColumn
            // 
            this.admyrDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.admyrDataGridViewTextBoxColumn.DataPropertyName = "adm_yr";
            this.admyrDataGridViewTextBoxColumn.HeaderText = "Year";
            this.admyrDataGridViewTextBoxColumn.Name = "admyrDataGridViewTextBoxColumn";
            this.admyrDataGridViewTextBoxColumn.ReadOnly = true;
            this.admyrDataGridViewTextBoxColumn.Width = 54;
            // 
            // cn_stuno
            // 
            this.cn_stuno.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.cn_stuno.DataPropertyName = "stuno";
            this.cn_stuno.HeaderText = "Student Number";
            this.cn_stuno.Name = "cn_stuno";
            this.cn_stuno.ReadOnly = true;
            // 
            // cn_refno
            // 
            this.cn_refno.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.cn_refno.DataPropertyName = "ref_no";
            this.cn_refno.HeaderText = "Reference Number";
            this.cn_refno.Name = "cn_refno";
            this.cn_refno.ReadOnly = true;
            this.cn_refno.Width = 112;
            // 
            // cn_submit_dte
            // 
            this.cn_submit_dte.DataPropertyName = "submit_dte";
            this.cn_submit_dte.HeaderText = "Submit Date";
            this.cn_submit_dte.Name = "cn_submit_dte";
            this.cn_submit_dte.ReadOnly = true;
            // 
            // cn_surn
            // 
            this.cn_surn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cn_surn.DataPropertyName = "surn";
            this.cn_surn.HeaderText = "Surname";
            this.cn_surn.Name = "cn_surn";
            this.cn_surn.ReadOnly = true;
            // 
            // cn_namestr
            // 
            this.cn_namestr.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cn_namestr.DataPropertyName = "namestr";
            this.cn_namestr.HeaderText = "Names";
            this.cn_namestr.Name = "cn_namestr";
            this.cn_namestr.ReadOnly = true;
            // 
            // cn_points
            // 
            this.cn_points.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.cn_points.DataPropertyName = "points";
            this.cn_points.HeaderText = "Points";
            this.cn_points.Name = "cn_points";
            this.cn_points.ReadOnly = true;
            this.cn_points.Width = 61;
            // 
            // cn_nationality
            // 
            this.cn_nationality.DataPropertyName = "nationality";
            this.cn_nationality.HeaderText = "Citizenship";
            this.cn_nationality.Name = "cn_nationality";
            this.cn_nationality.ReadOnly = true;
            // 
            // dobDataGridViewTextBoxColumn
            // 
            this.dobDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dobDataGridViewTextBoxColumn.DataPropertyName = "dob";
            this.dobDataGridViewTextBoxColumn.HeaderText = "Date Of Birth";
            this.dobDataGridViewTextBoxColumn.Name = "dobDataGridViewTextBoxColumn";
            this.dobDataGridViewTextBoxColumn.ReadOnly = true;
            this.dobDataGridViewTextBoxColumn.Width = 67;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Identity Number";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 97;
            // 
            // tempacad
            // 
            this.tempacad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.tempacad.DataPropertyName = "tempacad";
            this.tempacad.HeaderText = "Acad Stat";
            this.tempacad.Name = "tempacad";
            this.tempacad.ReadOnly = true;
            this.tempacad.Width = 73;
            // 
            // cntempactive
            // 
            this.cntempactive.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.cntempactive.DataPropertyName = "tempactive";
            this.cntempactive.HeaderText = "Status";
            this.cntempactive.Name = "cntempactive";
            this.cntempactive.ReadOnly = true;
            this.cntempactive.Width = 62;
            // 
            // verified
            // 
            this.verified.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.verified.DataPropertyName = "verified";
            this.verified.HeaderText = "Verified";
            this.verified.Name = "verified";
            this.verified.ReadOnly = true;
            this.verified.Width = 48;
            // 
            // oldstunoDataGridViewTextBoxColumn
            // 
            this.oldstunoDataGridViewTextBoxColumn.DataPropertyName = "oldstuno";
            this.oldstunoDataGridViewTextBoxColumn.HeaderText = "oldstuno";
            this.oldstunoDataGridViewTextBoxColumn.Name = "oldstunoDataGridViewTextBoxColumn";
            this.oldstunoDataGridViewTextBoxColumn.ReadOnly = true;
            this.oldstunoDataGridViewTextBoxColumn.Visible = false;
            // 
            // degr1DataGridViewTextBoxColumn
            // 
            this.degr1DataGridViewTextBoxColumn.DataPropertyName = "degr1";
            this.degr1DataGridViewTextBoxColumn.HeaderText = "degr1";
            this.degr1DataGridViewTextBoxColumn.Name = "degr1DataGridViewTextBoxColumn";
            this.degr1DataGridViewTextBoxColumn.ReadOnly = true;
            this.degr1DataGridViewTextBoxColumn.Visible = false;
            // 
            // degr2DataGridViewTextBoxColumn
            // 
            this.degr2DataGridViewTextBoxColumn.DataPropertyName = "degr2";
            this.degr2DataGridViewTextBoxColumn.HeaderText = "degr2";
            this.degr2DataGridViewTextBoxColumn.Name = "degr2DataGridViewTextBoxColumn";
            this.degr2DataGridViewTextBoxColumn.ReadOnly = true;
            this.degr2DataGridViewTextBoxColumn.Visible = false;
            // 
            // SearchAdmission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1080, 495);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_stu);
            this.Controls.Add(this.rb_honours);
            this.Controls.Add(this.rb_ug);
            this.Controls.Add(this.rb_mastphd);
            this.Controls.Add(this.rb_all);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_id);
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
            this.Name = "SearchAdmission";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admissions Search";
            this.Load += new System.EventHandler(this.SearchAdmission_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bs_list)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_list)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox22;
        private CustomDataGridView dg_list;
        private System.Windows.Forms.BindingSource bs_list;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_surn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_reference;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rb_all;
        private System.Windows.Forms.RadioButton rb_mastphd;
        private System.Windows.Forms.RadioButton rb_ug;
        private System.Windows.Forms.RadioButton rb_honours;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_stu;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.DataGridViewTextBoxColumn admyrDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_stuno;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_refno;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_submit_dte;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_surn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_namestr;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_points;
        private System.Windows.Forms.DataGridViewTextBoxColumn cn_nationality;
        private System.Windows.Forms.DataGridViewTextBoxColumn dobDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tempacad;
        private System.Windows.Forms.DataGridViewTextBoxColumn cntempactive;
        private System.Windows.Forms.DataGridViewCheckBoxColumn verified;
        private System.Windows.Forms.DataGridViewTextBoxColumn oldstunoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn degr1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn degr2DataGridViewTextBoxColumn;
    }
}
namespace Admissions.AdmissionForms
{
    partial class CheckFeePayer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckFeePayer));
            this.textBox22 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_surn = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_reference = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_check = new System.Windows.Forms.Button();
            this.dg_list = new CustomDataGridView();
            this.cnStuno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.refnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cnSurn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.degr1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.degr2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cnAdm_yr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bs_list = new System.Windows.Forms.BindingSource(this.components);
            this.cn_stuno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_ref_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_surn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_namestr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.p_unwt_pts = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unwt_pts = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cn_appstat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_stuno = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dg_list)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_list)).BeginInit();
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
            this.textBox22.Text = "Fee Payer Not Checked";
            this.textBox22.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(472, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 175;
            this.label6.Text = "Surname:";
            // 
            // txt_surn
            // 
            this.txt_surn.Location = new System.Drawing.Point(530, 27);
            this.txt_surn.Name = "txt_surn";
            this.txt_surn.Size = new System.Drawing.Size(214, 20);
            this.txt_surn.TabIndex = 172;
            this.txt_surn.TextChanged += new System.EventHandler(this.txt_surn_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(265, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 174;
            this.label3.Text = "Reference Number:";
            // 
            // txt_reference
            // 
            this.txt_reference.Location = new System.Drawing.Point(371, 27);
            this.txt_reference.Name = "txt_reference";
            this.txt_reference.Size = new System.Drawing.Size(95, 20);
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
            this.label4.Location = new System.Drawing.Point(392, 424);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(243, 13);
            this.label4.TabIndex = 178;
            this.label4.Text = "Double Click A Record Above To View Document";
            // 
            // btn_check
            // 
            this.btn_check.Location = new System.Drawing.Point(453, 440);
            this.btn_check.Name = "btn_check";
            this.btn_check.Size = new System.Drawing.Size(121, 23);
            this.btn_check.TabIndex = 179;
            this.btn_check.Text = "Check Fee Payer";
            this.btn_check.UseVisualStyleBackColor = true;
            this.btn_check.Click += new System.EventHandler(this.btn_print_Click);
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
            this.cnStuno,
            this.refnoDataGridViewTextBoxColumn,
            this.cnSurn,
            this.cnName,
            this.degr1,
            this.degr2DataGridViewTextBoxColumn,
            this.cnAdm_yr});
            this.dg_list.DataSource = this.bs_list;
            this.dg_list.Location = new System.Drawing.Point(1, 53);
            this.dg_list.MultiSelect = false;
            this.dg_list.Name = "dg_list";
            this.dg_list.ReadOnly = true;
            this.dg_list.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg_list.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_list.Size = new System.Drawing.Size(1023, 368);
            this.dg_list.TabIndex = 170;
            this.dg_list.DoubleClick += new System.EventHandler(this.dg_list_DoubleClick);
            this.dg_list.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dg_list_MouseClick);
            // 
            // cnStuno
            // 
            this.cnStuno.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.cnStuno.DataPropertyName = "stuno";
            this.cnStuno.HeaderText = "Stuno";
            this.cnStuno.Name = "cnStuno";
            this.cnStuno.ReadOnly = true;
            this.cnStuno.Width = 60;
            // 
            // refnoDataGridViewTextBoxColumn
            // 
            this.refnoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.refnoDataGridViewTextBoxColumn.DataPropertyName = "ref_no";
            this.refnoDataGridViewTextBoxColumn.HeaderText = "Reference No";
            this.refnoDataGridViewTextBoxColumn.Name = "refnoDataGridViewTextBoxColumn";
            this.refnoDataGridViewTextBoxColumn.ReadOnly = true;
            this.refnoDataGridViewTextBoxColumn.Width = 99;
            // 
            // cnSurn
            // 
            this.cnSurn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cnSurn.DataPropertyName = "surn";
            this.cnSurn.HeaderText = "Surname";
            this.cnSurn.Name = "cnSurn";
            this.cnSurn.ReadOnly = true;
            // 
            // cnName
            // 
            this.cnName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cnName.DataPropertyName = "namestr";
            this.cnName.HeaderText = "Name";
            this.cnName.Name = "cnName";
            this.cnName.ReadOnly = true;
            // 
            // degr1
            // 
            this.degr1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.degr1.DataPropertyName = "degr1";
            this.degr1.HeaderText = "Degree 1";
            this.degr1.Name = "degr1";
            this.degr1.ReadOnly = true;
            this.degr1.Width = 76;
            // 
            // degr2DataGridViewTextBoxColumn
            // 
            this.degr2DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.degr2DataGridViewTextBoxColumn.DataPropertyName = "degr2";
            this.degr2DataGridViewTextBoxColumn.HeaderText = "Degree 2";
            this.degr2DataGridViewTextBoxColumn.Name = "degr2DataGridViewTextBoxColumn";
            this.degr2DataGridViewTextBoxColumn.ReadOnly = true;
            this.degr2DataGridViewTextBoxColumn.Width = 76;
            // 
            // cnAdm_yr
            // 
            this.cnAdm_yr.DataPropertyName = "adm_yr";
            this.cnAdm_yr.HeaderText = "adm_yr";
            this.cnAdm_yr.Name = "cnAdm_yr";
            this.cnAdm_yr.ReadOnly = true;
            this.cnAdm_yr.Visible = false;
            // 
            // bs_list
            // 
            this.bs_list.DataSource = typeof(NS_Admissions.StrongTypesNS.DS_XADMDataSet.tt_xadmDataTable);
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(71, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 184;
            this.label5.Text = "Student Number:";
            // 
            // txt_stuno
            // 
            this.txt_stuno.Location = new System.Drawing.Point(164, 27);
            this.txt_stuno.Name = "txt_stuno";
            this.txt_stuno.Size = new System.Drawing.Size(95, 20);
            this.txt_stuno.TabIndex = 185;
            this.txt_stuno.TextChanged += new System.EventHandler(this.txt_stuno_TextChanged);
            // 
            // CheckFeePayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1027, 467);
            this.Controls.Add(this.txt_stuno);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_check);
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
            this.Name = "CheckFeePayer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Unchecked Fee Payer Forms Screen";
            this.Load += new System.EventHandler(this.CheckFeePayer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_list)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_list)).EndInit();
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
        private System.Windows.Forms.Button btn_check;
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
        private System.Windows.Forms.BindingSource bs_list;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnStuno;
        private System.Windows.Forms.DataGridViewTextBoxColumn refnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnSurn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn degr1;
        private System.Windows.Forms.DataGridViewTextBoxColumn degr2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnAdm_yr;
    }
}
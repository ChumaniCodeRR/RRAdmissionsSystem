namespace Admissions.UtilityScreens
{
    partial class ResidenceLookup
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlFilter = new System.Windows.Forms.Panel();
            this.ckActiveOnly = new System.Windows.Forms.CheckBox();
            this.txtResName = new System.Windows.Forms.TextBox();
            this.lblFilter = new System.Windows.Forms.Label();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.dgvResidenceLookup = new System.Windows.Forms.DataGridView();
            this.cResCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cResName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cActive = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.pnlFilter.SuspendLayout();
            this.pnlButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResidenceLookup)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(494, 24);
            this.lblTitle.TabIndex = 7;
            this.lblTitle.Text = "Residence Lookup";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pnlFilter
            // 
            this.pnlFilter.Controls.Add(this.ckActiveOnly);
            this.pnlFilter.Controls.Add(this.txtResName);
            this.pnlFilter.Controls.Add(this.lblFilter);
            this.pnlFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFilter.Location = new System.Drawing.Point(0, 24);
            this.pnlFilter.Name = "pnlFilter";
            this.pnlFilter.Size = new System.Drawing.Size(494, 31);
            this.pnlFilter.TabIndex = 9;
            // 
            // ckActiveOnly
            // 
            this.ckActiveOnly.AutoSize = true;
            this.ckActiveOnly.Checked = true;
            this.ckActiveOnly.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckActiveOnly.Location = new System.Drawing.Point(402, 7);
            this.ckActiveOnly.Name = "ckActiveOnly";
            this.ckActiveOnly.Size = new System.Drawing.Size(80, 17);
            this.ckActiveOnly.TabIndex = 2;
            this.ckActiveOnly.Text = "Active Only";
            this.ckActiveOnly.UseVisualStyleBackColor = true;
            this.ckActiveOnly.CheckedChanged += new System.EventHandler(this.ckActiveOnly_CheckedChanged);
            // 
            // txtResName
            // 
            this.txtResName.Location = new System.Drawing.Point(107, 5);
            this.txtResName.Name = "txtResName";
            this.txtResName.Size = new System.Drawing.Size(289, 20);
            this.txtResName.TabIndex = 1;
            this.txtResName.TextChanged += new System.EventHandler(this.txtResName_TextChanged);
            // 
            // lblFilter
            // 
            this.lblFilter.AutoSize = true;
            this.lblFilter.Location = new System.Drawing.Point(12, 8);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(89, 13);
            this.lblFilter.TabIndex = 0;
            this.lblFilter.Text = "Residence Name";
            // 
            // pnlButtons
            // 
            this.pnlButtons.Controls.Add(this.btnCancel);
            this.pnlButtons.Controls.Add(this.btnOK);
            this.pnlButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlButtons.Location = new System.Drawing.Point(0, 445);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(494, 31);
            this.pnlButtons.TabIndex = 11;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(250, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(169, 5);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // dgvResidenceLookup
            // 
            this.dgvResidenceLookup.AllowUserToAddRows = false;
            this.dgvResidenceLookup.AllowUserToDeleteRows = false;
            this.dgvResidenceLookup.BackgroundColor = System.Drawing.Color.White;
            this.dgvResidenceLookup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResidenceLookup.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cResCode,
            this.cResName,
            this.cGender,
            this.cActive});
            this.dgvResidenceLookup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvResidenceLookup.Location = new System.Drawing.Point(0, 55);
            this.dgvResidenceLookup.Name = "dgvResidenceLookup";
            this.dgvResidenceLookup.ReadOnly = true;
            this.dgvResidenceLookup.RowHeadersVisible = false;
            this.dgvResidenceLookup.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvResidenceLookup.Size = new System.Drawing.Size(494, 390);
            this.dgvResidenceLookup.TabIndex = 12;
            this.dgvResidenceLookup.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvResidenceLookup_CellDoubleClick);
            // 
            // cResCode
            // 
            this.cResCode.DataPropertyName = "res";
            this.cResCode.HeaderText = "Code";
            this.cResCode.Name = "cResCode";
            this.cResCode.ReadOnly = true;
            this.cResCode.Width = 60;
            // 
            // cResName
            // 
            this.cResName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cResName.DataPropertyName = "res_name";
            this.cResName.HeaderText = "Residence Name";
            this.cResName.Name = "cResName";
            this.cResName.ReadOnly = true;
            this.cResName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // cGender
            // 
            this.cGender.DataPropertyName = "sex";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.cGender.DefaultCellStyle = dataGridViewCellStyle1;
            this.cGender.HeaderText = "Gender";
            this.cGender.Name = "cGender";
            this.cGender.ReadOnly = true;
            this.cGender.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cGender.Width = 55;
            // 
            // cActive
            // 
            this.cActive.DataPropertyName = "active";
            this.cActive.HeaderText = "Active";
            this.cActive.Name = "cActive";
            this.cActive.ReadOnly = true;
            this.cActive.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cActive.Width = 40;
            // 
            // ResidenceLookup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(494, 476);
            this.Controls.Add(this.dgvResidenceLookup);
            this.Controls.Add(this.pnlButtons);
            this.Controls.Add(this.pnlFilter);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ResidenceLookup";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Residence Lookup";
            this.Load += new System.EventHandler(this.ResidenceLookup_Load);
            this.pnlFilter.ResumeLayout(false);
            this.pnlFilter.PerformLayout();
            this.pnlButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResidenceLookup)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlFilter;
        private System.Windows.Forms.TextBox txtResName;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.CheckBox ckActiveOnly;
        private System.Windows.Forms.DataGridView dgvResidenceLookup;
        private System.Windows.Forms.DataGridViewTextBoxColumn cResCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn cResName;
        private System.Windows.Forms.DataGridViewTextBoxColumn cGender;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cActive;
    }
}
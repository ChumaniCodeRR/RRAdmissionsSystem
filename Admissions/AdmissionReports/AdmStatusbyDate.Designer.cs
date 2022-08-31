namespace Admissions.AdmissionReports
{
    partial class AdmStatusbyDate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdmStatusbyDate));
            this.cb_nationality = new System.Windows.Forms.ComboBox();
            this.cb_status = new System.Windows.Forms.ComboBox();
            this.bs_appstatus = new System.Windows.Forms.BindingSource(this.components);
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_proceed = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.cb_faculty = new System.Windows.Forms.ComboBox();
            this.bs_faculty = new System.Windows.Forms.BindingSource(this.components);
            this.lblFaculty = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bs_appstatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_faculty)).BeginInit();
            this.SuspendLayout();
            // 
            // cb_nationality
            // 
            this.cb_nationality.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_nationality.FormattingEnabled = true;
            this.cb_nationality.Location = new System.Drawing.Point(187, 60);
            this.cb_nationality.Name = "cb_nationality";
            this.cb_nationality.Size = new System.Drawing.Size(200, 21);
            this.cb_nationality.TabIndex = 15;
            // 
            // cb_status
            // 
            this.cb_status.DataSource = this.bs_appstatus;
            this.cb_status.DisplayMember = "descrip";
            this.cb_status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_status.FormattingEnabled = true;
            this.cb_status.Location = new System.Drawing.Point(187, 6);
            this.cb_status.Name = "cb_status";
            this.cb_status.Size = new System.Drawing.Size(200, 21);
            this.cb_status.TabIndex = 1;
            this.cb_status.ValueMember = "code";
            this.cb_status.SelectedIndexChanged += new System.EventHandler(this.cb_status_SelectedIndexChanged);
            // 
            // bs_appstatus
            // 
            this.bs_appstatus.DataSource = typeof(NS_System.StrongTypesNS.ds_genDataSet.TT_GENDataTable);
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(209, 120);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(75, 23);
            this.btn_close.TabIndex = 30;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_proceed
            // 
            this.btn_proceed.Location = new System.Drawing.Point(128, 120);
            this.btn_proceed.Name = "btn_proceed";
            this.btn_proceed.Size = new System.Drawing.Size(75, 23);
            this.btn_proceed.TabIndex = 25;
            this.btn_proceed.Text = "Proceed";
            this.btn_proceed.UseVisualStyleBackColor = true;
            this.btn_proceed.Click += new System.EventHandler(this.btn_proceed_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(122, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nationality:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(141, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Status:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Application status before this date:";
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(187, 87);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(200, 20);
            this.dtpDate.TabIndex = 20;
            this.dtpDate.Value = new System.DateTime(2017, 5, 4, 0, 0, 0, 0);
            // 
            // cb_faculty
            // 
            this.cb_faculty.DataSource = this.bs_faculty;
            this.cb_faculty.DisplayMember = "descrip";
            this.cb_faculty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_faculty.FormattingEnabled = true;
            this.cb_faculty.Location = new System.Drawing.Point(187, 33);
            this.cb_faculty.Name = "cb_faculty";
            this.cb_faculty.Size = new System.Drawing.Size(200, 21);
            this.cb_faculty.TabIndex = 10;
            this.cb_faculty.ValueMember = "descrip";
            // 
            // bs_faculty
            // 
            this.bs_faculty.DataSource = typeof(NS_System.StrongTypesNS.ds_genDataSet.TT_GENDataTable);
            // 
            // lblFaculty
            // 
            this.lblFaculty.AutoSize = true;
            this.lblFaculty.Location = new System.Drawing.Point(137, 36);
            this.lblFaculty.Name = "lblFaculty";
            this.lblFaculty.Size = new System.Drawing.Size(44, 13);
            this.lblFaculty.TabIndex = 14;
            this.lblFaculty.Text = "Faculty:";
            // 
            // AdmStatusbyDate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(413, 152);
            this.Controls.Add(this.cb_faculty);
            this.Controls.Add(this.lblFaculty);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cb_nationality);
            this.Controls.Add(this.cb_status);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_proceed);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdmStatusbyDate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Application status before a given date";
            this.Load += new System.EventHandler(this.AdmStatusbyDate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bs_appstatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_faculty)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_nationality;
        private System.Windows.Forms.ComboBox cb_status;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_proceed;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.BindingSource bs_appstatus;
        private System.Windows.Forms.ComboBox cb_faculty;
        private System.Windows.Forms.Label lblFaculty;
        private System.Windows.Forms.BindingSource bs_faculty;
    }
}
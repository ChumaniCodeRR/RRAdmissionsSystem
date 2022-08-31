namespace Admissions.AdmissionReports
{
    partial class NoLettersNoActivity
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NoLettersNoActivity));
            this.cb_app = new System.Windows.Forms.ComboBox();
            this.bs_appstatus = new System.Windows.Forms.BindingSource(this.components);
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_proceed = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bs_appstatus)).BeginInit();
            this.SuspendLayout();
            // 
            // cb_app
            // 
            this.cb_app.DataSource = this.bs_appstatus;
            this.cb_app.DisplayMember = "descrip";
            this.cb_app.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_app.FormattingEnabled = true;
            this.cb_app.Location = new System.Drawing.Point(46, 12);
            this.cb_app.Name = "cb_app";
            this.cb_app.Size = new System.Drawing.Size(203, 21);
            this.cb_app.TabIndex = 1;
            this.cb_app.ValueMember = "code";
            // 
            // bs_appstatus
            // 
            this.bs_appstatus.DataSource = typeof(NS_System.StrongTypesNS.ds_genDataSet.TT_GENDataTable);
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(145, 39);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(75, 23);
            this.btn_close.TabIndex = 15;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_proceed
            // 
            this.btn_proceed.Location = new System.Drawing.Point(64, 39);
            this.btn_proceed.Name = "btn_proceed";
            this.btn_proceed.Size = new System.Drawing.Size(75, 23);
            this.btn_proceed.TabIndex = 10;
            this.btn_proceed.Text = "Proceed";
            this.btn_proceed.UseVisualStyleBackColor = true;
            this.btn_proceed.Click += new System.EventHandler(this.btn_proceed_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Type:";
            // 
            // NoLettersNoActivity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(284, 72);
            this.Controls.Add(this.cb_app);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_proceed);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NoLettersNoActivity";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admissions with no letters and no activity for over a week";
            this.Load += new System.EventHandler(this.NoLettersNoActivity_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bs_appstatus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_app;
        private System.Windows.Forms.BindingSource bs_appstatus;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_proceed;
        private System.Windows.Forms.Label label1;
    }
}
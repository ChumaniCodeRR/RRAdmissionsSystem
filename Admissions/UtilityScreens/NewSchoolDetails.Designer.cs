namespace Admissions.UtilityScreens
{
    partial class NewSchoolDetails
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSchoolName = new System.Windows.Forms.Label();
            this.lblSchoolCity = new System.Windows.Forms.Label();
            this.lblCellNo = new System.Windows.Forms.Label();
            this.txtSchoolName = new System.Windows.Forms.TextBox();
            this.txtSchoolCity = new System.Windows.Forms.TextBox();
            this.txtCellNo = new System.Windows.Forms.TextBox();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnlButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(357, 24);
            this.lblTitle.TabIndex = 12;
            this.lblTitle.Text = "New School";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblSchoolName
            // 
            this.lblSchoolName.AutoSize = true;
            this.lblSchoolName.Location = new System.Drawing.Point(12, 37);
            this.lblSchoolName.Name = "lblSchoolName";
            this.lblSchoolName.Size = new System.Drawing.Size(71, 13);
            this.lblSchoolName.TabIndex = 13;
            this.lblSchoolName.Text = "School Name";
            // 
            // lblSchoolCity
            // 
            this.lblSchoolCity.AutoSize = true;
            this.lblSchoolCity.Location = new System.Drawing.Point(12, 63);
            this.lblSchoolCity.Name = "lblSchoolCity";
            this.lblSchoolCity.Size = new System.Drawing.Size(60, 13);
            this.lblSchoolCity.TabIndex = 14;
            this.lblSchoolCity.Text = "School City";
            // 
            // lblCellNo
            // 
            this.lblCellNo.AutoSize = true;
            this.lblCellNo.Location = new System.Drawing.Point(12, 89);
            this.lblCellNo.Name = "lblCellNo";
            this.lblCellNo.Size = new System.Drawing.Size(64, 13);
            this.lblCellNo.TabIndex = 15;
            this.lblCellNo.Text = "Cell Number";
            // 
            // txtSchoolName
            // 
            this.txtSchoolName.Location = new System.Drawing.Point(89, 34);
            this.txtSchoolName.Name = "txtSchoolName";
            this.txtSchoolName.Size = new System.Drawing.Size(229, 20);
            this.txtSchoolName.TabIndex = 16;
            this.txtSchoolName.TextChanged += new System.EventHandler(this.txtSchoolName_TextChanged);
            // 
            // txtSchoolCity
            // 
            this.txtSchoolCity.Location = new System.Drawing.Point(89, 60);
            this.txtSchoolCity.Name = "txtSchoolCity";
            this.txtSchoolCity.Size = new System.Drawing.Size(229, 20);
            this.txtSchoolCity.TabIndex = 17;
            this.txtSchoolCity.TextChanged += new System.EventHandler(this.txtSchoolCity_TextChanged);
            // 
            // txtCellNo
            // 
            this.txtCellNo.Location = new System.Drawing.Point(89, 86);
            this.txtCellNo.Name = "txtCellNo";
            this.txtCellNo.Size = new System.Drawing.Size(113, 20);
            this.txtCellNo.TabIndex = 18;
            // 
            // pnlButtons
            // 
            this.pnlButtons.Controls.Add(this.btnCancel);
            this.pnlButtons.Controls.Add(this.btnOK);
            this.pnlButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlButtons.Location = new System.Drawing.Point(0, 123);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(357, 31);
            this.pnlButtons.TabIndex = 19;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(181, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnOK.Location = new System.Drawing.Point(100, 5);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // NewSchoolDetails
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(357, 154);
            this.Controls.Add(this.pnlButtons);
            this.Controls.Add(this.txtCellNo);
            this.Controls.Add(this.txtSchoolCity);
            this.Controls.Add(this.txtSchoolName);
            this.Controls.Add(this.lblCellNo);
            this.Controls.Add(this.lblSchoolCity);
            this.Controls.Add(this.lblSchoolName);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewSchoolDetails";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New School Details";
            this.Load += new System.EventHandler(this.NewSchoolDetails_Load);
            this.pnlButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSchoolName;
        private System.Windows.Forms.Label lblSchoolCity;
        private System.Windows.Forms.Label lblCellNo;
        private System.Windows.Forms.TextBox txtSchoolName;
        private System.Windows.Forms.TextBox txtSchoolCity;
        private System.Windows.Forms.TextBox txtCellNo;
        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}
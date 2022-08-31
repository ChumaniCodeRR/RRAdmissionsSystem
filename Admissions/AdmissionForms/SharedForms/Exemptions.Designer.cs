namespace Admissions.AdmissionForms
{
    partial class Exemptions
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
            this.gbExempt = new System.Windows.Forms.GroupBox();
            this.txtExempt4 = new System.Windows.Forms.TextBox();
            this.txtExempt3 = new System.Windows.Forms.TextBox();
            this.txtExempt2 = new System.Windows.Forms.TextBox();
            this.txtExempt1 = new System.Windows.Forms.TextBox();
            this.lblExempt1 = new System.Windows.Forms.Label();
            this.bs_exemptions = new System.Windows.Forms.BindingSource(this.components);
            this.lblTitle = new System.Windows.Forms.Label();
            this.gbExempt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bs_exemptions)).BeginInit();
            this.SuspendLayout();
            // 
            // gbExempt
            // 
            this.gbExempt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gbExempt.Controls.Add(this.txtExempt4);
            this.gbExempt.Controls.Add(this.txtExempt3);
            this.gbExempt.Controls.Add(this.txtExempt2);
            this.gbExempt.Controls.Add(this.txtExempt1);
            this.gbExempt.Controls.Add(this.lblExempt1);
            this.gbExempt.Location = new System.Drawing.Point(4, 27);
            this.gbExempt.Name = "gbExempt";
            this.gbExempt.Size = new System.Drawing.Size(541, 117);
            this.gbExempt.TabIndex = 13;
            this.gbExempt.TabStop = false;
            this.gbExempt.Text = "Exemptions";
            // 
            // txtExempt4
            // 
            this.txtExempt4.Location = new System.Drawing.Point(78, 91);
            this.txtExempt4.Name = "txtExempt4";
            this.txtExempt4.Size = new System.Drawing.Size(443, 20);
            this.txtExempt4.TabIndex = 8;
            // 
            // txtExempt3
            // 
            this.txtExempt3.Location = new System.Drawing.Point(78, 65);
            this.txtExempt3.Name = "txtExempt3";
            this.txtExempt3.Size = new System.Drawing.Size(443, 20);
            this.txtExempt3.TabIndex = 7;
            // 
            // txtExempt2
            // 
            this.txtExempt2.Location = new System.Drawing.Point(78, 39);
            this.txtExempt2.Name = "txtExempt2";
            this.txtExempt2.Size = new System.Drawing.Size(443, 20);
            this.txtExempt2.TabIndex = 6;
            // 
            // txtExempt1
            // 
            this.txtExempt1.Location = new System.Drawing.Point(78, 13);
            this.txtExempt1.Name = "txtExempt1";
            this.txtExempt1.Size = new System.Drawing.Size(443, 20);
            this.txtExempt1.TabIndex = 5;
            // 
            // lblExempt1
            // 
            this.lblExempt1.AutoSize = true;
            this.lblExempt1.Location = new System.Drawing.Point(6, 16);
            this.lblExempt1.Name = "lblExempt1";
            this.lblExempt1.Size = new System.Drawing.Size(59, 13);
            this.lblExempt1.TabIndex = 1;
            this.lblExempt1.Text = "Exemption:";
            // 
            // bs_exemptions
            // 
            this.bs_exemptions.DataSource = typeof(NS_Admissions.StrongTypesNS.DS_ADM_STUDataSet.TT_ADM_STUDataTable);
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(554, 24);
            this.lblTitle.TabIndex = 12;
            this.lblTitle.Text = "Exemptions";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Exemptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.gbExempt);
            this.Controls.Add(this.lblTitle);
            this.Name = "Exemptions";
            this.Size = new System.Drawing.Size(554, 149);
            this.gbExempt.ResumeLayout(false);
            this.gbExempt.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bs_exemptions)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbExempt;
        private System.Windows.Forms.TextBox txtExempt4;
        private System.Windows.Forms.TextBox txtExempt3;
        private System.Windows.Forms.TextBox txtExempt2;
        private System.Windows.Forms.TextBox txtExempt1;
        private System.Windows.Forms.Label lblExempt1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.BindingSource bs_exemptions;
    }
}

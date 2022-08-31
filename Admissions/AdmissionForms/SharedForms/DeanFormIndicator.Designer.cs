namespace Admissions.AdmissionForms
{
    partial class DeanFormIndicator
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.gbDeanForms = new System.Windows.Forms.GroupBox();
            this.chbxDeanRequest = new System.Windows.Forms.CheckBox();
            this.chbxHasForm = new System.Windows.Forms.CheckBox();
            this.gbDeanForms.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(212, 24);
            this.lblTitle.TabIndex = 12;
            this.lblTitle.Text = "Update Dean Form";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // gbDeanForms
            // 
            this.gbDeanForms.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gbDeanForms.Controls.Add(this.chbxDeanRequest);
            this.gbDeanForms.Controls.Add(this.chbxHasForm);
            this.gbDeanForms.Location = new System.Drawing.Point(4, 27);
            this.gbDeanForms.Name = "gbDeanForms";
            this.gbDeanForms.Size = new System.Drawing.Size(205, 72);
            this.gbDeanForms.TabIndex = 14;
            this.gbDeanForms.TabStop = false;
            this.gbDeanForms.Text = "Update Dean Form";
            // 
            // chbxDeanRequest
            // 
            this.chbxDeanRequest.AutoSize = true;
            this.chbxDeanRequest.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chbxDeanRequest.Location = new System.Drawing.Point(33, 44);
            this.chbxDeanRequest.Name = "chbxDeanRequest";
            this.chbxDeanRequest.Size = new System.Drawing.Size(139, 17);
            this.chbxDeanRequest.TabIndex = 1;
            this.chbxDeanRequest.Text = "Dean Requested Form?";
            this.chbxDeanRequest.UseVisualStyleBackColor = true;
            // 
            // chbxHasForm
            // 
            this.chbxHasForm.AutoSize = true;
            this.chbxHasForm.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chbxHasForm.Location = new System.Drawing.Point(66, 21);
            this.chbxHasForm.Name = "chbxHasForm";
            this.chbxHasForm.Size = new System.Drawing.Size(106, 17);
            this.chbxHasForm.TabIndex = 0;
            this.chbxHasForm.Text = "Dean Has Form?";
            this.chbxHasForm.UseVisualStyleBackColor = true;
            // 
            // DeanFormIndicator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.gbDeanForms);
            this.Controls.Add(this.lblTitle);
            this.Name = "DeanFormIndicator";
            this.Size = new System.Drawing.Size(212, 103);
            this.gbDeanForms.ResumeLayout(false);
            this.gbDeanForms.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox gbDeanForms;
        private System.Windows.Forms.CheckBox chbxDeanRequest;
        private System.Windows.Forms.CheckBox chbxHasForm;
    }
}

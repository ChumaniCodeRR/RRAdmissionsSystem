namespace Admissions.AdmissionForms
{
    partial class InternalAdmissionNotes
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.gbNotes = new System.Windows.Forms.GroupBox();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.bsAdmissionNotes = new System.Windows.Forms.BindingSource(this.components);
            this.gbNotes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsAdmissionNotes)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(353, 24);
            this.lblTitle.TabIndex = 11;
            this.lblTitle.Text = "Admission Notes";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // gbNotes
            // 
            this.gbNotes.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gbNotes.Controls.Add(this.txtNotes);
            this.gbNotes.Location = new System.Drawing.Point(4, 27);
            this.gbNotes.Name = "gbNotes";
            this.gbNotes.Size = new System.Drawing.Size(346, 185);
            this.gbNotes.TabIndex = 12;
            this.gbNotes.TabStop = false;
            this.gbNotes.Text = "Notes";
            // 
            // txtNotes
            // 
            this.txtNotes.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsAdmissionNotes, "NOTES", true));
            this.txtNotes.Location = new System.Drawing.Point(6, 19);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtNotes.Size = new System.Drawing.Size(334, 160);
            this.txtNotes.TabIndex = 0;
            this.txtNotes.GotFocus += new System.EventHandler(txtNotes_GotFocus);
            // 
            // bsAdmissionNotes
            // 
            this.bsAdmissionNotes.DataMember = "TT_ADM_NOTES";
            this.bsAdmissionNotes.DataSource = typeof(NS_Admissions.StrongTypesNS.DS_ADM_STUDataSet);
            // 
            // InternalAdmissionNotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.gbNotes);
            this.Controls.Add(this.lblTitle);
            this.Name = "InternalAdmissionNotes";
            this.Size = new System.Drawing.Size(353, 215);
            this.gbNotes.ResumeLayout(false);
            this.gbNotes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsAdmissionNotes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox gbNotes;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.BindingSource bsAdmissionNotes;
    }
}

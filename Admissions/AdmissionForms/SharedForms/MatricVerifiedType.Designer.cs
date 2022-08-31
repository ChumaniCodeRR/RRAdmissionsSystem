namespace Admissions.AdmissionForms
{
    partial class MatricVerifiedType
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
            this.gbMatric = new System.Windows.Forms.GroupBox();
            this.cbxType = new System.Windows.Forms.ComboBox();
            this.bs_gen = new System.Windows.Forms.BindingSource(this.components);
            this.lblGrossIncome = new System.Windows.Forms.Label();
            this.chbxVerified = new System.Windows.Forms.CheckBox();
            this.gbMatric.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bs_gen)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(309, 24);
            this.lblTitle.TabIndex = 7;
            this.lblTitle.Text = "Matric Verified/Type";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // gbMatric
            // 
            this.gbMatric.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gbMatric.Controls.Add(this.cbxType);
            this.gbMatric.Controls.Add(this.lblGrossIncome);
            this.gbMatric.Controls.Add(this.chbxVerified);
            this.gbMatric.Location = new System.Drawing.Point(4, 27);
            this.gbMatric.Name = "gbMatric";
            this.gbMatric.Size = new System.Drawing.Size(302, 85);
            this.gbMatric.TabIndex = 11;
            this.gbMatric.TabStop = false;
            this.gbMatric.Text = "Matric Verified/Type";
            // 
            // cbxType
            // 
            this.cbxType.DataSource = this.bs_gen;
            this.cbxType.DisplayMember = "descrip";
            this.cbxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxType.FormattingEnabled = true;
            this.cbxType.Location = new System.Drawing.Point(91, 44);
            this.cbxType.Name = "cbxType";
            this.cbxType.Size = new System.Drawing.Size(172, 21);
            this.cbxType.TabIndex = 2;
            this.cbxType.ValueMember = "code";
            // 
            // bs_gen
            // 
            this.bs_gen.DataSource = typeof(NS_System.StrongTypesNS.ds_genDataSet.TT_GENDataTable);
            // 
            // lblGrossIncome
            // 
            this.lblGrossIncome.AutoSize = true;
            this.lblGrossIncome.Location = new System.Drawing.Point(6, 47);
            this.lblGrossIncome.Name = "lblGrossIncome";
            this.lblGrossIncome.Size = new System.Drawing.Size(66, 13);
            this.lblGrossIncome.TabIndex = 1;
            this.lblGrossIncome.Text = "Matric Type:";
            // 
            // chbxVerified
            // 
            this.chbxVerified.AutoSize = true;
            this.chbxVerified.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chbxVerified.Location = new System.Drawing.Point(6, 21);
            this.chbxVerified.Name = "chbxVerified";
            this.chbxVerified.Size = new System.Drawing.Size(99, 17);
            this.chbxVerified.TabIndex = 0;
            this.chbxVerified.Text = "Matric Verified?";
            this.chbxVerified.UseVisualStyleBackColor = true;
            // 
            // MatricVerifiedType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.gbMatric);
            this.Controls.Add(this.lblTitle);
            this.Name = "MatricVerifiedType";
            this.Size = new System.Drawing.Size(309, 117);
            this.gbMatric.ResumeLayout(false);
            this.gbMatric.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bs_gen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox gbMatric;
        private System.Windows.Forms.Label lblGrossIncome;
        private System.Windows.Forms.CheckBox chbxVerified;
        private System.Windows.Forms.ComboBox cbxType;
        private System.Windows.Forms.BindingSource bs_gen;
    }
}

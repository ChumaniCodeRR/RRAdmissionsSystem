namespace Admissions.UtilityScreens
{
    partial class NbtResults
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_student = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_ql = new System.Windows.Forms.TextBox();
            this.bs_nbt = new System.Windows.Forms.BindingSource(this.components);
            this.txt_maths = new System.Windows.Forms.TextBox();
            this.txt_al = new System.Windows.Forms.TextBox();
            this.txt_nbt_ref = new System.Windows.Forms.TextBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bs_nbt)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(421, 24);
            this.lblTitle.TabIndex = 6;
            this.lblTitle.Text = "National Benchmarks";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Student:";
            // 
            // txt_student
            // 
            this.txt_student.Location = new System.Drawing.Point(145, 34);
            this.txt_student.Name = "txt_student";
            this.txt_student.ReadOnly = true;
            this.txt_student.Size = new System.Drawing.Size(255, 20);
            this.txt_student.TabIndex = 100;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Maths:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Quantitative Literacy:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Academic Literancy:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "NBT Reference Number:";
            // 
            // txt_ql
            // 
            this.txt_ql.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs_nbt, "QL", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txt_ql.Location = new System.Drawing.Point(145, 127);
            this.txt_ql.Name = "txt_ql";
            this.txt_ql.Size = new System.Drawing.Size(46, 20);
            this.txt_ql.TabIndex = 30;
            // 
            // bs_nbt
            // 
            this.bs_nbt.DataSource = typeof(NS_Admissions.StrongTypesNS.ds_nbt_fileDataSet.tt_nbtfileDataTable);
            // 
            // txt_maths
            // 
            this.txt_maths.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs_nbt, "MATH", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txt_maths.Location = new System.Drawing.Point(145, 153);
            this.txt_maths.Name = "txt_maths";
            this.txt_maths.Size = new System.Drawing.Size(46, 20);
            this.txt_maths.TabIndex = 40;
            // 
            // txt_al
            // 
            this.txt_al.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs_nbt, "AL", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txt_al.Location = new System.Drawing.Point(145, 101);
            this.txt_al.Name = "txt_al";
            this.txt_al.Size = new System.Drawing.Size(46, 20);
            this.txt_al.TabIndex = 20;
            // 
            // txt_nbt_ref
            // 
            this.txt_nbt_ref.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs_nbt, "nbt_ref", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txt_nbt_ref.Location = new System.Drawing.Point(145, 60);
            this.txt_nbt_ref.Name = "txt_nbt_ref";
            this.txt_nbt_ref.Size = new System.Drawing.Size(155, 20);
            this.txt_nbt_ref.TabIndex = 10;
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(132, 191);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 50;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(213, 191);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 60;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // NbtResults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(421, 221);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.txt_nbt_ref);
            this.Controls.Add(this.txt_al);
            this.Controls.Add(this.txt_maths);
            this.Controls.Add(this.txt_ql);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_student);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NbtResults";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "National Benchmarks";
            this.Load += new System.EventHandler(this.NbtResults_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bs_nbt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_student;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_ql;
        private System.Windows.Forms.TextBox txt_maths;
        private System.Windows.Forms.TextBox txt_al;
        private System.Windows.Forms.TextBox txt_nbt_ref;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.BindingSource bs_nbt;
    }
}
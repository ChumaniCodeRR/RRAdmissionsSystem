﻿namespace Admissions.AdmissionReports
{
    partial class AnyAdmissionStatus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnyAdmissionStatus));
            this.cb_faculty = new System.Windows.Forms.ComboBox();
            this.bs_faculty = new System.Windows.Forms.BindingSource(this.components);
            this.lblFaculty = new System.Windows.Forms.Label();
            this.lblStartDte = new System.Windows.Forms.Label();
            this.cb_nationality = new System.Windows.Forms.ComboBox();
            this.cb_status = new System.Windows.Forms.ComboBox();
            this.bs_appstatus = new System.Windows.Forms.BindingSource(this.components);
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_proceed = new System.Windows.Forms.Button();
            this.lblNationality = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_Degree = new System.Windows.Forms.ComboBox();
            this.bs_degree = new System.Windows.Forms.BindingSource(this.components);
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.cb_Entry = new System.Windows.Forms.ComboBox();
            this.lblEndDte = new System.Windows.Forms.Label();
            this.lblDegree = new System.Windows.Forms.Label();
            this.lblEntry = new System.Windows.Forms.Label();
            this.chbxPhone = new System.Windows.Forms.CheckBox();
            this.chbxHomeAdress = new System.Windows.Forms.CheckBox();
            this.btnExport = new System.Windows.Forms.Button();
            this.chbxFoundation = new System.Windows.Forms.CheckBox();
            this.chbxCancel = new System.Windows.Forms.CheckBox();
            this.chbxDeposit = new System.Windows.Forms.CheckBox();
            this.chbxUC = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnCitizen = new System.Windows.Forms.RadioButton();
            this.rbtnEntry = new System.Windows.Forms.RadioButton();
            this.rbtnName = new System.Windows.Forms.RadioButton();
            this.rbtnFaculty = new System.Windows.Forms.RadioButton();
            this.rbtnDegree = new System.Windows.Forms.RadioButton();
            this.rbtnApp = new System.Windows.Forms.RadioButton();
            this.chbxDeanRequest = new System.Windows.Forms.CheckBox();
            this.chbxDeanHasForm = new System.Windows.Forms.CheckBox();
            this.chbxEmail = new System.Windows.Forms.CheckBox();
            this.chbxDeanComment = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.bs_faculty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_appstatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_degree)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cb_faculty
            // 
            this.cb_faculty.DataSource = this.bs_faculty;
            this.cb_faculty.DisplayMember = "descrip";
            this.cb_faculty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_faculty.FormattingEnabled = true;
            this.cb_faculty.Location = new System.Drawing.Point(80, 39);
            this.cb_faculty.Name = "cb_faculty";
            this.cb_faculty.Size = new System.Drawing.Size(239, 21);
            this.cb_faculty.TabIndex = 10;
            this.cb_faculty.ValueMember = "descrip";
            this.cb_faculty.SelectedIndexChanged += new System.EventHandler(this.cb_faculty_SelectedIndexChanged);
            // 
            // bs_faculty
            // 
            this.bs_faculty.DataSource = typeof(NS_System.StrongTypesNS.ds_genDataSet.TT_GENDataTable);
            // 
            // lblFaculty
            // 
            this.lblFaculty.AutoSize = true;
            this.lblFaculty.Location = new System.Drawing.Point(30, 42);
            this.lblFaculty.Name = "lblFaculty";
            this.lblFaculty.Size = new System.Drawing.Size(44, 13);
            this.lblFaculty.TabIndex = 24;
            this.lblFaculty.Text = "Faculty:";
            // 
            // lblStartDte
            // 
            this.lblStartDte.AutoSize = true;
            this.lblStartDte.Location = new System.Drawing.Point(16, 96);
            this.lblStartDte.Name = "lblStartDte";
            this.lblStartDte.Size = new System.Drawing.Size(58, 13);
            this.lblStartDte.TabIndex = 22;
            this.lblStartDte.Text = "Start Date:";
            // 
            // cb_nationality
            // 
            this.cb_nationality.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_nationality.FormattingEnabled = true;
            this.cb_nationality.Location = new System.Drawing.Point(80, 172);
            this.cb_nationality.Name = "cb_nationality";
            this.cb_nationality.Size = new System.Drawing.Size(239, 21);
            this.cb_nationality.TabIndex = 50;
            // 
            // cb_status
            // 
            this.cb_status.DataSource = this.bs_appstatus;
            this.cb_status.DisplayMember = "descrip";
            this.cb_status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_status.FormattingEnabled = true;
            this.cb_status.Location = new System.Drawing.Point(80, 12);
            this.cb_status.Name = "cb_status";
            this.cb_status.Size = new System.Drawing.Size(239, 21);
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
            this.btn_close.Location = new System.Drawing.Point(280, 318);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(75, 23);
            this.btn_close.TabIndex = 120;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_proceed
            // 
            this.btn_proceed.Location = new System.Drawing.Point(118, 318);
            this.btn_proceed.Name = "btn_proceed";
            this.btn_proceed.Size = new System.Drawing.Size(75, 23);
            this.btn_proceed.TabIndex = 110;
            this.btn_proceed.Text = "Report";
            this.btn_proceed.UseVisualStyleBackColor = true;
            this.btn_proceed.Click += new System.EventHandler(this.btn_proceed_Click);
            // 
            // lblNationality
            // 
            this.lblNationality.AutoSize = true;
            this.lblNationality.Location = new System.Drawing.Point(14, 175);
            this.lblNationality.Name = "lblNationality";
            this.lblNationality.Size = new System.Drawing.Size(60, 13);
            this.lblNationality.TabIndex = 17;
            this.lblNationality.Text = "Citizenship:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Status:";
            // 
            // cb_Degree
            // 
            this.cb_Degree.DataSource = this.bs_degree;
            this.cb_Degree.DisplayMember = "degree";
            this.cb_Degree.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Degree.FormattingEnabled = true;
            this.cb_Degree.Location = new System.Drawing.Point(80, 66);
            this.cb_Degree.Name = "cb_Degree";
            this.cb_Degree.Size = new System.Drawing.Size(239, 21);
            this.cb_Degree.TabIndex = 20;
            this.cb_Degree.ValueMember = "degr";
            // 
            // bs_degree
            // 
            this.bs_degree.DataSource = typeof(NS_System.StrongTypesNS.ds_deg_facultyDataSet.tt_deg_by_facultyDataTable);
            // 
            // dtpStart
            // 
            this.dtpStart.Location = new System.Drawing.Point(80, 93);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(239, 20);
            this.dtpStart.TabIndex = 25;
            this.dtpStart.Value = new System.DateTime(2017, 5, 4, 0, 0, 0, 0);
            // 
            // dtpEnd
            // 
            this.dtpEnd.Location = new System.Drawing.Point(80, 119);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(239, 20);
            this.dtpEnd.TabIndex = 30;
            this.dtpEnd.Value = new System.DateTime(2017, 5, 4, 0, 0, 0, 0);
            // 
            // cb_Entry
            // 
            this.cb_Entry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Entry.FormattingEnabled = true;
            this.cb_Entry.Location = new System.Drawing.Point(80, 145);
            this.cb_Entry.Name = "cb_Entry";
            this.cb_Entry.Size = new System.Drawing.Size(239, 21);
            this.cb_Entry.TabIndex = 40;
            // 
            // lblEndDte
            // 
            this.lblEndDte.AutoSize = true;
            this.lblEndDte.Location = new System.Drawing.Point(19, 122);
            this.lblEndDte.Name = "lblEndDte";
            this.lblEndDte.Size = new System.Drawing.Size(55, 13);
            this.lblEndDte.TabIndex = 30;
            this.lblEndDte.Text = "End Date:";
            // 
            // lblDegree
            // 
            this.lblDegree.AutoSize = true;
            this.lblDegree.Location = new System.Drawing.Point(29, 69);
            this.lblDegree.Name = "lblDegree";
            this.lblDegree.Size = new System.Drawing.Size(45, 13);
            this.lblDegree.TabIndex = 31;
            this.lblDegree.Text = "Degree:";
            // 
            // lblEntry
            // 
            this.lblEntry.AutoSize = true;
            this.lblEntry.Location = new System.Drawing.Point(7, 148);
            this.lblEntry.Name = "lblEntry";
            this.lblEntry.Size = new System.Drawing.Size(67, 13);
            this.lblEntry.TabIndex = 32;
            this.lblEntry.Text = "Entry Status:";
            // 
            // chbxPhone
            // 
            this.chbxPhone.AutoSize = true;
            this.chbxPhone.Location = new System.Drawing.Point(230, 222);
            this.chbxPhone.Name = "chbxPhone";
            this.chbxPhone.Size = new System.Drawing.Size(140, 17);
            this.chbxPhone.TabIndex = 70;
            this.chbxPhone.Text = "Include Phone Numbers";
            this.chbxPhone.UseVisualStyleBackColor = true;
            // 
            // chbxHomeAdress
            // 
            this.chbxHomeAdress.AutoSize = true;
            this.chbxHomeAdress.Location = new System.Drawing.Point(230, 199);
            this.chbxHomeAdress.Name = "chbxHomeAdress";
            this.chbxHomeAdress.Size = new System.Drawing.Size(125, 17);
            this.chbxHomeAdress.TabIndex = 60;
            this.chbxHomeAdress.Text = "Show Home Address";
            this.chbxHomeAdress.UseVisualStyleBackColor = true;
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(199, 318);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(75, 23);
            this.btnExport.TabIndex = 115;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // chbxFoundation
            // 
            this.chbxFoundation.AutoSize = true;
            this.chbxFoundation.Enabled = false;
            this.chbxFoundation.Location = new System.Drawing.Point(14, 245);
            this.chbxFoundation.Name = "chbxFoundation";
            this.chbxFoundation.Size = new System.Drawing.Size(210, 17);
            this.chbxFoundation.TabIndex = 75;
            this.chbxFoundation.Text = "Show Foundation Course students only";
            this.chbxFoundation.UseVisualStyleBackColor = true;
            // 
            // chbxCancel
            // 
            this.chbxCancel.AutoSize = true;
            this.chbxCancel.Location = new System.Drawing.Point(14, 199);
            this.chbxCancel.Name = "chbxCancel";
            this.chbxCancel.Size = new System.Drawing.Size(156, 17);
            this.chbxCancel.TabIndex = 55;
            this.chbxCancel.Text = "Show cancelled admissions";
            this.chbxCancel.UseVisualStyleBackColor = true;
            // 
            // chbxDeposit
            // 
            this.chbxDeposit.AutoSize = true;
            this.chbxDeposit.Location = new System.Drawing.Point(14, 222);
            this.chbxDeposit.Name = "chbxDeposit";
            this.chbxDeposit.Size = new System.Drawing.Size(208, 17);
            this.chbxDeposit.TabIndex = 65;
            this.chbxDeposit.Text = "Show replied forms but no deposit paid";
            this.chbxDeposit.UseVisualStyleBackColor = true;
            // 
            // chbxUC
            // 
            this.chbxUC.AutoSize = true;
            this.chbxUC.Location = new System.Drawing.Point(230, 245);
            this.chbxUC.Name = "chbxUC";
            this.chbxUC.Size = new System.Drawing.Size(107, 17);
            this.chbxUC.TabIndex = 80;
            this.chbxUC.Text = "List of UC Letters";
            this.chbxUC.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnCitizen);
            this.groupBox1.Controls.Add(this.rbtnEntry);
            this.groupBox1.Controls.Add(this.rbtnName);
            this.groupBox1.Controls.Add(this.rbtnFaculty);
            this.groupBox1.Controls.Add(this.rbtnDegree);
            this.groupBox1.Controls.Add(this.rbtnApp);
            this.groupBox1.Location = new System.Drawing.Point(325, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(127, 162);
            this.groupBox1.TabIndex = 95;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sort Options";
            // 
            // rbtnCitizen
            // 
            this.rbtnCitizen.AutoSize = true;
            this.rbtnCitizen.Location = new System.Drawing.Point(6, 135);
            this.rbtnCitizen.Name = "rbtnCitizen";
            this.rbtnCitizen.Size = new System.Drawing.Size(111, 17);
            this.rbtnCitizen.TabIndex = 101;
            this.rbtnCitizen.Text = "Sort by Citizenship";
            this.rbtnCitizen.UseVisualStyleBackColor = true;
            // 
            // rbtnEntry
            // 
            this.rbtnEntry.AutoSize = true;
            this.rbtnEntry.Location = new System.Drawing.Point(6, 112);
            this.rbtnEntry.Name = "rbtnEntry";
            this.rbtnEntry.Size = new System.Drawing.Size(118, 17);
            this.rbtnEntry.TabIndex = 100;
            this.rbtnEntry.Text = "Sort by Entry Status";
            this.rbtnEntry.UseVisualStyleBackColor = true;
            // 
            // rbtnName
            // 
            this.rbtnName.AutoSize = true;
            this.rbtnName.Checked = true;
            this.rbtnName.Location = new System.Drawing.Point(6, 20);
            this.rbtnName.Name = "rbtnName";
            this.rbtnName.Size = new System.Drawing.Size(103, 17);
            this.rbtnName.TabIndex = 96;
            this.rbtnName.TabStop = true;
            this.rbtnName.Text = "Sort by Surname";
            this.rbtnName.UseVisualStyleBackColor = true;
            // 
            // rbtnFaculty
            // 
            this.rbtnFaculty.AutoSize = true;
            this.rbtnFaculty.Location = new System.Drawing.Point(6, 66);
            this.rbtnFaculty.Name = "rbtnFaculty";
            this.rbtnFaculty.Size = new System.Drawing.Size(95, 17);
            this.rbtnFaculty.TabIndex = 98;
            this.rbtnFaculty.Text = "Sort by Faculty";
            this.rbtnFaculty.UseVisualStyleBackColor = true;
            // 
            // rbtnDegree
            // 
            this.rbtnDegree.AutoSize = true;
            this.rbtnDegree.Location = new System.Drawing.Point(6, 43);
            this.rbtnDegree.Name = "rbtnDegree";
            this.rbtnDegree.Size = new System.Drawing.Size(96, 17);
            this.rbtnDegree.TabIndex = 97;
            this.rbtnDegree.Text = "Sort by Degree";
            this.rbtnDegree.UseVisualStyleBackColor = true;
            // 
            // rbtnApp
            // 
            this.rbtnApp.AutoSize = true;
            this.rbtnApp.Location = new System.Drawing.Point(6, 89);
            this.rbtnApp.Name = "rbtnApp";
            this.rbtnApp.Size = new System.Drawing.Size(116, 17);
            this.rbtnApp.TabIndex = 99;
            this.rbtnApp.Text = "Sort by App. Status";
            this.rbtnApp.UseVisualStyleBackColor = true;
            // 
            // chbxDeanRequest
            // 
            this.chbxDeanRequest.AutoSize = true;
            this.chbxDeanRequest.Location = new System.Drawing.Point(14, 268);
            this.chbxDeanRequest.Name = "chbxDeanRequest";
            this.chbxDeanRequest.Size = new System.Drawing.Size(193, 17);
            this.chbxDeanRequest.TabIndex = 85;
            this.chbxDeanRequest.Text = "Print List of Forms Dean Requested";
            this.chbxDeanRequest.UseVisualStyleBackColor = true;
            this.chbxDeanRequest.CheckedChanged += new System.EventHandler(this.chbxDeanRequest_CheckedChanged);
            // 
            // chbxDeanHasForm
            // 
            this.chbxDeanHasForm.AutoSize = true;
            this.chbxDeanHasForm.Location = new System.Drawing.Point(230, 268);
            this.chbxDeanHasForm.Name = "chbxDeanHasForm";
            this.chbxDeanHasForm.Size = new System.Drawing.Size(220, 17);
            this.chbxDeanHasForm.TabIndex = 90;
            this.chbxDeanHasForm.Text = "Print List of Forms Outstanding with Dean";
            this.chbxDeanHasForm.UseVisualStyleBackColor = true;
            this.chbxDeanHasForm.CheckedChanged += new System.EventHandler(this.chbxDeanHasForm_CheckedChanged);
            // 
            // chbxEmail
            // 
            this.chbxEmail.AutoSize = true;
            this.chbxEmail.Location = new System.Drawing.Point(14, 291);
            this.chbxEmail.Name = "chbxEmail";
            this.chbxEmail.Size = new System.Drawing.Size(110, 17);
            this.chbxEmail.TabIndex = 95;
            this.chbxEmail.Text = "Print list of E-mails";
            this.chbxEmail.UseVisualStyleBackColor = true;
            // 
            // chbxDeanComment
            // 
            this.chbxDeanComment.AutoSize = true;
            this.chbxDeanComment.Enabled = false;
            this.chbxDeanComment.Location = new System.Drawing.Point(230, 291);
            this.chbxDeanComment.Name = "chbxDeanComment";
            this.chbxDeanComment.Size = new System.Drawing.Size(134, 17);
            this.chbxDeanComment.TabIndex = 100;
            this.chbxDeanComment.Text = "Show Dean Comments";
            this.chbxDeanComment.UseVisualStyleBackColor = true;
            // 
            // AnyAdmissionStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(464, 353);
            this.Controls.Add(this.chbxDeanComment);
            this.Controls.Add(this.chbxEmail);
            this.Controls.Add(this.chbxDeanHasForm);
            this.Controls.Add(this.chbxDeanRequest);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chbxUC);
            this.Controls.Add(this.chbxDeposit);
            this.Controls.Add(this.chbxCancel);
            this.Controls.Add(this.chbxFoundation);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.chbxHomeAdress);
            this.Controls.Add(this.chbxPhone);
            this.Controls.Add(this.lblEntry);
            this.Controls.Add(this.lblDegree);
            this.Controls.Add(this.lblEndDte);
            this.Controls.Add(this.cb_Entry);
            this.Controls.Add(this.dtpEnd);
            this.Controls.Add(this.dtpStart);
            this.Controls.Add(this.cb_Degree);
            this.Controls.Add(this.cb_faculty);
            this.Controls.Add(this.lblFaculty);
            this.Controls.Add(this.lblStartDte);
            this.Controls.Add(this.cb_nationality);
            this.Controls.Add(this.cb_status);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_proceed);
            this.Controls.Add(this.lblNationality);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AnyAdmissionStatus";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Any Admission Status";
            this.Load += new System.EventHandler(this.AnyAdmissionStatus_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bs_faculty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_appstatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_degree)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_faculty;
        private System.Windows.Forms.Label lblFaculty;
        private System.Windows.Forms.Label lblStartDte;
        private System.Windows.Forms.ComboBox cb_nationality;
        private System.Windows.Forms.ComboBox cb_status;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_proceed;
        private System.Windows.Forms.Label lblNationality;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_Degree;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.ComboBox cb_Entry;
        private System.Windows.Forms.Label lblEndDte;
        private System.Windows.Forms.Label lblDegree;
        private System.Windows.Forms.Label lblEntry;
        private System.Windows.Forms.CheckBox chbxPhone;
        private System.Windows.Forms.CheckBox chbxHomeAdress;
        private System.Windows.Forms.BindingSource bs_faculty;
        private System.Windows.Forms.BindingSource bs_appstatus;
        private System.Windows.Forms.BindingSource bs_degree;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.CheckBox chbxFoundation;
        private System.Windows.Forms.CheckBox chbxCancel;
        private System.Windows.Forms.CheckBox chbxDeposit;
        private System.Windows.Forms.CheckBox chbxUC;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtnName;
        private System.Windows.Forms.RadioButton rbtnFaculty;
        private System.Windows.Forms.RadioButton rbtnDegree;
        private System.Windows.Forms.RadioButton rbtnApp;
        private System.Windows.Forms.RadioButton rbtnCitizen;
        private System.Windows.Forms.RadioButton rbtnEntry;
        private System.Windows.Forms.CheckBox chbxDeanRequest;
        private System.Windows.Forms.CheckBox chbxDeanHasForm;
        private System.Windows.Forms.CheckBox chbxEmail;
        private System.Windows.Forms.CheckBox chbxDeanComment;
    }
}
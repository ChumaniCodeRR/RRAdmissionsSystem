﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NS_Admissions.StrongTypesNS;
using Utilities;

namespace Admissions.UtilityScreens
{
    public partial class MatricPoints : Form
    {
        DS_ADM_STUDataSet ds_adm_stu;
        string decline_message;
        bool adm;
        public bool degChange = false;

        public MatricPoints()
        {
            InitializeComponent();
        }

        public MatricPoints(bool adm, DS_ADM_STUDataSet ds_adm_stu, string decline_message)
            : this()
        {
            this.ds_adm_stu = ds_adm_stu;
            this.decline_message = decline_message;
            this.adm = adm;
        }

        private void MatricSubjOptions_Load(object sender, EventArgs e)
        {
            bool iCheck = false;
            if (adm == false) txtProvUnwtd.ReadOnly = txtProvWtd.ReadOnly = txtFinalUnwt.ReadOnly = txtFinalWtd.ReadOnly = false;

            try
            {
                if (ds_adm_stu.TT_ADM_STU.Rows.Count > 0)
                {
                    bsAdmStudent.DataSource = ds_adm_stu.TT_ADM_STU;
                }


                if (ds_adm_stu.TT_ADM.Rows.Count > 0)
                {
                 /*   if (ds_adm_stu.TT_ADM[0].DEGR1.ToString().StartsWith("LLB") && Global.Global.ChangeShow == "Show")
                    {
                        iCheck = true;
                        lblDeclineMessage.Visible = false;
                        btnChangeDegree.Visible = true;
                    }
                    if (ds_adm_stu.TT_ADM[0].DEGR2.ToString().StartsWith("LLB") && Global.Global.ChangeShow == "Show")
                    {
                        iCheck = true;
                        lblDeclineMessage.Visible = false;
                        btnChangeDegree.Visible = true;
                    } */
                }

                if (!iCheck)
                {
                    if (decline_message.Length > 0)
                    {
                        lblDeclineMessage.Visible = true;
                        lblDeclineMessage.Text = decline_message;
                    }
                    else { lblDeclineMessage.Visible = false; }
                } 
            }
            catch (Exception ex)
            {
                Utils.HandleException(ExceptionSource.Admissions, ex);
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                if (adm == false)
                {
                    string temperror = Proxy.Admissions.UPDATE_FINAL_PROV_MAT_PTS(Global.Global.FromWhere, ds_adm_stu);
                    if (temperror != string.Empty) MessageBox.Show(temperror, "Update Matric Points", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            catch (Exception ex)
            {
                Utils.HandleException(ExceptionSource.Admissions, ex);
            }
        }

        private void btnChangeDegree_Click(object sender, EventArgs e)
        {
            degChange = true;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utilities;

namespace Admissions.AdmissionForms.Undergraduate
{
    public partial class AcceptanceOffer : Form
    {
        string tempstu;
        string feedback;
        NS_Admissions.StrongTypesNS.ds_stuofferDataSet ds_stuoffer = new NS_Admissions.StrongTypesNS.ds_stuofferDataSet();

        public AcceptanceOffer()
        {
            InitializeComponent();
        }

        private void AcceptanceOffer_Load(object sender, EventArgs e)
        {
            pnlMain.Enabled = false;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Search_Grid_Students.Search_Grid_Students frmStuSearch = new Search_Grid_Students.Search_Grid_Students(true);
            frmStuSearch.ShowDialog();
            if (!string.IsNullOrEmpty(frmStuSearch.Stuno.Trim()))
            {
                Populate_student(frmStuSearch.Stuno);
            }
        }

        private void Populate_student(string _tempstu)
        {
            try
            {
                tempstu = _tempstu;
                feedback = Proxy.Admissions.student_accept_offer(tempstu, out ds_stuoffer);

                if (feedback != "")
                {
                    MessageBox.Show(feedback, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ClearAll();
                }
                else
                {
                    bs_studentoffer.DataSource = ds_stuoffer.tt_stu_offer;
                    pnlMain.Enabled = true;
                    txtstuno.Enabled = false;
                    btnSearch.Enabled = false;
                }

            }
            catch (Exception ex)
            {
                Utils.HandleException(ExceptionSource.DMU, ex);
            }
        }

        private void ClearAll()
        {
            ds_stuoffer = new NS_Admissions.StrongTypesNS.ds_stuofferDataSet();
            bs_studentoffer.DataSource = ds_stuoffer.tt_stu_offer;
            pnlMain.Enabled = false;
            txtstuno.Enabled = true;
            btnSearch.Enabled = true;
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {

                if (txtstuno.Text == "")  MessageBox.Show("Please enter a student number", "Missing student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    feedback = Proxy.Admissions.save_student_offer(ds_stuoffer);

                    if (feedback.StartsWith("Error") == true) MessageBox.Show(feedback, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                    {
                        MessageBox.Show(feedback, "Acceptance of Offer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearAll();
                        btnSearch.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                Utils.HandleException(ExceptionSource.DMU, ex);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearAll();
            btnSearch.Focus();
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtstuno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (txtstuno.Text != string.Empty)
                {
                    Populate_student(txtstuno.Text);
                }
            }
        }

    }
}

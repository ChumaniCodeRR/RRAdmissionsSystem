using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Admissions.UtilityScreens
{
    public partial class NewSchoolDetails : Form
    {
        

        public NewSchoolDetails()
        {
            InitializeComponent();
        
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (IsValidSchoolDetails())
            {
                schoolName = txtSchoolName.Text.Trim();
                schoolCity = txtSchoolCity.Text.Trim();
                cellNumber = txtCellNo.Text.Trim();
                
                DialogResult = DialogResult.OK;
            }
        }

        private void txtSchoolName_TextChanged(object sender, EventArgs e)
        {
            errorProvider.SetError(txtSchoolName, string.Empty);
        }

        private void txtSchoolCity_TextChanged(object sender, EventArgs e)
        {
            errorProvider.SetError(txtSchoolCity, string.Empty);
        }

        bool IsValidSchoolDetails()
        {
            errorProvider.Clear();
            bool valid = true;

            if (string.IsNullOrEmpty(txtSchoolName.Text.Trim()))
            {
                valid = false;
                errorProvider.SetError(txtSchoolName, "School name is required.");
            }

            if (string.IsNullOrEmpty(txtSchoolCity.Text.Trim()))
            {
                valid = false;
                errorProvider.SetError(txtSchoolCity, "School city is required.");
            }

            return valid;
        }

        string schoolName;

        public string SchoolName
        {
            get { return schoolName; }
            set { schoolName = value; }
        }

        string schoolCity;

        public string SchoolCity
        {
            get { return schoolCity; }
            set { schoolCity = value; }
        }

        string cellNumber;

        public string CellNumber
        {
            get { return cellNumber; }
            set { cellNumber = value; }
        }

        private void NewSchoolDetails_Load(object sender, EventArgs e)
        {
            txtSchoolName.Text = Admissions.Utilities.AdmissionStateItems.schoolname;
        }
    }
}

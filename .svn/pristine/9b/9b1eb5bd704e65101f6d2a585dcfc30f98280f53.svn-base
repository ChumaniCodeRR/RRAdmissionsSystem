using System;
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
    public partial class ResidenceLookup : Form
    {
        DS_ADM_RESDataSet ds_adm_res;

        public ResidenceLookup()
        {
            InitializeComponent();
            dgvResidenceLookup.AutoGenerateColumns = false;
            dgvResidenceLookup.Columns[cGender.Name].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        public ResidenceLookup(DS_ADM_RESDataSet ds_adm_res)
            : this()
        {
            this.ds_adm_res = ds_adm_res;
        }

        private void ResidenceLookup_Load(object sender, EventArgs e)
        {
            FilterResidences();
        }

        private void txtResName_TextChanged(object sender, EventArgs e)
        {
            FilterResidences();
        }

        private void ckActiveOnly_CheckedChanged(object sender, EventArgs e)
        {
            FilterResidences();
        }

        void dgvResidenceLookup_CellDoubleClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {
            SelectResidence();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            SelectResidence();
        }

        void FilterResidences()
        {
            try
            {
                DataView dvResidences = new DataView(ds_adm_res.TT_ADM_RES);

                string filter = string.Format("res_name LIKE '*{0}*'", txtResName.Text.Trim());
                if (ckActiveOnly.Checked) filter = string.Concat(filter, " AND active = true");

                dvResidences.RowFilter = filter;
                dvResidences.Sort = "res_name";

                dgvResidenceLookup.DataSource = dvResidences;
            }
            catch (Exception ex)
            {
                Utils.HandleException(ExceptionSource.Admissions, ex);
            }
        }

        void SelectResidence()
        {
            try
            {
                if (dgvResidenceLookup.SelectedRows.Count.Equals(0))
                {
                    string msg = "There is no selected residence.";
                    MessageBox.Show(msg, "Admissions", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                resCode = int.Parse(dgvResidenceLookup.SelectedRows[0].Cells[cResCode.Name].Value.ToString());
                DialogResult = System.Windows.Forms.DialogResult.OK;
            }
            catch (Exception ex)
            {
                Utils.HandleException(ExceptionSource.Admissions, ex);
            }
        }

        int resCode;

        public int ResCode
        {
            get { return resCode; }
            set { resCode = value; }
        }
    }
}

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
    public partial class RhodesDegree : Form
    {
        bool valid = true;
        DS_DEG_LOOKUPDataSet ds_deg_lookup;

        public RhodesDegree()
        {
            InitializeComponent();
            dgvDegreeLookup.AutoGenerateColumns = false;
        }

        public RhodesDegree(DS_DEG_LOOKUPDataSet ds_deg_lookup)
            : this()
        {
            this.ds_deg_lookup = ds_deg_lookup;
        }

        private void RhodesDegree_Load(object sender, EventArgs e)
        {
            //dgvDegreeLookup.DataSource = ds_deg_lookup.TT_DEG_LOOKUP;
            Invoke(new EventHandler(txtFilter_TextChanged), sender, e);
        }

        void RhodesDegree_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {
            if (DialogResult.Equals(DialogResult.OK))
            {
                if (!valid) e.Cancel = true;
                else deg = dgvDegreeLookup.SelectedRows[0].Cells[cDegree.Name].Value.ToString();
            }
        }

        void dgvDegreeLookup_DataBindingComplete(object sender, System.Windows.Forms.DataGridViewBindingCompleteEventArgs e)
        {
            dgvDegreeLookup.ClearSelection();
        }

        void dgvDegreeLookup_CellDoubleClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex < 0 || e.RowIndex < 0) return;
            
            DialogResult = DialogResult.OK;
            Invoke(new EventHandler(btnOK_Click), sender, EventArgs.Empty);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            valid = true;
            if (dgvDegreeLookup.SelectedRows.Count.Equals(0))
            {
                valid = false;
                MessageBox.Show("There is no selected degree", "Admissions", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        string deg;

        public string Deg
        {
            get { return deg; }
            set { deg = value; }
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataView dvDegreeLookup = new DataView(ds_deg_lookup.TT_DEG_LOOKUP);
                dvDegreeLookup.Sort = "DEGREE";
                dvDegreeLookup.RowFilter = string.Concat("DEGR LIKE '*", txtFilter.Text.Trim(), "*' OR DEGREE LIKE '*", txtFilter.Text.Trim(), "*'");
                dgvDegreeLookup.DataSource = dvDegreeLookup;
            }
            catch (Exception ex)
            {
                Utils.HandleException(ExceptionSource.Admissions, ex);
            }
        }
    }
}

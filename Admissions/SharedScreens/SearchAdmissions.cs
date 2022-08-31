using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Utilities;

namespace Admissions
{
    public partial class SearchAdmission : Form
    {

        DataView dv_list;
        string _Refno;
        string _TempActive;

        string AcadStat = "*";
        string Tempdept;

        public string TempAcitve
        {
            get { return _TempActive; }
            set { _TempActive = value; }
        }

        public string Refno
        {
            get { return _Refno; }
            set { _Refno = value; }
        }


        public SearchAdmission(string _Tempdept,string _AcadStat)
        {
            InitializeComponent();
            AcadStat = _AcadStat;
            Tempdept = _Tempdept;
        }

        private void SearchAdmission_Load(object sender, EventArgs e)
        {
            if (AcadStat == "PG") rb_mastphd.Checked = true;
            else if (AcadStat == "UG") rb_ug.Checked = true;
        }

        private void acadstat_changed()
        {
            AcadStat = "*";
            if (rb_ug.Checked) AcadStat = "UG";
            else if (rb_honours.Checked) AcadStat = "Honours";
            else if (rb_mastphd.Checked) AcadStat = "MastPhd";
            
            dg_list.ClearSelection();
        }

        private void get_list()
        {
            try
            {
                NS_Admissions.StrongTypesNS.DS_XADMDataSet ds_xadm = Proxy.Admissions.get_current_admissions(Tempdept, AcadStat, txt_reference.Text.ToString(), txt_surn.Text.ToString(), txt_id.Text.ToString(), txt_stu.Text.ToString(), txt_email.Text.ToString());
                dv_list = new DataView(ds_xadm.tt_xadm);
                filter();
            }
            catch (Exception ex)
            {
                Utils.HandleException(ExceptionSource.Admissions, ex);
            }
        }

     

        private void filter()
        {
            if (dv_list != null)
            {
                dv_list.RowFilter = "ref_no like '" + txt_reference.Text + "*' and surn like '" + txt_surn.Text + "*' and id like '" + txt_id.Text.ToString() + "*' and stuno like '" + txt_stu.Text.ToString() + "*' and email like '*" + txt_email.Text.ToString() + "*'";
                dv_list.Sort = "surn";
                bs_list.DataSource = dv_list;
            }
        }

        private void txt_reference_TextChanged(object sender, EventArgs e)
        {
            filter();
        }

        private void txt_surn_TextChanged(object sender, EventArgs e)
        {
            filter();
        }

        private void txt_id_TextChanged(object sender, EventArgs e)
        {
            filter();
        }

        private void dg_list_DoubleClick(object sender, EventArgs e)
        {
            if (dg_list.SelectedRows.Count > 0)
            {
                if (dg_list.SelectedRows[0].Cells[cn_refno.Name].Value.ToString() != string.Empty) _Refno = dg_list.SelectedRows[0].Cells[cn_refno.Name].Value.ToString();
                else _Refno = dg_list.SelectedRows[0].Cells[cn_stuno.Name].Value.ToString();

                _TempActive = dg_list.SelectedRows[0].Cells[cntempactive.Name].Value.ToString();
                this.Close();
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            if (txt_id.Text.Length < 3 & txt_reference.Text.Length < 3 & txt_surn.Text.Length < 3 & txt_stu.Text.Length < 3 & txt_email.Text.Length < 3)
            {
                MessageBox.Show("Your search expression needs to have at least 3 characters in one of the search boxes in order to proceed.", "Search Admissions", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else get_list();
        }

        private void rb_all_CheckedChanged(object sender, EventArgs e)
        {
            acadstat_changed();
        }

        private void rb_ug_CheckedChanged(object sender, EventArgs e)
        {
            acadstat_changed();
        }

        private void rb_pg_CheckedChanged(object sender, EventArgs e)
        {
            acadstat_changed();            
        }

        private void rb_honours_CheckedChanged(object sender, EventArgs e)
        {
            acadstat_changed();
        }

        private void txt_stu_TextChanged(object sender, EventArgs e)
        {
            filter();
        }

        private void txt_email_TextChanged(object sender, EventArgs e)
        {
            filter();
        }
      
    }
}

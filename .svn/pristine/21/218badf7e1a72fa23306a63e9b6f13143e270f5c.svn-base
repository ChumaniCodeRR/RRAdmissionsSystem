using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Utilities;

namespace Admissions.UtilityScreens
{
    public partial class NbtResults : Form
    {
        string namestring;
        public NbtResults(string _namestring)
        {
            InitializeComponent();
            namestring = _namestring;
        }

        private void NbtResults_Load(object sender, EventArgs e)
        {
            try
            {
                txt_student.Text = namestring;
                NS_Admissions.StrongTypesNS.ds_nbt_fileDataSet ds_nbt = Proxy.Admissions.get_nbt_files(Global.Global.tempstu);
                bs_nbt.DataSource = ds_nbt.tt_nbtfile;
                if (txt_nbt_ref.Text != string.Empty) txt_nbt_ref.ReadOnly = true;
            }
            catch (Exception ex)
            {
                Utils.HandleException(ExceptionSource.Admissions, ex);
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {

                if (txt_nbt_ref.Text == "") MessageBox.Show("Please enter NBT reference number to continue", "Error Reference", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    int AL = 0;
                    int QL = 0;
                    int MATH = 0;
                    if (txt_al.Text != "")
                    {
                        bool TryAL = Int32.TryParse(txt_al.Text, out AL);
                        if (TryAL == false)
                        {
                            MessageBox.Show("AL must be a number from 0 to 100", "Error AL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    if (txt_ql.Text != "")
                    {
                        bool TryQL = Int32.TryParse(txt_ql.Text, out QL);
                        if (TryQL == false)
                        {
                            MessageBox.Show("QL must be a number from 0 to 100", "Error QL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    if (txt_maths.Text != "")
                    {
                        bool Trymaths = Int32.TryParse(txt_maths.Text, out MATH);
                        if (Trymaths == false)
                        {
                            MessageBox.Show("MATH must be a number from 0 to 100", "Error MATH", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    if (AL > 100 | QL > 100 | MATH > 100)
                    {
                        MessageBox.Show("Marks can only be up to 100, please correct to continue", "Error Marks", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    string feedback = Proxy.Admissions.update_nbt_file(Global.Global.tempstu, txt_nbt_ref.Text, AL.ToString(), QL.ToString(), MATH.ToString());
                    if (feedback.ToUpper().StartsWith("ERROR"))
                    {
                        MessageBox.Show(feedback, "Update NBT", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                    else
                    {
                        MessageBox.Show(feedback, "Update NBT", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }

                }
           
            }
            catch (Exception ex)
            {
                 Utils.HandleException(ExceptionSource.Admissions, ex);
             }
        }
    }
}

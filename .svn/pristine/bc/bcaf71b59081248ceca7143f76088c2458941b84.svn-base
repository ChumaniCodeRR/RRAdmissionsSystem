using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Admissions.AdmissionForms.SharedForms
{
    public partial class PDFViewer : Form
    {
        string source;
        public PDFViewer(string source)
        {
            InitializeComponent();
            this.source = source;
        }

        private void PDFViewer_Load(object sender, EventArgs e)
        {
            axAcroPDF1.src = source;
        }

        private void PDFViewer_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.axAcroPDF1 != null)
            {
                Controls.Remove(axAcroPDF1);
                this.axAcroPDF1 = null;
            }
        }
    }
}

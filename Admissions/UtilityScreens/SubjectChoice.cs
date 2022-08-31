using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NS_System.StrongTypesNS;
using Admissions.EventArguments;
using Admissions.Utilities;

namespace Admissions.UtilityScreens
{
    public partial class SubjectChoice : Form
    {
        string degree;
        int degreeChoice;
        ds_genDataSet ds_choices;
        List<string> subjects;

        public event EventHandler<SubjectChoiceSelected> SubjectChoiceSelected;

        public SubjectChoice()
        {
            InitializeComponent();
            dgvSubjectChoices.AutoGenerateColumns = false;            
        }

        public SubjectChoice(ds_genDataSet ds_choices, int degreeChoice, List<string> subjects, string degree)
            : this()
        {
            this.ds_choices = ds_choices;
            this.degreeChoice = degreeChoice;
            this.subjects = subjects;
            this.degree = degree;

            dgvSubjectChoices.DataSource = ds_choices.TT_GEN;
        }

        private void SubjectChoice_Load(object sender, EventArgs e)
        {
            lblTitle.Text = string.Concat(lblTitle.Text, " : ", degree);
            
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            List<string> subjectChoices = new List<string>();
            foreach (DataGridViewRow choice in dgvSubjectChoices.Rows)
            {
                if (choice.Cells[ckSubj.Name].Value != null && (bool)choice.Cells[ckSubj.Name].Value)
                { subjectChoices.Add(choice.Cells[cCode.Name].Value.ToString()); }
            }

            if (subjectChoices.Count.Equals(0))
            {
                string msg = "You have to select at least one subject choice.";
                MessageBox.Show(msg, AdmissionConstants.MessageBoxCaption, MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
            }
            if (subjectChoices.Count > 5)
            {
                string msg = "You can select a maximun of 5 subject choices.";
                MessageBox.Show(msg, AdmissionConstants.MessageBoxCaption, MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
            }

            if (SubjectChoiceSelected != null)
            {
                SubjectChoiceSelected(sender, new SubjectChoiceSelected(degreeChoice, subjectChoices));
            }
            this.Close();
        }

        void dgvSubjectChoices_DataBindingComplete(object sender, System.Windows.Forms.DataGridViewBindingCompleteEventArgs e)
        {
            if (subjects == null || subjects.Count.Equals(0)) return;

            foreach (DataGridViewRow item in dgvSubjectChoices.Rows)
            {
                subjects.ForEach(delegate(string s)
                {
                    if (item.Cells[cCode.Name].Value.ToString().Equals(s, StringComparison.InvariantCultureIgnoreCase))
                    { item.Cells[ckSubj.Name].Value = true; }
                });
            }
        }

        public void AddSubjectChoices()
        {
            btnOK_Click(btnOK, EventArgs.Empty);
        }
    }
}

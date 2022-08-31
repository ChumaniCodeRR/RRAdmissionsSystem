using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Admissions.EventArguments
{
    public class SubjectChoiceSelected : EventArgs
    {
        public SubjectChoiceSelected(int degreeChoice, List<string> subjectChoices)
            : base()
        {
            this.degreeChoice = degreeChoice;
            this.subjectChoices = subjectChoices;
        }

        int degreeChoice;

        public int DegreeChoice
        {
            get { return degreeChoice; }
            set { degreeChoice = value; }
        }

        List<string> subjectChoices;

        public List<string> SubjectChoices
        {
            get { return subjectChoices; }
            set { subjectChoices = value; }
        }
    }
}

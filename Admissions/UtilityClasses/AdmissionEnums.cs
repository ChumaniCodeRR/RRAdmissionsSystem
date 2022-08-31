using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Admissions.Utilities
{
    public class Enumerations
    {
        public enum AdmissionApplicationType
        {
            Unknown = 0,
            UG = 1,
            Hons_LLB_BBS = 2,
            PG = 3,
            International = 4,
            ACE = 5,
            Gadra = 6
        }

        public enum DegreeChoice
        {
            FirstDegree = 1,
            SecondDegree = 2
        }

        public enum AddressType
        {
            Home_Postal_Address,
            Home_Street_Address,
            Guardian_Address,
            Account_Payer_Address 
        }
    }
}

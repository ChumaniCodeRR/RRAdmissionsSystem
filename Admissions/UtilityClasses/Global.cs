using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Global
{
    public static class Global
    {
        public static NS_System.StrongTypesNS.DS_PHOTODataSet ds_logo;
        public static NS_System.StrongTypesNS.ds_stuDataSet ds_Stu;
        public static NS_Honours.StrongTypesNS.ds_controlDataSet ds_control;
        public static NS_StuReg.StrongTypesNS.ds_subjectDataSet ds_subjects;

        public static string tempstu;
        public static bool admissions_view;

        public static Admissions.Utilities.Enumerations.AdmissionApplicationType AdmAppType;

        public static int tempyr;

        public static int adm_yr = 0;
        public static string oldstuno = string.Empty;
        public static string ref_no = string.Empty;
        public static string app_stat = string.Empty;
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NS_Admissions.StrongTypesNS;

namespace Admissions.Utilities
{
    internal static class AdmissionUtilities
    {
        internal static void PopulateCopyAddress(ComboBox cb, Enumerations.AddressType exclude)
        {
            List<string> items = new List<string>(Enum.GetNames(typeof(Enumerations.AddressType)));
            List<StudentRegistration.AddressTypeBinding> list = new List<StudentRegistration.AddressTypeBinding>();

            list.Add(new StudentRegistration.AddressTypeBinding(-1, "[Please Select]"));
            items.ForEach(delegate(string s)
            {
                int id = (int)Enum.Parse(typeof(Enumerations.AddressType), s);
                if (!id.Equals((int)exclude))
                {
                    string description = s.Replace('_', ' ');
                    list.Add(new StudentRegistration.AddressTypeBinding(id, description));
                }
            });

            cb.DataSource = list;
        }

        internal static void CopyAddress(List<TextBox> to, List<string> addr)
        {
            for (int i = 0; i < to.Count; i++)
            {
                to[i].Text = addr[i];
            }
        }

        internal static List<string> GetAdmissionsHomeAddress(DS_ADM_STUDataSet ds_adm_stu)
        {
            List<string> addr = new List<string>();
            addr.Add(ds_adm_stu.TT_ADM_STU[0].HOME_ADDR1);
            addr.Add(ds_adm_stu.TT_ADM_STU[0].HOME_ADDR2);
            addr.Add(ds_adm_stu.TT_ADM_STU[0].HOME_ADDR3);
            addr.Add(ds_adm_stu.TT_ADM_STU[0].HOME_ADDR4);
            addr.Add(ds_adm_stu.TT_ADM_STU[0].HOME_ADDR5);
            addr.Add(ds_adm_stu.TT_ADM_STU[0].HOME_POST);
            addr.Add(ds_adm_stu.TT_ADM_STU[0].HOME_PHONE);
            return addr;
        }
        /*
        internal static List<string> GetTermPhysicalAddress(ds_AdmStuDataSet ds_AdmStu)
        {
            List<string> addr = new List<string>();
            addr.Add(ds_AdmStu.tt_AdmStu[0].STREET_ADDR1);
            addr.Add(ds_AdmStu.tt_AdmStu[0].STREET_ADDR2);
            addr.Add(ds_AdmStu.tt_AdmStu[0].STREET_ADDR3);
            addr.Add(ds_AdmStu.tt_AdmStu[0].STREET_ADDR4);
            addr.Add(ds_AdmStu.tt_AdmStu[0].STREET_ADDR5);
            addr.Add(ds_AdmStu.tt_AdmStu[0].STREET_POST);
            addr.Add(string.Empty); //Place holder for contact no.
            return addr;
        }*/

        internal static List<string> GetAdmissionsLocalAddress(DS_ADM_STUDataSet ds_adm_stu)
        {
            List<string> addr = new List<string>();
            addr.Add(ds_adm_stu.TT_ADM_STU[0].LOCAL_ADDR1);
            addr.Add(ds_adm_stu.TT_ADM_STU[0].LOCAL_ADDR2);
            addr.Add(ds_adm_stu.TT_ADM_STU[0].LOCAL_ADDR3);
            addr.Add(ds_adm_stu.TT_ADM_STU[0].LOCAL_ADDR4);
            addr.Add(ds_adm_stu.TT_ADM_STU[0].LOCAL_ADDR5);
            addr.Add(ds_adm_stu.TT_ADM_STU[0].LOCAL_POST);
            //addr.Add(ds_adm_stu.TT_ADM_STU[0].LOCAL_PHONE);
            addr.Add(string.Empty); //Place holder for contact no.
            return addr;
        }

        internal static List<string> GetAdmissionsKinAddress(DS_ADM_STUDataSet ds_adm_stu)
        {
            List<string> addr = new List<string>();
            addr.Add(ds_adm_stu.TT_ADM_STU[0].KIN_ADDR1);
            addr.Add(ds_adm_stu.TT_ADM_STU[0].KIN_ADDR2);
            addr.Add(ds_adm_stu.TT_ADM_STU[0].KIN_ADDR3);
            addr.Add(ds_adm_stu.TT_ADM_STU[0].KIN_ADDR4);
            addr.Add(ds_adm_stu.TT_ADM_STU[0].KIN_ADDR5);
            addr.Add(ds_adm_stu.TT_ADM_STU[0].KIN_POST);
            addr.Add(ds_adm_stu.TT_ADM_STU[0].KIN_PHONE);
            return addr;
        }

        internal static List<string> GetAdmissionsAccountAddress(DS_ADM_STUDataSet ds_adm_stu)
        {
            List<string> addr = new List<string>();
            addr.Add(ds_adm_stu.TT_ADM_STU[0].ACCT_ADDR1);
            addr.Add(ds_adm_stu.TT_ADM_STU[0].ACCT_ADDR2);
            addr.Add(ds_adm_stu.TT_ADM_STU[0].ACCT_ADDR3);
            addr.Add(ds_adm_stu.TT_ADM_STU[0].ACCT_ADDR4);
            addr.Add(ds_adm_stu.TT_ADM_STU[0].ACCT_ADDR5);
            addr.Add(ds_adm_stu.TT_ADM_STU[0].ACCT_POST);
            addr.Add(ds_adm_stu.TT_ADM_STU[0].ACCT_PHONE);
            return addr;
        }

        internal static bool IsUndergradApplication()
        {
            if (Global.Global.AdmAppType.Equals(Enumerations.AdmissionApplicationType.UG) ||
                Global.Global.AdmAppType.Equals(Enumerations.AdmissionApplicationType.International) ||
                Global.Global.AdmAppType.Equals(Enumerations.AdmissionApplicationType.ACE) ||
                Global.Global.AdmAppType.Equals(Enumerations.AdmissionApplicationType.Gadra) ||
                Global.Global.AdmAppType.Equals(Enumerations.AdmissionApplicationType.Unknown)) return true;
            return false;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HospitalManagementEntity;
using HospitalManagementData;

namespace HospitalManagementBusiness
{
    public class AdminBLL
    {
        public bool AdminLogin(string adminName, string adminPassword)
        {
            bool flag = false;
            AdminDAL adminDAL = new AdminDAL();
            List<Admin> admins = adminDAL.GetAllAdminsDAL();
            foreach (var item in admins)
            {
                if (item.AdminName == adminName && item.AdminPassword == adminPassword)
                {
                    flag = true;
                    break;
                }
            }
            return flag;
        }
    }
}

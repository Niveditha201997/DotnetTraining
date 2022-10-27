using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagementData;
using LibraryManagementEntity;


namespace LibraryManagementBussiness
{
    public class AdminBLL
    {
        public bool AdminLogin(string adminEmail, string adminPassword)
        {
            bool flag = false;
            AdminDAL adminDAL = new AdminDAL();
            List<Admin> admins = adminDAL.GetAllAdminsDAL();
            foreach (var item in admins)
            {
                if (item.AdminEmail == adminEmail && item.AdminPassword == adminPassword)
                {   
                    flag = true;
                    break;
                }
            }
            return flag;
        }
    }
}

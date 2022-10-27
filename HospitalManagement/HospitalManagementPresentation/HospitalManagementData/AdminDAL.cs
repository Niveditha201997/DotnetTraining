using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HospitalManagementEntity;

namespace HospitalManagementData
{
    public class AdminDAL
    {
        public List<Admin> admins;
        public List<Admin> GetAllAdminsDAL()
        {
            List<Admin> admins = new List<Admin>();
            Admin obj = new Admin("Sandesh", "123");
            admins.Add(obj);            

            return admins;

            foreach (var values in admins)
            {
                Console.WriteLine(values.AdminName);
                Console.WriteLine(values.AdminPassword);
            }
        }
    }
}

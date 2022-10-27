using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagementEntity;

namespace LibraryManagementData
{
    public class AdminDAL
    {
        public List<Admin> admins;
        public List<Admin> GetAllAdminsDAL()
        {
            List<Admin> admins = new List<Admin>();
            Admin obj = new Admin("nive@123", 01, "nive", "123");
            admins.Add(obj);
            
            //    admins = new list<admin>
            //    {
            //        new admin("nive@123",01,"nive",123);
            //    new admin("nive@342", 02, "niveditha", 1234);
            //};

            return admins;

            foreach (var values in admins)
            {
                Console.WriteLine(values.AdminEmail);
                Console.WriteLine(values.AdminId);
                Console.WriteLine(values.AdminName);
                Console.WriteLine(values.AdminPassword);
            }
        }
      
    }
}

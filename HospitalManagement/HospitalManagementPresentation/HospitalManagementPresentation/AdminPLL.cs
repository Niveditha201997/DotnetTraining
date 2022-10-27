using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HospitalManagementBusiness;
using HospitalManagementEntity;

namespace HospitalManagementPresentation
{
    public class AdminPLL
    {
        public void AdminLogin()
        {
            Console.WriteLine("enter admin name : ");
            string name = Console.ReadLine();
            Console.WriteLine("enter admin password : ");
            string password = Console.ReadLine();
            AdminBLL adminbll = new AdminBLL();
            bool status = adminbll.AdminLogin(name, password);
            if (status)
                Console.WriteLine("successfull!!!");
            else
                Console.WriteLine("invalid credentials");
        }
    }
}

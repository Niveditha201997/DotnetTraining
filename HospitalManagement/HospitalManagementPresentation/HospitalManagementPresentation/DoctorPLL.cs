using HospitalManagementBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HospitalManagementBusiness;
using HospitalManagementEntity;

namespace HospitalManagementPresentation
{
    public class DoctorPLL
    {
        public void DoctorLogin()
        {
            Console.WriteLine("enter user name : ");
            string name = Console.ReadLine();
            Console.WriteLine("enter user password : ");
            string password = Console.ReadLine();
            DoctorBLL doctorbll = new DoctorBLL();
            bool status = doctorbll.DoctorLogin(name, password);
            if (status)
                Console.WriteLine("successfull!!!");
            else
                Console.WriteLine("invalid credentials");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementPresentation
{
    public class Program
    {
        static void Main(string[] args)
        {
            bool status = true;
            while (status == true)
            {

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Welcome to ABC Library Management System");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("1) Press 1 to login as Admin\n" +
                "2) Press 2 to login as Doctor\n" +
                "3) Press 3 to login as Patient\n" +
                "4) Press 4 to exit");

                int logCase = int.Parse(Console.ReadLine());
                switch (logCase)
                {
                    case 1:
                        AdminPLL adminPL = new AdminPLL();
                        adminPL.AdminLogin();
                        
                        break;
                    case 2:
                        DoctorPLL doctorPL = new DoctorPLL();
                        doctorPL.DoctorLogin();
                        break;
                    case 3:
                        PatientPLL patientPL = new PatientPLL();
                        patientPL.PatientSection();
                        // patientPL.GetAllPatients();                     
                        
                        break ;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Enter a valid input...");
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                        
                }

            }
        }
    }
}

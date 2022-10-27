using HospitalManagementBusiness;
using HospitalManagementEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HospitalManagementPresentation
{
    public class PatientPLL
    {
        public void OutPatient()
        {
            Console.WriteLine("enter patient name : ");
            string name = Console.ReadLine();
            Console.WriteLine("enter patient password : ");
            string password = Console.ReadLine();
            Console.WriteLine("enter patient id : ");
            int id = Convert.ToInt32 (Console.ReadLine());
            Console.WriteLine("enter patient email : ");
            string email = Console.ReadLine();
            PatientBLL patientbll = new PatientBLL();
            bool status = patientbll.OutPatient(name, password,id,email);
            if (status)
                Console.WriteLine("successfull!!!");
            else
                Console.WriteLine("invalid credentials");

        }
        //public void ShowAllOutPatientDetails()
        //{

        //    List<Patient> patients = new List<Patient>();

        //    foreach (var item in patients)
        //    {
        //        Console.WriteLine("Id : " + item.UserName);
        //        Console.WriteLine("Name : " + item.UserPassword);
        //        Console.WriteLine("Description : " + item.PatientId);
        //        Console.WriteLine("Type : " + item.PatientEmail);
        //    }
        //}
        public void GetAllOutPatient()
        {
            List<Patient> patients = new List<Patient>();
            PatientBLL patientTemp = new PatientBLL();
            patients = patientTemp.GetAllOutPatientBLL();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("---------------------------Patient-List---------------------------");

            Console.WriteLine("--UserName-----UserPassword---------------PatientId-------------------PatientEmail-----");
            Console.ForegroundColor = ConsoleColor.White;
            foreach (Patient patient in patients)
            {
                Console.WriteLine("  " + patient.UserName + "\t" + patient.UserPassword + "\t  " + patient.PatientId + "\t\t\t" + patient.PatientEmail);
            }
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("----------------------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.White;
        }
        public void InPatient()
        {
            Console.WriteLine("enter patient name : ");
            string name = Console.ReadLine();
            Console.WriteLine("enter patient password : ");
            string password = Console.ReadLine();
            Console.WriteLine("enter patient id : ");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter patient email : ");
            string email = Console.ReadLine();
            PatientBLL patientbll = new PatientBLL();
            bool status = patientbll.OutPatient(name, password, id, email);
            if (status)
                Console.WriteLine("successfull!!!");
            else
                Console.WriteLine("invalid credentials");

        }
        //public void GetAllInPatient()
        //{
        //    List<Patient> patients = new List<Patient>();
        //    PatientBLL patientTemp = new PatientBLL();
        //    patients = patientTemp.GetAllInPatientBLL();
        //    Console.ForegroundColor = ConsoleColor.Yellow;
        //    Console.WriteLine("---------------------------Patient-List---------------------------");

        //    Console.WriteLine("--UserName-----UserPassword---------------PatientId-------------------PatientEmail-----");
        //    Console.ForegroundColor = ConsoleColor.White;
        //    foreach (Patient patient in patients)
        //    {
        //        Console.WriteLine("  " + patient.UserName + "\t" + patient.UserPassword + "\t  " + patient.PatientId + "\t\t\t" + patient.PatientEmail);
        //    }
        //    Console.ForegroundColor = ConsoleColor.Yellow;
        //    Console.WriteLine("----------------------------------------------------------------");
        //    Console.ForegroundColor = ConsoleColor.White;
        //}

        //public List<Patient> GetAllPatients()
        //{
        //    PatientBLL PatientBLL = new PatientBLL();
        //    return GetAllPatients();
        //}
        //public List<Patient> AddPatientBLL()
        //{
        //    PatientBLL PatientBLL = new PatientBLL();
        //    return AddPatientBLL();
        //}


        private void GetPatientMenu()
        {
            Console.WriteLine("1) Press 1 to login as outpatient \n" +
                "2) Press 2 to login inpatient \n" +               
                "3) Press 3 to exit");
        }


        //Patient patient = null;
        //public void AddPatientBLL()
        //{
        //    Patient patient= new Patient();
        //    Console.WriteLine("Enter UserName");
        //    patient.UserName = Console.ReadLine();
        //    Console.WriteLine("Enter UserPassword : ");
        //    patient.UserPassword = Console.ReadLine();        
        //    PatientBLL patientBLL = new PatientBLL();
        //   string msg = patientBLL.AddPatientBLL(patient);
        //    Console.WriteLine(msg);

        //}
        public void PatientSection()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Welcome-to-Patient-Section-------------");
            Console.ForegroundColor = ConsoleColor.White;
            bool bookLoop = true;
            while (bookLoop == true)
            {

                GetPatientMenu();
                int bookCase = int.Parse(Console.ReadLine());
                switch (bookCase)
                {
                    case 1:
                        OutPatient();
                        //GetAllOutPatient();
                        break;
                    case 2:
                        InPatient();
                        break;                    
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Invalid input!!!");
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                }
            }
        }
    }

}

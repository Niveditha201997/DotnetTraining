using HospitalManagementEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HospitalManagementData
{
    public class DoctorDAL
    {
        public List<Doctor> doctors;
        public List<Doctor> GetAllDoctorDAL()
        {
            List<Doctor> doctors = new List<Doctor>();
            Doctor obj = new Doctor("Niveditha", "1234");
            doctors.Add(obj);

            return doctors;

            foreach (var values in doctors)
            {
                Console.WriteLine(values.UserName);
                Console.WriteLine(values.UserPassword);
            }
        }
    }
}

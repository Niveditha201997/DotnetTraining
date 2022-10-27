using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementEntity
{
    public class Patient
    {
        public string UserName { get; set; }
        public string UserPassword { get; set; }
        public int PatientId { get; set; }
        public string PatientEmail { get; set; }


        public Patient(string UserName, string UserPassword,int PatientId,string PatientEmail)
        {
            this.UserName = UserName;
            this.UserPassword = UserPassword;
            this.PatientId = PatientId;
            this.PatientEmail = PatientEmail;
        }


    }
}

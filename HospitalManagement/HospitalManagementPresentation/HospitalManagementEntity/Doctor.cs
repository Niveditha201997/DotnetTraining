using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementEntity
{
    public class Doctor
    {
        public string UserName { get; set; }
        public string UserPassword { get; set; }

        public Doctor(string UserName, string UserPassword)
        {
            this.UserName = UserName;
            this.UserPassword = UserPassword;
        }
    }    
}

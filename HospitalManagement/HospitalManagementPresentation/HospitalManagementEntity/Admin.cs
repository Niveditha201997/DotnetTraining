using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementEntity
{
    public class Admin
    {              
        public string AdminName { get; set; }
        public string AdminPassword { get; set; }

        public Admin(string AdminName, string AdminPassword)
        {            
            this.AdminName = AdminName;
            this.AdminPassword = AdminPassword;
        }
    }
}

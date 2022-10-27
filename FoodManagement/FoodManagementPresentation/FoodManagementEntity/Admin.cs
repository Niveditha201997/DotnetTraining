using System;
using System.Collections.Generic;
using System.Text;

namespace FoodManagementEntity
{
    public class Admin
    {
        public string AdminEmail { get; set; }
        public int AdminId { get; set; }
        public string AdminName { get; set; }
        public string AdminPassword { get; set; }

        public Admin(string AdminEmail, int AdminId, string AdminName, string AdminPassword)
        {
            this.AdminEmail = AdminEmail;
            this.AdminId = AdminId;
            this.AdminName = AdminName;
            this.AdminPassword = AdminPassword;
        }
        public Admin()
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using FoodManagementEntity;


namespace FoodManagementData
{
    public class AdminDAL
    {
        public List<Admin> admins;
        public List<Admin> GetAllAdminsDAL()
        {
            List<Admin> admins = new List<Admin>();
            Admin obj = new Admin("nive@123", 01, "nive", "123");
            admins.Add(obj);

            

            return admins;

            
        }
    }
}

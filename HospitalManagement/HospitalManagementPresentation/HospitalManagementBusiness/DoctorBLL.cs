using HospitalManagementData;
using HospitalManagementEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementBusiness
{
    public class DoctorBLL
    {
        public bool DoctorLogin(string username, string userPassword)
        {
            bool flag = false;
            DoctorDAL doctorDAL = new DoctorDAL();
            List<Doctor> doctors = doctorDAL.GetAllDoctorDAL();
            foreach (var item in doctors)
            {
                if (item.UserName == username && item.UserPassword == userPassword)
                {
                    flag = true;
                    break;
                }
            }
            return flag;
        }
    }
}

using HospitalManagementEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.IO;


namespace HospitalManagementData
{
    public class PatientDAL
    {
        public List<Patient> patients;
        public List<Patient> OutPatientDAL()
        {
            List<Patient> patients = new List<Patient>();
            Patient obj = new Patient("Chaitra", "12345", 01, "chaitra@gmail.com");
            patients.Add(obj);

            return patients;

            foreach (var values in patients)
            {
                Console.WriteLine(values.UserName);
                Console.WriteLine(values.UserPassword);
                Console.WriteLine(values.PatientId);
                Console.WriteLine(values.PatientEmail);
            }
        }
        
        public List<Patient> GetAllOutPatientDAL()
        {
            return patients;
        }
        public List<Patient> InPatientDAL()
        {
            List<Patient> patients = new List<Patient>();
            Patient obj = new Patient("Shrivarsha", "12345", 01, "Shrivarsha@gmail.com");
            patients.Add(obj);

            return patients;

            foreach (var values in patients)
            {
                Console.WriteLine(values.UserName);
                Console.WriteLine(values.UserPassword);
                Console.WriteLine(values.PatientId);
                Console.WriteLine(values.PatientEmail);
            }
        }
        public List<Patient> GetAllInPatientDAL()
        {
            return patients;
        }

        //        public static string sqlcon = "Data source = VDC01LTC2013;Initial Catalog = HospitalMng;Integrated Security = True;";
        //        public List<Patient> patients;

        //public string AddPatientsDAL(Patient Patient)
        //{

        //    #region disconnected approach
        //    string msg = "";
        //    SqlConnection con = new SqlConnection(sqlcon);
        //    SqlDataAdapter adp = new SqlDataAdapter("insert into Patient values('" + Patient.UserName + "','" + Patient.UserPassword + "')", con);
        //    DataTable dt = new DataTable();
        //    DataSet ds = new DataSet();
        //    adp.Fill(dt);
        //    msg = "Inserted";
        //    return msg;
        //    #endregion
        //}

        //public List<Patient> GetAllpatientsDAL()
        //{
        //    #region connected
        //    SqlConnection con = new SqlConnection(sqlcon);
        //    SqlDataAdapter adp = new SqlDataAdapter("Select * from Patient", con);
        //    DataTable dt = new DataTable();
        //    List<Patient> books = new List<Patient>();
        //    adp.Fill(dt);
        //    if (dt != null && dt.Rows.Count > 0)
        //    {
        //        for (int i = 0; i < dt.Rows.Count; i++)
        //        {
        //            {
        //                patients.Add(new Patient
        //                {
        //                    UserName = dt.Rows[i]["PatientName"].ToString(),
        //                    UserPassword = dt.Rows[i]["Department"].ToString(),

        //                });
        //            }
        //        }
        //    }
        //    return patients;
        //    #endregion
        //}





    }
}

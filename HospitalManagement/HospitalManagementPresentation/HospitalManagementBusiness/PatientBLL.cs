using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HospitalManagementBusiness;
using HospitalManagementData;
using HospitalManagementEntity;

namespace HospitalManagementBusiness
{
    public class PatientBLL
    {
        public bool OutPatient(string username, string userPassword,int patientId,string patientEmail)
        {
            bool flag = false;
            PatientDAL patientDAL = new PatientDAL();
            List<Patient> doctors = patientDAL.OutPatientDAL();
            foreach (var item in doctors)
            {
                if (item.UserName == username && item.UserPassword == userPassword && item.PatientId == patientId && item.PatientEmail == patientEmail)
                {
                    flag = true;
                    break;
                }
            }
            return flag;
        }
        public bool InPatient(string username, string userPassword, int patientId, string patientEmail)
        {
            bool flag = false;
            PatientDAL patientDAL = new PatientDAL();
            List<Patient> doctors = patientDAL.OutPatientDAL();
            foreach (var item in doctors)
            {
                if (item.UserName == username && item.UserPassword == userPassword && item.PatientId == patientId && item.PatientEmail == patientEmail)
                {
                    flag = true;
                    break;
                }
            }
            return flag;
        }
        PatientDAL dalPatient = new PatientDAL();
        public List<Patient> GetAllOutPatientBLL()
        {

            List<Patient> patients = dalPatient.GetAllOutPatientDAL();
            return patients;
        }
        public List<Patient> GetAllInPatientBLL()
        {

            List<Patient> patients = dalPatient.GetAllInPatientDAL();
            return patients;
        }


        //private List<Patient> dalPatient;

        //public string AddPatientBLL(Patient patient)
        //{
        //    PatientDAL patientDAL = new PatientDAL();
        //    return patientDAL.AddPatientsDAL(patient);
        //}
        //public string GetAllpatientsBLL(Patient patient)
        //{
        //    PatientDAL patientDAL = new PatientDAL();
        //    return patientDAL.AddPatientsDAL(patient);
        //}

    }
}

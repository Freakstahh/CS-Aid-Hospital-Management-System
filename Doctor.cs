using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Aid_Hospital_Management_System
{
    class Doctor : User
    {
        public int Employee_ID { get; set; }
        public string Specialization { get; set; }

        public List<Patient> Patients = new List<Patient>();

        public Doctor(string name, string gender, DateTime birthdate, int contactNumber, string email, string username, string password,string iD, string specialization):base(name, gender, birthdate, contactNumber, email,  username, password, iD)
        {
            Specialization = specialization;
        }

        public void addPatient(Patient patient)
        {
            Patients.Add(patient);
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Aid_Hospital_Management_System
{
    public class Doctor : User
    {
        public string Specialization { get; set; }
        public List <Patient> Patients { get; set; }

        // private List<Patient> patients;

        // public List<Patient> Patients { get { return new List<Patient>(this.patients); } }

        public Doctor(string id, string name, string gender, DateTime birthdate, string contactNumber, string email, string username, string password, string specialization, string shifts,string departments, string uniqueKey):base(id, name, gender, birthdate, contactNumber, email,  username, password, shifts, departments, uniqueKey)
        {
            this.Specialization = specialization;
            this.Patients = new List<Patient>();
        }
    }
}

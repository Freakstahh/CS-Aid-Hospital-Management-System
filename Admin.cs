using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Aid_Hospital_Management_System
{
    class Admin: User
    {
        private string UniqueKey;
        public List<Patient> Patients = new List<Patient>();

        public Admin(string name, string gender, DateTime birthdate, int contactNumber, string email, string username, string password, string iD, string uniqueKey): base(iD,name, gender, birthdate, contactNumber, email, username, password)
        {
            this.UniqueKey = uniqueKey;
        }
        public void addPatient(Patient patient)
        {
            Patients.Add(patient);
        }
        public void RemovePatient(Patient patient)
        {
            Patients.Remove(patient);
        }
        public int CountNumberOfPatients()
        {
            return Patients.Count;
        }

    }
}

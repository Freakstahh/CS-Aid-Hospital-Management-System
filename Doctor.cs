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
        public int State { get; set; }//ilhanan ra ni kung on duty ang doctor or wala

        public List<Patient> Patients = new List<Patient>();

        public Doctor(string name, string gender, DateTime birthdate, int contactNumber, string email, string username, string password,string iD, string specialization):base(iD, name, gender, birthdate, contactNumber, email,  username, password)
        {
            this.State = 0;
            this.Specialization = specialization;
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
        public void SignIn()//kung on duty ang doctor
        {
            if (this.State == 0)
                this.State = 1;
            else
                return;
        }
        public void SignOut()//kung off duty
        {
            if (this.State == 1)
                this.State = 0;
            else
                return;
        }
    }
}

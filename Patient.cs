using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Aid_Hospital_Management_System
{
    class Patient : User
    {
        public int Patient_Id { get; set; }
        public DateTime AdmitDate { get; set; }
        public string Diagnosis { get; set; }
        public Patient(string name, string gender, DateTime birthdate, int contactNumber, string email, string username, string password, string iD, string diagnosis, int patient_Id, DateTime admitdate) : base(name, gender, birthdate, contactNumber, email, username, password, iD)
        {
            this.Patient_Id = patient_Id;
            this.AdmitDate = admitdate;
            this.Diagnosis = diagnosis;
        }
    }
}

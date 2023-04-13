using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CS_Aid_Hospital_Management_System
{
    public class Admin : User
    {
        [JsonRequired]
        internal List<Patient> Patients = new List<Patient>();
        [JsonIgnore]
        public List<Patient> patients = new List<Patient>();

        [JsonRequired]
        internal List<Doctor> Doctors = new List<Doctor>();
        [JsonIgnore]
        public List<Doctor> doctors = new List<Doctor>();

        [JsonRequired]
        internal List<Nurse> Nurses = new List<Nurse>();
        [JsonIgnore]
        public List<Nurse> nurses = new List<Nurse>();

        public Admin(string id, string name, string gender, DateTime birthdate, string contactNumber, string email, string username, string password, string shifts, string departments, string uniqueKey) : base(id,name, gender, birthdate, contactNumber, email, username, password, shifts, departments, uniqueKey)
        {
     
        }


        public void addPatient(Patient patient, Building building, int floorNum, int roomNum)
        {
            if (!Patients.Contains(patient) && building.AddPatient(floorNum, roomNum))
            {
                Patients.Add(patient);
            }
        }
        public void RemovePatient(Patient patient, Building building, int floorNum, int roomNum)
        {
            if (building.DismissPatient(floorNum, roomNum))
            {
                Patients.Remove(patient);
            }
        }
        public int CountNumberOfPatients()
        {
            return Patients.Count;
        }

        public void addDoctor(Doctor doctor)
        {
            Doctors.Add(doctor);
        }

        public void addNurse(Nurse nurse)
        {
            Nurses.Add(nurse);
        }
    }
}

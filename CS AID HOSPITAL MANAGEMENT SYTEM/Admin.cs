using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Aid_Hospital_Management_System
{
    public class Admin: User
    {
        private string UniqueKey;
        public List<Patient> Patients = new List<Patient>();
        public List<Doctor> Doctors = new List<Doctor>();
        public List <Nurse> Nurses = new List<Nurse>();

        public Admin(string name, string gender, DateTime birthdate, string contactNumber, string email, string username, string password,string shifts,string departments, string iD, string uniqueKey): base(iD,name, gender, birthdate, contactNumber, email, username, password, shifts, departments)
        {
            this.UniqueKey = uniqueKey;
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

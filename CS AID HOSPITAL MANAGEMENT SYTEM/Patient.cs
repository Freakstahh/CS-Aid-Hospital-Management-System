using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Aid_Hospital_Management_System
{
    public class Patient
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string Diagnosis { get; set; }
        public int Patient_Id { get; set; }
        public int FloorNumber { get; set; }
        public int RoomNumber { get; set; }
        public int Bills { get; set; }
        public DateTime AdmitDate { get; set; }
        public DateTime Birthdate { get; set; }
        public Patient(string lastname, string firstname, string middleName, string diagnosis, int patient_Id, int floorNumber, int roomNumber, int bills ,DateTime admitDate, DateTime birthdate)
        {
            this.LastName = lastname;
            this.FirstName = firstname;
            this.MiddleName = middleName;
            this.Diagnosis = diagnosis;
            this.Patient_Id = patient_Id;
            this.FloorNumber = floorNumber;
            this.RoomNumber = roomNumber;
            this.Bills = bills;
            this.AdmitDate = admitDate;
            this.Birthdate = birthdate;
        }
    }
}

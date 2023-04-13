using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Aid_Hospital_Management_System
{
    public class Appointment
    {
        public DateTime StartTime { get; set; }
        //public TimeSpan Duration { get; set; }
        public string Patientname { get; set; }
        public string Doctorname { get; set; }

        public Appointment(DateTime startTime, Patient patient, Doctor doctor)
        {
            this.StartTime = startTime;
            //this.Duration = duration;
            this.Patientname = patient.FirstName + patient.MiddleName + patient.LastName;
            this.Doctorname = doctor.Name;
        }
        public Timeslot Timeslot
        {
            get
            {
                return new Timeslot(StartTime, StartTime + new TimeSpan(01, 00, 00));
            }
        }

    }
}
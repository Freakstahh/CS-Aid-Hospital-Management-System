using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Aid_Hospital_Management_System
{
    public class AppointmentScheduler
    {
        private List<Appointment> appointments;
        public AppointmentScheduler()
        {
            appointments = new List<Appointment>();
        }

        public void AddAppointment(Appointment appointment)
        {
            // Check if appointment time conflicts with existing appointments
            foreach (Appointment existingAppointment in appointments)
            {
                if (appointment.Timeslot.Overlaps(existingAppointment.Timeslot))
                {
                    throw new Exception();
                }
            }

            // Add appointment to list
            appointments.Add(appointment);
        }

        public List<Appointment> GetAppointments(DateTime date)
        {
            // Get all appointments on a specific date
            List<Appointment> appointmentsOnDate = new List<Appointment>();

            foreach (Appointment appointment in appointments)
            {
                if (appointment.Timeslot.Start.Date == date.Date)
                {
                    appointmentsOnDate.Add(appointment);
                }
            }
            return appointmentsOnDate;
        }
    }

}

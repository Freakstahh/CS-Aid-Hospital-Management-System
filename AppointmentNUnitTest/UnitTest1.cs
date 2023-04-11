using NUnit.Framework;
using System;
using System.Numerics;

namespace CS_Aid_Hospital_Management_System.Tests
{
    public class AppointmentTests
    {
        private Patient patient;
        private Doctor doctor;

        [SetUp]
        public void Setup()
        {
            patient = new Patient("Doe", "John", "", "Cold", 1, 1, 101, 0, DateTime.Now, new DateTime(1980, 1, 1));
            doctor = new Doctor("Smith", "M", new DateTime(1980, 1, 1), 5551234, "smith@example.com", "smith", "password", "123456", "Shift 1", "Department", "Cardiology");
        }

        [Test]
        public void Timeslot_ReturnsCorrectTimeslot()
        {
            var appointment = new Appointment(new DateTime(2023, 4, 1, 9, 0, 0), TimeSpan.FromMinutes(30), patient, doctor);

            var expected = new Timeslot(new DateTime(2023, 4, 1, 9, 0, 0), new DateTime(2023, 4, 1, 9, 30, 0));

            Assert.AreEqual(expected.Start, appointment.Timeslot.Start);
            Assert.AreEqual(expected.End, appointment.Timeslot.End);
        }

        [Test]
        public void Overlaps_ReturnsTrueIfOverlapping()
        {
            var appointment1 = new Appointment(new DateTime(2023, 4, 1, 9, 0, 0), TimeSpan.FromMinutes(30), patient, doctor);
            var appointment2 = new Appointment(new DateTime(2023, 4, 1, 9, 15, 0), TimeSpan.FromMinutes(30), patient, doctor);

            Assert.IsTrue(appointment1.Timeslot.Overlaps(appointment2.Timeslot));
        }

        [Test]
        public void Overlaps_ReturnsFalseIfNotOverlapping()
        {
            var appointment1 = new Appointment(new DateTime(2023, 4, 1, 9, 0, 0), TimeSpan.FromMinutes(30), patient, doctor);
            var appointment2 = new Appointment(new DateTime(2023, 4, 1, 10, 0, 0), TimeSpan.FromMinutes(30), patient, doctor);

            Assert.IsFalse(appointment1.Timeslot.Overlaps(appointment2.Timeslot));
        }
    }
}

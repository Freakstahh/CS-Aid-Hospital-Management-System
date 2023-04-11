using NUnit.Framework;
using System;

namespace CS_Aid_Hospital_Management_System.Tests
{
    public class RoomTests
    {
        [Test]
        public void TestRoomOccupancy()
        {
            Room room = new Room(1, 101, "Room 101");
            Assert.IsFalse(room.isOccupied(room), "Room should not be occupied by default");

            Patient patient = new Patient("Doe", "John", "M.", "Influenza", 1, 1, 101, 100, DateTime.Now, new DateTime(1990, 1, 1));
            room.Patients.Add(patient);
            room.State = 1;

            Assert.IsTrue(room.isOccupied(room), "Room should be occupied after adding a patient");
        }
    }

    public class PatientTests
    {
        [Test]
        public void TestPatientAge()
        {
            Patient patient = new Patient("Doe", "John", "M.", "Influenza", 1, 1, 101, 100, DateTime.Now, new DateTime(1990, 1, 1));
            int age = DateTime.Now.Year - patient.Birthdate.Year;
            Assert.AreEqual(age, 33, "Patient age should be calculated correctly");
        }
    }
}

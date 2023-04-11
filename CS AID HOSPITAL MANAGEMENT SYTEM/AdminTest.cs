using CS_Aid_Hospital_Management_System;
using NUnit.Framework;

namespace AdminNUnitTest
{
    public class AdminTests
    {
        [Test]
        public void TestAddPatient()
        {
            // Arrange
            Admin admin = new Admin("AD12345", "John Doe", "M", DateTime.Now.AddYears(-30), "1234567890", "johndoe@example.com", "johndoe", "password", "Day", "Cardiology", "12345");
            Patient patient = new Patient("Smith", "Adam", "", "Flu", 1, 1, 1, 1000, DateTime.Now, DateTime.Now.AddYears(-40));
            Building building = new Building();
            int initialCount = admin.CountNumberOfPatients();

            // Act
            admin.addPatient(patient, building, 1, 1);

            // Assert
            Assert.AreEqual(initialCount + 1, admin.CountNumberOfPatients());
            Assert.IsTrue(admin.Patients.Contains(patient));
            Assert.AreEqual(1, building.Rooms[0].State);
        }

        [Test]
        public void TestRemovePatient()
        {
            // Arrange
            Admin admin = new Admin("AD12345", "John Doe", "M", DateTime.Now.AddYears(-30), "1234567890", "johndoe@example.com", "johndoe", "password", "Day", "Cardiology", "12345");
            Patient patient = new Patient("Smith", "Adam", "", "Flu", 1, 1, 1, 1000, DateTime.Now, DateTime.Now.AddYears(-40));
            Building building = new Building();
            admin.addPatient(patient, building, 1, 1);
            int initialCount = admin.CountNumberOfPatients();

            // Act
            admin.RemovePatient(patient, building, 1, 1);

            // Assert
            Assert.AreEqual(initialCount - 1, admin.CountNumberOfPatients());
            Assert.IsFalse(admin.Patients.Contains(patient));
            Assert.AreEqual(0, building.Rooms[0].State);
        }

        [Test]
        public void TestAddDoctor()
        {
            // Arrange
            Admin admin = new Admin("AD12345", "John Doe", "M", DateTime.Now.AddYears(-30), "1234567890", "johndoe@example.com", "johndoe", "password", "Day", "Cardiology", "12345");
            Doctor doctor = new Doctor("DOC12345", "Jane Doe", "F", DateTime.Now.AddYears(-35), "1234567890", "janedoe@example.com", "janedoe", "password", "Day", "Cardiology", "Cardiologist", "01");
            int initialCount = admin.Doctors.Count;

            // Act
            admin.addDoctor(doctor);

            // Assert
            Assert.AreEqual(initialCount + 1, admin.Doctors.Count);
            Assert.IsTrue(admin.Doctors.Contains(doctor));
        }

        [Test]
        public void TestAddNurse()
        {
            // Arrange
            Admin admin = new Admin("AD12345", "John Doe", "M", DateTime.Now.AddYears(-30), "1234567890", "johndoe@example.com", "johndoe", "password", "Day", "Cardiology", "12345");
            Nurse nurse = new Nurse("NS12345", "Mary Smith", "F", DateTime.Now.AddYears(-25), "1234567890", "marysmith@example.com", "marysmith", "password", "Day", "Cardiology", "02");
            int initialCount = admin.Nurses.Count;

            // Act
            admin.addNurse(nurse);

            // Assert
            Assert.AreEqual(initialCount + 1, admin.Nurses.Count);
            Assert.IsTrue(admin.Nurses.Contains(nurse));
        }
    }
}

using NUnit.Framework;
using System;

namespace CS_Aid_Hospital_Management_System.Tests
{
    public class TimeslotTests
    {
        [Test]
        public void Overlaps_WhenOtherTimeslot()
        {
            //returns true :)
            // Arrange
            var timeslot1 = new Timeslot(DateTime.Parse("2023-04-01 09:00:00"), DateTime.Parse("2023-04-01 12:00:00"));
            var timeslot2 = new Timeslot(DateTime.Parse("2023-04-01 11:00:00"), DateTime.Parse("2023-04-01 15:00:00"));

            // Act
            var result = timeslot1.Overlaps(timeslot2);

            // Assert
            Assert.IsTrue(result);
        }

        [Test]
        public void Overlaps_WhenOtherTimeslotDoesNot()
        {
            //returns false :)

            // Arrange
            var timeslot1 = new Timeslot(DateTime.Parse("2023-04-01 09:00:00"), DateTime.Parse("2023-04-01 12:00:00"));
            var timeslot2 = new Timeslot(DateTime.Parse("2023-04-01 14:00:00"), DateTime.Parse("2023-04-01 15:00:00"));

            // Act
            var result = timeslot1.Overlaps(timeslot2);

            // Assert
            Assert.IsFalse(result);
        }
    }
}

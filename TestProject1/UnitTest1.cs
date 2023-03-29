using CS_Aid_Hospital_Management_System;

namespace TestProject1
{
    [TestFixture]
    public class RoomTests
    {
        [Test]
        public void RoomConstructor_ValidInput_PropertiesSet()
        {
            // Arrange
            int floorNumber = 3;
            int roomNumber = 15;
            string name = "Test Room";

            // Act
            Room room = new Room(floorNumber, roomNumber, name);

            // Assert
            Assert.AreEqual(floorNumber, room.FloorNumber);
            Assert.AreEqual(roomNumber, room.RoomNumber);
            Assert.AreEqual(name, room.Name);
            Assert.AreEqual(0, room.State);
            Assert.IsNotNull(room.Patients);
            Assert.AreEqual(0, room.Patients.Count);
        }

        [Test]
        public void isOccupied_RoomIsNotOccupied_ReturnsFalse()
        {
            // Arrange
            Room room = new Room(1, 101, "Test Room");

            // Act
            bool result = room.isOccupied(room);

            // Assert
            Assert.IsFalse(result);
        }

        [Test]
        public void isOccupied_RoomIsOccupied_ReturnsTrue()
        {
            // Arrange
            Room room = new Room(2, 201, "Occupied Room");
            room.State = 1;

            // Act
            bool result = room.isOccupied(room);

            // Assert
            Assert.IsTrue(result);
        }
    }
}
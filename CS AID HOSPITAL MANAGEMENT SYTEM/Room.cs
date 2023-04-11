using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Aid_Hospital_Management_System
{
    public class Room
    {
        public int FloorNumber { get; set; }
        public int  RoomNumber {get; set; }
        public string Name { get; set; }
        public int State { get; set; }//0 is for not occupied and 1 for occupied
        internal List<Patient> Patients { get; set; }

        public Room(int floorNumber, int roomNumber, string name)
        {
            this.FloorNumber = floorNumber;
            this.RoomNumber = roomNumber;
            this.Name = name;
            this.State = 0;
            this.Patients = new List<Patient>();
        }
        public bool isOccupied(Room room)
        {
            if (this.State != 0)
                return true;
            return false;
        }
    }
}

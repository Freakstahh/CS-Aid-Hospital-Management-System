using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Aid_Hospital_Management_System
{
    public class Building
    {
        public Room[] Rooms;
        public Building()
        {
            this.Rooms = new Room[60];
            this.CreateRooms(this.Rooms);
        }

        private void CreateRooms(Room[] rooms)
        {
            int x = 1;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    rooms[i * 20 + j] = new Room(i, j, "Default");
                }
                x += 10;
            }
        }

        public bool AddPatient(int floorNum, int roomNum)
        {
            if(isInputValid(floorNum, roomNum) == true && this.Rooms[(floorNum - 1) * 10 + roomNum].State == 0)
            {
                this.Rooms[(floorNum-1) * 10 + roomNum].State = 1;
                return true;
            }
            return false;
        }

        public bool DismissPatient(int floorNum, int roomNum)
        {
            if (isInputValid(floorNum, roomNum) == true)
            {
                this.Rooms[(floorNum - 1) * 10 + roomNum].State = 0;
                return true;
            }
            return false;
        }
        
        private bool isInputValid(int floorNum, int roomNum)
        {
            if (floorNum - 1 < 0 || floorNum - 1 > 2 || roomNum - 1 < 0 || roomNum - 1 > 19)
                return false;
            return true;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Aid_Hospital_Management_System
{
    class Building
    {
        public Room[] Rooms;
        public Building()
        {
            int x = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    this.Rooms[i * x + (j+1)] = new Room(i, j, null);
                }
                x += 10;
            }
        }

        public void AddPatient(int floorNum, int roomNum)
        {
            if(isInputValid(floorNum, roomNum) == true && this.Rooms[(floorNum - 1) * 10 + roomNum].State == 0)
            {
                this.Rooms[(floorNum-1) * 10 + roomNum].State = 1;
            }
        }

        public void DismissPatient(int floorNum, int roomNum)
        {
            if (isInputValid(floorNum, roomNum) == true)
            {
                this.Rooms[(floorNum - 1) * 10 + roomNum].State = 0;
            }
        }
        
        private bool isInputValid(int floorNum, int roomNum)
        {
            if (floorNum - 1 < 0 || floorNum - 1 > 2 || roomNum - 1 < 0 || roomNum - 1 > 19)
                return false;
            return true;
        }
    }
}

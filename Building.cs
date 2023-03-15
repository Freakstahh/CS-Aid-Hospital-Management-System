using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Aid_Hospital_Management_System
{
    public class Building
    {
        public int[,] Rooms;
        public Building()
        {
            this.Rooms = new int[3,20];
            this.PopulateRooms(this.Rooms);
            //1's for occupied rooms
            //0's for not occupied rooms
        }

        public bool isOccupied(int floorNum, int roomNum)
        {
            if (this.Rooms[floorNum-1, roomNum-1] == 1 && isInputValid(floorNum, roomNum))
                return true;
            else
                return false;
        }
        public void dismissPatient(int floorNum, int roomNum)
        {
            if(isOccupied(floorNum,roomNum) && isInputValid(floorNum, roomNum))
            {
                this.Rooms[floorNum - 1, roomNum - 1] = 0;
            }
        }

        public void OccupyRoom(int floorNum, int roomNum)
        {

            if (this.Rooms[floorNum-1,roomNum-1] == 0 && isInputValid(floorNum, roomNum))
            {
                this.Rooms[floorNum-1, roomNum-1] = 1;
            }
        }

        private void PopulateRooms(int[,] arr)//populate rooms with zero's 
        {
            for(int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 20; j++)
                {
                    arr[i,j] = 0;
                }
            }
        }

        private bool isInputValid(int floorNum, int roomNum)
        {
            if(floorNum-1 >= 0 && floorNum-1 <= 2 && roomNum-1 >= 0 && roomNum-1 <= 19)
            {
                return true;
            }
            return false;
        }
    }
}

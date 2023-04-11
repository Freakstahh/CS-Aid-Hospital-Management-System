using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Aid_Hospital_Management_System
{
    public class Nurse : User
    {
        internal List<Room> Rooms { get; set; }
        public Nurse(string id, string name, string gender, DateTime birthdate, string contactNumber, string email, string username, string password, string shifts,string departments, string uniqueKey) : base (id, name, gender, birthdate, contactNumber, email, username, password, shifts, departments, uniqueKey)
        {
             this.Rooms = new List<Room>();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Aid_Hospital_Management_System
{
    class Nurse : User
    {
        public Nurse(string id, string name, string gender, DateTime birthdate, int contactNumber, string email, string username, string password) : base (id, name, gender, birthdate, contactNumber, email, username, password)
        {
             
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Aid_Hospital_Management_System
{
    class Nurse : User
    {
        public List<Room> Rooms { get; private set; }
        public Nurse(string id, string name, string gender, DateTime birthdate, int contactNumber, string email, string username, string password, string shifts,string departments) : base (id, name, gender, birthdate, contactNumber, email, username, password, shifts, departments)
        {
             this.Rooms = new List<Room>();
        }
    }
}
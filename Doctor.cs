﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Aid_Hospital_Management_System
{
    public class Doctor : User
    {
        public int Employee_ID { get; set; }
        public string Specialization { get; set; }
        public List <Patient> Patients { get; private set; }

        public Doctor(string name, string gender, DateTime birthdate, int contactNumber, string email, string username, string password,string iD, string shifts,string departments, string specialization):base(iD, name, gender, birthdate, contactNumber, email,  username, password, shifts, departments)
        {
            this.Specialization = specialization;
            this.Patients = new List<Patient>();
        }
    }
}

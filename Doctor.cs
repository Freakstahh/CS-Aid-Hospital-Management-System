using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Aid_Hospital_Management_System
{
    class Doctor : User
    {
        public int Employee_ID { get; set; }
        public string Specialization { get; set; }
        public int State { get; set; }//ilhanan ra ni kung on duty ang doctor or wala

        public Doctor(string name, string gender, DateTime birthdate, int contactNumber, string email, string username, string password,string iD, string shifts, string specialization):base(iD, name, gender, birthdate, contactNumber, email,  username, password, shifts)
        {
            this.State = 0;
            this.Specialization = specialization;
        }
    }
}

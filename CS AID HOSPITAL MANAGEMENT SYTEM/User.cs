using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Aid_Hospital_Management_System
{
    public abstract class User
    {
        public string ID { get; private set; }
        public string Name { get; private set; }
        public string Gender { get; private set; }
        public DateTime Birthdate { get; private set; }
        public string ContactNumber { get; private set; }
        public string Email { get; private set; }
        public string Username { get; private set; }
        public string Shifts { get; private set; }
        public string Departments { get; private set; }
        [JsonRequired]
        private string Password;

        public int State { get; private set; }
        public User(string id, string name, string gender, DateTime birthdate, string contactNumber, string email, string username, string password, string shifts, string departments)
        {
            this.ID = id;
            this.Name = name;
            this.Gender = gender;
            this.Birthdate = birthdate;
            this.ContactNumber = contactNumber;
            this.Email = email;
            this.Username = username;
            this.Password = password;
            this.Shifts = shifts;
            this.State = 0;
            this.Departments = departments;
        }
        /*public void SignIn()//kung on duty ang doctor
        {
            if (this.State == 0)
                this.State = 1;
            else
                return;
        }
        public void SignOut()//kung off duty
        {
            if (this.State == 1)
                this.State = 0;
            else
                return;
        }*/

        public bool CanLogin(string username, string password)
        {
            return username.Equals(this.Username) && password.Equals(this.Password);
        }
    }
}
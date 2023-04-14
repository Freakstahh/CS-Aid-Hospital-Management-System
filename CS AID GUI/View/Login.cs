using CS_Aid_Hospital_Management_System;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSAid_MainWinFormsApp.View
{
    public partial class Login : UserControl
    {

        public static AdminForm adminForm = new AdminForm();
        public static DoctorForm doctorForm = new DoctorForm();
        public Login()
        {
            InitializeComponent();
        }

        private void labellogin_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button_login_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_username.Text) && string.IsNullOrEmpty(textBox_pass.Text))
            {
                MessageBox.Show("Please enter your username and password");
            }
            else if (string.IsNullOrEmpty(textBox_username.Text))
            {
                MessageBox.Show("Please enter your username");
            }
            else if (string.IsNullOrEmpty(textBox_pass.Text))
            {
                MessageBox.Show("Please enter your password.");
            }

            bool successfulLogin = false;

            foreach (User u in Database.Masterlist())
            {
                if (!u.CanLogin(textBox_username.Text, textBox_pass.Text))
                    continue;

                successfulLogin = true;
                textBox_username.Clear();
                textBox_pass.Clear();

                if (u is Doctor)
                {
                    doctorForm.Show();
                    break;
                }
                else if (u is Admin)
                {
                    adminForm.Show();
                    break;
                }
            }

            if (!successfulLogin)
            { MessageBox.Show("The password you've entered is incorrect."); }

            /*if (textBox_username.Text == "admin" && textBox_pass.Text == "admin123")
            {
                adminForm.Show();
                textBox_username.Clear();
                textBox_pass.Clear();
            }
            else if (textBox_username.Text == "doctor" && textBox_pass.Text == "doctor123")
            {
                new DoctorForm().Show();
                textBox_username.Clear();
                textBox_pass.Clear();
            }
            else if (textBox_username.Text == "nurse" && textBox_pass.Text == "nurse123")
            {
                new NurseForm().Show();
                textBox_username.Clear();
                textBox_pass.Clear();
            }
            else
            {
                MessageBox.Show("Incorrect Username or Password Input.\nPlease Try Again.");
                textBox_username.Clear();
                textBox_pass.Clear();
            }*/
        }

        private void textBox_pass_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (textBox_pass.PasswordChar == '*')
            {
                textBox_pass.PasswordChar = '\0';
            }
            else if (textBox_pass.PasswordChar == '\0')
            {
                textBox_pass.PasswordChar = '*';
            }
        }
    }
}

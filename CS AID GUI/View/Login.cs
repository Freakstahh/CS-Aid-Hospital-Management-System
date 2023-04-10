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
            if (textBox_username.Text == "admin" && textBox_pass.Text == "admin123")
            {
                new AdminForm().Show();
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
            }
        }
    }
}

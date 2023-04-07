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
    public partial class LoginView : Form
    {
        public LoginView()
        {
            InitializeComponent();
        }

        private void bg_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void linkreg_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.login1.Visible = false;
            this.register1.Visible = true;
        }

        private void login1_Load(object sender, EventArgs e)
        {

        }

        private void linkLabellogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.login1.Visible = true;
            this.register1.Visible = false;
        }
    }
}

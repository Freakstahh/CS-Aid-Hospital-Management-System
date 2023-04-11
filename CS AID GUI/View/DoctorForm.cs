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
    public partial class DoctorForm : Form
    {
        public DoctorForm()
        {
            InitializeComponent();
        }

        private void panel_lower_Paint(object sender, PaintEventArgs e)
        {

        }

        private void logout_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DoctorForm_Load(object sender, EventArgs e)
        {
            this.doctor_Appointments2.Visible = false;
            this.doctor_Operations2.Visible = false;
        }

        private void button_noOfOperations_Click(object sender, EventArgs e)
        {
            this.doctor_Appointments2.Visible = false;
            this.doctor_Operations2.Visible = true;
        }

        private void button_addappointments_Click(object sender, EventArgs e)
        {
            this.doctor_Appointments2.Visible = true;
            this.doctor_Operations2.Visible = false;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}

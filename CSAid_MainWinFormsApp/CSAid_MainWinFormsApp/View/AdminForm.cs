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
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            this.admin_addPatient1.Visible = false;
            this.admin_addAppointment1.Visible = false;
            this.admin_addDoctor1.Visible = false;
            this.admin_addNurse1.Visible = false;
            this.admin_Inventory1.Visible = false;
            this.admin_availableRooms1.Visible = false;
        }

        private void panel_lower_Paint(object sender, PaintEventArgs e)
        {

        }

        private void logout_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_addPatient_Click(object sender, EventArgs e)
        {
            this.admin_addPatient1.Visible = true;
            this.admin_addAppointment1.Visible = false;
            this.admin_addDoctor1.Visible = false;
            this.admin_addNurse1.Visible = false;
            this.admin_Inventory1.Visible = false;
            this.admin_availableRooms1.Visible = false;
        }

        private void button_addappointments_Click(object sender, EventArgs e)
        {
            this.admin_addPatient1.Visible = false;
            this.admin_addAppointment1.Visible = true;
            this.admin_addDoctor1.Visible = false;
            this.admin_addNurse1.Visible = false;
            this.admin_Inventory1.Visible = false;
            this.admin_availableRooms1.Visible = false;
        }

        private void button_addnurse_Click(object sender, EventArgs e)
        {
            this.admin_addPatient1.Visible = false;
            this.admin_addAppointment1.Visible = false;
            this.admin_addDoctor1.Visible = false;
            this.admin_addNurse1.Visible = true;
            this.admin_Inventory1.Visible = false;
            this.admin_availableRooms1.Visible = false;
        }

        private void button_adddoctor_Click(object sender, EventArgs e)
        {
            this.admin_addPatient1.Visible = false;
            this.admin_addAppointment1.Visible = false;
            this.admin_addDoctor1.Visible = true;
            this.admin_addNurse1.Visible = false;
            this.admin_Inventory1.Visible = false;
            this.admin_availableRooms1.Visible = false;
        }

        private void button_inventory_Click(object sender, EventArgs e)
        {
            this.admin_addPatient1.Visible = false;
            this.admin_addAppointment1.Visible = false;
            this.admin_addDoctor1.Visible = false;
            this.admin_addNurse1.Visible = false;
            this.admin_Inventory1.Visible = true;
            this.admin_availableRooms1.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.admin_addPatient1.Visible = false;
            this.admin_addAppointment1.Visible = false;
            this.admin_addDoctor1.Visible = false;
            this.admin_addNurse1.Visible = false;
            this.admin_Inventory1.Visible = false;
            this.admin_availableRooms1.Visible = true;
        }
    }
}

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
    public partial class NurseForm : Form
    {
        public NurseForm()
        {
            InitializeComponent();
        }

        private void NurseForm_Load(object sender, EventArgs e)
        {
            this.nurse_Departments2.Visible = false;
            this.nurse_Shifts2.Visible = false;
            this.nurse_Rounds2.Visible = false;
            this.nurse_ViewInventory1.Visible = false;
        }

        private void panel_lower_Paint(object sender, PaintEventArgs e)
        {

        }

        private void logout_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_Shifts_Click(object sender, EventArgs e)
        {
            this.nurse_Departments2.Visible = false;
            this.nurse_Shifts2.Visible = true;
            this.nurse_Rounds2.Visible = false;
            this.nurse_ViewInventory1.Visible = false;
        }

        private void button_rounds_Click(object sender, EventArgs e)
        {
            this.nurse_Departments2.Visible = false;
            this.nurse_Shifts2.Visible = false;
            this.nurse_Rounds2.Visible = true;
            this.nurse_ViewInventory1.Visible = false;
        }

        private void button_departments_Click(object sender, EventArgs e)
        {
            this.nurse_Departments2.Visible = true;
            this.nurse_Shifts2.Visible = false;
            this.nurse_Rounds2.Visible = false;
            this.nurse_ViewInventory1.Visible = false;
        }

        private void button_inventory_Click(object sender, EventArgs e)
        {
            this.nurse_Departments2.Visible = false;
            this.nurse_Shifts2.Visible = false;
            this.nurse_Rounds2.Visible = false;
            this.nurse_ViewInventory1.Visible = true;
        }
    }
}

﻿using System;
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

        private void panel_lower_Paint(object sender, PaintEventArgs e)
        {

        }

        private void logout_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

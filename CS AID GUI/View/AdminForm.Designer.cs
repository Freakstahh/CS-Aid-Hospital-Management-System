namespace CSAid_MainWinFormsApp.View
{
    partial class AdminForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel_upper = new Panel();
            panel6 = new Panel();
            pictureBox9 = new PictureBox();
            button4 = new Button();
            panel_inventory = new Panel();
            pictureBox8 = new PictureBox();
            button_inventory = new Button();
            panel4 = new Panel();
            pictureBox6 = new PictureBox();
            pictureBox7 = new PictureBox();
            button_empaccs = new Button();
            panel3 = new Panel();
            pictureBox5 = new PictureBox();
            button_addappointments = new Button();
            panel_addpatient = new Panel();
            panel1 = new Panel();
            panel2 = new Panel();
            pictureBox4 = new PictureBox();
            button_addPatient = new Button();
            button2 = new Button();
            add_patient = new Button();
            panel_upperLeft = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            panel_upperRight = new Panel();
            logout_button = new Button();
            label3 = new Label();
            label2 = new Label();
            pictureBox3 = new PictureBox();
            linkLabel_admin = new LinkLabel();
            panel_lower = new Panel();
            admin_empAccounts1 = new Admin_empAccounts();
            admin_Inventory1 = new Admin_Inventory();
            admin_availableRooms1 = new Admin_availableRooms();
            admin_addAppointment1 = new Admin_addAppointment();
            admin_addPatient1 = new Admin_addPatient();
            panel_upper.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            panel_inventory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            panel_addpatient.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel_upperLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel_upperRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel_lower.SuspendLayout();
            SuspendLayout();
            // 
            // panel_upper
            // 
            panel_upper.BorderStyle = BorderStyle.Fixed3D;
            panel_upper.Controls.Add(panel6);
            panel_upper.Controls.Add(panel_inventory);
            panel_upper.Controls.Add(panel4);
            panel_upper.Controls.Add(panel3);
            panel_upper.Controls.Add(panel_addpatient);
            panel_upper.Controls.Add(panel_upperLeft);
            panel_upper.Controls.Add(panel_upperRight);
            panel_upper.Dock = DockStyle.Top;
            panel_upper.Location = new Point(0, 0);
            panel_upper.Margin = new Padding(3, 2, 3, 2);
            panel_upper.Name = "panel_upper";
            panel_upper.Size = new Size(1664, 87);
            panel_upper.TabIndex = 0;
            // 
            // panel6
            // 
            panel6.Controls.Add(pictureBox9);
            panel6.Controls.Add(button4);
            panel6.Dock = DockStyle.Left;
            panel6.Location = new Point(722, 0);
            panel6.Margin = new Padding(3, 2, 3, 2);
            panel6.Name = "panel6";
            panel6.Size = new Size(94, 83);
            panel6.TabIndex = 14;
            // 
            // pictureBox9
            // 
            pictureBox9.Image = Properties.Resources.bed;
            pictureBox9.Location = new Point(21, 0);
            pictureBox9.Margin = new Padding(3, 2, 3, 2);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(52, 33);
            pictureBox9.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox9.TabIndex = 14;
            pictureBox9.TabStop = false;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(74, 98, 101);
            button4.FlatStyle = FlatStyle.Popup;
            button4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = SystemColors.Control;
            button4.Location = new Point(5, 32);
            button4.Margin = new Padding(3, 2, 3, 2);
            button4.Name = "button4";
            button4.Size = new Size(82, 46);
            button4.TabIndex = 13;
            button4.Text = "Available Rooms";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // panel_inventory
            // 
            panel_inventory.Controls.Add(pictureBox8);
            panel_inventory.Controls.Add(button_inventory);
            panel_inventory.Dock = DockStyle.Left;
            panel_inventory.Location = new Point(628, 0);
            panel_inventory.Margin = new Padding(3, 2, 3, 2);
            panel_inventory.Name = "panel_inventory";
            panel_inventory.Size = new Size(94, 83);
            panel_inventory.TabIndex = 13;
            // 
            // pictureBox8
            // 
            pictureBox8.Image = Properties.Resources.inventory;
            pictureBox8.Location = new Point(20, -2);
            pictureBox8.Margin = new Padding(3, 2, 3, 2);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(52, 33);
            pictureBox8.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox8.TabIndex = 13;
            pictureBox8.TabStop = false;
            // 
            // button_inventory
            // 
            button_inventory.BackColor = Color.FromArgb(74, 98, 101);
            button_inventory.FlatStyle = FlatStyle.Popup;
            button_inventory.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button_inventory.ForeColor = SystemColors.Control;
            button_inventory.Location = new Point(5, 32);
            button_inventory.Margin = new Padding(3, 2, 3, 2);
            button_inventory.Name = "button_inventory";
            button_inventory.Size = new Size(82, 46);
            button_inventory.TabIndex = 12;
            button_inventory.Text = "View Inventory";
            button_inventory.UseVisualStyleBackColor = false;
            button_inventory.Click += button_inventory_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(pictureBox6);
            panel4.Controls.Add(pictureBox7);
            panel4.Controls.Add(button_empaccs);
            panel4.Dock = DockStyle.Left;
            panel4.Location = new Point(481, 0);
            panel4.Margin = new Padding(3, 2, 3, 2);
            panel4.Name = "panel4";
            panel4.Size = new Size(147, 83);
            panel4.TabIndex = 11;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.medical_team;
            pictureBox6.Location = new Point(77, 0);
            pictureBox6.Margin = new Padding(3, 2, 3, 2);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(52, 33);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 12;
            pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = Properties.Resources.nurse;
            pictureBox7.Location = new Point(20, 1);
            pictureBox7.Margin = new Padding(3, 2, 3, 2);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(52, 33);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 13;
            pictureBox7.TabStop = false;
            // 
            // button_empaccs
            // 
            button_empaccs.BackColor = Color.FromArgb(74, 98, 101);
            button_empaccs.FlatStyle = FlatStyle.Popup;
            button_empaccs.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button_empaccs.ForeColor = SystemColors.Control;
            button_empaccs.Location = new Point(5, 32);
            button_empaccs.Margin = new Padding(3, 2, 3, 2);
            button_empaccs.Name = "button_empaccs";
            button_empaccs.Size = new Size(136, 46);
            button_empaccs.TabIndex = 10;
            button_empaccs.Text = "Employee Accounts";
            button_empaccs.UseVisualStyleBackColor = false;
            button_empaccs.Click += button_addnurse_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(pictureBox5);
            panel3.Controls.Add(button_addappointments);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(359, 0);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(122, 83);
            panel3.TabIndex = 10;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.appointment;
            pictureBox5.Location = new Point(35, 0);
            pictureBox5.Margin = new Padding(3, 2, 3, 2);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(52, 33);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 11;
            pictureBox5.TabStop = false;
            // 
            // button_addappointments
            // 
            button_addappointments.BackColor = Color.FromArgb(74, 98, 101);
            button_addappointments.FlatStyle = FlatStyle.Popup;
            button_addappointments.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button_addappointments.ForeColor = SystemColors.Control;
            button_addappointments.Location = new Point(5, 32);
            button_addappointments.Margin = new Padding(3, 2, 3, 2);
            button_addappointments.Name = "button_addappointments";
            button_addappointments.Size = new Size(112, 46);
            button_addappointments.TabIndex = 10;
            button_addappointments.Text = "Appointments";
            button_addappointments.UseVisualStyleBackColor = false;
            button_addappointments.Click += button_addappointments_Click;
            // 
            // panel_addpatient
            // 
            panel_addpatient.Controls.Add(panel1);
            panel_addpatient.Controls.Add(add_patient);
            panel_addpatient.Dock = DockStyle.Left;
            panel_addpatient.Location = new Point(265, 0);
            panel_addpatient.Margin = new Padding(3, 2, 3, 2);
            panel_addpatient.Name = "panel_addpatient";
            panel_addpatient.Size = new Size(94, 83);
            panel_addpatient.TabIndex = 9;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(button2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(94, 83);
            panel1.TabIndex = 10;
            // 
            // panel2
            // 
            panel2.Controls.Add(pictureBox4);
            panel2.Controls.Add(button_addPatient);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(94, 83);
            panel2.TabIndex = 11;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.hospitalisation;
            pictureBox4.Location = new Point(24, 1);
            pictureBox4.Margin = new Padding(3, 2, 3, 2);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(52, 33);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 10;
            pictureBox4.TabStop = false;
            // 
            // button_addPatient
            // 
            button_addPatient.BackColor = Color.FromArgb(74, 98, 101);
            button_addPatient.FlatStyle = FlatStyle.Popup;
            button_addPatient.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button_addPatient.ForeColor = SystemColors.Control;
            button_addPatient.Location = new Point(5, 33);
            button_addPatient.Margin = new Padding(3, 2, 3, 2);
            button_addPatient.Name = "button_addPatient";
            button_addPatient.Size = new Size(82, 46);
            button_addPatient.TabIndex = 9;
            button_addPatient.Text = "Patients";
            button_addPatient.UseVisualStyleBackColor = false;
            button_addPatient.Click += button_addPatient_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(74, 98, 101);
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.Control;
            button2.Location = new Point(5, 33);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(82, 46);
            button2.TabIndex = 9;
            button2.Text = "Add Patient";
            button2.UseVisualStyleBackColor = false;
            // 
            // add_patient
            // 
            add_patient.BackColor = Color.FromArgb(74, 98, 101);
            add_patient.FlatStyle = FlatStyle.Popup;
            add_patient.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            add_patient.ForeColor = SystemColors.Control;
            add_patient.Location = new Point(5, 33);
            add_patient.Margin = new Padding(3, 2, 3, 2);
            add_patient.Name = "add_patient";
            add_patient.Size = new Size(82, 46);
            add_patient.TabIndex = 9;
            add_patient.Text = "Add Patient";
            add_patient.UseVisualStyleBackColor = false;
            // 
            // panel_upperLeft
            // 
            panel_upperLeft.Controls.Add(pictureBox1);
            panel_upperLeft.Controls.Add(label1);
            panel_upperLeft.Controls.Add(pictureBox2);
            panel_upperLeft.Dock = DockStyle.Left;
            panel_upperLeft.Location = new Point(0, 0);
            panel_upperLeft.Margin = new Padding(3, 2, 3, 2);
            panel_upperLeft.Name = "panel_upperLeft";
            panel_upperLeft.Size = new Size(265, 83);
            panel_upperLeft.TabIndex = 8;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.purelogo;
            pictureBox1.Location = new Point(9, 9);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(86, 68);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Agency FB", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(74, 98, 101);
            label1.Location = new Point(97, 44);
            label1.Name = "label1";
            label1.Size = new Size(155, 20);
            label1.TabIndex = 2;
            label1.Text = "Hospital Management System";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.csaidtext;
            pictureBox2.Location = new Point(80, 20);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(102, 36);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // panel_upperRight
            // 
            panel_upperRight.Controls.Add(logout_button);
            panel_upperRight.Controls.Add(label3);
            panel_upperRight.Controls.Add(label2);
            panel_upperRight.Controls.Add(pictureBox3);
            panel_upperRight.Controls.Add(linkLabel_admin);
            panel_upperRight.Dock = DockStyle.Right;
            panel_upperRight.Location = new Point(1441, 0);
            panel_upperRight.Margin = new Padding(3, 2, 3, 2);
            panel_upperRight.Name = "panel_upperRight";
            panel_upperRight.Size = new Size(219, 83);
            panel_upperRight.TabIndex = 7;
            // 
            // logout_button
            // 
            logout_button.FlatStyle = FlatStyle.Flat;
            logout_button.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            logout_button.ForeColor = Color.Red;
            logout_button.Location = new Point(33, 54);
            logout_button.Margin = new Padding(3, 2, 3, 2);
            logout_button.Name = "logout_button";
            logout_button.Size = new Size(144, 28);
            logout_button.TabIndex = 7;
            logout_button.Text = "Log Out?";
            logout_button.UseVisualStyleBackColor = true;
            logout_button.Click += logout_button_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(33, 198, 182);
            label3.Location = new Point(41, 10);
            label3.Name = "label3";
            label3.Size = new Size(93, 19);
            label3.TabIndex = 6;
            label3.Text = "Admin_Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(33, 198, 182);
            label2.Location = new Point(67, 35);
            label2.Name = "label2";
            label2.Size = new Size(77, 15);
            label2.TabIndex = 3;
            label2.Text = "Logged in as:";
            label2.Click += label2_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.user__2_;
            pictureBox3.Location = new Point(10, 5);
            pictureBox3.Margin = new Padding(3, 2, 3, 2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(29, 28);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            // 
            // linkLabel_admin
            // 
            linkLabel_admin.AutoSize = true;
            linkLabel_admin.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            linkLabel_admin.LinkColor = Color.FromArgb(33, 198, 182);
            linkLabel_admin.Location = new Point(152, 33);
            linkLabel_admin.Name = "linkLabel_admin";
            linkLabel_admin.Size = new Size(54, 20);
            linkLabel_admin.TabIndex = 4;
            linkLabel_admin.TabStop = true;
            linkLabel_admin.Text = "Admin";
            // 
            // panel_lower
            // 
            panel_lower.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel_lower.BorderStyle = BorderStyle.Fixed3D;
            panel_lower.Controls.Add(admin_empAccounts1);
            panel_lower.Controls.Add(admin_Inventory1);
            panel_lower.Controls.Add(admin_availableRooms1);
            panel_lower.Controls.Add(admin_addAppointment1);
            panel_lower.Controls.Add(admin_addPatient1);
            panel_lower.Location = new Point(0, 86);
            panel_lower.Margin = new Padding(3, 2, 3, 2);
            panel_lower.Name = "panel_lower";
            panel_lower.Size = new Size(1665, 690);
            panel_lower.TabIndex = 1;
            panel_lower.Paint += panel_lower_Paint;
            // 
            // admin_empAccounts1
            // 
            admin_empAccounts1.BackColor = Color.FromArgb(33, 33, 33);
            admin_empAccounts1.Location = new Point(-2, -2);
            admin_empAccounts1.Margin = new Padding(3, 2, 3, 2);
            admin_empAccounts1.Name = "admin_empAccounts1";
            admin_empAccounts1.Size = new Size(1664, 688);
            admin_empAccounts1.TabIndex = 6;
            admin_empAccounts1.Load += admin_empAccounts1_Load;
            // 
            // admin_Inventory1
            // 
            admin_Inventory1.BackColor = Color.FromArgb(33, 33, 33);
            admin_Inventory1.Location = new Point(-2, -2);
            admin_Inventory1.Margin = new Padding(3, 2, 3, 2);
            admin_Inventory1.Name = "admin_Inventory1";
            admin_Inventory1.Size = new Size(1664, 688);
            admin_Inventory1.TabIndex = 5;
            // 
            // admin_availableRooms1
            // 
            admin_availableRooms1.BackColor = Color.FromArgb(33, 33, 33);
            admin_availableRooms1.Location = new Point(-2, -2);
            admin_availableRooms1.Margin = new Padding(3, 2, 3, 2);
            admin_availableRooms1.Name = "admin_availableRooms1";
            admin_availableRooms1.Size = new Size(1664, 688);
            admin_availableRooms1.TabIndex = 4;
            // 
            // admin_addAppointment1
            // 
            admin_addAppointment1.BackColor = Color.FromArgb(33, 33, 33);
            admin_addAppointment1.Location = new Point(-2, -2);
            admin_addAppointment1.Margin = new Padding(3, 2, 3, 2);
            admin_addAppointment1.Name = "admin_addAppointment1";
            admin_addAppointment1.Size = new Size(1664, 688);
            admin_addAppointment1.TabIndex = 1;
            // 
            // admin_addPatient1
            // 
            admin_addPatient1.BackColor = Color.FromArgb(33, 33, 33);
            admin_addPatient1.Location = new Point(-2, -2);
            admin_addPatient1.Margin = new Padding(3, 2, 3, 2);
            admin_addPatient1.Name = "admin_addPatient1";
            admin_addPatient1.Size = new Size(1664, 688);
            admin_addPatient1.TabIndex = 0;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(33, 33, 33);
            ClientSize = new Size(1664, 775);
            Controls.Add(panel_lower);
            Controls.Add(panel_upper);
            Margin = new Padding(3, 2, 3, 2);
            Name = "AdminForm";
            Text = "CSAid Hospital Management System - Admin";
            WindowState = FormWindowState.Maximized;
            Load += AdminForm_Load;
            panel_upper.ResumeLayout(false);
            panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            panel_inventory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            panel_addpatient.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel_upperLeft.ResumeLayout(false);
            panel_upperLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel_upperRight.ResumeLayout(false);
            panel_upperRight.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel_lower.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_upper;
        private PictureBox pictureBox1;
        private Panel panel_lower;
        private Label label1;
        private PictureBox pictureBox2;
        private Label label2;
        private LinkLabel linkLabel_admin;
        private Panel panel_upperRight;
        private Label label3;
        private PictureBox pictureBox3;
        private Button logout_button;
        private Panel panel_upperLeft;
        private Panel panel4;
        private Button button_empaccs;
        private Panel panel3;
        private Button button_addappointments;
        private Panel panel_addpatient;
        private Panel panel1;
        private Panel panel2;
        private Button button_addPatient;
        private Button button2;
        private Button add_patient;
        private Panel panel_inventory;
        private Button button_inventory;
        private Panel panel6;
        private Button button4;
        private PictureBox pictureBox9;
        private PictureBox pictureBox8;
        private PictureBox pictureBox7;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private Admin_addPatient admin_addPatient1;
        private Admin_Inventory admin_Inventory1;
        private Admin_availableRooms admin_availableRooms1;
        private Admin_addAppointment admin_addAppointment1;
        private PictureBox pictureBox6;
        private Admin_empAccounts admin_empAccounts1;
    }
}
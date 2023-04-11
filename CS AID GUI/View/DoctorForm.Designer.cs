namespace CSAid_MainWinFormsApp.View
{
    partial class DoctorForm
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
            panel_lower = new Panel();
            doctor_Appointments2 = new Doctor_Appointments();
            doctor_Operations2 = new Doctor_Operations();
            panel_upper = new Panel();
            panel1 = new Panel();
            pictureBox6 = new PictureBox();
            linkLabel1 = new LinkLabel();
            label4 = new Label();
            panel3 = new Panel();
            pictureBox5 = new PictureBox();
            button_appointments = new Button();
            panel2 = new Panel();
            pictureBox4 = new PictureBox();
            button_noOfOperations = new Button();
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
            panel_lower.SuspendLayout();
            panel_upper.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel_upperLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel_upperRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // panel_lower
            // 
            panel_lower.BackColor = Color.FromArgb(33, 33, 33);
            panel_lower.BorderStyle = BorderStyle.Fixed3D;
            panel_lower.Controls.Add(doctor_Appointments2);
            panel_lower.Controls.Add(doctor_Operations2);
            panel_lower.Dock = DockStyle.Fill;
            panel_lower.Location = new Point(0, 115);
            panel_lower.Name = "panel_lower";
            panel_lower.Size = new Size(1260, 501);
            panel_lower.TabIndex = 3;
            panel_lower.Paint += panel_lower_Paint;
            // 
            // doctor_Appointments2
            // 
            doctor_Appointments2.BackColor = Color.FromArgb(33, 33, 33);
            doctor_Appointments2.Location = new Point(-2, -2);
            doctor_Appointments2.Name = "doctor_Appointments2";
            doctor_Appointments2.Size = new Size(1260, 501);
            doctor_Appointments2.TabIndex = 1;
            // 
            // doctor_Operations2
            // 
            doctor_Operations2.BackColor = Color.FromArgb(33, 33, 33);
            doctor_Operations2.Location = new Point(-2, -4);
            doctor_Operations2.Name = "doctor_Operations2";
            doctor_Operations2.Size = new Size(1147, 503);
            doctor_Operations2.TabIndex = 0;
            // 
            // panel_upper
            // 
            panel_upper.BackColor = Color.FromArgb(33, 33, 33);
            panel_upper.BorderStyle = BorderStyle.Fixed3D;
            panel_upper.Controls.Add(panel1);
            panel_upper.Controls.Add(panel3);
            panel_upper.Controls.Add(panel2);
            panel_upper.Controls.Add(panel_upperLeft);
            panel_upper.Controls.Add(panel_upperRight);
            panel_upper.Dock = DockStyle.Top;
            panel_upper.Location = new Point(0, 0);
            panel_upper.Name = "panel_upper";
            panel_upper.Size = new Size(1260, 115);
            panel_upper.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox6);
            panel1.Controls.Add(linkLabel1);
            panel1.Controls.Add(label4);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(756, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 111);
            panel1.TabIndex = 15;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.stethoscope;
            pictureBox6.Location = new Point(13, 1);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(59, 44);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 12;
            pictureBox6.TabStop = false;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            linkLabel1.LinkColor = Color.FromArgb(33, 198, 182);
            linkLabel1.Location = new Point(54, 72);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(178, 25);
            linkLabel1.TabIndex = 8;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Specialization_Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(33, 198, 182);
            label4.Location = new Point(13, 47);
            label4.Name = "label4";
            label4.Size = new Size(118, 23);
            label4.TabIndex = 8;
            label4.Text = "Specialization:";
            label4.Click += label4_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(pictureBox5);
            panel3.Controls.Add(button_appointments);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(410, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(140, 111);
            panel3.TabIndex = 12;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.medical_appointment;
            pictureBox5.Location = new Point(44, 0);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(59, 44);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 11;
            pictureBox5.TabStop = false;
            // 
            // button_appointments
            // 
            button_appointments.BackColor = Color.FromArgb(74, 98, 101);
            button_appointments.FlatStyle = FlatStyle.Popup;
            button_appointments.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button_appointments.ForeColor = SystemColors.Control;
            button_appointments.Location = new Point(6, 43);
            button_appointments.Name = "button_appointments";
            button_appointments.Size = new Size(128, 61);
            button_appointments.TabIndex = 10;
            button_appointments.Text = "Appointments";
            button_appointments.UseVisualStyleBackColor = false;
            button_appointments.Click += button_addappointments_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(pictureBox4);
            panel2.Controls.Add(button_noOfOperations);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(303, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(107, 111);
            panel2.TabIndex = 14;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.operating_room;
            pictureBox4.Location = new Point(27, 1);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(59, 44);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 10;
            pictureBox4.TabStop = false;
            // 
            // button_noOfOperations
            // 
            button_noOfOperations.BackColor = Color.FromArgb(74, 98, 101);
            button_noOfOperations.FlatStyle = FlatStyle.Popup;
            button_noOfOperations.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button_noOfOperations.ForeColor = SystemColors.Control;
            button_noOfOperations.Location = new Point(6, 44);
            button_noOfOperations.Name = "button_noOfOperations";
            button_noOfOperations.Size = new Size(94, 61);
            button_noOfOperations.TabIndex = 9;
            button_noOfOperations.Text = "Operations";
            button_noOfOperations.UseVisualStyleBackColor = false;
            button_noOfOperations.Click += button_noOfOperations_Click;
            // 
            // panel_upperLeft
            // 
            panel_upperLeft.Controls.Add(pictureBox1);
            panel_upperLeft.Controls.Add(label1);
            panel_upperLeft.Controls.Add(pictureBox2);
            panel_upperLeft.Dock = DockStyle.Left;
            panel_upperLeft.Location = new Point(0, 0);
            panel_upperLeft.Name = "panel_upperLeft";
            panel_upperLeft.Size = new Size(303, 111);
            panel_upperLeft.TabIndex = 8;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.purelogo;
            pictureBox1.Location = new Point(10, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(98, 91);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Agency FB", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(74, 98, 101);
            label1.Location = new Point(111, 59);
            label1.Name = "label1";
            label1.Size = new Size(185, 24);
            label1.TabIndex = 2;
            label1.Text = "Hospital Management System";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.csaidtext;
            pictureBox2.Location = new Point(91, 27);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(117, 48);
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
            panel_upperRight.Location = new Point(1006, 0);
            panel_upperRight.Name = "panel_upperRight";
            panel_upperRight.Size = new Size(250, 111);
            panel_upperRight.TabIndex = 7;
            // 
            // logout_button
            // 
            logout_button.FlatStyle = FlatStyle.Flat;
            logout_button.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            logout_button.ForeColor = Color.Red;
            logout_button.Location = new Point(38, 72);
            logout_button.Name = "logout_button";
            logout_button.Size = new Size(165, 37);
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
            label3.Location = new Point(47, 13);
            label3.Name = "label3";
            label3.Size = new Size(115, 23);
            label3.TabIndex = 6;
            label3.Text = "Doctor_Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(33, 198, 182);
            label2.Location = new Point(77, 47);
            label2.Name = "label2";
            label2.Size = new Size(99, 20);
            label2.TabIndex = 3;
            label2.Text = "Logged in as:";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.user__2_;
            pictureBox3.Location = new Point(11, 7);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(33, 37);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            // 
            // linkLabel_admin
            // 
            linkLabel_admin.AutoSize = true;
            linkLabel_admin.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            linkLabel_admin.LinkColor = Color.FromArgb(33, 198, 182);
            linkLabel_admin.Location = new Point(174, 44);
            linkLabel_admin.Name = "linkLabel_admin";
            linkLabel_admin.Size = new Size(66, 25);
            linkLabel_admin.TabIndex = 4;
            linkLabel_admin.TabStop = true;
            linkLabel_admin.Text = "Doctor";
            // 
            // DoctorForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1260, 616);
            Controls.Add(panel_lower);
            Controls.Add(panel_upper);
            Name = "DoctorForm";
            Text = "CSAid Hospital Management System - Doctor";
            WindowState = FormWindowState.Maximized;
            Load += DoctorForm_Load;
            panel_lower.ResumeLayout(false);
            panel_upper.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel_upperLeft.ResumeLayout(false);
            panel_upperLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel_upperRight.ResumeLayout(false);
            panel_upperRight.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_lower;
        private Panel panel_upper;
        private Panel panel_upperLeft;
        private PictureBox pictureBox1;
        private Label label1;
        private PictureBox pictureBox2;
        private Panel panel_upperRight;
        private Button logout_button;
        private Label label3;
        private Label label2;
        private PictureBox pictureBox3;
        private LinkLabel linkLabel_admin;
        private Panel panel3;
        private PictureBox pictureBox5;
        private Button button_appointments;
        private Panel panel2;
        private PictureBox pictureBox4;
        private Button button_noOfOperations;
        private Doctor_Appointments doctor_Appointments2;
        private Doctor_Operations doctor_Operations2;
        private Label label4;
        private Panel panel1;
        private LinkLabel linkLabel1;
        private PictureBox pictureBox6;
    }
}
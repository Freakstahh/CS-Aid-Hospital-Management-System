namespace CSAid_MainWinFormsApp.View
{
    partial class NurseForm
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
            panel_upperLeft = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            panel_upper = new Panel();
            panel3 = new Panel();
            pictureBox6 = new PictureBox();
            button_departments = new Button();
            panel4 = new Panel();
            panel1 = new Panel();
            pictureBox5 = new PictureBox();
            button_rounds = new Button();
            pictureBox7 = new PictureBox();
            button_addnurse = new Button();
            panel2 = new Panel();
            pictureBox4 = new PictureBox();
            button_Shifts = new Button();
            panel_upperRight = new Panel();
            logout_button = new Button();
            label3 = new Label();
            label2 = new Label();
            pictureBox3 = new PictureBox();
            linkLabel_admin = new LinkLabel();
            panel_lower = new Panel();
            nurse_Departments1 = new Nurse_Departments();
            nurse_Rounds1 = new Nurse_Rounds();
            nurse_Shifts1 = new Nurse_Shifts();
            panel_upperLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel_upper.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            panel4.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel_upperRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel_lower.SuspendLayout();
            SuspendLayout();
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
            // panel_upper
            // 
            panel_upper.BackColor = Color.FromArgb(33, 33, 33);
            panel_upper.BorderStyle = BorderStyle.Fixed3D;
            panel_upper.Controls.Add(panel3);
            panel_upper.Controls.Add(panel4);
            panel_upper.Controls.Add(panel2);
            panel_upper.Controls.Add(panel_upperLeft);
            panel_upper.Controls.Add(panel_upperRight);
            panel_upper.Dock = DockStyle.Top;
            panel_upper.Location = new Point(0, 0);
            panel_upper.Name = "panel_upper";
            panel_upper.Size = new Size(1147, 115);
            panel_upper.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.Controls.Add(pictureBox6);
            panel3.Controls.Add(button_departments);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(516, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(130, 111);
            panel3.TabIndex = 15;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.plastic_surgery;
            pictureBox6.Location = new Point(35, 1);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(59, 44);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 13;
            pictureBox6.TabStop = false;
            // 
            // button_departments
            // 
            button_departments.BackColor = Color.FromArgb(74, 98, 101);
            button_departments.FlatStyle = FlatStyle.Popup;
            button_departments.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button_departments.ForeColor = SystemColors.Control;
            button_departments.Location = new Point(6, 43);
            button_departments.Name = "button_departments";
            button_departments.Size = new Size(117, 61);
            button_departments.TabIndex = 10;
            button_departments.Text = "Departments";
            button_departments.UseVisualStyleBackColor = false;
            button_departments.Click += button_departments_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(panel1);
            panel4.Controls.Add(pictureBox7);
            panel4.Controls.Add(button_addnurse);
            panel4.Dock = DockStyle.Left;
            panel4.Location = new Point(410, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(106, 111);
            panel4.TabIndex = 13;
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox5);
            panel1.Controls.Add(button_rounds);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(106, 111);
            panel1.TabIndex = 14;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.arrow;
            pictureBox5.Location = new Point(23, 1);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(59, 44);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 13;
            pictureBox5.TabStop = false;
            // 
            // button_rounds
            // 
            button_rounds.BackColor = Color.FromArgb(74, 98, 101);
            button_rounds.FlatStyle = FlatStyle.Popup;
            button_rounds.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button_rounds.ForeColor = SystemColors.Control;
            button_rounds.Location = new Point(6, 43);
            button_rounds.Name = "button_rounds";
            button_rounds.Size = new Size(94, 61);
            button_rounds.TabIndex = 10;
            button_rounds.Text = "Rounds";
            button_rounds.UseVisualStyleBackColor = false;
            button_rounds.Click += button_rounds_Click;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = Properties.Resources.nurse;
            pictureBox7.Location = new Point(23, 1);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(59, 44);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 13;
            pictureBox7.TabStop = false;
            // 
            // button_addnurse
            // 
            button_addnurse.BackColor = Color.FromArgb(74, 98, 101);
            button_addnurse.FlatStyle = FlatStyle.Popup;
            button_addnurse.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button_addnurse.ForeColor = SystemColors.Control;
            button_addnurse.Location = new Point(6, 43);
            button_addnurse.Name = "button_addnurse";
            button_addnurse.Size = new Size(94, 61);
            button_addnurse.TabIndex = 10;
            button_addnurse.Text = "Add Nurse";
            button_addnurse.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(pictureBox4);
            panel2.Controls.Add(button_Shifts);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(303, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(107, 111);
            panel2.TabIndex = 14;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.work_schedule;
            pictureBox4.Location = new Point(27, 1);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(59, 44);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 10;
            pictureBox4.TabStop = false;
            // 
            // button_Shifts
            // 
            button_Shifts.BackColor = Color.FromArgb(74, 98, 101);
            button_Shifts.FlatStyle = FlatStyle.Popup;
            button_Shifts.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button_Shifts.ForeColor = SystemColors.Control;
            button_Shifts.Location = new Point(6, 44);
            button_Shifts.Name = "button_Shifts";
            button_Shifts.Size = new Size(94, 61);
            button_Shifts.TabIndex = 9;
            button_Shifts.Text = "Shifts";
            button_Shifts.UseVisualStyleBackColor = false;
            button_Shifts.Click += button_Shifts_Click;
            // 
            // panel_upperRight
            // 
            panel_upperRight.Controls.Add(logout_button);
            panel_upperRight.Controls.Add(label3);
            panel_upperRight.Controls.Add(label2);
            panel_upperRight.Controls.Add(pictureBox3);
            panel_upperRight.Controls.Add(linkLabel_admin);
            panel_upperRight.Dock = DockStyle.Right;
            panel_upperRight.Location = new Point(893, 0);
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
            label3.Size = new Size(108, 23);
            label3.TabIndex = 6;
            label3.Text = "Nurse_Name";
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
            linkLabel_admin.Size = new Size(60, 25);
            linkLabel_admin.TabIndex = 4;
            linkLabel_admin.TabStop = true;
            linkLabel_admin.Text = "Nurse";
            // 
            // panel_lower
            // 
            panel_lower.BackColor = Color.FromArgb(33, 33, 33);
            panel_lower.BorderStyle = BorderStyle.Fixed3D;
            panel_lower.Controls.Add(nurse_Departments1);
            panel_lower.Controls.Add(nurse_Rounds1);
            panel_lower.Controls.Add(nurse_Shifts1);
            panel_lower.Dock = DockStyle.Fill;
            panel_lower.Location = new Point(0, 0);
            panel_lower.Name = "panel_lower";
            panel_lower.Size = new Size(1147, 616);
            panel_lower.TabIndex = 3;
            panel_lower.Paint += panel_lower_Paint;
            // 
            // nurse_Departments1
            // 
            nurse_Departments1.BackColor = Color.FromArgb(33, 33, 33);
            nurse_Departments1.Location = new Point(-2, 111);
            nurse_Departments1.Name = "nurse_Departments1";
            nurse_Departments1.Size = new Size(1147, 503);
            nurse_Departments1.TabIndex = 2;
            // 
            // nurse_Rounds1
            // 
            nurse_Rounds1.BackColor = Color.FromArgb(33, 33, 33);
            nurse_Rounds1.Location = new Point(-2, 111);
            nurse_Rounds1.Name = "nurse_Rounds1";
            nurse_Rounds1.Size = new Size(1147, 503);
            nurse_Rounds1.TabIndex = 1;
            // 
            // nurse_Shifts1
            // 
            nurse_Shifts1.BackColor = Color.FromArgb(33, 33, 33);
            nurse_Shifts1.Location = new Point(-2, 111);
            nurse_Shifts1.Name = "nurse_Shifts1";
            nurse_Shifts1.Size = new Size(1145, 503);
            nurse_Shifts1.TabIndex = 0;
            // 
            // NurseForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1147, 616);
            Controls.Add(panel_upper);
            Controls.Add(panel_lower);
            Name = "NurseForm";
            Text = "CSAid Hospital Management System - Nurse";
            Load += NurseForm_Load;
            panel_upperLeft.ResumeLayout(false);
            panel_upperLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel_upper.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            panel4.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel_upperRight.ResumeLayout(false);
            panel_upperRight.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel_lower.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_upperLeft;
        private PictureBox pictureBox1;
        private Label label1;
        private PictureBox pictureBox2;
        private Panel panel_upper;
        private Panel panel_upperRight;
        private Button logout_button;
        private Label label3;
        private Label label2;
        private PictureBox pictureBox3;
        private LinkLabel linkLabel_admin;
        private Panel panel_lower;
        private Panel panel4;
        private PictureBox pictureBox7;
        private Button button_addnurse;
        private Panel panel2;
        private PictureBox pictureBox4;
        private Button button_Shifts;
        private Panel panel3;
        private PictureBox pictureBox6;
        private Button button_departments;
        private Panel panel1;
        private PictureBox pictureBox5;
        private Button button_rounds;
        private Nurse_Departments nurse_Departments1;
        private Nurse_Rounds nurse_Rounds1;
        private Nurse_Shifts nurse_Shifts1;
    }
}
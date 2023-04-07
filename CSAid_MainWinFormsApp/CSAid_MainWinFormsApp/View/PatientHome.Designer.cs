namespace CSAid_MainWinFormsApp.View
{
    partial class PatientHome
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
            panel_upperLeft = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            panel_upper = new Panel();
            panel_upperRight = new Panel();
            logout_button = new Button();
            label3 = new Label();
            label2 = new Label();
            pictureBox3 = new PictureBox();
            linkLabel_admin = new LinkLabel();
            panel_upperLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel_upper.SuspendLayout();
            panel_upperRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // panel_lower
            // 
            panel_lower.BackColor = Color.FromArgb(33, 33, 33);
            panel_lower.BorderStyle = BorderStyle.Fixed3D;
            panel_lower.Dock = DockStyle.Fill;
            panel_lower.Location = new Point(0, 115);
            panel_lower.Name = "panel_lower";
            panel_lower.Size = new Size(1147, 501);
            panel_lower.TabIndex = 5;
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
            pictureBox1.Size = new Size(98, 90);
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
            pictureBox2.Location = new Point(92, 27);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(116, 48);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // panel_upper
            // 
            panel_upper.BackColor = Color.FromArgb(33, 33, 33);
            panel_upper.BorderStyle = BorderStyle.Fixed3D;
            panel_upper.Controls.Add(panel_upperLeft);
            panel_upper.Controls.Add(panel_upperRight);
            panel_upper.Dock = DockStyle.Top;
            panel_upper.Location = new Point(0, 0);
            panel_upper.Name = "panel_upper";
            panel_upper.Size = new Size(1147, 115);
            panel_upper.TabIndex = 4;
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
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(33, 198, 182);
            label3.Location = new Point(47, 14);
            label3.Name = "label3";
            label3.Size = new Size(117, 23);
            label3.TabIndex = 6;
            label3.Text = "Patient_Name";
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
            pictureBox3.Size = new Size(33, 38);
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
            linkLabel_admin.Size = new Size(69, 25);
            linkLabel_admin.TabIndex = 4;
            linkLabel_admin.TabStop = true;
            linkLabel_admin.Text = "Patient";
            // 
            // PatientHome
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1147, 616);
            Controls.Add(panel_lower);
            Controls.Add(panel_upper);
            Name = "PatientHome";
            Text = "CSAid Hospital Management System - Patient";
            panel_upperLeft.ResumeLayout(false);
            panel_upperLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel_upper.ResumeLayout(false);
            panel_upperRight.ResumeLayout(false);
            panel_upperRight.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_lower;
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
    }
}
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
            panel_upper = new Panel();
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
            panel_upper.SuspendLayout();
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
            panel_lower.Dock = DockStyle.Fill;
            panel_lower.Location = new Point(0, 87);
            panel_lower.Margin = new Padding(3, 2, 3, 2);
            panel_lower.Name = "panel_lower";
            panel_lower.Size = new Size(1004, 375);
            panel_lower.TabIndex = 3;
            panel_lower.Paint += panel_lower_Paint;
            // 
            // panel_upper
            // 
            panel_upper.BackColor = Color.FromArgb(33, 33, 33);
            panel_upper.BorderStyle = BorderStyle.Fixed3D;
            panel_upper.Controls.Add(panel_upperLeft);
            panel_upper.Controls.Add(panel_upperRight);
            panel_upper.Dock = DockStyle.Top;
            panel_upper.Location = new Point(0, 0);
            panel_upper.Margin = new Padding(3, 2, 3, 2);
            panel_upper.Name = "panel_upper";
            panel_upper.Size = new Size(1004, 87);
            panel_upper.TabIndex = 2;
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
            panel_upperRight.Location = new Point(781, 0);
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
            label3.Size = new Size(95, 19);
            label3.TabIndex = 6;
            label3.Text = "Doctor_Name";
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
            linkLabel_admin.Text = "Doctor";
            // 
            // DoctorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1004, 462);
            Controls.Add(panel_lower);
            Controls.Add(panel_upper);
            Margin = new Padding(3, 2, 3, 2);
            Name = "DoctorForm";
            Text = "CSAid Hospital Management System - Doctor";
            panel_upper.ResumeLayout(false);
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
    }
}
namespace CSAid_MainWinFormsApp.View
{
    partial class Register
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelregister = new Label();
            panel1 = new Panel();
            pictureBoxlogo = new PictureBox();
            label3 = new Label();
            textBox_firstname = new TextBox();
            fullname_label = new Label();
            textBox_MI = new TextBox();
            textBox_lastname = new TextBox();
            dateTimePicker = new DateTimePicker();
            dateofbirth_label = new Label();
            label_gender = new Label();
            textBox1 = new TextBox();
            label_number = new Label();
            label_emailadd = new Label();
            textBox2 = new TextBox();
            label_personalinfo = new Label();
            label_logininfo = new Label();
            label1 = new Label();
            textBox3 = new TextBox();
            label2 = new Label();
            textBox4 = new TextBox();
            label4 = new Label();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            label5 = new Label();
            button1 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxlogo).BeginInit();
            SuspendLayout();
            // 
            // labelregister
            // 
            labelregister.AutoSize = true;
            labelregister.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            labelregister.ForeColor = Color.WhiteSmoke;
            labelregister.Location = new Point(0, 63);
            labelregister.Name = "labelregister";
            labelregister.Size = new Size(233, 62);
            labelregister.TabIndex = 0;
            labelregister.Text = "  Register";
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBoxlogo);
            panel1.Controls.Add(labelregister);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(558, 125);
            panel1.TabIndex = 1;
            // 
            // pictureBoxlogo
            // 
            pictureBoxlogo.Image = Properties.Resources.MainLogo_removebg_preview;
            pictureBoxlogo.Location = new Point(348, 14);
            pictureBoxlogo.Name = "pictureBoxlogo";
            pictureBoxlogo.Size = new Size(207, 125);
            pictureBoxlogo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxlogo.TabIndex = 8;
            pictureBoxlogo.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Agency FB", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(33, 198, 182);
            label3.Location = new Point(374, 128);
            label3.Name = "label3";
            label3.Size = new Size(154, 18);
            label3.TabIndex = 9;
            label3.Text = "Hospital Management System";
            // 
            // textBox_firstname
            // 
            textBox_firstname.BackColor = Color.FromArgb(50, 50, 50);
            textBox_firstname.ForeColor = Color.WhiteSmoke;
            textBox_firstname.Location = new Point(51, 195);
            textBox_firstname.Name = "textBox_firstname";
            textBox_firstname.PlaceholderText = "First Name";
            textBox_firstname.Size = new Size(175, 27);
            textBox_firstname.TabIndex = 10;
            // 
            // fullname_label
            // 
            fullname_label.AutoSize = true;
            fullname_label.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            fullname_label.ForeColor = Color.WhiteSmoke;
            fullname_label.Location = new Point(44, 175);
            fullname_label.Name = "fullname_label";
            fullname_label.Size = new Size(69, 17);
            fullname_label.TabIndex = 9;
            fullname_label.Text = "Full Name";
            fullname_label.Click += label1_Click;
            // 
            // textBox_MI
            // 
            textBox_MI.BackColor = Color.FromArgb(50, 50, 50);
            textBox_MI.ForeColor = Color.WhiteSmoke;
            textBox_MI.Location = new Point(245, 195);
            textBox_MI.Name = "textBox_MI";
            textBox_MI.PlaceholderText = "M.I.";
            textBox_MI.Size = new Size(58, 27);
            textBox_MI.TabIndex = 11;
            // 
            // textBox_lastname
            // 
            textBox_lastname.BackColor = Color.FromArgb(50, 50, 50);
            textBox_lastname.ForeColor = Color.WhiteSmoke;
            textBox_lastname.Location = new Point(324, 195);
            textBox_lastname.Name = "textBox_lastname";
            textBox_lastname.PlaceholderText = "Last Name";
            textBox_lastname.Size = new Size(175, 27);
            textBox_lastname.TabIndex = 12;
            // 
            // dateTimePicker
            // 
            dateTimePicker.CalendarMonthBackground = Color.FromArgb(50, 50, 50);
            dateTimePicker.Format = DateTimePickerFormat.Short;
            dateTimePicker.Location = new Point(51, 255);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.RightToLeft = RightToLeft.No;
            dateTimePicker.Size = new Size(175, 27);
            dateTimePicker.TabIndex = 14;
            dateTimePicker.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // dateofbirth_label
            // 
            dateofbirth_label.AutoSize = true;
            dateofbirth_label.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            dateofbirth_label.ForeColor = Color.WhiteSmoke;
            dateofbirth_label.Location = new Point(44, 235);
            dateofbirth_label.Name = "dateofbirth_label";
            dateofbirth_label.Size = new Size(85, 17);
            dateofbirth_label.TabIndex = 13;
            dateofbirth_label.Text = "Date of Birth";
            // 
            // label_gender
            // 
            label_gender.AutoSize = true;
            label_gender.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            label_gender.ForeColor = Color.WhiteSmoke;
            label_gender.Location = new Point(411, 235);
            label_gender.Name = "label_gender";
            label_gender.Size = new Size(52, 17);
            label_gender.TabIndex = 17;
            label_gender.Text = "Gender";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(50, 50, 50);
            textBox1.ForeColor = Color.WhiteSmoke;
            textBox1.Location = new Point(239, 254);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "e.g. 09xxxxxxxxx";
            textBox1.Size = new Size(164, 27);
            textBox1.TabIndex = 18;
            // 
            // label_number
            // 
            label_number.AutoSize = true;
            label_number.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            label_number.ForeColor = Color.WhiteSmoke;
            label_number.Location = new Point(234, 234);
            label_number.Name = "label_number";
            label_number.Size = new Size(101, 17);
            label_number.TabIndex = 19;
            label_number.Text = "Phone Number";
            // 
            // label_emailadd
            // 
            label_emailadd.AutoSize = true;
            label_emailadd.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            label_emailadd.ForeColor = Color.WhiteSmoke;
            label_emailadd.Location = new Point(44, 294);
            label_emailadd.Name = "label_emailadd";
            label_emailadd.Size = new Size(93, 17);
            label_emailadd.TabIndex = 20;
            label_emailadd.Text = "Email Address";
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(50, 50, 50);
            textBox2.ForeColor = Color.WhiteSmoke;
            textBox2.Location = new Point(51, 314);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "source.example@mail.com";
            textBox2.Size = new Size(364, 27);
            textBox2.TabIndex = 21;
            // 
            // label_personalinfo
            // 
            label_personalinfo.AutoSize = true;
            label_personalinfo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label_personalinfo.ForeColor = Color.WhiteSmoke;
            label_personalinfo.Location = new Point(29, 149);
            label_personalinfo.Name = "label_personalinfo";
            label_personalinfo.Size = new Size(158, 20);
            label_personalinfo.TabIndex = 22;
            label_personalinfo.Text = "Personal Information";
            // 
            // label_logininfo
            // 
            label_logininfo.AutoSize = true;
            label_logininfo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label_logininfo.ForeColor = Color.WhiteSmoke;
            label_logininfo.Location = new Point(29, 355);
            label_logininfo.Name = "label_logininfo";
            label_logininfo.Size = new Size(137, 20);
            label_logininfo.TabIndex = 23;
            label_logininfo.Text = "Login Information";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(51, 381);
            label1.Name = "label1";
            label1.Size = new Size(69, 17);
            label1.TabIndex = 24;
            label1.Text = "Username";
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.FromArgb(50, 50, 50);
            textBox3.ForeColor = Color.WhiteSmoke;
            textBox3.Location = new Point(58, 401);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(198, 27);
            textBox3.TabIndex = 25;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.WhiteSmoke;
            label2.Location = new Point(295, 381);
            label2.Name = "label2";
            label2.Size = new Size(66, 17);
            label2.TabIndex = 26;
            label2.Text = "Password";
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.FromArgb(50, 50, 50);
            textBox4.ForeColor = Color.WhiteSmoke;
            textBox4.Location = new Point(302, 401);
            textBox4.Name = "textBox4";
            textBox4.PasswordChar = '*';
            textBox4.Size = new Size(195, 27);
            textBox4.TabIndex = 27;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.WhiteSmoke;
            label4.Location = new Point(29, 441);
            label4.Name = "label4";
            label4.Size = new Size(129, 20);
            label4.TabIndex = 28;
            label4.Text = "Role Information";
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.FromArgb(50, 50, 50);
            comboBox1.ForeColor = Color.WhiteSmoke;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Male", "Female" });
            comboBox1.Location = new Point(414, 254);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(85, 28);
            comboBox1.TabIndex = 30;
            // 
            // comboBox2
            // 
            comboBox2.BackColor = Color.FromArgb(50, 50, 50);
            comboBox2.ForeColor = Color.WhiteSmoke;
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Patient", "Admin", "Doctor", "Nurse" });
            comboBox2.Location = new Point(51, 481);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(205, 28);
            comboBox2.TabIndex = 31;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.WhiteSmoke;
            label5.Location = new Point(44, 461);
            label5.Name = "label5";
            label5.Size = new Size(34, 17);
            label5.TabIndex = 32;
            label5.Text = "Role";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.WhiteSmoke;
            button1.Location = new Point(302, 481);
            button1.Name = "button1";
            button1.Size = new Size(195, 61);
            button1.TabIndex = 33;
            button1.Text = "Register";
            button1.UseVisualStyleBackColor = false;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(50, 50, 50);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(textBox4);
            Controls.Add(label1);
            Controls.Add(textBox3);
            Controls.Add(label_logininfo);
            Controls.Add(label_personalinfo);
            Controls.Add(label_emailadd);
            Controls.Add(textBox2);
            Controls.Add(label_number);
            Controls.Add(textBox1);
            Controls.Add(label_gender);
            Controls.Add(dateTimePicker);
            Controls.Add(dateofbirth_label);
            Controls.Add(textBox_lastname);
            Controls.Add(textBox_MI);
            Controls.Add(fullname_label);
            Controls.Add(textBox_firstname);
            Controls.Add(label3);
            Controls.Add(panel1);
            Name = "Register";
            Size = new Size(558, 598);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxlogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelregister;
        private Panel panel1;
        private PictureBox pictureBoxlogo;
        private Label label3;
        private TextBox textBox_firstname;
        private Label fullname_label;
        private TextBox textBox_MI;
        private TextBox textBox_lastname;
        private DateTimePicker dateTimePicker;
        private Label dateofbirth_label;
        private Label label_gender;
        private TextBox textBox1;
        private Label label_number;
        private Label label_emailadd;
        private TextBox textBox2;
        private Label label_personalinfo;
        private Label label_logininfo;
        private Label label1;
        private TextBox textBox3;
        private Label label2;
        private TextBox textBox4;
        private Label label4;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Label label5;
        private Button button1;
    }
}

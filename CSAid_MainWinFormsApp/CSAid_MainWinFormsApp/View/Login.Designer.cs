namespace CSAid_MainWinFormsApp.View
{
    partial class Login
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
            panel2 = new Panel();
            label3 = new Label();
            pictureBox_user = new PictureBox();
            pictureBox_key = new PictureBox();
            button_login = new Button();
            textBox_pass = new TextBox();
            textBox_username = new TextBox();
            label2 = new Label();
            label1 = new Label();
            pictureBoxlogo = new PictureBox();
            labellogin = new Label();
            panel1 = new Panel();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_user).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_key).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxlogo).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(label3);
            panel2.Controls.Add(pictureBox_user);
            panel2.Controls.Add(pictureBox_key);
            panel2.Controls.Add(button_login);
            panel2.Controls.Add(textBox_pass);
            panel2.Controls.Add(textBox_username);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 94);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(488, 354);
            panel2.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Agency FB", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(33, 198, 182);
            label3.Location = new Point(327, 3);
            label3.Name = "label3";
            label3.Size = new Size(111, 15);
            label3.TabIndex = 7;
            label3.Text = "Hospital Management System";
            // 
            // pictureBox_user
            // 
            pictureBox_user.Image = Properties.Resources.profile;
            pictureBox_user.Location = new Point(66, 68);
            pictureBox_user.Margin = new Padding(3, 2, 3, 2);
            pictureBox_user.Name = "pictureBox_user";
            pictureBox_user.Size = new Size(35, 30);
            pictureBox_user.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox_user.TabIndex = 6;
            pictureBox_user.TabStop = false;
            // 
            // pictureBox_key
            // 
            pictureBox_key.Image = Properties.Resources.key1;
            pictureBox_key.Location = new Point(66, 152);
            pictureBox_key.Margin = new Padding(3, 2, 3, 2);
            pictureBox_key.Name = "pictureBox_key";
            pictureBox_key.Size = new Size(35, 30);
            pictureBox_key.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox_key.TabIndex = 5;
            pictureBox_key.TabStop = false;
            // 
            // button_login
            // 
            button_login.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button_login.ForeColor = Color.WhiteSmoke;
            button_login.Location = new Point(177, 247);
            button_login.Margin = new Padding(3, 2, 3, 2);
            button_login.Name = "button_login";
            button_login.Size = new Size(120, 28);
            button_login.TabIndex = 4;
            button_login.Text = "Log in";
            button_login.UseVisualStyleBackColor = false;
            button_login.Click += button_login_Click;
            // 
            // textBox_pass
            // 
            textBox_pass.AcceptsReturn = true;
            textBox_pass.BackColor = Color.FromArgb(50, 50, 50);
            textBox_pass.ForeColor = Color.WhiteSmoke;
            textBox_pass.Location = new Point(71, 186);
            textBox_pass.Margin = new Padding(3, 2, 3, 2);
            textBox_pass.Name = "textBox_pass";
            textBox_pass.PasswordChar = '*';
            textBox_pass.PlaceholderText = "  Enter password . . . ";
            textBox_pass.Size = new Size(341, 23);
            textBox_pass.TabIndex = 3;
            // 
            // textBox_username
            // 
            textBox_username.AcceptsReturn = true;
            textBox_username.BackColor = Color.FromArgb(50, 50, 50);
            textBox_username.ForeColor = Color.WhiteSmoke;
            textBox_username.Location = new Point(71, 103);
            textBox_username.Margin = new Padding(3, 2, 3, 2);
            textBox_username.Name = "textBox_username";
            textBox_username.PlaceholderText = "  Enter username . . . ";
            textBox_username.Size = new Size(341, 23);
            textBox_username.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.WhiteSmoke;
            label2.Location = new Point(104, 155);
            label2.Name = "label2";
            label2.Size = new Size(79, 21);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(104, 70);
            label1.Name = "label1";
            label1.Size = new Size(83, 21);
            label1.TabIndex = 0;
            label1.Text = "Username";
            // 
            // pictureBoxlogo
            // 
            pictureBoxlogo.Image = Properties.Resources.MainLogo_removebg_preview;
            pictureBoxlogo.Location = new Point(304, 10);
            pictureBoxlogo.Margin = new Padding(3, 2, 3, 2);
            pictureBoxlogo.Name = "pictureBoxlogo";
            pictureBoxlogo.Size = new Size(181, 94);
            pictureBoxlogo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxlogo.TabIndex = 1;
            pictureBoxlogo.TabStop = false;
            // 
            // labellogin
            // 
            labellogin.AutoSize = true;
            labellogin.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            labellogin.ForeColor = Color.WhiteSmoke;
            labellogin.Location = new Point(0, 47);
            labellogin.Name = "labellogin";
            labellogin.Size = new Size(152, 51);
            labellogin.TabIndex = 0;
            labellogin.Text = "  Log in";
            labellogin.Click += labellogin_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBoxlogo);
            panel1.Controls.Add(labellogin);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(488, 94);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(50, 50, 50);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Login";
            Size = new Size(488, 448);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_user).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_key).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxlogo).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private Label label2;
        private Label label1;
        private TextBox textBox_username;
        private TextBox textBox_pass;
        private Button button_login;
        private PictureBox pictureBox_user;
        private PictureBox pictureBox_key;
        private Label label3;
        private PictureBox pictureBoxlogo;
        private Label labellogin;
        private Panel panel1;
    }
}

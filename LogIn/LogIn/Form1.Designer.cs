namespace LogIn
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            LoginButton = new Button();
            UsernameTextbox = new TextBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            Logo = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            exitButton = new PictureBox();
            minimizeButton = new PictureBox();
            PasswordTextBox = new TextBox();
            Clear = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Logo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)exitButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)minimizeButton).BeginInit();
            SuspendLayout();
            // 
            // LoginButton
            // 
            LoginButton.AllowDrop = true;
            LoginButton.BackColor = Color.FromArgb(20, 255, 236);
            LoginButton.FlatAppearance.BorderColor = Color.FromArgb(20, 255, 236);
            LoginButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(21, 21, 21);
            LoginButton.FlatStyle = FlatStyle.Flat;
            LoginButton.Font = new Font("Candara", 15F, FontStyle.Bold, GraphicsUnit.Point);
            LoginButton.ForeColor = Color.FromArgb(90, 90, 90);
            LoginButton.Location = new Point(146, 372);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(115, 38);
            LoginButton.TabIndex = 0;
            LoginButton.Text = "Log In";
            LoginButton.UseVisualStyleBackColor = true;
            LoginButton.Click += LoginButton_Click;
            // 
            // UsernameTextbox
            // 
            UsernameTextbox.BackColor = Color.FromArgb(21, 21, 21);
            UsernameTextbox.BorderStyle = BorderStyle.None;
            UsernameTextbox.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            UsernameTextbox.ForeColor = Color.FromArgb(20, 255, 236);
            UsernameTextbox.Location = new Point(111, 234);
            UsernameTextbox.Name = "UsernameTextbox";
            UsernameTextbox.PlaceholderText = "Enter Username";
            UsernameTextbox.Size = new Size(150, 19);
            UsernameTextbox.TabIndex = 2;
            UsernameTextbox.TextChanged += UsernameTextbox_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(70, 230);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(30, 30);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(70, 291);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(30, 30);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // Logo
            // 
            Logo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Logo.BackColor = Color.FromArgb(21, 21, 21);
            Logo.Image = (Image)resources.GetObject("Logo.Image");
            Logo.Location = new Point(86, 51);
            Logo.Name = "Logo";
            Logo.Size = new Size(160, 160);
            Logo.SizeMode = PictureBoxSizeMode.StretchImage;
            Logo.TabIndex = 8;
            Logo.TabStop = false;
            Logo.Click += Logo_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.FromArgb(21, 21, 21);
            pictureBox3.Location = new Point(0, 29);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(328, 427);
            pictureBox3.TabIndex = 9;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Location = new Point(74, 266);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(187, 2);
            pictureBox4.TabIndex = 10;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.Location = new Point(74, 327);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(187, 2);
            pictureBox5.TabIndex = 11;
            pictureBox5.TabStop = false;
            // 
            // exitButton
            // 
            exitButton.Image = (Image)resources.GetObject("exitButton.Image");
            exitButton.Location = new Point(299, 2);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(25, 25);
            exitButton.SizeMode = PictureBoxSizeMode.StretchImage;
            exitButton.TabIndex = 12;
            exitButton.TabStop = false;
            exitButton.Click += pictureBox6_Click;
            // 
            // minimizeButton
            // 
            minimizeButton.Image = (Image)resources.GetObject("minimizeButton.Image");
            minimizeButton.Location = new Point(269, 2);
            minimizeButton.Name = "minimizeButton";
            minimizeButton.Size = new Size(25, 25);
            minimizeButton.SizeMode = PictureBoxSizeMode.StretchImage;
            minimizeButton.TabIndex = 13;
            minimizeButton.TabStop = false;
            minimizeButton.Click += minimizeButton_Click;
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.BackColor = Color.FromArgb(21, 21, 21);
            PasswordTextBox.BorderStyle = BorderStyle.None;
            PasswordTextBox.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            PasswordTextBox.ForeColor = Color.FromArgb(20, 255, 236);
            PasswordTextBox.Location = new Point(111, 298);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.PasswordChar = '●';
            PasswordTextBox.PlaceholderText = "Enter Password";
            PasswordTextBox.Size = new Size(150, 19);
            PasswordTextBox.TabIndex = 15;
            PasswordTextBox.TextChanged += PasswordTextBox_TextChanged;
            // 
            // Clear
            // 
            Clear.BackColor = Color.FromArgb(21, 21, 21);
            Clear.FlatAppearance.BorderColor = Color.FromArgb(20, 255, 236);
            Clear.FlatAppearance.MouseOverBackColor = Color.FromArgb(20, 255, 236);
            Clear.FlatStyle = FlatStyle.Flat;
            Clear.Font = new Font("Candara", 15F, FontStyle.Bold, GraphicsUnit.Point);
            Clear.ForeColor = Color.FromArgb(90, 90, 90);
            Clear.Location = new Point(70, 372);
            Clear.Name = "Clear";
            Clear.Size = new Size(70, 38);
            Clear.TabIndex = 16;
            Clear.Text = "Clear";
            Clear.UseVisualStyleBackColor = false;
            Clear.Click += Clear_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(20, 255, 236);
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(326, 460);
            Controls.Add(Clear);
            Controls.Add(PasswordTextBox);
            Controls.Add(minimizeButton);
            Controls.Add(exitButton);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(Logo);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(UsernameTextbox);
            Controls.Add(LoginButton);
            Controls.Add(pictureBox3);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LogInForm";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)Logo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)exitButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)minimizeButton).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button LoginButton;
        private TextBox UsernameTextbox;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox Logo;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox exitButton;
        private PictureBox minimizeButton;
        private TextBox PasswordTextBox;
        private Button Clear;
    }
}
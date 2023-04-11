namespace CSAid_MainWinFormsApp.View
{
    partial class LoginView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginView));
            this.leftPanel = new Panel();
            this.linkLabellogin = new LinkLabel();
            this.linkreg = new LinkLabel();
            this.noacc = new Label();
            this.tostart = new Label();
            this.wcbacklabel = new Label();
            this.vsulogo = new PictureBox();
            this.logo = new PictureBox();
            this.bg = new PictureBox();
            this.login1 = new Login();
            this.register1 = new Register();
            this.leftPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)this.vsulogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.logo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.bg).BeginInit();
            SuspendLayout();
            // 
            // leftPanel
            // 
            this.leftPanel.Controls.Add(this.linkLabellogin);
            this.leftPanel.Controls.Add(this.linkreg);
            this.leftPanel.Controls.Add(this.noacc);
            this.leftPanel.Controls.Add(this.tostart);
            this.leftPanel.Controls.Add(this.wcbacklabel);
            this.leftPanel.Controls.Add(this.vsulogo);
            this.leftPanel.Controls.Add(this.logo);
            this.leftPanel.Controls.Add(this.bg);
            this.leftPanel.Dock = DockStyle.Left;
            this.leftPanel.Location = new Point(0, 0);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new Size(607, 598);
            this.leftPanel.TabIndex = 0;
            // 
            // linkLabellogin
            // 
            this.linkLabellogin.AutoSize = true;
            this.linkLabellogin.BackColor = Color.FromArgb(250, 250, 250);
            this.linkLabellogin.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            this.linkLabellogin.LinkColor = Color.Black;
            this.linkLabellogin.Location = new Point(225, 531);
            this.linkLabellogin.Name = "linkLabellogin";
            this.linkLabellogin.Size = new Size(166, 25);
            this.linkLabellogin.TabIndex = 4;
            this.linkLabellogin.TabStop = true;
            this.linkLabellogin.Text = "Back to login page";
            this.linkLabellogin.LinkClicked += linkLabellogin_LinkClicked;
            // 
            // linkreg
            // 
            this.linkreg.AutoSize = true;
            this.linkreg.BackColor = Color.FromArgb(250, 250, 250);
            this.linkreg.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            this.linkreg.LinkColor = Color.Black;
            this.linkreg.Location = new Point(301, 495);
            this.linkreg.Name = "linkreg";
            this.linkreg.Size = new Size(125, 25);
            this.linkreg.TabIndex = 0;
            this.linkreg.TabStop = true;
            this.linkreg.Text = "Register now.";
            this.linkreg.LinkClicked += linkreg_LinkClicked;
            // 
            // noacc
            // 
            this.noacc.AutoSize = true;
            this.noacc.BackColor = Color.FromArgb(250, 250, 250);
            this.noacc.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            this.noacc.Location = new Point(193, 495);
            this.noacc.Name = "noacc";
            this.noacc.Size = new Size(114, 25);
            this.noacc.TabIndex = 3;
            this.noacc.Text = "No account?";
            // 
            // tostart
            // 
            this.tostart.AutoSize = true;
            this.tostart.BackColor = Color.FromArgb(250, 250, 250);
            this.tostart.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            this.tostart.Location = new Point(61, 93);
            this.tostart.Name = "tostart";
            this.tostart.Size = new Size(330, 25);
            this.tostart.TabIndex = 2;
            this.tostart.Text = "To start, please log in to your account.";
            // 
            // wcbacklabel
            // 
            this.wcbacklabel.AutoSize = true;
            this.wcbacklabel.BackColor = Color.FromArgb(250, 250, 250);
            this.wcbacklabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            this.wcbacklabel.Location = new Point(56, 36);
            this.wcbacklabel.Name = "wcbacklabel";
            this.wcbacklabel.Size = new Size(231, 82);
            this.wcbacklabel.TabIndex = 0;
            this.wcbacklabel.Text = "Welcome Back!\r\n\r\n";
            this.wcbacklabel.TextAlign = ContentAlignment.TopCenter;
            this.wcbacklabel.Click += label1_Click_1;
            // 
            // vsulogo
            // 
            this.vsulogo.BackColor = Color.FromArgb(250, 250, 250);
            this.vsulogo.BackgroundImage = Properties.Resources.VSU_Seal_2022;
            this.vsulogo.BackgroundImageLayout = ImageLayout.Zoom;
            this.vsulogo.Location = new Point(496, 495);
            this.vsulogo.Name = "vsulogo";
            this.vsulogo.Size = new Size(99, 91);
            this.vsulogo.TabIndex = 1;
            this.vsulogo.TabStop = false;
            // 
            // logo
            // 
            this.logo.BackColor = Color.FromArgb(250, 250, 250);
            this.logo.BackgroundImage = Properties.Resources.MainLogo_removebg_preview;
            this.logo.BackgroundImageLayout = ImageLayout.Stretch;
            this.logo.Location = new Point(12, 495);
            this.logo.Name = "logo";
            this.logo.Size = new Size(99, 91);
            this.logo.TabIndex = 0;
            this.logo.TabStop = false;
            // 
            // bg
            // 
            this.bg.BackColor = Color.FromArgb(250, 250, 250);
            this.bg.BackgroundImage = Properties.Resources._19834;
            this.bg.BackgroundImageLayout = ImageLayout.Zoom;
            this.bg.Location = new Point(0, 0);
            this.bg.Name = "bg";
            this.bg.Size = new Size(607, 598);
            this.bg.TabIndex = 0;
            this.bg.TabStop = false;
            this.bg.Click += bg_Click;
            // 
            // login1
            // 
            this.login1.BackColor = Color.FromArgb(50, 50, 50);
            this.login1.Location = new Point(613, 0);
            this.login1.Name = "login1";
            this.login1.Size = new Size(558, 598);
            this.login1.TabIndex = 1;
            this.login1.Load += login1_Load;
            // 
            // register1
            // 
            this.register1.BackColor = Color.FromArgb(50, 50, 50);
            this.register1.Location = new Point(613, 0);
            this.register1.Name = "register1";
            this.register1.Size = new Size(558, 598);
            this.register1.TabIndex = 2;
            // 
            // LoginView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(50, 50, 50);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1174, 598);
            Controls.Add(this.login1);
            Controls.Add(this.leftPanel);
            Controls.Add(this.register1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            HelpButton = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "LoginView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CSAid Hospital Management System";
            Load += LoginView_Load;
            this.leftPanel.ResumeLayout(false);
            this.leftPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)this.vsulogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.logo).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.bg).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel leftPanel;
        private PictureBox bg;
        private PictureBox logo;
        private PictureBox vsulogo;
        private Label wcbacklabel;
        private Label noacc;
        private Label tostart;
        private LinkLabel linkreg;
        private Login login1;
        private Register register1;
        private LinkLabel linkLabellogin;
    }
}
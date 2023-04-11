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
            leftPanel = new Panel();
            tostart = new Label();
            wcbacklabel = new Label();
            vsulogo = new PictureBox();
            logo = new PictureBox();
            bg = new PictureBox();
            login1 = new Login();
            leftPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)vsulogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bg).BeginInit();
            SuspendLayout();
            // 
            // leftPanel
            // 
            leftPanel.Controls.Add(tostart);
            leftPanel.Controls.Add(wcbacklabel);
            leftPanel.Controls.Add(vsulogo);
            leftPanel.Controls.Add(logo);
            leftPanel.Controls.Add(bg);
            leftPanel.Dock = DockStyle.Left;
            leftPanel.Location = new Point(0, 0);
            leftPanel.Name = "leftPanel";
            leftPanel.Size = new Size(607, 598);
            leftPanel.TabIndex = 0;
            // 
            // tostart
            // 
            tostart.AutoSize = true;
            tostart.BackColor = Color.FromArgb(250, 250, 250);
            tostart.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            tostart.Location = new Point(61, 93);
            tostart.Name = "tostart";
            tostart.Size = new Size(330, 25);
            tostart.TabIndex = 2;
            tostart.Text = "To start, please log in to your account.";
            // 
            // wcbacklabel
            // 
            wcbacklabel.AutoSize = true;
            wcbacklabel.BackColor = Color.FromArgb(250, 250, 250);
            wcbacklabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            wcbacklabel.Location = new Point(56, 36);
            wcbacklabel.Name = "wcbacklabel";
            wcbacklabel.Size = new Size(231, 82);
            wcbacklabel.TabIndex = 0;
            wcbacklabel.Text = "Welcome Back!\r\n\r\n";
            wcbacklabel.TextAlign = ContentAlignment.TopCenter;
            wcbacklabel.Click += label1_Click_1;
            // 
            // vsulogo
            // 
            vsulogo.BackColor = Color.FromArgb(250, 250, 250);
            vsulogo.BackgroundImage = Properties.Resources.VSU_Seal_2022;
            vsulogo.BackgroundImageLayout = ImageLayout.Zoom;
            vsulogo.Location = new Point(496, 495);
            vsulogo.Name = "vsulogo";
            vsulogo.Size = new Size(99, 91);
            vsulogo.TabIndex = 1;
            vsulogo.TabStop = false;
            // 
            // logo
            // 
            logo.BackColor = Color.FromArgb(250, 250, 250);
            logo.BackgroundImage = Properties.Resources.MainLogo_removebg_preview;
            logo.BackgroundImageLayout = ImageLayout.Stretch;
            logo.Location = new Point(12, 495);
            logo.Name = "logo";
            logo.Size = new Size(99, 91);
            logo.TabIndex = 0;
            logo.TabStop = false;
            // 
            // bg
            // 
            bg.BackColor = Color.FromArgb(250, 250, 250);
            bg.BackgroundImage = Properties.Resources._19834;
            bg.BackgroundImageLayout = ImageLayout.Zoom;
            bg.Location = new Point(0, 0);
            bg.Name = "bg";
            bg.Size = new Size(607, 598);
            bg.TabIndex = 0;
            bg.TabStop = false;
            bg.Click += bg_Click;
            // 
            // login1
            // 
            login1.BackColor = Color.FromArgb(50, 50, 50);
            login1.Location = new Point(613, 0);
            login1.Name = "login1";
            login1.Size = new Size(558, 598);
            login1.TabIndex = 1;
            login1.Load += login1_Load;
            // 
            // LoginView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(50, 50, 50);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1174, 598);
            Controls.Add(login1);
            Controls.Add(leftPanel);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            HelpButton = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "LoginView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CSAid Hospital Management System";
            Load += LoginView_Load;
            leftPanel.ResumeLayout(false);
            leftPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)vsulogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            ((System.ComponentModel.ISupportInitialize)bg).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel leftPanel;
        private PictureBox bg;
        private PictureBox logo;
        private PictureBox vsulogo;
        private Label wcbacklabel;
        private Label tostart;
        private Login login1;
    }
}
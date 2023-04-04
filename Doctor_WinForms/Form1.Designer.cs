namespace Doctor_WinForms
{
    partial class mainForm
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
            leftPanel1 = new Panel();
            iconButton4 = new FontAwesome.Sharp.IconButton();
            iconButton3 = new FontAwesome.Sharp.IconButton();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            topLeftPanel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            topPanel1 = new Panel();
            iconButton5 = new FontAwesome.Sharp.IconButton();
            searchBar = new TextBox();
            home1 = new Home();
            settings1 = new Settings();
            about1 = new About();
            leftPanel1.SuspendLayout();
            topLeftPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            topPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // leftPanel1
            // 
            leftPanel1.BackColor = Color.FromArgb(50, 50, 50);
            leftPanel1.Controls.Add(iconButton4);
            leftPanel1.Controls.Add(iconButton3);
            leftPanel1.Controls.Add(iconButton2);
            leftPanel1.Controls.Add(iconButton1);
            leftPanel1.Controls.Add(topLeftPanel1);
            leftPanel1.Dock = DockStyle.Left;
            leftPanel1.Location = new Point(0, 0);
            leftPanel1.Margin = new Padding(3, 4, 3, 4);
            leftPanel1.Name = "leftPanel1";
            leftPanel1.Size = new Size(195, 714);
            leftPanel1.TabIndex = 0;
            leftPanel1.Paint += leftPanel1_Paint;
            // 
            // iconButton4
            // 
            iconButton4.Dock = DockStyle.Top;
            iconButton4.FlatAppearance.BorderSize = 0;
            iconButton4.FlatStyle = FlatStyle.Flat;
            iconButton4.Font = new Font("Trebuchet MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            iconButton4.ForeColor = Color.White;
            iconButton4.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            iconButton4.IconColor = Color.FromArgb(20, 255, 236);
            iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton4.IconSize = 40;
            iconButton4.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton4.Location = new Point(0, 342);
            iconButton4.Margin = new Padding(3, 4, 3, 4);
            iconButton4.Name = "iconButton4";
            iconButton4.Padding = new Padding(11, 0, 23, 0);
            iconButton4.Size = new Size(195, 71);
            iconButton4.TabIndex = 4;
            iconButton4.Text = "  Exit";
            iconButton4.TextAlign = ContentAlignment.MiddleLeft;
            iconButton4.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton4.UseVisualStyleBackColor = true;
            iconButton4.Click += iconButton4_Click;
            // 
            // iconButton3
            // 
            iconButton3.Dock = DockStyle.Top;
            iconButton3.FlatAppearance.BorderSize = 0;
            iconButton3.FlatStyle = FlatStyle.Flat;
            iconButton3.Font = new Font("Trebuchet MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            iconButton3.ForeColor = Color.White;
            iconButton3.IconChar = FontAwesome.Sharp.IconChar.Info;
            iconButton3.IconColor = Color.FromArgb(20, 255, 236);
            iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton3.IconSize = 40;
            iconButton3.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton3.Location = new Point(0, 271);
            iconButton3.Margin = new Padding(3, 4, 3, 4);
            iconButton3.Name = "iconButton3";
            iconButton3.Padding = new Padding(11, 0, 23, 0);
            iconButton3.Size = new Size(195, 71);
            iconButton3.TabIndex = 3;
            iconButton3.Text = "  About";
            iconButton3.TextAlign = ContentAlignment.MiddleLeft;
            iconButton3.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton3.UseVisualStyleBackColor = true;
            iconButton3.Click += iconButton3_Click;
            // 
            // iconButton2
            // 
            iconButton2.Dock = DockStyle.Top;
            iconButton2.FlatAppearance.BorderSize = 0;
            iconButton2.FlatStyle = FlatStyle.Flat;
            iconButton2.Font = new Font("Trebuchet MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            iconButton2.ForeColor = Color.White;
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.Gear;
            iconButton2.IconColor = Color.FromArgb(20, 255, 236);
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton2.IconSize = 40;
            iconButton2.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton2.Location = new Point(0, 200);
            iconButton2.Margin = new Padding(3, 4, 3, 4);
            iconButton2.Name = "iconButton2";
            iconButton2.Padding = new Padding(11, 0, 23, 0);
            iconButton2.Size = new Size(195, 71);
            iconButton2.TabIndex = 2;
            iconButton2.Text = "  Settings";
            iconButton2.TextAlign = ContentAlignment.MiddleLeft;
            iconButton2.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton2.UseVisualStyleBackColor = true;
            iconButton2.Click += iconButton2_Click_1;
            // 
            // iconButton1
            // 
            iconButton1.Dock = DockStyle.Top;
            iconButton1.FlatAppearance.BorderSize = 0;
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.Font = new Font("Trebuchet MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            iconButton1.ForeColor = Color.White;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.HouseChimneyMedical;
            iconButton1.IconColor = Color.FromArgb(20, 255, 236);
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 40;
            iconButton1.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton1.Location = new Point(0, 129);
            iconButton1.Margin = new Padding(3, 4, 3, 4);
            iconButton1.Name = "iconButton1";
            iconButton1.Padding = new Padding(11, 0, 23, 0);
            iconButton1.Size = new Size(195, 71);
            iconButton1.TabIndex = 1;
            iconButton1.Text = "  Home";
            iconButton1.TextAlign = ContentAlignment.MiddleLeft;
            iconButton1.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton1.UseVisualStyleBackColor = true;
            iconButton1.Click += iconButton1_Click;
            // 
            // topLeftPanel1
            // 
            topLeftPanel1.BackColor = Color.Black;
            topLeftPanel1.BorderStyle = BorderStyle.FixedSingle;
            topLeftPanel1.Controls.Add(label1);
            topLeftPanel1.Controls.Add(pictureBox1);
            topLeftPanel1.Dock = DockStyle.Top;
            topLeftPanel1.Location = new Point(0, 0);
            topLeftPanel1.Margin = new Padding(3, 4, 3, 4);
            topLeftPanel1.Name = "topLeftPanel1";
            topLeftPanel1.Size = new Size(195, 129);
            topLeftPanel1.TabIndex = 0;
            topLeftPanel1.Paint += topLeftPanel1_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(20, 255, 236);
            label1.Location = new Point(-1, 105);
            label1.Name = "label1";
            label1.Size = new Size(196, 18);
            label1.TabIndex = 1;
            label1.Text = "Hospital Management System";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.MainLogo_removebg_preview;
            pictureBox1.Location = new Point(9, 1);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(174, 112);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // topPanel1
            // 
            topPanel1.BackColor = Color.FromArgb(13, 115, 119);
            topPanel1.Controls.Add(iconButton5);
            topPanel1.Controls.Add(searchBar);
            topPanel1.Dock = DockStyle.Top;
            topPanel1.Location = new Point(195, 0);
            topPanel1.Margin = new Padding(3, 4, 3, 4);
            topPanel1.Name = "topPanel1";
            topPanel1.Size = new Size(1085, 85);
            topPanel1.TabIndex = 1;
            topPanel1.Paint += topPanel1_Paint;
            // 
            // iconButton5
            // 
            iconButton5.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            iconButton5.IconColor = Color.Black;
            iconButton5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton5.IconSize = 30;
            iconButton5.Location = new Point(330, 15);
            iconButton5.Margin = new Padding(3, 4, 3, 4);
            iconButton5.Name = "iconButton5";
            iconButton5.Size = new Size(69, 51);
            iconButton5.TabIndex = 1;
            iconButton5.UseVisualStyleBackColor = true;
            // 
            // searchBar
            // 
            searchBar.BackColor = Color.White;
            searchBar.Font = new Font("Trebuchet MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            searchBar.Location = new Point(24, 27);
            searchBar.Margin = new Padding(3, 4, 3, 4);
            searchBar.Name = "searchBar";
            searchBar.PlaceholderText = "Search...";
            searchBar.Size = new Size(299, 29);
            searchBar.TabIndex = 0;
            // 
            // home1
            // 
            home1.BackColor = Color.FromArgb(33, 33, 33);
            home1.Dock = DockStyle.Fill;
            home1.Location = new Point(195, 85);
            home1.Margin = new Padding(3, 5, 3, 5);
            home1.Name = "home1";
            home1.Size = new Size(1085, 629);
            home1.TabIndex = 2;
            // 
            // settings1
            // 
            settings1.BackColor = Color.FromArgb(33, 33, 33);
            settings1.Dock = DockStyle.Fill;
            settings1.ForeColor = Color.White;
            settings1.Location = new Point(195, 85);
            settings1.Margin = new Padding(3, 5, 3, 5);
            settings1.Name = "settings1";
            settings1.Size = new Size(1085, 629);
            settings1.TabIndex = 3;
            // 
            // about1
            // 
            about1.BackColor = Color.FromArgb(33, 33, 33);
            about1.Dock = DockStyle.Fill;
            about1.Location = new Point(195, 85);
            about1.Margin = new Padding(3, 5, 3, 5);
            about1.Name = "about1";
            about1.Size = new Size(1085, 629);
            about1.TabIndex = 4;
            // 
            // mainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(33, 33, 33);
            ClientSize = new Size(1280, 714);
            Controls.Add(about1);
            Controls.Add(settings1);
            Controls.Add(home1);
            Controls.Add(topPanel1);
            Controls.Add(leftPanel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "mainForm";
            Text = "CSAid Hospital Management System - Doctor";
            Load += mainForm_Load;
            leftPanel1.ResumeLayout(false);
            topLeftPanel1.ResumeLayout(false);
            topLeftPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            topPanel1.ResumeLayout(false);
            topPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel leftPanel1;
        private Panel topLeftPanel1;
        private PictureBox pictureBox1;
        private Label label1;
        private Panel topPanel1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton4;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton iconButton2;
        private Home home1;
        private FontAwesome.Sharp.IconButton iconButton5;
        private TextBox searchBar;
        private Settings settings1;
        private About about1;
    }
}
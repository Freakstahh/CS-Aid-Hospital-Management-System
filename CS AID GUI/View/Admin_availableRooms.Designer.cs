namespace CSAid_MainWinFormsApp.View
{
    partial class Admin_availableRooms
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
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            textBox_admin_search = new TextBox();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            label1 = new Label();
            button2 = new Button();
            panel2 = new Panel();
            textBox7 = new TextBox();
            label11 = new Label();
            textBox6 = new TextBox();
            label10 = new Label();
            comboBox1 = new ComboBox();
            label13 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textBox_admin_search);
            panel1.Controls.Add(dataGridView1);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(865, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1037, 918);
            panel1.TabIndex = 9;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(50, 50, 50);
            pictureBox1.Image = Properties.Resources.search;
            pictureBox1.Location = new Point(902, 27);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(60, 35);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.WhiteSmoke;
            label2.Location = new Point(90, 32);
            label2.Name = "label2";
            label2.Size = new Size(146, 23);
            label2.TabIndex = 5;
            label2.Text = "Search for Rooms";
            // 
            // textBox_admin_search
            // 
            textBox_admin_search.BackColor = Color.FromArgb(50, 50, 50);
            textBox_admin_search.ForeColor = Color.WhiteSmoke;
            textBox_admin_search.Location = new Point(242, 31);
            textBox_admin_search.Name = "textBox_admin_search";
            textBox_admin_search.Size = new Size(659, 27);
            textBox_admin_search.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(40, 87);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(954, 788);
            dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.WhiteSmoke;
            button1.Location = new Point(270, 501);
            button1.Name = "button1";
            button1.Size = new Size(133, 51);
            button1.TabIndex = 2;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(36, 31);
            label1.Name = "label1";
            label1.Size = new Size(462, 62);
            label1.TabIndex = 0;
            label1.Text = "Room Management";
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.WhiteSmoke;
            button2.Location = new Point(467, 501);
            button2.Name = "button2";
            button2.Size = new Size(133, 51);
            button2.TabIndex = 3;
            button2.Text = "Update";
            button2.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(comboBox1);
            panel2.Controls.Add(label13);
            panel2.Controls.Add(textBox7);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(textBox6);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(button1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(865, 918);
            panel2.TabIndex = 10;
            // 
            // textBox7
            // 
            textBox7.BackColor = Color.FromArgb(50, 50, 50);
            textBox7.ForeColor = Color.WhiteSmoke;
            textBox7.Location = new Point(491, 214);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(247, 27);
            textBox7.TabIndex = 26;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.WhiteSmoke;
            label11.Location = new Point(467, 180);
            label11.Name = "label11";
            label11.Size = new Size(124, 23);
            label11.TabIndex = 25;
            label11.Text = "Room Number";
            // 
            // textBox6
            // 
            textBox6.BackColor = Color.FromArgb(50, 50, 50);
            textBox6.ForeColor = Color.WhiteSmoke;
            textBox6.Location = new Point(142, 214);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(247, 27);
            textBox6.TabIndex = 24;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.WhiteSmoke;
            label10.Location = new Point(118, 180);
            label10.Name = "label10";
            label10.Size = new Size(117, 23);
            label10.TabIndex = 23;
            label10.Text = "Floor Number";
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.FromArgb(50, 50, 50);
            comboBox1.ForeColor = Color.WhiteSmoke;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Available", "Not Available" });
            comboBox1.Location = new Point(142, 330);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(356, 28);
            comboBox1.TabIndex = 30;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label13.ForeColor = Color.WhiteSmoke;
            label13.Location = new Point(118, 301);
            label13.Name = "label13";
            label13.Size = new Size(144, 23);
            label13.TabIndex = 29;
            label13.Text = "Room Availability";
            // 
            // Admin_availableRooms
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(33, 33, 33);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Admin_availableRooms";
            Size = new Size(1902, 918);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label2;
        private TextBox textBox_admin_search;
        private DataGridView dataGridView1;
        private Button button1;
        private Label label1;
        private Button button2;
        private Panel panel2;
        private TextBox textBox7;
        private Label label11;
        private TextBox textBox6;
        private Label label10;
        private ComboBox comboBox1;
        private Label label13;
    }
}

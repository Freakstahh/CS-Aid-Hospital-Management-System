namespace CSAid_MainWinFormsApp.View
{
    partial class Admin_addPatient
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
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            textBox_admin_search = new TextBox();
            dataGridView1 = new DataGridView();
            panel2 = new Panel();
            dateTimePicker2 = new DateTimePicker();
            label12 = new Label();
            textBox7 = new TextBox();
            label11 = new Label();
            textBox6 = new TextBox();
            label10 = new Label();
            textBox5 = new TextBox();
            label9 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label8 = new Label();
            label7 = new Label();
            textBox4 = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label3 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(36, 31);
            label1.Name = "label1";
            label1.Size = new Size(286, 62);
            label1.TabIndex = 0;
            label1.Text = "Add Patient";
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.WhiteSmoke;
            button1.Location = new Point(142, 796);
            button1.Name = "button1";
            button1.Size = new Size(133, 51);
            button1.TabIndex = 2;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.WhiteSmoke;
            button2.Location = new Point(339, 796);
            button2.Name = "button2";
            button2.Size = new Size(133, 51);
            button2.TabIndex = 3;
            button2.Text = "Update";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.WhiteSmoke;
            button3.Location = new Point(538, 796);
            button3.Name = "button3";
            button3.Size = new Size(133, 51);
            button3.TabIndex = 4;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = true;
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
            panel1.TabIndex = 5;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(50, 50, 50);
            pictureBox1.Image = Properties.Resources.search;
            pictureBox1.Location = new Point(921, 27);
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
            label2.Location = new Point(87, 32);
            label2.Name = "label2";
            label2.Size = new Size(147, 23);
            label2.TabIndex = 5;
            label2.Text = "Search for Patient";
            // 
            // textBox_admin_search
            // 
            textBox_admin_search.BackColor = Color.FromArgb(50, 50, 50);
            textBox_admin_search.ForeColor = Color.WhiteSmoke;
            textBox_admin_search.Location = new Point(240, 31);
            textBox_admin_search.Name = "textBox_admin_search";
            textBox_admin_search.Size = new Size(680, 27);
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
            // panel2
            // 
            panel2.Controls.Add(dateTimePicker2);
            panel2.Controls.Add(label12);
            panel2.Controls.Add(textBox7);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(textBox6);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(textBox5);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(dateTimePicker1);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(textBox4);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(textBox3);
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(button3);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(865, 918);
            panel2.TabIndex = 6;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(75, 642);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(448, 27);
            dateTimePicker2.TabIndex = 24;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label12.ForeColor = Color.WhiteSmoke;
            label12.Location = new Point(59, 607);
            label12.Name = "label12";
            label12.Size = new Size(129, 23);
            label12.TabIndex = 23;
            label12.Text = "Admission Date";
            // 
            // textBox7
            // 
            textBox7.BackColor = Color.FromArgb(50, 50, 50);
            textBox7.ForeColor = Color.WhiteSmoke;
            textBox7.Location = new Point(424, 548);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(247, 27);
            textBox7.TabIndex = 22;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.WhiteSmoke;
            label11.Location = new Point(400, 514);
            label11.Name = "label11";
            label11.Size = new Size(124, 23);
            label11.TabIndex = 21;
            label11.Text = "Room Number";
            // 
            // textBox6
            // 
            textBox6.BackColor = Color.FromArgb(50, 50, 50);
            textBox6.ForeColor = Color.WhiteSmoke;
            textBox6.Location = new Point(75, 548);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(247, 27);
            textBox6.TabIndex = 20;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.WhiteSmoke;
            label10.Location = new Point(51, 514);
            label10.Name = "label10";
            label10.Size = new Size(117, 23);
            label10.TabIndex = 19;
            label10.Text = "Floor Number";
            // 
            // textBox5
            // 
            textBox5.BackColor = Color.FromArgb(50, 50, 50);
            textBox5.ForeColor = Color.WhiteSmoke;
            textBox5.Location = new Point(75, 461);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(247, 27);
            textBox5.TabIndex = 18;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.WhiteSmoke;
            label9.Location = new Point(51, 427);
            label9.Name = "label9";
            label9.Size = new Size(86, 23);
            label9.TabIndex = 17;
            label9.Text = "Patient ID";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(75, 268);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(448, 27);
            dateTimePicker1.TabIndex = 16;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.WhiteSmoke;
            label8.Location = new Point(47, 233);
            label8.Name = "label8";
            label8.Size = new Size(87, 23);
            label8.TabIndex = 15;
            label8.Text = "Birth Date";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.WhiteSmoke;
            label7.Location = new Point(47, 329);
            label7.Name = "label7";
            label7.Size = new Size(83, 23);
            label7.TabIndex = 14;
            label7.Text = "Diagnosis";
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.FromArgb(50, 50, 50);
            textBox4.ForeColor = Color.WhiteSmoke;
            textBox4.Location = new Point(75, 363);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(533, 27);
            textBox4.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.WhiteSmoke;
            label6.Location = new Point(538, 151);
            label6.Name = "label6";
            label6.Size = new Size(70, 17);
            label6.TabIndex = 12;
            label6.Text = "Last Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.WhiteSmoke;
            label5.Location = new Point(339, 151);
            label5.Name = "label5";
            label5.Size = new Size(88, 17);
            label5.TabIndex = 11;
            label5.Text = "Middle Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.WhiteSmoke;
            label4.Location = new Point(75, 151);
            label4.Name = "label4";
            label4.Size = new Size(71, 17);
            label4.TabIndex = 10;
            label4.Text = "First Name";
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.FromArgb(50, 50, 50);
            textBox3.ForeColor = Color.WhiteSmoke;
            textBox3.Location = new Point(538, 171);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(247, 27);
            textBox3.TabIndex = 9;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(50, 50, 50);
            textBox2.ForeColor = Color.WhiteSmoke;
            textBox2.Location = new Point(339, 171);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(184, 27);
            textBox2.TabIndex = 8;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(50, 50, 50);
            textBox1.ForeColor = Color.WhiteSmoke;
            textBox1.Location = new Point(75, 171);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(247, 27);
            textBox1.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.WhiteSmoke;
            label3.Location = new Point(47, 118);
            label3.Name = "label3";
            label3.Size = new Size(88, 23);
            label3.TabIndex = 6;
            label3.Text = "Full Name";
            // 
            // Admin_addPatient
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(33, 33, 33);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Admin_addPatient";
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

        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Panel panel1;
        private Panel panel2;
        private DataGridView dataGridView1;
        private PictureBox pictureBox1;
        private Label label2;
        private TextBox textBox_admin_search;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label3;
        private DateTimePicker dateTimePicker2;
        private Label label12;
        private TextBox textBox7;
        private Label label11;
        private TextBox textBox6;
        private Label label10;
        private TextBox textBox5;
        private Label label9;
        private DateTimePicker dateTimePicker1;
        private Label label8;
        private Label label7;
        private TextBox textBox4;
        private Label label6;
        private Label label5;
        private Label label4;
    }
}

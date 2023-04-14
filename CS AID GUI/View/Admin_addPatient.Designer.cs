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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            Column1 = new DataGridViewTextBoxColumn();
            dltBtn = new Button();
            addBtn = new Button();
            label1 = new Label();
            upBtn = new Button();
            label3 = new Label();
            firstName = new TextBox();
            midName = new TextBox();
            lastName = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            diag = new TextBox();
            label7 = new Label();
            label8 = new Label();
            birthDatePicker = new DateTimePicker();
            label9 = new Label();
            patID = new TextBox();
            label10 = new Label();
            floorNum = new TextBox();
            label11 = new Label();
            roomNum = new TextBox();
            label12 = new Label();
            admitDate = new DateTimePicker();
            panel2 = new Panel();
            textBox_admin_search = new TextBox();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            patDataListBg = new GroupBox();
            patDataList = new DataGridView();
            patientBindingSource = new BindingSource(components);
            birthdateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            admitDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            roomNumberDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            floorNumberDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            patientIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            diagnosisDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            middleNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            firstNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            lastNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            patDataListBg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)patDataList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)patientBindingSource).BeginInit();
            SuspendLayout();
            // 
            // Column1
            // 
            Column1.HeaderText = "First Name";
            Column1.Name = "Column1";
            // 
            // dltBtn
            // 
            dltBtn.FlatStyle = FlatStyle.Flat;
            dltBtn.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            dltBtn.ForeColor = Color.WhiteSmoke;
            dltBtn.Location = new Point(471, 597);
            dltBtn.Margin = new Padding(3, 2, 3, 2);
            dltBtn.Name = "dltBtn";
            dltBtn.Size = new Size(116, 38);
            dltBtn.TabIndex = 4;
            dltBtn.Text = "Delete";
            dltBtn.UseVisualStyleBackColor = true;
            // 
            // addBtn
            // 
            addBtn.FlatStyle = FlatStyle.Flat;
            addBtn.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            addBtn.ForeColor = Color.WhiteSmoke;
            addBtn.Location = new Point(124, 597);
            addBtn.Margin = new Padding(3, 2, 3, 2);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(116, 38);
            addBtn.TabIndex = 2;
            addBtn.Text = "Add";
            addBtn.UseVisualStyleBackColor = true;
            addBtn.Click += addBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(32, 23);
            label1.Name = "label1";
            label1.Size = new Size(234, 51);
            label1.TabIndex = 0;
            label1.Text = "Add Patient";
            // 
            // upBtn
            // 
            upBtn.FlatStyle = FlatStyle.Flat;
            upBtn.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            upBtn.ForeColor = Color.WhiteSmoke;
            upBtn.Location = new Point(297, 597);
            upBtn.Margin = new Padding(3, 2, 3, 2);
            upBtn.Name = "upBtn";
            upBtn.Size = new Size(116, 38);
            upBtn.TabIndex = 3;
            upBtn.Text = "Update";
            upBtn.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.WhiteSmoke;
            label3.Location = new Point(41, 88);
            label3.Name = "label3";
            label3.Size = new Size(73, 19);
            label3.TabIndex = 6;
            label3.Text = "Full Name";
            // 
            // firstName
            // 
            firstName.BackColor = Color.FromArgb(50, 50, 50);
            firstName.ForeColor = Color.WhiteSmoke;
            firstName.Location = new Point(66, 128);
            firstName.Margin = new Padding(3, 2, 3, 2);
            firstName.Name = "firstName";
            firstName.Size = new Size(217, 23);
            firstName.TabIndex = 7;
            // 
            // midName
            // 
            midName.BackColor = Color.FromArgb(50, 50, 50);
            midName.ForeColor = Color.WhiteSmoke;
            midName.Location = new Point(297, 128);
            midName.Margin = new Padding(3, 2, 3, 2);
            midName.Name = "midName";
            midName.Size = new Size(162, 23);
            midName.TabIndex = 8;
            // 
            // lastName
            // 
            lastName.BackColor = Color.FromArgb(50, 50, 50);
            lastName.ForeColor = Color.WhiteSmoke;
            lastName.Location = new Point(471, 128);
            lastName.Margin = new Padding(3, 2, 3, 2);
            lastName.Name = "lastName";
            lastName.Size = new Size(217, 23);
            lastName.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.WhiteSmoke;
            label4.Location = new Point(66, 113);
            label4.Name = "label4";
            label4.Size = new Size(61, 13);
            label4.TabIndex = 10;
            label4.Text = "First Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.WhiteSmoke;
            label5.Location = new Point(297, 113);
            label5.Name = "label5";
            label5.Size = new Size(75, 13);
            label5.TabIndex = 11;
            label5.Text = "Middle Name";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.WhiteSmoke;
            label6.Location = new Point(471, 113);
            label6.Name = "label6";
            label6.Size = new Size(59, 13);
            label6.TabIndex = 12;
            label6.Text = "Last Name";
            // 
            // diag
            // 
            diag.BackColor = Color.FromArgb(50, 50, 50);
            diag.ForeColor = Color.WhiteSmoke;
            diag.Location = new Point(66, 272);
            diag.Margin = new Padding(3, 2, 3, 2);
            diag.Name = "diag";
            diag.Size = new Size(467, 23);
            diag.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.WhiteSmoke;
            label7.Location = new Point(41, 247);
            label7.Name = "label7";
            label7.Size = new Size(70, 19);
            label7.TabIndex = 14;
            label7.Text = "Diagnosis";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.WhiteSmoke;
            label8.Location = new Point(41, 175);
            label8.Name = "label8";
            label8.Size = new Size(72, 19);
            label8.TabIndex = 15;
            label8.Text = "Birth Date";
            // 
            // birthDatePicker
            // 
            birthDatePicker.Location = new Point(66, 201);
            birthDatePicker.Margin = new Padding(3, 2, 3, 2);
            birthDatePicker.Name = "birthDatePicker";
            birthDatePicker.Size = new Size(392, 23);
            birthDatePicker.TabIndex = 16;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.WhiteSmoke;
            label9.Location = new Point(45, 320);
            label9.Name = "label9";
            label9.Size = new Size(71, 19);
            label9.TabIndex = 17;
            label9.Text = "Patient ID";
            // 
            // patID
            // 
            patID.BackColor = Color.FromArgb(50, 50, 50);
            patID.ForeColor = Color.WhiteSmoke;
            patID.Location = new Point(66, 346);
            patID.Margin = new Padding(3, 2, 3, 2);
            patID.Name = "patID";
            patID.Size = new Size(217, 23);
            patID.TabIndex = 18;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.WhiteSmoke;
            label10.Location = new Point(45, 386);
            label10.Name = "label10";
            label10.Size = new Size(96, 19);
            label10.TabIndex = 19;
            label10.Text = "Floor Number";
            // 
            // floorNum
            // 
            floorNum.BackColor = Color.FromArgb(50, 50, 50);
            floorNum.ForeColor = Color.WhiteSmoke;
            floorNum.Location = new Point(66, 411);
            floorNum.Margin = new Padding(3, 2, 3, 2);
            floorNum.Name = "floorNum";
            floorNum.Size = new Size(217, 23);
            floorNum.TabIndex = 20;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.WhiteSmoke;
            label11.Location = new Point(350, 386);
            label11.Name = "label11";
            label11.Size = new Size(101, 19);
            label11.TabIndex = 21;
            label11.Text = "Room Number";
            // 
            // roomNum
            // 
            roomNum.BackColor = Color.FromArgb(50, 50, 50);
            roomNum.ForeColor = Color.WhiteSmoke;
            roomNum.Location = new Point(371, 411);
            roomNum.Margin = new Padding(3, 2, 3, 2);
            roomNum.Name = "roomNum";
            roomNum.Size = new Size(217, 23);
            roomNum.TabIndex = 22;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label12.ForeColor = Color.WhiteSmoke;
            label12.Location = new Point(52, 455);
            label12.Name = "label12";
            label12.Size = new Size(107, 19);
            label12.TabIndex = 23;
            label12.Text = "Admission Date";
            // 
            // admitDate
            // 
            admitDate.Location = new Point(66, 482);
            admitDate.Margin = new Padding(3, 2, 3, 2);
            admitDate.Name = "admitDate";
            admitDate.Size = new Size(392, 23);
            admitDate.TabIndex = 24;
            // 
            // panel2
            // 
            panel2.Controls.Add(admitDate);
            panel2.Controls.Add(label12);
            panel2.Controls.Add(roomNum);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(floorNum);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(patID);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(birthDatePicker);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(diag);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(lastName);
            panel2.Controls.Add(midName);
            panel2.Controls.Add(firstName);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(upBtn);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(addBtn);
            panel2.Controls.Add(dltBtn);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(1664, 688);
            panel2.TabIndex = 6;
            // 
            // textBox_admin_search
            // 
            textBox_admin_search.BackColor = Color.FromArgb(50, 50, 50);
            textBox_admin_search.ForeColor = Color.WhiteSmoke;
            textBox_admin_search.Location = new Point(210, 23);
            textBox_admin_search.Margin = new Padding(3, 2, 3, 2);
            textBox_admin_search.Name = "textBox_admin_search";
            textBox_admin_search.Size = new Size(596, 23);
            textBox_admin_search.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.WhiteSmoke;
            label2.Location = new Point(76, 24);
            label2.Name = "label2";
            label2.Size = new Size(121, 19);
            label2.TabIndex = 5;
            label2.Text = "Search for Patient";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(50, 50, 50);
            pictureBox1.Image = Properties.Resources.search;
            pictureBox1.Location = new Point(806, 20);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(52, 26);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(patDataListBg);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textBox_admin_search);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(757, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(907, 688);
            panel1.TabIndex = 5;
            // 
            // patDataListBg
            // 
            patDataListBg.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            patDataListBg.AutoSize = true;
            patDataListBg.BackColor = Color.White;
            patDataListBg.Controls.Add(patDataList);
            patDataListBg.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            patDataListBg.ForeColor = Color.Black;
            patDataListBg.Location = new Point(76, -47);
            patDataListBg.Name = "patDataListBg";
            patDataListBg.Size = new Size(800, 682);
            patDataListBg.TabIndex = 7;
            patDataListBg.TabStop = false;
            patDataListBg.Text = "Patient List";
            // 
            // patDataList
            // 
            patDataList.AllowDrop = true;
            patDataList.AllowUserToDeleteRows = false;
            patDataList.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            patDataList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            patDataList.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(51, 51, 51, 51);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.ControlLightLight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            patDataList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            patDataList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            patDataList.Columns.AddRange(new DataGridViewColumn[] { lastNameDataGridViewTextBoxColumn, firstNameDataGridViewTextBoxColumn, middleNameDataGridViewTextBoxColumn, diagnosisDataGridViewTextBoxColumn, patientIdDataGridViewTextBoxColumn, floorNumberDataGridViewTextBoxColumn, roomNumberDataGridViewTextBoxColumn, admitDateDataGridViewTextBoxColumn, birthdateDataGridViewTextBoxColumn });
            patDataList.Location = new Point(2, 111);
            patDataList.Name = "patDataList";
            patDataList.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            patDataList.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            patDataList.RowsDefaultCellStyle = dataGridViewCellStyle3;
            patDataList.RowTemplate.Height = 25;
            patDataList.RowTemplate.ReadOnly = true;
            patDataList.SelectionMode = DataGridViewSelectionMode.CellSelect;
            patDataList.Size = new Size(794, 547);
            patDataList.TabIndex = 0;
            // 
            // patientBindingSource
            // 
            patientBindingSource.DataSource = typeof(CS_Aid_Hospital_Management_System.Patient);
            // 
            // birthdateDataGridViewTextBoxColumn
            // 
            birthdateDataGridViewTextBoxColumn.DataPropertyName = "Birthdate";
            birthdateDataGridViewTextBoxColumn.HeaderText = "Birthdate";
            birthdateDataGridViewTextBoxColumn.Name = "birthdateDataGridViewTextBoxColumn";
            birthdateDataGridViewTextBoxColumn.ReadOnly = true;
            birthdateDataGridViewTextBoxColumn.Width = 90;
            // 
            // admitDateDataGridViewTextBoxColumn
            // 
            admitDateDataGridViewTextBoxColumn.DataPropertyName = "AdmitDate";
            admitDateDataGridViewTextBoxColumn.HeaderText = "Admission Date";
            admitDateDataGridViewTextBoxColumn.Name = "admitDateDataGridViewTextBoxColumn";
            admitDateDataGridViewTextBoxColumn.ReadOnly = true;
            admitDateDataGridViewTextBoxColumn.Width = 130;
            // 
            // roomNumberDataGridViewTextBoxColumn
            // 
            roomNumberDataGridViewTextBoxColumn.DataPropertyName = "RoomNumber";
            roomNumberDataGridViewTextBoxColumn.HeaderText = "Room Number";
            roomNumberDataGridViewTextBoxColumn.Name = "roomNumberDataGridViewTextBoxColumn";
            roomNumberDataGridViewTextBoxColumn.ReadOnly = true;
            roomNumberDataGridViewTextBoxColumn.Width = 124;
            // 
            // floorNumberDataGridViewTextBoxColumn
            // 
            floorNumberDataGridViewTextBoxColumn.DataPropertyName = "FloorNumber";
            floorNumberDataGridViewTextBoxColumn.HeaderText = "Floor Number";
            floorNumberDataGridViewTextBoxColumn.Name = "floorNumberDataGridViewTextBoxColumn";
            floorNumberDataGridViewTextBoxColumn.ReadOnly = true;
            floorNumberDataGridViewTextBoxColumn.Width = 119;
            // 
            // patientIdDataGridViewTextBoxColumn
            // 
            patientIdDataGridViewTextBoxColumn.DataPropertyName = "Patient_Id";
            patientIdDataGridViewTextBoxColumn.HeaderText = "Patient ID";
            patientIdDataGridViewTextBoxColumn.Name = "patientIdDataGridViewTextBoxColumn";
            patientIdDataGridViewTextBoxColumn.ReadOnly = true;
            patientIdDataGridViewTextBoxColumn.Width = 95;
            // 
            // diagnosisDataGridViewTextBoxColumn
            // 
            diagnosisDataGridViewTextBoxColumn.DataPropertyName = "Diagnosis";
            diagnosisDataGridViewTextBoxColumn.HeaderText = "Diagnosis";
            diagnosisDataGridViewTextBoxColumn.Name = "diagnosisDataGridViewTextBoxColumn";
            diagnosisDataGridViewTextBoxColumn.ReadOnly = true;
            diagnosisDataGridViewTextBoxColumn.Width = 93;
            // 
            // middleNameDataGridViewTextBoxColumn
            // 
            middleNameDataGridViewTextBoxColumn.DataPropertyName = "MiddleName";
            middleNameDataGridViewTextBoxColumn.HeaderText = "Middle Name";
            middleNameDataGridViewTextBoxColumn.Name = "middleNameDataGridViewTextBoxColumn";
            middleNameDataGridViewTextBoxColumn.ReadOnly = true;
            middleNameDataGridViewTextBoxColumn.Width = 116;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            firstNameDataGridViewTextBoxColumn.HeaderText = "First Name";
            firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            firstNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            lastNameDataGridViewTextBoxColumn.HeaderText = "Last Name";
            lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            lastNameDataGridViewTextBoxColumn.ReadOnly = true;
            lastNameDataGridViewTextBoxColumn.Width = 99;
            // 
            // Admin_addPatient
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(33, 33, 33);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Admin_addPatient";
            Size = new Size(1664, 688);
            Load += Admin_addPatient_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            patDataListBg.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)patDataList).EndInit();
            ((System.ComponentModel.ISupportInitialize)patientBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button addBtn;
        private Button upBtn;
        private Button dltBtn;
        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label label2;
        private TextBox textBox_admin_search;
        private TextBox lastName;
        private TextBox midName;
        private TextBox firstName;
        private Label label3;
        private DateTimePicker admitDate;
        private Label label12;
        private TextBox roomNum;
        private Label label11;
        private TextBox floorNum;
        private Label label10;
        private TextBox patID;
        private Label label9;
        private DateTimePicker birthDatePicker;
        private Label label8;
        private Label label7;
        private TextBox diag;
        private Label label6;
        private Label label5;
        private Label label4;
        private DataGridViewTextBoxColumn Column1;
        private BindingSource databaseBindingSource1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn BirthDate;
        private DataGridViewTextBoxColumn Diagnosis;
        private DataGridViewTextBoxColumn patientID;
        private DataGridViewTextBoxColumn FloorNumber;
        private DataGridViewTextBoxColumn roomNumber;
        private DataGridViewTextBoxColumn admissionDate;
        private GroupBox patDataListBg;
        private DataGridView patDataList;
        private DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn middleNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn diagnosisDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn patientIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn floorNumberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn roomNumberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn admitDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn birthdateDataGridViewTextBoxColumn;
        private BindingSource patientBindingSource;
    }
}

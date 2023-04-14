namespace CSAid_MainWinFormsApp.View
{
    partial class Admin_Inventory
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
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            textBox_admin_search = new TextBox();
            inventoryList = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            textBox4 = new TextBox();
            label7 = new Label();
            numericUpDown1 = new NumericUpDown();
            label3 = new Label();
            label4 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)inventoryList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(textBox4);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(textBox_admin_search);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(inventoryList);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(numericUpDown1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1664, 688);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(1018, 0);
            label1.Name = "label1";
            label1.Size = new Size(197, 51);
            label1.TabIndex = 11;
            label1.Text = "Inventory";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(50, 50, 50);
            pictureBox1.Image = Properties.Resources.search;
            pictureBox1.Location = new Point(1425, 67);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(52, 26);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.WhiteSmoke;
            label2.Location = new Point(724, 70);
            label2.Name = "label2";
            label2.Size = new Size(111, 19);
            label2.TabIndex = 9;
            label2.Text = "Search for Items";
            // 
            // textBox_admin_search
            // 
            textBox_admin_search.BackColor = Color.FromArgb(50, 50, 50);
            textBox_admin_search.ForeColor = Color.WhiteSmoke;
            textBox_admin_search.Location = new Point(848, 70);
            textBox_admin_search.Margin = new Padding(3, 2, 3, 2);
            textBox_admin_search.Name = "textBox_admin_search";
            textBox_admin_search.Size = new Size(577, 23);
            textBox_admin_search.TabIndex = 8;
            // 
            // inventoryList
            // 
            inventoryList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            inventoryList.Location = new Point(563, 111);
            inventoryList.Margin = new Padding(3, 2, 3, 2);
            inventoryList.Name = "inventoryList";
            inventoryList.RowHeadersWidth = 51;
            inventoryList.RowTemplate.Height = 29;
            inventoryList.Size = new Size(1056, 536);
            inventoryList.TabIndex = 7;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.WhiteSmoke;
            button1.Location = new Point(57, 245);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(140, 38);
            button1.TabIndex = 5;
            button1.Text = "Add Item";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.WhiteSmoke;
            button2.Location = new Point(214, 245);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(140, 38);
            button2.TabIndex = 6;
            button2.Text = "Update Item";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.WhiteSmoke;
            button3.Location = new Point(370, 245);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(140, 38);
            button3.TabIndex = 7;
            button3.Text = "Delete Item";
            button3.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.FromArgb(50, 50, 50);
            textBox4.ForeColor = Color.WhiteSmoke;
            textBox4.Location = new Point(85, 107);
            textBox4.Margin = new Padding(3, 2, 3, 2);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(406, 23);
            textBox4.TabIndex = 28;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.WhiteSmoke;
            label7.Location = new Point(65, 83);
            label7.Name = "label7";
            label7.Size = new Size(78, 19);
            label7.TabIndex = 27;
            label7.Text = "Item Name";
            // 
            // numericUpDown1
            // 
            numericUpDown1.BackColor = Color.FromArgb(50, 50, 50);
            numericUpDown1.ForeColor = Color.WhiteSmoke;
            numericUpDown1.Location = new Point(85, 186);
            numericUpDown1.Margin = new Padding(3, 2, 3, 2);
            numericUpDown1.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(131, 23);
            numericUpDown1.TabIndex = 29;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.WhiteSmoke;
            label3.Location = new Point(65, 162);
            label3.Name = "label3";
            label3.Size = new Size(79, 19);
            label3.TabIndex = 30;
            label3.Text = "Item Count";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.WhiteSmoke;
            label4.Location = new Point(57, 10);
            label4.Name = "label4";
            label4.Size = new Size(350, 41);
            label4.TabIndex = 31;
            label4.Text = "Inventory Management";
            // 
            // Admin_Inventory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(33, 33, 33);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Admin_Inventory";
            Size = new Size(1664, 688);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)inventoryList).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label2;
        private TextBox textBox_admin_search;
        private DataGridView inventoryList;
        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
        private TextBox textBox4;
        private Label label7;
        private NumericUpDown numericUpDown1;
        private Label label3;
        private Label label4;
    }
}

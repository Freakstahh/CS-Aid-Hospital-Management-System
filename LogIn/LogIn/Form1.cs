namespace LogIn
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //nothing
        }

        private void Logo_Click(object sender, EventArgs e)
        {
            //nothing
        }

        private void UsernameTextbox_TextChanged(object sender, EventArgs e)
        {
            //input username
        }

        private void PasswordTextBox_TextChanged(object sender, EventArgs e)
        {
            //input password
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            //nothing
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            //nothing
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            //testing pa ni
            if (UsernameTextbox.Text == "CSAID Personnel" && PasswordTextBox.Text == "MgaGwapo")
            {
                new Form2().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect Username or Password Input.\nPlease Try Again.");
                UsernameTextbox.Clear();
                PasswordTextBox.Clear();
            }
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            PasswordTextBox.Clear();
            UsernameTextbox.Clear();   
        }
    }
}
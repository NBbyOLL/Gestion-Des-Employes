using Project_dotNet.Forms;
using System;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;
using System.Data;





namespace Project_dotNet
{

    public partial class Emsi : Form
    {
        private SqlConnection connect;

        public Emsi()
        {
            InitializeComponent();

            connect = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=winformdb;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");



        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }



        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }





        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {

        }

        private void login_show_password_CheckedChanged(object sender, EventArgs e)
        {

            if (login_show_password.Checked)
            {
                login_password.PasswordChar = '\0';
            }
            else
            {
                login_password.PasswordChar = '*';
            }

        }



        private void login_password_TextChanged(object sender, EventArgs e)
        {
            login_password.PasswordChar = '*';
        }

        private void Password_Click(object sender, EventArgs e)
        {

        }

        private void login_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            {
                // You can check if the username and password match "admin" here
                if (login_name.Text == "admin" && login_password.Text == "admin")
                {
                    // If credentials match, show the AdminDashboard form
                    MessageBox.Show("Login Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    adminDaashboard adminDashboard = new adminDaashboard();
                    adminDashboard.Show();
                    this.Hide();  // Hide the login form
                }
                else
                {
                    // If credentials are incorrect, show an error message
                    MessageBox.Show("Invalid username or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

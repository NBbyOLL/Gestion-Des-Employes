using System;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;



namespace Project_dotNet
{
    public partial class Emsi : Form
    {
        public Emsi()
        {
            InitializeComponent();

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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
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

        private void label1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void login_Click(object sender, EventArgs e)
        {
            string connstring = "server=localhost;uid=root;pwd=123456;database=farmchicken;port=3307";

            string username = labelName.Text;
            string password = Password.Text;
            string role = login_role.ToString();

            using (MySqlConnection conn = new MySqlConnection(connstring))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM users WHERE name = @username AND password = @password AND role = @role";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);
                    cmd.Parameters.AddWithValue("@role", role);

                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        // If login is successful
                        MessageBox.Show("Login successful!");
                        // Proceed to next action, such as opening the main form or dashboard
                    }
                    else
                    {
                        // If login fails
                        MessageBox.Show("Invalid username, password, or role.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void pictureBox1_Click_2(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Microsoft.Data.SqlClient;

namespace Project_dotNet.Forms
{
    public partial class adminDaashboard : Form
    {
        public adminDaashboard()
        {
            InitializeComponent();
            LoadEmployeeData(); // Automatically load data on form initialization
            LoadEmployeeDatavacation(); // Automatically load data on form initialization
            LoadEmployeeDataSalaries(); // Ensure this method is called to update the label

        }

        private void adminDashboard_Load(object sender, EventArgs e)
        {

        }
        private void LoadEmployeeData()
        {
            string connectionString = @"Data Source=ALOUAHAPC\SQLEXPRESS;Initial Catalog=GestionDesEmployee;Integrated Security=True;Pooling=False;Encrypt=True;Trust Server Certificate=True";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Query to get the count of employees
                    using (SqlCommand command = new SqlCommand("SELECT COUNT(CIN) AS EmployeeCount FROM Employees", connection))
                    {
                        int employeeCount = (int)command.ExecuteScalar();
                        labelEmployeeCount.Text = employeeCount.ToString();
                        labelEmployeeCount.TextAlign = ContentAlignment.MiddleCenter;
                        labelEmployeeCount.Font = new Font("Times new roman", 30F, FontStyle.Bold, GraphicsUnit.Point);



                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
        private void LoadEmployeeDatavacation()
        {
            string connectionString = @"Data Source=ALOUAHAPC\SQLEXPRESS;Initial Catalog=GestionDesEmployee;Integrated Security=True;Pooling=False;Encrypt=True;Trust Server Certificate=True";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Query to get the count of employees
                    using (SqlCommand command = new SqlCommand("SELECT COUNT(CIN) AS EmployeeCount FROM vacation", connection))
                    {
                        int employeeCount = (int)command.ExecuteScalar();
                        vacationlabel.Text = employeeCount.ToString();
                        vacationlabel.TextAlign = ContentAlignment.MiddleCenter;
                        vacationlabel.Font = new Font("Times new roman", 30F, FontStyle.Bold, GraphicsUnit.Point);



                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
        private void LoadEmployeeDataSalaries()
        {
            string connectionString = @"Data Source=ALOUAHAPC\SQLEXPRESS;Initial Catalog=GestionDesEmployee;Integrated Security=True;Pooling=False;Encrypt=True;Trust Server Certificate=True";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Query to get the count of employees
                    using (SqlCommand command = new SqlCommand("SELECT SUM(Salary) AS TotalSalaries FROM Employees", connection))
                    {
                        object result = command.ExecuteScalar(); // Get the result of the query

                        decimal totalSalaries = (result != DBNull.Value) ? Convert.ToDecimal(result) : 0;
                        labelsalaries.Text = "{totalSalaries:C}"; // Format as currency
                        labelsalaries.TextAlign = ContentAlignment.MiddleCenter;
                        labelsalaries.Font = new Font("Times New Roman", 20F, FontStyle.Bold, GraphicsUnit.Point);
                    }
                }


            }
                
            
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            addEmployees addEmp = new addEmployees();
            addEmp.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void adminLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
                Emsi login = new Emsi();
                login.Show();
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void adminExpense_Click(object sender, EventArgs e)
        {
            Cnss cnss = new Cnss();
            cnss.Show();
            this.Hide();
        }

        private void adminClients_Click(object sender, EventArgs e)
        {
            vacation vacation = new vacation();
            vacation.Show();
            this.Hide();
        }

        private void vacationEmployeeCin_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridNumbersOfEmployees_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void labelEmployeeCount_Click(object sender, EventArgs e)
        {

        }

        private void adminDaashboard_Load(object sender, EventArgs e)
        {

        }

        private void BoxNumbersOfEmployees_TextChanged(object sender, EventArgs e)
        {

        }

        private void vacationlabel_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

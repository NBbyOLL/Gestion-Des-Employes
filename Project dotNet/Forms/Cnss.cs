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
    public partial class Cnss : Form
    {
        private SqlConnection connect;

        public Cnss()
        {
            InitializeComponent();

        }

        private void pictureBox3_Click(object sender, EventArgs e)
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

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void cnssSumarryThisMonth_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridTotalDeclaration_CellContentClick(object sender, DataGridViewCellEventArgs e)//data Grid total declaration 
        {

        }

        private void dataGridThisMonth_CellContentClick(object sender, DataGridViewCellEventArgs e)//data Grid ThisMonth
        {

        }

        private void BoxCinCNSS_TextChanged(object sender, EventArgs e)
        {

        }

        private void cnssUpDown_ValueChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)//button submit
        {
            string connectionString = @"Data Source=ALOUAHAPC\SQLEXPRESS;Initial Catalog=GestionDesEmployee;Integrated Security=True;Pooling=False;Encrypt=True;Trust Server Certificate=True";
            {
                // Retrieve input values
                string cin = BoxCinCNSS.Text.Trim();
                decimal totalAmount = cnssUpDown.Value; // Assuming cnssUpDown is the NumericUpDown control
                DateTime declarationDate = cnssimePicker.Value; // Assuming cnssDatePicker is the DateTimePicker control

                if (string.IsNullOrEmpty(cin))
                {
                    MessageBox.Show("CIN is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                using (SqlConnection connect = new SqlConnection(connectionString))
                {
                    try
                    {
                        connect.Open();

                        // Check if CIN exists in Employees table
                        string checkCINQuery = "SELECT COUNT(1) FROM Employees WHERE CIN = @CIN";
                        SqlCommand checkCmd = new SqlCommand(checkCINQuery, connect);
                        checkCmd.Parameters.AddWithValue("@CIN", cin);

                        int exists = (int)checkCmd.ExecuteScalar();

                        if (exists > 0)
                        {
                            // Insert CNSS record
                            string insertQuery = "INSERT INTO CNSS (CIN, TotalAmount, DeclarationDate) VALUES (@CIN, @TotalAmount, @DeclarationDate)";
                            SqlCommand cmd = new SqlCommand(insertQuery, connect);
                            cmd.Parameters.AddWithValue("@CIN", cin);
                            cmd.Parameters.AddWithValue("@TotalAmount", totalAmount);
                            cmd.Parameters.AddWithValue("@DeclarationDate", declarationDate);

                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Record inserted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("CIN does not exist in the Employees table.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void DisplayMonthlyData(SqlConnection connect)
        {
            try
            {
                // Query for Total Declarations, Total Amount, and Average Amount for the current month
                string totalDeclarationsQuery = "SELECT COUNT(*) FROM CNSS WHERE MONTH(DeclarationDate) = MONTH(GETDATE()) AND YEAR(DeclarationDate) = YEAR(GETDATE())";
                SqlCommand totalDeclarationsCmd = new SqlCommand(totalDeclarationsQuery, connect);
                int totalDeclarations = (int)totalDeclarationsCmd.ExecuteScalar();

                string totalAmountQuery = "SELECT SUM(TotalAmount) FROM CNSS WHERE MONTH(DeclarationDate) = MONTH(GETDATE()) AND YEAR(DeclarationDate) = YEAR(GETDATE())";
                SqlCommand totalAmountCmd = new SqlCommand(totalAmountQuery, connect);
                decimal totalAmountForMonth = (decimal)totalAmountCmd.ExecuteScalar();

                string averageAmountQuery = "SELECT AVG(TotalAmount) FROM CNSS WHERE MONTH(DeclarationDate) = MONTH(GETDATE()) AND YEAR(DeclarationDate) = YEAR(GETDATE())";
                SqlCommand averageAmountCmd = new SqlCommand(averageAmountQuery, connect);
                decimal averageAmount = (decimal)averageAmountCmd.ExecuteScalar();

                // Update DataGridViews
                dataGridTotalDeclaration.Rows.Clear(); // Clear previous rows if any
                dataGridTotalAmount.Rows.Clear();
                dataGridAverageAmount.Rows.Clear();
                dataGridThisMonth.Rows.Clear();

                // Add the results to the respective DataGridViews
                dataGridTotalDeclaration.Rows.Add(new object[] { "Total Declarations", totalDeclarations });
                dataGridTotalAmount.Rows.Add(new object[] { "Total Amount", totalAmountForMonth });
                dataGridAverageAmount.Rows.Add(new object[] { "Average Amount", averageAmount });

            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while fetching data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void dataGridTotalAmount_CellContentClick(object sender, DataGridViewCellEventArgs e)//data Grid TotalAmount
        {

        }

        private void dataGridAverageAmount_CellContentClick(object sender, DataGridViewCellEventArgs e)//dataGridAverageAmount
        {

        }

        private void adminEmployees_Click(object sender, EventArgs e)
        {
            addEmployees employees = new addEmployees();
            employees.Show();
            this.Hide();
        }

        private void adminClients_Click(object sender, EventArgs e)
        {
            vacation vacation = new vacation();
            vacation.Show();
            this.Hide();
        }
    }
}

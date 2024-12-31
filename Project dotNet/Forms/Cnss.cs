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
        public const decimal EmployerContributionPercentage = 0.1819m; // 18.19%

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

        private void guna2Button1_Click(object sender, EventArgs e) // Button submit
        {
            string connectionString = @"Data Source=ALOUAHAPC\SQLEXPRESS;Initial Catalog=GestionDesEmployee;Integrated Security=True;Pooling=False;Encrypt=True;Trust Server Certificate=True";
            {
                // Retrieve input values
                string cin = BoxCinCNSS.Text.Trim();
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

                        // Fetch the salary of the employee
                        string salaryQuery = "SELECT Salary FROM Employees WHERE CIN = @CIN";
                        SqlCommand salaryCmd = new SqlCommand(salaryQuery, connect);
                        salaryCmd.Parameters.AddWithValue("@CIN", cin);

                        object result = salaryCmd.ExecuteScalar();
                        if (result == null || result == DBNull.Value)
                        {
                            MessageBox.Show("Salary not found for the employee. Please verify the CIN.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        decimal salary = Convert.ToDecimal(result);

                        // Calculate contributions
                        decimal employeeContribution = salary * 0.0429m; // 4.29%
                        decimal employerContribution = salary * 0.1819m; // 18.19%
                        decimal totalAmount = employeeContribution + employerContribution;

                        // Check if a record already exists for this CIN and month
                        string checkRecordQuery = @"SELECT COUNT(1) FROM CNSS 
                                            WHERE CIN = @CIN 
                                              AND MONTH(DeclarationDate) = MONTH(@DeclarationDate) 
                                              AND YEAR(DeclarationDate) = YEAR(@DeclarationDate)";
                        SqlCommand checkRecordCmd = new SqlCommand(checkRecordQuery, connect);
                        checkRecordCmd.Parameters.AddWithValue("@CIN", cin);
                        checkRecordCmd.Parameters.AddWithValue("@DeclarationDate", declarationDate);

                        int recordExists = (int)checkRecordCmd.ExecuteScalar();

                        if (recordExists > 0)
                        {
                            // Delete the existing record
                            string deleteQuery = @"DELETE FROM CNSS 
                           WHERE CIN = @CIN 
                             AND MONTH(DeclarationDate) = MONTH(@DeclarationDate) 
                             AND YEAR(DeclarationDate) = YEAR(@DeclarationDate)";
                            SqlCommand deleteCmd = new SqlCommand(deleteQuery, connect);
                            deleteCmd.Parameters.AddWithValue("@CIN", cin);
                            deleteCmd.Parameters.AddWithValue("@DeclarationDate", declarationDate);

                            deleteCmd.ExecuteNonQuery();

                            // Insert new record with calculated contributions
                            string insertQuery = @"INSERT INTO CNSS (CIN, TotalAmount, DeclarationDate, EmployerContribution, EmployeeContribution) 
                           VALUES (@CIN, @TotalAmount, @DeclarationDate, @EmployerContribution, @EmployeeContribution)";
                            SqlCommand insertCmd = new SqlCommand(insertQuery, connect);
                            insertCmd.Parameters.AddWithValue("@CIN", cin);
                            insertCmd.Parameters.AddWithValue("@TotalAmount", totalAmount);
                            insertCmd.Parameters.AddWithValue("@DeclarationDate", declarationDate);
                            insertCmd.Parameters.AddWithValue("@EmployerContribution", employerContribution);
                            insertCmd.Parameters.AddWithValue("@EmployeeContribution", employeeContribution);

                            insertCmd.ExecuteNonQuery();

                            MessageBox.Show("Record updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                        else
                        {
                            // Insert new record with calculated contributions
                            string insertQuery = @"INSERT INTO CNSS (CIN, TotalAmount, DeclarationDate, EmployerContribution, EmployeeContribution) 
                                           VALUES (@CIN, @TotalAmount, @DeclarationDate, @EmployerContribution, @EmployeeContribution)";
                            SqlCommand insertCmd = new SqlCommand(insertQuery, connect);
                            insertCmd.Parameters.AddWithValue("@CIN", cin);
                            insertCmd.Parameters.AddWithValue("@TotalAmount", totalAmount);
                            insertCmd.Parameters.AddWithValue("@DeclarationDate", declarationDate);
                            insertCmd.Parameters.AddWithValue("@EmployerContribution", employerContribution);
                            insertCmd.Parameters.AddWithValue("@EmployeeContribution", employeeContribution);

                            insertCmd.ExecuteNonQuery();

                            MessageBox.Show("Record inserted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    LoadCNSSData();

                }
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

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            // Set the Employer Contribution TextBox to read-only
            textboxEmployerContribution.ReadOnly = true;

            // Set the default value to "18.19%" as a constant display
            textboxEmployerContribution.Text = (EmployerContributionPercentage * 100).ToString("F2") + "%";
        }

        private void CNSSDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string connectionString = @"Data Source=ALOUAHAPC\SQLEXPRESS;Initial Catalog=GestionDesEmployee;Integrated Security=True;Pooling=False;Encrypt=True;Trust Server Certificate=True";

            try
            {
                // Ensure that the row clicked is valid
                if (e.RowIndex >= 0 && e.RowIndex < CNSSDataGridView.Rows.Count)
                {
                    string cin = CNSSDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString(); // CIN is in the first column

                    // Retrieve employee details and CNSS data for the selected CIN
                    string query = @"
                SELECT E.Name, E.Salary, C.EmployerContribution, C.EmployeeContribution, C.TotalAmount, C.DeclarationDate 
                FROM CNSS C 
                JOIN Employees E ON C.CIN = E.CIN
                WHERE C.CIN = E.CIN";

                    using (SqlConnection connect = new SqlConnection(connectionString))
                    {
                        connect.Open();

                        SqlCommand cmd = new SqlCommand(query, connect);
                        cmd.Parameters.AddWithValue("@CIN", cin);

                        SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        int rowsAffected = dataAdapter.Fill(dt);

                        // Check if rows were returned
                        if (rowsAffected > 0)
                        {
                            // Bind the DataTable to DataGridView
                            CNSSDataGridView.DataSource = dt;
                        }
                        else
                        {
                            MessageBox.Show("No data found for this CIN.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        // Optionally, you can display the data in a message box
                        if (dt.Rows.Count > 0)
                        {
                            DataRow row = dt.Rows[0];
                            string employeeName = row["Name"].ToString();
                            decimal employeeSalary = Convert.ToDecimal(row["Salary"]);
                            decimal employerContribution = Convert.ToDecimal(row["EmployerContribution"]);
                            decimal employeeContribution = Convert.ToDecimal(row["EmployeeContribution"]);
                            decimal totalAmount = Convert.ToDecimal(row["TotalAmount"]);

                            MessageBox.Show($"Employee: {employeeName}\nSalary: {employeeSalary}\nEmployer Contribution: {employerContribution}\nEmployee Contribution: {employeeContribution}\nTotal Amount: {totalAmount}", "Employee Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Invalid row clicked.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void LoadCNSSData()
        {
            string connectionString = @"Data Source=ALOUAHAPC\SQLEXPRESS;Initial Catalog=GestionDesEmployee;Integrated Security=True;Pooling=False;Encrypt=True;Trust Server Certificate=True";
            string query = "SELECT CIN, TotalAmount, EmployerContribution, EmployeeContribution, DeclarationDate FROM CNSS";

            using (SqlConnection connect = new SqlConnection(connectionString))
            {
                try
                {
                    connect.Open();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connect);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    // Bind the DataTable to the DataGridView
                    CNSSDataGridView.DataSource = dataTable;
                    CNSSDataGridView.ColumnHeadersHeight = 40;


                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while loading data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void adminDashboard_Click(object sender, EventArgs e)
        {
            adminDaashboard adminDaashboard = new adminDaashboard();
            adminDaashboard.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void Cnss_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }
    }
}

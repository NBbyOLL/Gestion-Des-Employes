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
using static Guna.UI2.Native.WinApi;

namespace Project_dotNet.Forms
{
    public partial class vacation : Form
    {
        public vacation()
        {
            InitializeComponent();
        }

        private void adminClients_Click(object sender, EventArgs e)
        {
            vacation vacation = new vacation();
            vacation.Show();
            this.Hide();
        }

        private void adminCnss_Click(object sender, EventArgs e)
        {
            Cnss cnss = new Cnss();
            cnss.Show();
            this.Hide();
        }

        private void adminEmployees_Click(object sender, EventArgs e)
        {
            addEmployees addemp = new addEmployees();
            addemp.Show();
            this.Hide();
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

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void vocationbuttonSave_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=ALOUAHAPC\SQLEXPRESS;Initial Catalog=GestionDesEmployee;Integrated Security=True;Pooling=False;Encrypt=True;Trust Server Certificate=True";
            string cin = Boxvacationcin.Text.Trim();
            string isPaidString = ComboBoxisPaid.SelectedItem.ToString();
            DateTime Datestart = vacationtimePickerStartDate.Value;
            DateTime DateEnd = vacationtimePickerEndDate.Value;

            bool isPaid = isPaidString == "Yes";

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
                        string insertQuery = "INSERT INTO vacation (CIN, StartDate, EndDate,IsPaid) VALUES (@CIN, @StartDate, @EndDate,@IsPaid)";
                        SqlCommand cmd = new SqlCommand(insertQuery, connect);
                        cmd.Parameters.AddWithValue("@CIN", cin);
                        cmd.Parameters.AddWithValue("@StartDate", Datestart);
                        cmd.Parameters.AddWithValue("@EndDate", DateEnd);
                        cmd.Parameters.AddWithValue("@IsPaid", isPaid);

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

        private void boxUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connect = new SqlConnection(@"Data Source=ALOUAHAPC\SQLEXPRESS;Initial Catalog=GestionDesEmployee;Integrated Security=True;Pooling=False;Encrypt=True;Trust Server Certificate=True"))
                {
                    connect.Open();

                    // Validate inputs
                    string cin = Boxvacationcin.Text.Trim();
                    string isPaidString = ComboBoxisPaid.SelectedItem?.ToString();
                    DateTime Datestart = vacationtimePickerStartDate.Value;
                    DateTime DateEnd = vacationtimePickerEndDate.Value;

                    if (string.IsNullOrEmpty(cin))
                    {
                        MessageBox.Show("CIN is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (string.IsNullOrEmpty(isPaidString))
                    {
                        MessageBox.Show("Please select whether the vacation is paid or not.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Convert "Yes" or "No" to a boolean value
                    bool isPaid = isPaidString == "Yes";

                    // Update query for the vacation table
                    string updateQuery = "UPDATE vacation SET StartDate = @StartDate, EndDate = @EndDate, IsPaid = @IsPaid WHERE CIN = @CIN";

                    SqlCommand cmd = new SqlCommand(updateQuery, connect);
                    cmd.Parameters.AddWithValue("@StartDate", Datestart);
                    cmd.Parameters.AddWithValue("@EndDate", DateEnd);
                    cmd.Parameters.AddWithValue("@IsPaid", isPaid);
                    cmd.Parameters.AddWithValue("@CIN", cin);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Vacation updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No record found with the specified CIN.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating vacation: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void boxDelete_Click(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;


namespace Project_dotNet.Forms
{
    public partial class addEmployees : Form
    {
        private byte[] imageData;

        public addEmployees()
        {
            InitializeComponent();

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {

        }

        private void A_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void employePrenom_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void boxAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2TextBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void boxNom_TextChanged(object sender, EventArgs e)
        {

        }

        private void employeeNom_Click(object sender, EventArgs e)
        {

        }

        private void employeeAdress_Click(object sender, EventArgs e)
        {

        }

        private void boxSave_Click(object sender, EventArgs e)
        {
            RefreshDataGridView();

        }

        private void addEmployees_Load(object sender, EventArgs e)
        {
            RefreshDataGridView();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (imageData == null || imageData.Length == 0)
                {
                    MessageBox.Show("Please select a photo for the employee.");
                    return;
                }

                using (SqlConnection connect = new SqlConnection(@"Data Source=ALOUAHAPC\SQLEXPRESS;Initial Catalog=GestionDesEmployee;Integrated Security=True;Pooling=False;Encrypt=True;Trust Server Certificate=True"))
                {
                    connect.Open();

                    // Convert the image to byte array
                    byte[] photoData = null;
                    if (BoxPic.Image != null)
                    {
                        using (MemoryStream ms = new MemoryStream())
                        {
                            BoxPic.Image.Save(ms, BoxPic.Image.RawFormat);
                            photoData = ms.ToArray();
                        }
                    }

                    SqlCommand cmd = new SqlCommand("INSERT INTO Employees (CIN, Name, photo, HireDate, Salary, EmployeeType) VALUES (@CIN, @Name, @photo, @HireDate, @Salary, @EmployeeType)", connect);

                    string employeeType = employeeTypeBox.SelectedItem.ToString();

                    cmd.Parameters.AddWithValue("@CIN", boxCin.Text);
                    cmd.Parameters.AddWithValue("@Name", boxName.Text);
                    cmd.Parameters.AddWithValue("@photo", (object)imageData ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@HireDate", DateTime.Parse(boxHireDate.Text));
                    cmd.Parameters.AddWithValue("@Salary", decimal.Parse(boxSalary.Text));
                    cmd.Parameters.AddWithValue("@EmployeeType", employeeType);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Employee Saved successfully");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving employee: " + ex.Message);
            }

        }

        private void boxSalary_TextChanged(object sender, EventArgs e)
        {

        }

        private void boxUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connect = new SqlConnection(@"Data Source=ALOUAHAPC\SQLEXPRESS;Initial Catalog=GestionDesEmployee;Integrated Security=True;Pooling=False;Encrypt=True;Trust Server Certificate=True"))
                {
                    connect.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE Employees SET Name=@Name, photo=@photo, HireDate=@HireDate, Salary=@Salary, EmployeeType=@EmployeeType WHERE CIN=@CIN", connect);

                    string employeeType = employeeTypeBox.SelectedItem.ToString();

                    cmd.Parameters.AddWithValue("@CIN", boxCin.Text);
                    cmd.Parameters.AddWithValue("@Name", boxName.Text);
                    cmd.Parameters.AddWithValue("@photo", (object)imageData ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@HireDate", DateTime.Parse(boxHireDate.Text));
                    cmd.Parameters.AddWithValue("@Salary", decimal.Parse(boxSalary.Text));
                    cmd.Parameters.AddWithValue("@EmployeeType", employeeType);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Employee Updated successfully");
                    RefreshDataGridView();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating employee: " + ex.Message);
            }

        }
        private void RefreshDataGridView()
        {
            using (SqlConnection connect = new SqlConnection(@"Data Source=ALOUAHAPC\SQLEXPRESS;Initial Catalog=GestionDesEmployee;Integrated Security=True;Pooling=False;Encrypt=True;Trust Server Certificate=True"))
            {
                connect.Open();
                SqlCommand cmd = new SqlCommand("SELECT CIN, Name, HireDate, Salary, EmployeeType FROM Employees;", connect);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                adapter.Fill(table);
                DataGridView.DataSource = table;
                connect.Close();

                DataGridView.ColumnHeadersHeight = 40;
            }
        }


        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void boxId_TextChanged(object sender, EventArgs e)
        {

        }

        private void boxDelete_Click(object sender, EventArgs e)
        {
            SqlConnection connect = new SqlConnection(@"Data Source=ALOUAHAPC\SQLEXPRESS;Initial Catalog=GestionDesEmployee;Integrated Security=True;Pooling=False;Encrypt=True;Trust Server Certificate=True");
            connect.Open();
            SqlCommand cmd = new SqlCommand("delete Employees where CIN=@CIN ", connect);
            cmd.Parameters.AddWithValue("@CIN", boxCin.Text);

            cmd.ExecuteNonQuery();
            connect.Close();
            MessageBox.Show("Employee Deleted successfully");
            RefreshDataGridView();

        }


        private void DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void boxAddress_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void buttonBox_Click(object sender, EventArgs e)
        {

        }

        private void BoxPic_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void boxName_TextChanged(object sender, EventArgs e)
        {

        }


        private void Import_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Get the path of specified file
                    string filePath = openFileDialog.FileName;

                    // Optionally, display the selected image in a PictureBox
                    BoxPic.Image = Image.FromFile(filePath);

                    // You can also store the file path in a TextBox or any other control
                    BoxPic.Text = filePath;

                    // Convert the image into a byte array and store it in imageData
                    using (MemoryStream ms = new MemoryStream())
                    {
                        BoxPic.Image.Save(ms, BoxPic.Image.RawFormat);
                        imageData = ms.ToArray();  // Store the image data as a byte array
                    }
                }
            }
        }

        private void employeeTypeBox_SelectedIndexChanged(object sender, EventArgs e)
        {

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

        private void adminCnss_Click(object sender, EventArgs e)
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

        private void boxCin_TextChanged(object sender, EventArgs e)
        {

        }

        private void adminDashboard_Click(object sender, EventArgs e)
        {
            adminDaashboard adminDaashboard = new adminDaashboard();
            adminDaashboard.Show();
            this.Hide();
        }
    }
}


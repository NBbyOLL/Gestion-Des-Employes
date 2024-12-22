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
            SqlConnection connect = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=winformdb;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");
            connect.Open();
            SqlCommand cmd = new SqlCommand("select * from employees ;", connect);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            DataGridView.DataSource = table;
        }

        private void addEmployees_Load(object sender, EventArgs e)
        {
            RefreshDataGridView();

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            SqlConnection connect = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=winformdb;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");
            connect.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO employees VALUES (@firstName, @lastName, @address, @salary, @dateBirth, @phoneNumber, @CIN)", connect);
            cmd.Parameters.AddWithValue("@firstName", boxFirstName.Text);
            cmd.Parameters.AddWithValue("@lastName", boxlastName.Text);
            cmd.Parameters.AddWithValue("@address", boxAddress.Text);
            cmd.Parameters.AddWithValue("@salary", Convert.ToDouble(boxSalary.Text));
            cmd.Parameters.AddWithValue("@dateBirth", boxBirth.Text);
            cmd.Parameters.AddWithValue("@phoneNumber", boxphoneNumber.Text);
            cmd.Parameters.AddWithValue("@CIN", boxCin.Text);

            cmd.ExecuteNonQuery();
            connect.Close();
            MessageBox.Show("Employee Saved successfully");
            RefreshDataGridView();

        }

        private void boxSalary_TextChanged(object sender, EventArgs e)
        {

        }

        private void boxUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection connect = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=winformdb;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");
            connect.Open();
            SqlCommand cmd = new SqlCommand("update employees set firstName=@firstName, lastName=@lastName, address=@address, salary=@salary, dateBirth=@dateBirth, phoneNumber=@phoneNumber where CIN=@CIN", connect);
            cmd.Parameters.AddWithValue("@firstName", boxFirstName.Text);
            cmd.Parameters.AddWithValue("@lastName", boxlastName.Text);
            cmd.Parameters.AddWithValue("@address", boxAddress.Text);
            cmd.Parameters.AddWithValue("@salary", Convert.ToDouble(boxSalary.Text));
            cmd.Parameters.AddWithValue("@dateBirth", boxBirth.Text);
            cmd.Parameters.AddWithValue("@phoneNumber", boxphoneNumber.Text);
            cmd.Parameters.AddWithValue("@CIN", boxCin.Text);
            cmd.ExecuteNonQuery();
            connect.Close();
            MessageBox.Show("Employee Updated successfully");

            RefreshDataGridView();

        }
        private void RefreshDataGridView()
        {
            SqlConnection connect = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=winformdb;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");
            connect.Open();
            SqlCommand cmd = new SqlCommand("select * from employees;", connect);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            DataGridView.DataSource = table;
            connect.Close();
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void boxId_TextChanged(object sender, EventArgs e)
        {

        }

        private void boxDelete_Click(object sender, EventArgs e)
        {
            SqlConnection connect = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=winformdb;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");
            connect.Open();
            SqlCommand cmd = new SqlCommand("delete employees where CIN=@CIN ", connect);
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
    }
}

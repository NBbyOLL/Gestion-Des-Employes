namespace Project_dotNet.Forms
{
    partial class adminDaashboard
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adminDaashboard));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            label1 = new Label();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            adminDashboard = new Guna.UI2.WinForms.Guna2Button();
            textBox2 = new TextBox();
            adminEmployees = new Guna.UI2.WinForms.Guna2Button();
            adminExpense = new Guna.UI2.WinForms.Guna2Button();
            adminClients = new Guna.UI2.WinForms.Guna2Button();
            adminSales = new Guna.UI2.WinForms.Guna2Button();
            adminLogout = new Guna.UI2.WinForms.Guna2Button();
            panel2 = new Panel();
            sqlDataAdapter1 = new Microsoft.Data.SqlClient.SqlDataAdapter();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            guna2ContextMenuStrip1 = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Red;
            label1.Font = new Font("Microsoft New Tai Lue", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(1857, 12);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(22, 24);
            label1.TabIndex = 1;
            label1.Text = "X";
            // 
            // panel1
            // 
            panel1.BackColor = Color.MidnightBlue;
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-4, 0);
            panel1.Margin = new Padding(5, 3, 5, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1290, 40);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(1236, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(40, 37);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(116, 8);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(94, 91);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // adminDashboard
            // 
            adminDashboard.BorderColor = Color.White;
            adminDashboard.BorderRadius = 10;
            adminDashboard.BorderThickness = 1;
            adminDashboard.CustomizableEdges = customizableEdges1;
            adminDashboard.DisabledState.BorderColor = Color.DarkGray;
            adminDashboard.DisabledState.CustomBorderColor = Color.DarkGray;
            adminDashboard.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            adminDashboard.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            adminDashboard.FillColor = Color.Transparent;
            adminDashboard.FocusedColor = Color.FromArgb(64, 64, 64);
            adminDashboard.Font = new Font("Segoe UI", 9F);
            adminDashboard.ForeColor = Color.White;
            adminDashboard.Location = new Point(71, 217);
            adminDashboard.Name = "adminDashboard";
            adminDashboard.ShadowDecoration.CustomizableEdges = customizableEdges2;
            adminDashboard.Size = new Size(205, 40);
            adminDashboard.TabIndex = 1;
            adminDashboard.Text = "Dashboard";
            adminDashboard.Click += guna2Button1_Click;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.MidnightBlue;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.ForeColor = Color.White;
            textBox2.Location = new Point(83, 123);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(205, 27);
            textBox2.TabIndex = 2;
            textBox2.Text = "Welcome, Admin";
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // adminEmployees
            // 
            adminEmployees.BorderColor = Color.White;
            adminEmployees.BorderRadius = 10;
            adminEmployees.BorderThickness = 1;
            adminEmployees.CustomizableEdges = customizableEdges3;
            adminEmployees.DisabledState.BorderColor = Color.DarkGray;
            adminEmployees.DisabledState.CustomBorderColor = Color.DarkGray;
            adminEmployees.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            adminEmployees.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            adminEmployees.FillColor = Color.Transparent;
            adminEmployees.Font = new Font("Segoe UI", 9F);
            adminEmployees.ForeColor = Color.White;
            adminEmployees.Location = new Point(71, 277);
            adminEmployees.Name = "adminEmployees";
            adminEmployees.ShadowDecoration.CustomizableEdges = customizableEdges4;
            adminEmployees.Size = new Size(205, 40);
            adminEmployees.TabIndex = 3;
            adminEmployees.Text = "Employee Management";
            adminEmployees.Click += guna2Button2_Click;
            // 
            // adminExpense
            // 
            adminExpense.BorderColor = Color.White;
            adminExpense.BorderRadius = 10;
            adminExpense.BorderThickness = 1;
            adminExpense.CustomizableEdges = customizableEdges5;
            adminExpense.DisabledState.BorderColor = Color.DarkGray;
            adminExpense.DisabledState.CustomBorderColor = Color.DarkGray;
            adminExpense.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            adminExpense.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            adminExpense.FillColor = Color.Transparent;
            adminExpense.Font = new Font("Segoe UI", 9F);
            adminExpense.ForeColor = Color.White;
            adminExpense.Location = new Point(71, 338);
            adminExpense.Name = "adminExpense";
            adminExpense.ShadowDecoration.CustomizableEdges = customizableEdges6;
            adminExpense.Size = new Size(205, 40);
            adminExpense.TabIndex = 4;
            adminExpense.Text = "Expense Management";
            // 
            // adminClients
            // 
            adminClients.BorderColor = Color.White;
            adminClients.BorderRadius = 10;
            adminClients.BorderThickness = 1;
            adminClients.CustomizableEdges = customizableEdges7;
            adminClients.DisabledState.BorderColor = Color.DarkGray;
            adminClients.DisabledState.CustomBorderColor = Color.DarkGray;
            adminClients.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            adminClients.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            adminClients.FillColor = Color.Transparent;
            adminClients.Font = new Font("Segoe UI", 9F);
            adminClients.ForeColor = Color.White;
            adminClients.Location = new Point(71, 397);
            adminClients.Name = "adminClients";
            adminClients.ShadowDecoration.CustomizableEdges = customizableEdges8;
            adminClients.Size = new Size(205, 40);
            adminClients.TabIndex = 5;
            adminClients.Text = "Clients Management";
            // 
            // adminSales
            // 
            adminSales.BorderColor = Color.White;
            adminSales.BorderRadius = 10;
            adminSales.BorderThickness = 1;
            adminSales.CustomizableEdges = customizableEdges9;
            adminSales.DisabledState.BorderColor = Color.DarkGray;
            adminSales.DisabledState.CustomBorderColor = Color.DarkGray;
            adminSales.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            adminSales.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            adminSales.FillColor = Color.Transparent;
            adminSales.Font = new Font("Segoe UI", 9F);
            adminSales.ForeColor = Color.White;
            adminSales.Location = new Point(71, 458);
            adminSales.Name = "adminSales";
            adminSales.ShadowDecoration.CustomizableEdges = customizableEdges10;
            adminSales.Size = new Size(205, 40);
            adminSales.TabIndex = 7;
            adminSales.Text = "Sales Management";
            // 
            // adminLogout
            // 
            adminLogout.BorderColor = Color.White;
            adminLogout.BorderRadius = 10;
            adminLogout.BorderThickness = 1;
            adminLogout.CustomizableEdges = customizableEdges11;
            adminLogout.DisabledState.BorderColor = Color.DarkGray;
            adminLogout.DisabledState.CustomBorderColor = Color.DarkGray;
            adminLogout.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            adminLogout.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            adminLogout.FillColor = Color.Transparent;
            adminLogout.Font = new Font("Segoe UI", 9F);
            adminLogout.ForeColor = Color.White;
            adminLogout.Location = new Point(71, 741);
            adminLogout.Name = "adminLogout";
            adminLogout.ShadowDecoration.CustomizableEdges = customizableEdges12;
            adminLogout.Size = new Size(205, 40);
            adminLogout.TabIndex = 8;
            adminLogout.Text = "Logout";
            adminLogout.Click += adminLogout_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.MidnightBlue;
            panel2.Controls.Add(adminLogout);
            panel2.Controls.Add(adminSales);
            panel2.Controls.Add(adminClients);
            panel2.Controls.Add(adminExpense);
            panel2.Controls.Add(adminEmployees);
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(adminDashboard);
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(-4, 38);
            panel2.Margin = new Padding(5, 3, 5, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(350, 936);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // guna2ContextMenuStrip1
            // 
            guna2ContextMenuStrip1.ImageScalingSize = new Size(20, 20);
            guna2ContextMenuStrip1.Name = "guna2ContextMenuStrip1";
            guna2ContextMenuStrip1.RenderStyle.ArrowColor = Color.FromArgb(151, 143, 255);
            guna2ContextMenuStrip1.RenderStyle.BorderColor = Color.Gainsboro;
            guna2ContextMenuStrip1.RenderStyle.ColorTable = null;
            guna2ContextMenuStrip1.RenderStyle.RoundedEdges = true;
            guna2ContextMenuStrip1.RenderStyle.SelectionArrowColor = Color.White;
            guna2ContextMenuStrip1.RenderStyle.SelectionBackColor = Color.FromArgb(100, 88, 255);
            guna2ContextMenuStrip1.RenderStyle.SelectionForeColor = Color.White;
            guna2ContextMenuStrip1.RenderStyle.SeparatorColor = Color.Gainsboro;
            guna2ContextMenuStrip1.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            guna2ContextMenuStrip1.Size = new Size(61, 4);
            // 
            // adminDaashboard
            // 
            AutoScaleDimensions = new SizeF(13F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1284, 848);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(5, 3, 5, 3);
            Name = "adminDaashboard";
            Text = "admin-Dashboard";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label label1;
        private Panel panel1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Button adminDashboard;
        private TextBox textBox2;
        private Guna.UI2.WinForms.Guna2Button adminEmployees;
        private Guna.UI2.WinForms.Guna2Button adminExpense;
        private Guna.UI2.WinForms.Guna2Button adminClients;
        private Guna.UI2.WinForms.Guna2Button adminSales;
        private Guna.UI2.WinForms.Guna2Button adminLogout;
        private Panel panel2;
        private Microsoft.Data.SqlClient.SqlDataAdapter sqlDataAdapter1;
        private Label employeeCin;
        private Guna.UI2.WinForms.Guna2TextBox boxCin;
        private Label employeefirstName;
        private Guna.UI2.WinForms.Guna2TextBox boxFirstName;
        private Label employeeBirth;
        private Guna.UI2.WinForms.Guna2TextBox boxBirth;
        private Guna.UI2.WinForms.Guna2Button buttonSave;
        private Guna.UI2.WinForms.Guna2DataGridView DataGridView;
        private Guna.UI2.WinForms.Guna2Button boxDelete;
        private Guna.UI2.WinForms.Guna2Button boxUpdate;
        private Label employeePhone;
        private Guna.UI2.WinForms.Guna2TextBox boxphoneNumber;
        private Label employeeSalary;
        private Guna.UI2.WinForms.Guna2TextBox boxSalary;
        private Label employeeAdress;
        private Guna.UI2.WinForms.Guna2TextBox boxAddress;
        private Label employeelastName;
        private Guna.UI2.WinForms.Guna2TextBox boxlastName;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip guna2ContextMenuStrip1;
        private Guna.UI2.WinForms.Guna2Button buttonAdd;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
    }
}
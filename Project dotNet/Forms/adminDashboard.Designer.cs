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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges15 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges16 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges17 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges18 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges19 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges20 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            label1 = new Label();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            adminOverview = new Guna.UI2.WinForms.Guna2Button();
            textBox2 = new TextBox();
            adminEmployees = new Guna.UI2.WinForms.Guna2Button();
            adminCnss = new Guna.UI2.WinForms.Guna2Button();
            adminClients = new Guna.UI2.WinForms.Guna2Button();
            adminLogout = new Guna.UI2.WinForms.Guna2Button();
            panel2 = new Panel();
            pictureBox4 = new PictureBox();
            pictureBox7 = new PictureBox();
            pictureBox6 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox3 = new PictureBox();
            sqlDataAdapter1 = new Microsoft.Data.SqlClient.SqlDataAdapter();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            guna2ContextMenuStrip1 = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            labelEmployeeCount = new Label();
            vacationlabel = new Label();
            pictureBox8 = new PictureBox();
            pictureBox9 = new PictureBox();
            pictureBox10 = new PictureBox();
            labelsalaries = new Label();
            sqlCommand2 = new Microsoft.Data.SqlClient.SqlCommand();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).BeginInit();
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
            panel1.Size = new Size(1289, 40);
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
            // adminOverview
            // 
            adminOverview.AccessibleRole = AccessibleRole.Cursor;
            adminOverview.BorderColor = Color.Aquamarine;
            adminOverview.BorderRadius = 10;
            adminOverview.CustomizableEdges = customizableEdges11;
            adminOverview.DisabledState.BorderColor = Color.DarkGray;
            adminOverview.DisabledState.CustomBorderColor = Color.DarkGray;
            adminOverview.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            adminOverview.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            adminOverview.FillColor = Color.Transparent;
            adminOverview.FocusedColor = Color.FromArgb(64, 64, 64);
            adminOverview.Font = new Font("Segoe UI", 9F);
            adminOverview.ForeColor = Color.White;
            adminOverview.Location = new Point(71, 217);
            adminOverview.Name = "adminOverview";
            adminOverview.ShadowDecoration.CustomizableEdges = customizableEdges12;
            adminOverview.Size = new Size(205, 40);
            adminOverview.TabIndex = 1;
            adminOverview.Text = "Dashboard";
            adminOverview.TextAlign = HorizontalAlignment.Left;
            adminOverview.Click += guna2Button1_Click;
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
            adminEmployees.CustomizableEdges = customizableEdges13;
            adminEmployees.DisabledState.BorderColor = Color.DarkGray;
            adminEmployees.DisabledState.CustomBorderColor = Color.DarkGray;
            adminEmployees.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            adminEmployees.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            adminEmployees.FillColor = Color.Transparent;
            adminEmployees.Font = new Font("Segoe UI", 9F);
            adminEmployees.ForeColor = Color.White;
            adminEmployees.Location = new Point(71, 277);
            adminEmployees.Name = "adminEmployees";
            adminEmployees.ShadowDecoration.CustomizableEdges = customizableEdges14;
            adminEmployees.Size = new Size(205, 40);
            adminEmployees.TabIndex = 3;
            adminEmployees.Text = "Employee Management";
            adminEmployees.TextAlign = HorizontalAlignment.Left;
            adminEmployees.Click += guna2Button2_Click;
            // 
            // adminCnss
            // 
            adminCnss.BorderColor = Color.White;
            adminCnss.BorderRadius = 10;
            adminCnss.CustomizableEdges = customizableEdges15;
            adminCnss.DisabledState.BorderColor = Color.DarkGray;
            adminCnss.DisabledState.CustomBorderColor = Color.DarkGray;
            adminCnss.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            adminCnss.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            adminCnss.FillColor = Color.Transparent;
            adminCnss.Font = new Font("Segoe UI", 9F);
            adminCnss.ForeColor = Color.White;
            adminCnss.Location = new Point(71, 338);
            adminCnss.Name = "adminCnss";
            adminCnss.ShadowDecoration.CustomizableEdges = customizableEdges16;
            adminCnss.Size = new Size(205, 40);
            adminCnss.TabIndex = 4;
            adminCnss.Text = "Declaration CNSS";
            adminCnss.TextAlign = HorizontalAlignment.Left;
            adminCnss.Click += adminExpense_Click;
            // 
            // adminClients
            // 
            adminClients.BorderColor = Color.White;
            adminClients.BorderRadius = 10;
            adminClients.CustomizableEdges = customizableEdges17;
            adminClients.DisabledState.BorderColor = Color.DarkGray;
            adminClients.DisabledState.CustomBorderColor = Color.DarkGray;
            adminClients.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            adminClients.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            adminClients.FillColor = Color.Transparent;
            adminClients.Font = new Font("Segoe UI", 9F);
            adminClients.ForeColor = Color.White;
            adminClients.Location = new Point(71, 397);
            adminClients.Name = "adminClients";
            adminClients.ShadowDecoration.CustomizableEdges = customizableEdges18;
            adminClients.Size = new Size(205, 40);
            adminClients.TabIndex = 5;
            adminClients.Text = " Vacation Management";
            adminClients.TextAlign = HorizontalAlignment.Left;
            adminClients.Click += adminClients_Click;
            // 
            // adminLogout
            // 
            adminLogout.BorderColor = Color.White;
            adminLogout.BorderRadius = 10;
            adminLogout.CustomizableEdges = customizableEdges19;
            adminLogout.DisabledState.BorderColor = Color.DarkGray;
            adminLogout.DisabledState.CustomBorderColor = Color.DarkGray;
            adminLogout.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            adminLogout.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            adminLogout.FillColor = Color.Transparent;
            adminLogout.Font = new Font("Segoe UI", 9F);
            adminLogout.ForeColor = Color.White;
            adminLogout.Location = new Point(71, 741);
            adminLogout.Name = "adminLogout";
            adminLogout.ShadowDecoration.CustomizableEdges = customizableEdges20;
            adminLogout.Size = new Size(205, 40);
            adminLogout.TabIndex = 8;
            adminLogout.Text = "Logout";
            adminLogout.TextAlign = HorizontalAlignment.Left;
            adminLogout.Click += adminLogout_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.MidnightBlue;
            panel2.Controls.Add(pictureBox4);
            panel2.Controls.Add(pictureBox7);
            panel2.Controls.Add(pictureBox6);
            panel2.Controls.Add(pictureBox5);
            panel2.Controls.Add(pictureBox3);
            panel2.Controls.Add(adminLogout);
            panel2.Controls.Add(adminClients);
            panel2.Controls.Add(adminCnss);
            panel2.Controls.Add(adminEmployees);
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(adminOverview);
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(-4, 38);
            panel2.Margin = new Padding(5, 3, 5, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(350, 936);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(16, 750);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(55, 25);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 26;
            pictureBox4.TabStop = false;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(16, 405);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(55, 25);
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox7.TabIndex = 25;
            pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(16, 345);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(55, 25);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 24;
            pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(16, 288);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(55, 25);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 23;
            pictureBox5.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(35, 226);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(41, 25);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 22;
            pictureBox3.TabStop = false;
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
            // labelEmployeeCount
            // 
            labelEmployeeCount.BackColor = Color.FromArgb(255, 102, 196);
            labelEmployeeCount.ForeColor = Color.White;
            labelEmployeeCount.Location = new Point(425, 123);
            labelEmployeeCount.Name = "labelEmployeeCount";
            labelEmployeeCount.Size = new Size(190, 100);
            labelEmployeeCount.TabIndex = 16;
            labelEmployeeCount.Text = "                          \r\n\r\n\r\n\r\n";
            labelEmployeeCount.TextAlign = ContentAlignment.MiddleCenter;
            labelEmployeeCount.Click += labelEmployeeCount_Click;
            // 
            // vacationlabel
            // 
            vacationlabel.BackColor = Color.FromArgb(170, 216, 134);
            vacationlabel.ForeColor = Color.White;
            vacationlabel.Location = new Point(712, 123);
            vacationlabel.Name = "vacationlabel";
            vacationlabel.Size = new Size(190, 100);
            vacationlabel.TabIndex = 16;
            vacationlabel.Text = "                          \r\n \r\n\r\n\r\n";
            vacationlabel.TextAlign = ContentAlignment.MiddleCenter;
            vacationlabel.Click += vacationlabel_Click;
            // 
            // pictureBox8
            // 
            pictureBox8.Image = (Image)resources.GetObject("pictureBox8.Image");
            pictureBox8.Location = new Point(425, 46);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(190, 74);
            pictureBox8.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox8.TabIndex = 17;
            pictureBox8.TabStop = false;
            // 
            // pictureBox9
            // 
            pictureBox9.Image = (Image)resources.GetObject("pictureBox9.Image");
            pictureBox9.Location = new Point(712, 46);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(190, 74);
            pictureBox9.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox9.TabIndex = 18;
            pictureBox9.TabStop = false;
            // 
            // pictureBox10
            // 
            pictureBox10.Image = (Image)resources.GetObject("pictureBox10.Image");
            pictureBox10.Location = new Point(1006, 46);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new Size(190, 74);
            pictureBox10.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox10.TabIndex = 20;
            pictureBox10.TabStop = false;
            // 
            // labelsalaries
            // 
            labelsalaries.BackColor = Color.FromArgb(154, 173, 255);
            labelsalaries.ForeColor = Color.White;
            labelsalaries.Location = new Point(1006, 123);
            labelsalaries.Name = "labelsalaries";
            labelsalaries.Size = new Size(190, 100);
            labelsalaries.TabIndex = 19;
            labelsalaries.Text = "                          \r\n \r\n\r\n\r\n";
            labelsalaries.TextAlign = ContentAlignment.MiddleCenter;
            labelsalaries.Click += label2_Click;
            // 
            // sqlCommand2
            // 
            sqlCommand2.CommandTimeout = 30;
            sqlCommand2.EnableOptimizedParameterBinding = false;
            // 
            // adminDaashboard
            // 
            AutoScaleDimensions = new SizeF(13F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1284, 848);
            Controls.Add(pictureBox10);
            Controls.Add(labelsalaries);
            Controls.Add(pictureBox9);
            Controls.Add(pictureBox8);
            Controls.Add(vacationlabel);
            Controls.Add(labelEmployeeCount);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(5, 3, 5, 3);
            Name = "adminDaashboard";
            Load += adminDaashboard_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label label1;
        private Panel panel1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Button adminOverview;
        private TextBox textBox2;
        private Guna.UI2.WinForms.Guna2Button adminEmployees;
        private Guna.UI2.WinForms.Guna2Button adminCnss;
        private Guna.UI2.WinForms.Guna2Button adminClients;
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
        private Label labelEmployeeCount;
        private PictureBox pictureBox7;
        private PictureBox pictureBox6;
        private PictureBox pictureBox5;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private Label vacationlabel;
        private PictureBox pictureBox8;
        private PictureBox pictureBox9;
        private PictureBox pictureBox10;
        private Label labelsalaries;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand2;
    }
}
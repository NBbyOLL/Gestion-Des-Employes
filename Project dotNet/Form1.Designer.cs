
namespace Project_dotNet
{
    partial class Emsi
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label1 = new Label();
            login_show_password = new CheckBox();
            login = new Button();
            login_password = new TextBox();
            Password = new Label();
            login_role = new ComboBox();
            login_name = new TextBox();
            labelName = new Label();
            Role = new Label();
            loginAccount = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.IndianRed;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(490, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(452, 631);
            panel1.TabIndex = 16;
            panel1.Paint += panel1_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Red;
            label1.Font = new Font("Microsoft New Tai Lue", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(417, 9);
            label1.Name = "label1";
            label1.Size = new Size(22, 24);
            label1.TabIndex = 0;
            label1.Text = "X";
            label1.Click += label1_Click_1;
            // 
            // login_show_password
            // 
            login_show_password.AutoSize = true;
            login_show_password.Location = new Point(247, 378);
            login_show_password.Name = "login_show_password";
            login_show_password.Size = new Size(132, 24);
            login_show_password.TabIndex = 30;
            login_show_password.Text = "Show Password";
            login_show_password.UseVisualStyleBackColor = true;
            // 
            // login
            // 
            login.BackColor = Color.Chartreuse;
            login.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            login.Location = new Point(57, 422);
            login.Name = "login";
            login.Size = new Size(184, 42);
            login.TabIndex = 29;
            login.Text = "Login";
            login.UseVisualStyleBackColor = false;
            login.Click += login_Click;
            // 
            // login_password
            // 
            login_password.Location = new Point(171, 345);
            login_password.Name = "login_password";
            login_password.Size = new Size(216, 27);
            login_password.TabIndex = 28;
            // 
            // Password
            // 
            Password.AutoSize = true;
            Password.BackColor = Color.Transparent;
            Password.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Password.Location = new Point(57, 347);
            Password.Name = "Password";
            Password.Size = new Size(88, 22);
            Password.TabIndex = 27;
            Password.Text = "Password";
            // 
            // login_role
            // 
            login_role.FormattingEnabled = true;
            login_role.Items.AddRange(new object[] { "Admin", "Employee" });
            login_role.Location = new Point(171, 227);
            login_role.Name = "login_role";
            login_role.Size = new Size(216, 28);
            login_role.TabIndex = 26;
            // 
            // login_name
            // 
            login_name.Location = new Point(171, 283);
            login_name.Name = "login_name";
            login_name.Size = new Size(216, 27);
            login_name.TabIndex = 25;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.BackColor = Color.Transparent;
            labelName.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelName.Location = new Point(58, 285);
            labelName.Name = "labelName";
            labelName.Size = new Size(56, 22);
            labelName.TabIndex = 24;
            labelName.Text = "Name";
            // 
            // Role
            // 
            Role.AutoSize = true;
            Role.BackColor = Color.Transparent;
            Role.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Role.Location = new Point(57, 233);
            Role.Name = "Role";
            Role.Size = new Size(48, 22);
            Role.TabIndex = 23;
            Role.Text = "Role";
            // 
            // loginAccount
            // 
            loginAccount.BorderStyle = BorderStyle.None;
            loginAccount.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            loginAccount.Location = new Point(113, 105);
            loginAccount.Name = "loginAccount";
            loginAccount.Size = new Size(245, 38);
            loginAccount.TabIndex = 31;
            loginAccount.Text = "Login Account";
            // 
            // Emsi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(940, 630);
            Controls.Add(loginAccount);
            Controls.Add(login_show_password);
            Controls.Add(login);
            Controls.Add(login_password);
            Controls.Add(Password);
            Controls.Add(login_role);
            Controls.Add(login_name);
            Controls.Add(labelName);
            Controls.Add(Role);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Emsi";
            Text = "Emsi";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion
        private Panel panel1;
        private CheckBox login_show_password;
        private Button login;
        private TextBox login_password;
        private Label Password;
        private ComboBox login_role;
        private TextBox login_name;
        private Label labelName;
        private Label Role;
        private TextBox loginAccount;
        private Label label1;
    }
}


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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Emsi));
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            login_show_password = new CheckBox();
            login_password = new TextBox();
            Password = new Label();
            login_name = new TextBox();
            labelName = new Label();
            loginAccount = new TextBox();
            toolTip1 = new ToolTip(components);
            toolTip2 = new ToolTip(components);
            pictureBox1 = new PictureBox();
            errorProvider1 = new ErrorProvider(components);
            errorProvider2 = new ErrorProvider(components);
            login_button_Click = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.MidnightBlue;
            panel1.Controls.Add(pictureBox2);
            panel1.Location = new Point(499, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(442, 631);
            panel1.TabIndex = 16;
            panel1.Paint += panel1_Paint;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(399, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(40, 32);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // login_show_password
            // 
            login_show_password.AutoSize = true;
            login_show_password.Location = new Point(237, 446);
            login_show_password.Name = "login_show_password";
            login_show_password.Size = new Size(132, 24);
            login_show_password.TabIndex = 30;
            login_show_password.Text = "Show Password";
            login_show_password.UseVisualStyleBackColor = true;
            login_show_password.CheckedChanged += login_show_password_CheckedChanged;
            // 
            // login_password
            // 
            login_password.Location = new Point(161, 413);
            login_password.Name = "login_password";
            login_password.Size = new Size(216, 27);
            login_password.TabIndex = 28;
            login_password.TextChanged += login_password_TextChanged;
            // 
            // Password
            // 
            Password.AutoSize = true;
            Password.BackColor = Color.Transparent;
            Password.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Password.Location = new Point(47, 415);
            Password.Name = "Password";
            Password.Size = new Size(88, 22);
            Password.TabIndex = 27;
            Password.Text = "Password";
            Password.Click += Password_Click;
            // 
            // login_name
            // 
            login_name.Location = new Point(161, 351);
            login_name.Name = "login_name";
            login_name.Size = new Size(216, 27);
            login_name.TabIndex = 25;
            login_name.TextChanged += login_name_TextChanged;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.BackColor = Color.Transparent;
            labelName.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelName.Location = new Point(48, 353);
            labelName.Name = "labelName";
            labelName.Size = new Size(56, 22);
            labelName.TabIndex = 24;
            labelName.Text = "Name";
            // 
            // loginAccount
            // 
            loginAccount.BorderStyle = BorderStyle.None;
            loginAccount.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            loginAccount.Location = new Point(83, 272);
            loginAccount.Name = "loginAccount";
            loginAccount.Size = new Size(245, 38);
            loginAccount.TabIndex = 31;
            loginAccount.Text = "Login Account";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(149, 84);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(167, 117);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 32;
            pictureBox1.TabStop = false;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            errorProvider2.ContainerControl = this;
            // 
            // login_button_Click
            // 
            login_button_Click.BackColor = Color.MidnightBlue;
            login_button_Click.FlatAppearance.BorderColor = Color.White;
            login_button_Click.FlatAppearance.MouseDownBackColor = Color.White;
            login_button_Click.FlatStyle = FlatStyle.Popup;
            login_button_Click.Font = new Font("Microsoft New Tai Lue", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            login_button_Click.ForeColor = Color.White;
            login_button_Click.Location = new Point(68, 488);
            login_button_Click.Name = "login_button_Click";
            login_button_Click.Size = new Size(134, 37);
            login_button_Click.TabIndex = 33;
            login_button_Click.Text = "Login";
            login_button_Click.UseVisualStyleBackColor = false;
            login_button_Click.Click += button1_Click_1;
            // 
            // Emsi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(940, 630);
            Controls.Add(login_button_Click);
            Controls.Add(pictureBox1);
            Controls.Add(loginAccount);
            Controls.Add(login_show_password);
            Controls.Add(login_password);
            Controls.Add(Password);
            Controls.Add(login_name);
            Controls.Add(labelName);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Emsi";
            Text = "Emsi";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion
        private Panel panel1;
        private CheckBox login_show_password;
        private TextBox login_password;
        private Label Password;
        private TextBox login_name;
        private Label labelName;
        private TextBox loginAccount;
        private ToolTip toolTip1;
        private ToolTip toolTip2;
        private PictureBox pictureBox1;
        private ErrorProvider errorProvider1;
        private ErrorProvider errorProvider2;
        private Button login_button_Click;
        private PictureBox pictureBox2;
    }
}

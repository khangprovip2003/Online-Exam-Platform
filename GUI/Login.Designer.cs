namespace GUI
{
    partial class Login
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
            label1 = new Label();
            groupBox1 = new GroupBox();
            label5 = new Label();
            radCandidate = new RadioButton();
            radEmployee = new RadioButton();
            groupBox2 = new GroupBox();
            txtPassWord = new TextBox();
            txtUserName = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            btnLogin = new Button();
            btnRegister = new Button();
            btnChangePassword = new Button();
            btnExit = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Desktop;
            label1.Location = new Point(135, 31);
            label1.Name = "label1";
            label1.Size = new Size(544, 50);
            label1.TabIndex = 0;
            label1.Text = "Online Exam English Platform";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.IndianRed;
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(radCandidate);
            groupBox1.Controls.Add(radEmployee);
            groupBox1.Location = new Point(94, 445);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(653, 100);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 26.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.Window;
            label5.Location = new Point(218, 19);
            label5.Name = "label5";
            label5.Size = new Size(202, 40);
            label5.TabIndex = 2;
            label5.Text = "Select Role";
            // 
            // radCandidate
            // 
            radCandidate.AutoSize = true;
            radCandidate.Checked = true;
            radCandidate.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            radCandidate.ForeColor = SystemColors.Window;
            radCandidate.Location = new Point(467, 54);
            radCandidate.Name = "radCandidate";
            radCandidate.Size = new Size(120, 29);
            radCandidate.TabIndex = 1;
            radCandidate.TabStop = true;
            radCandidate.Text = "Candidate";
            radCandidate.UseVisualStyleBackColor = true;
            radCandidate.CheckedChanged += RoleRadioButton_CheckedChanged;
            // 
            // radEmployee
            // 
            radEmployee.AutoSize = true;
            radEmployee.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            radEmployee.ForeColor = SystemColors.Window;
            radEmployee.Location = new Point(41, 54);
            radEmployee.Name = "radEmployee";
            radEmployee.Size = new Size(116, 29);
            radEmployee.TabIndex = 0;
            radEmployee.Text = "Employee";
            radEmployee.UseVisualStyleBackColor = true;
            radEmployee.CheckedChanged += RoleRadioButton_CheckedChanged;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.IndianRed;
            groupBox2.Controls.Add(txtPassWord);
            groupBox2.Controls.Add(txtUserName);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Location = new Point(94, 134);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(383, 289);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            // 
            // txtPassWord
            // 
            txtPassWord.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassWord.Location = new Point(22, 223);
            txtPassWord.Name = "txtPassWord";
            txtPassWord.PasswordChar = '*';
            txtPassWord.Size = new Size(336, 33);
            txtPassWord.TabIndex = 4;
            // 
            // txtUserName
            // 
            txtUserName.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtUserName.Location = new Point(22, 117);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(336, 33);
            txtUserName.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.Window;
            label4.Location = new Point(22, 178);
            label4.Name = "label4";
            label4.Size = new Size(101, 25);
            label4.TabIndex = 2;
            label4.Text = "Password :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.Window;
            label3.Location = new Point(22, 78);
            label3.Name = "label3";
            label3.Size = new Size(108, 25);
            label3.TabIndex = 1;
            label3.Text = "Username :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 26.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Window;
            label2.Location = new Point(134, 19);
            label2.Name = "label2";
            label2.Size = new Size(110, 40);
            label2.TabIndex = 0;
            label2.Text = "Login";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(192, 192, 0);
            btnLogin.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnLogin.ForeColor = SystemColors.ControlLightLight;
            btnLogin.Location = new Point(522, 212);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(225, 45);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.FromArgb(255, 128, 0);
            btnRegister.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnRegister.ForeColor = SystemColors.ControlLightLight;
            btnRegister.Location = new Point(522, 134);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(225, 48);
            btnRegister.TabIndex = 4;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnChangePassword
            // 
            btnChangePassword.BackColor = Color.Green;
            btnChangePassword.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnChangePassword.ForeColor = SystemColors.ControlLightLight;
            btnChangePassword.Location = new Point(522, 287);
            btnChangePassword.Name = "btnChangePassword";
            btnChangePassword.Size = new Size(225, 50);
            btnChangePassword.TabIndex = 5;
            btnChangePassword.Text = "Change Password";
            btnChangePassword.UseVisualStyleBackColor = false;
            btnChangePassword.Click += btnChangePassword_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Maroon;
            btnExit.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnExit.ForeColor = SystemColors.ControlLightLight;
            btnExit.Location = new Point(522, 371);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(225, 52);
            btnExit.TabIndex = 6;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = SystemColors.Info;
            ClientSize = new Size(829, 559);
            Controls.Add(btnExit);
            Controls.Add(btnChangePassword);
            Controls.Add(btnRegister);
            Controls.Add(btnLogin);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "Login";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtPassWord;
        private TextBox txtUserName;
        private Label label5;
        private RadioButton radCandidate;
        private RadioButton radEmployee;
        private Button btnLogin;
        private Button btnRegister;
        private Button btnChangePassword;
        private Button btnExit;
    }
}

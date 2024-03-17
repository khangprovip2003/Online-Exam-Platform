namespace GUI
{
    partial class Register
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
            groupBox1 = new GroupBox();
            txtRepeatPassword = new TextBox();
            label6 = new Label();
            txtAddress = new TextBox();
            txtPassWord = new TextBox();
            txtUserName = new TextBox();
            txtFullName = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnCreateAccount = new Button();
            btnCancel = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.IndianRed;
            groupBox1.Controls.Add(txtRepeatPassword);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtAddress);
            groupBox1.Controls.Add(txtPassWord);
            groupBox1.Controls.Add(txtUserName);
            groupBox1.Controls.Add(txtFullName);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(50, 55);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(533, 389);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // txtRepeatPassword
            // 
            txtRepeatPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtRepeatPassword.Location = new Point(190, 281);
            txtRepeatPassword.Name = "txtRepeatPassword";
            txtRepeatPassword.PasswordChar = '*';
            txtRepeatPassword.Size = new Size(303, 29);
            txtRepeatPassword.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.Window;
            label6.Location = new Point(6, 281);
            label6.Name = "label6";
            label6.Size = new Size(178, 22);
            label6.TabIndex = 9;
            label6.Text = "Repeat password:";
            // 
            // txtAddress
            // 
            txtAddress.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtAddress.Location = new Point(190, 338);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(303, 29);
            txtAddress.TabIndex = 8;
            // 
            // txtPassWord
            // 
            txtPassWord.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassWord.Location = new Point(191, 222);
            txtPassWord.Name = "txtPassWord";
            txtPassWord.PasswordChar = '*';
            txtPassWord.Size = new Size(303, 29);
            txtPassWord.TabIndex = 7;
            // 
            // txtUserName
            // 
            txtUserName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtUserName.Location = new Point(191, 163);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(303, 29);
            txtUserName.TabIndex = 6;
            // 
            // txtFullName
            // 
            txtFullName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtFullName.Location = new Point(190, 101);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(303, 29);
            txtFullName.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.Window;
            label5.Location = new Point(89, 338);
            label5.Name = "label5";
            label5.Size = new Size(95, 22);
            label5.TabIndex = 4;
            label5.Text = "Address:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.Window;
            label4.Location = new Point(74, 222);
            label4.Name = "label4";
            label4.Size = new Size(110, 22);
            label4.TabIndex = 3;
            label4.Text = "Password:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.Window;
            label3.Location = new Point(74, 163);
            label3.Name = "label3";
            label3.Size = new Size(111, 22);
            label3.TabIndex = 2;
            label3.Text = "Username:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Window;
            label2.Location = new Point(73, 101);
            label2.Name = "label2";
            label2.Size = new Size(103, 22);
            label2.TabIndex = 1;
            label2.Text = "FullName:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 27.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Window;
            label1.Location = new Point(54, 19);
            label1.Name = "label1";
            label1.Size = new Size(434, 50);
            label1.TabIndex = 0;
            label1.Text = "Registration information";
            // 
            // btnCreateAccount
            // 
            btnCreateAccount.BackColor = Color.FromArgb(128, 128, 255);
            btnCreateAccount.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnCreateAccount.ForeColor = SystemColors.Control;
            btnCreateAccount.Location = new Point(66, 463);
            btnCreateAccount.Name = "btnCreateAccount";
            btnCreateAccount.Size = new Size(148, 40);
            btnCreateAccount.TabIndex = 1;
            btnCreateAccount.Text = "Create Account";
            btnCreateAccount.UseVisualStyleBackColor = false;
            btnCreateAccount.Click += btnCreateAccount_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(128, 128, 255);
            btnCancel.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancel.ForeColor = SystemColors.Control;
            btnCancel.Location = new Point(409, 463);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(148, 40);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = SystemColors.Info;
            ClientSize = new Size(620, 514);
            Controls.Add(btnCancel);
            Controls.Add(btnCreateAccount);
            Controls.Add(groupBox1);
            Name = "Register";
            Text = "Register";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private Label label2;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox txtAddress;
        private TextBox txtPassWord;
        private TextBox txtUserName;
        private TextBox txtFullName;
        private Button btnCreateAccount;
        private Button btnCancel;
        private TextBox txtRepeatPassword;
        private Label label6;
    }
}
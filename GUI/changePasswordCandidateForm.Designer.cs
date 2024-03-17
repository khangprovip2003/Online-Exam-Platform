namespace GUI
{
    partial class changePasswordCandidateForm
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
            txtRepeatPass = new TextBox();
            txtNewPass = new TextBox();
            txtOldPass = new TextBox();
            txtUserName = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnSave = new Button();
            btnCancel = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.IndianRed;
            groupBox1.Controls.Add(txtRepeatPass);
            groupBox1.Controls.Add(txtNewPass);
            groupBox1.Controls.Add(txtOldPass);
            groupBox1.Controls.Add(txtUserName);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(53, 33);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(526, 348);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // txtRepeatPass
            // 
            txtRepeatPass.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtRepeatPass.Location = new Point(219, 285);
            txtRepeatPass.Name = "txtRepeatPass";
            txtRepeatPass.PasswordChar = '*';
            txtRepeatPass.Size = new Size(288, 25);
            txtRepeatPass.TabIndex = 8;
            // 
            // txtNewPass
            // 
            txtNewPass.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtNewPass.Location = new Point(219, 219);
            txtNewPass.Name = "txtNewPass";
            txtNewPass.PasswordChar = '*';
            txtNewPass.Size = new Size(288, 25);
            txtNewPass.TabIndex = 7;
            // 
            // txtOldPass
            // 
            txtOldPass.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtOldPass.Location = new Point(219, 154);
            txtOldPass.Name = "txtOldPass";
            txtOldPass.PasswordChar = '*';
            txtOldPass.Size = new Size(288, 25);
            txtOldPass.TabIndex = 6;
            // 
            // txtUserName
            // 
            txtUserName.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtUserName.Location = new Point(219, 91);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(288, 25);
            txtUserName.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(6, 282);
            label5.Name = "label5";
            label5.Size = new Size(196, 25);
            label5.TabIndex = 4;
            label5.Text = "Repeat new password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(66, 216);
            label4.Name = "label4";
            label4.Size = new Size(136, 25);
            label4.TabIndex = 3;
            label4.Text = "New password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(70, 151);
            label3.Name = "label3";
            label3.Size = new Size(132, 25);
            label3.TabIndex = 2;
            label3.Text = "Old password ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(90, 88);
            label2.Name = "label2";
            label2.Size = new Size(102, 25);
            label2.TabIndex = 1;
            label2.Text = "UserName";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(16, 19);
            label1.Name = "label1";
            label1.Size = new Size(489, 47);
            label1.TabIndex = 0;
            label1.Text = "Change Password Candidate";
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(128, 128, 255);
            btnSave.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.ForeColor = SystemColors.ControlLightLight;
            btnSave.Location = new Point(59, 406);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(176, 34);
            btnSave.TabIndex = 1;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(128, 64, 64);
            btnCancel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancel.ForeColor = SystemColors.ControlLightLight;
            btnCancel.Location = new Point(384, 406);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(176, 34);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // changePasswordCandidateForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = SystemColors.Info;
            ClientSize = new Size(635, 466);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(groupBox1);
            Name = "changePasswordCandidateForm";
            Text = "ChangePassword";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label5;
        private TextBox txtUserName;
        private TextBox txtRepeatPass;
        private TextBox txtNewPass;
        private TextBox txtOldPass;
        private Button btnSave;
        private Button btnCancel;
    }
}
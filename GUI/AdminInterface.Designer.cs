namespace GUI
{
    partial class AdminInterface
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
            label1 = new Label();
            groupBox1 = new GroupBox();
            txtPhoneNumber = new TextBox();
            txtID = new TextBox();
            label8 = new Label();
            txtAddress = new TextBox();
            label9 = new Label();
            label4 = new Label();
            txtPassWord = new TextBox();
            label7 = new Label();
            txtUserName = new TextBox();
            label6 = new Label();
            txtFullName = new TextBox();
            label5 = new Label();
            label2 = new Label();
            groupBox2 = new GroupBox();
            btnSearch = new Button();
            txtKeyword = new TextBox();
            label10 = new Label();
            label3 = new Label();
            dgvTeacher = new DataGridView();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnExit = new Button();
            btnListTeacher = new Button();
            btnClear = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTeacher).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(23, 20);
            label1.Name = "label1";
            label1.Size = new Size(322, 50);
            label1.TabIndex = 0;
            label1.Text = "Teacher Manager";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.IndianRed;
            groupBox1.Controls.Add(txtPhoneNumber);
            groupBox1.Controls.Add(txtID);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(txtAddress);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtPassWord);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtUserName);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtFullName);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(23, 100);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(479, 424);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(164, 385);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(280, 23);
            txtPhoneNumber.TabIndex = 17;
            txtPhoneNumber.Leave += txtPhoneNumber_Leave;
            // 
            // txtID
            // 
            txtID.Location = new Point(164, 89);
            txtID.Name = "txtID";
            txtID.ReadOnly = true;
            txtID.Size = new Size(280, 23);
            txtID.TabIndex = 16;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.HighlightText;
            label8.Location = new Point(27, 84);
            label8.Name = "label8";
            label8.Size = new Size(116, 25);
            label8.TabIndex = 15;
            label8.Text = "EmployeeID";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(164, 331);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(280, 23);
            txtAddress.TabIndex = 13;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = SystemColors.HighlightText;
            label9.Location = new Point(6, 380);
            label9.Name = "label9";
            label9.Size = new Size(137, 25);
            label9.TabIndex = 12;
            label9.Text = "PhoneNumber";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.HighlightText;
            label4.Location = new Point(56, 326);
            label4.Name = "label4";
            label4.Size = new Size(80, 25);
            label4.TabIndex = 11;
            label4.Text = "Address";
            // 
            // txtPassWord
            // 
            txtPassWord.Location = new Point(164, 269);
            txtPassWord.Name = "txtPassWord";
            txtPassWord.Size = new Size(280, 23);
            txtPassWord.TabIndex = 8;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.HighlightText;
            label7.Location = new Point(45, 269);
            label7.Name = "label7";
            label7.Size = new Size(91, 25);
            label7.TabIndex = 7;
            label7.Text = "Password";
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(164, 208);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(280, 23);
            txtUserName.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.HighlightText;
            label6.Location = new Point(38, 208);
            label6.Name = "label6";
            label6.Size = new Size(98, 25);
            label6.TabIndex = 5;
            label6.Text = "Username";
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(164, 146);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(280, 23);
            txtFullName.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.HighlightText;
            label5.Location = new Point(45, 141);
            label5.Name = "label5";
            label5.Size = new Size(95, 25);
            label5.TabIndex = 3;
            label5.Text = "FullName";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.HighlightText;
            label2.Location = new Point(105, 19);
            label2.Name = "label2";
            label2.Size = new Size(213, 37);
            label2.TabIndex = 0;
            label2.Text = "Teacher Info";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.IndianRed;
            groupBox2.Controls.Add(btnSearch);
            groupBox2.Controls.Add(txtKeyword);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label3);
            groupBox2.Location = new Point(518, 100);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(487, 97);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.RosyBrown;
            btnSearch.Font = new Font("Arial", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnSearch.ForeColor = Color.Honeydew;
            btnSearch.Location = new Point(294, 53);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(169, 29);
            btnSearch.TabIndex = 9;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtKeyword
            // 
            txtKeyword.Location = new Point(99, 57);
            txtKeyword.Name = "txtKeyword";
            txtKeyword.Size = new Size(176, 23);
            txtKeyword.TabIndex = 5;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = SystemColors.HighlightText;
            label10.Location = new Point(6, 57);
            label10.Name = "label10";
            label10.Size = new Size(87, 25);
            label10.TabIndex = 4;
            label10.Text = "Keyword";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.HighlightText;
            label3.Location = new Point(171, 9);
            label3.Name = "label3";
            label3.Size = new Size(104, 32);
            label3.TabIndex = 1;
            label3.Text = "Search";
            // 
            // dgvTeacher
            // 
            dgvTeacher.BackgroundColor = SystemColors.ControlLightLight;
            dgvTeacher.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTeacher.Location = new Point(518, 212);
            dgvTeacher.Name = "dgvTeacher";
            dgvTeacher.RowTemplate.Height = 25;
            dgvTeacher.Size = new Size(487, 312);
            dgvTeacher.TabIndex = 4;
            dgvTeacher.SelectionChanged += dgvTeacher_SelectionChanged;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(128, 128, 255);
            btnAdd.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.ForeColor = SystemColors.HighlightText;
            btnAdd.Location = new Point(12, 537);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(154, 33);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(128, 128, 255);
            btnUpdate.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdate.ForeColor = SystemColors.HighlightText;
            btnUpdate.Location = new Point(187, 537);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(157, 33);
            btnUpdate.TabIndex = 6;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(128, 128, 255);
            btnDelete.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.ForeColor = SystemColors.HighlightText;
            btnDelete.Location = new Point(350, 537);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(152, 33);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.FromArgb(128, 64, 64);
            btnExit.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnExit.ForeColor = SystemColors.HighlightText;
            btnExit.Location = new Point(862, 537);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(143, 33);
            btnExit.TabIndex = 8;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnListTeacher
            // 
            btnListTeacher.BackColor = Color.FromArgb(128, 128, 255);
            btnListTeacher.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnListTeacher.ForeColor = SystemColors.HighlightText;
            btnListTeacher.Location = new Point(518, 537);
            btnListTeacher.Name = "btnListTeacher";
            btnListTeacher.Size = new Size(149, 33);
            btnListTeacher.TabIndex = 9;
            btnListTeacher.Text = "Display List Teacher";
            btnListTeacher.UseVisualStyleBackColor = false;
            btnListTeacher.Click += btnListTeacher_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(128, 128, 255);
            btnClear.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnClear.ForeColor = SystemColors.HighlightText;
            btnClear.Location = new Point(689, 537);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(149, 33);
            btnClear.TabIndex = 10;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // AdminInterface
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = SystemColors.Info;
            ClientSize = new Size(1044, 597);
            Controls.Add(btnClear);
            Controls.Add(btnListTeacher);
            Controls.Add(btnExit);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(dgvTeacher);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "AdminInterface";
            Text = "AdminInterface";
            Load += AdminInterface_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTeacher).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label2;
        private Label label3;
        private DataGridView dgvTeacher;
        private Label label5;
        private TextBox txtFullName;
        private Label label6;
        private TextBox txtUserName;
        private Label label7;
        private TextBox txtPassWord;
        private TextBox txtAddress;
        private Label label9;
        private Label label4;
        private TextBox txtKeyword;
        private Label label10;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnExit;
        private Button btnSearch;
        private TextBox txtID;
        private Label label8;
        private Button btnListTeacher;
        private Button btnClear;
        private TextBox txtPhoneNumber;
    }
}
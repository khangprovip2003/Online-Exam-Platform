namespace GUI
{
    partial class CandidatesManagement
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
            txtAddress = new TextBox();
            txtPassWord = new TextBox();
            txtUserName = new TextBox();
            txtFullName = new TextBox();
            txtID = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            groupBox2 = new GroupBox();
            btnSearch = new Button();
            txtKeyWord = new TextBox();
            label9 = new Label();
            label8 = new Label();
            dgvCandidates = new DataGridView();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnList = new Button();
            btnClear = new Button();
            btnExit = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCandidates).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 27.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(12, 19);
            label1.Name = "label1";
            label1.Size = new Size(385, 42);
            label1.TabIndex = 0;
            label1.Text = "Candidates manager";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Coral;
            groupBox1.Controls.Add(txtAddress);
            groupBox1.Controls.Add(txtPassWord);
            groupBox1.Controls.Add(txtUserName);
            groupBox1.Controls.Add(txtFullName);
            groupBox1.Controls.Add(txtID);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(12, 94);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(524, 360);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(178, 308);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(295, 23);
            txtAddress.TabIndex = 10;
            // 
            // txtPassWord
            // 
            txtPassWord.Location = new Point(178, 255);
            txtPassWord.Name = "txtPassWord";
            txtPassWord.Size = new Size(295, 23);
            txtPassWord.TabIndex = 9;
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(178, 203);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(295, 23);
            txtUserName.TabIndex = 8;
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(178, 146);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(295, 23);
            txtFullName.TabIndex = 7;
            // 
            // txtID
            // 
            txtID.Location = new Point(178, 89);
            txtID.Name = "txtID";
            txtID.ReadOnly = true;
            txtID.Size = new Size(295, 23);
            txtID.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 26.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.HighlightText;
            label7.Location = new Point(141, 19);
            label7.Name = "label7";
            label7.Size = new Size(257, 40);
            label7.TabIndex = 5;
            label7.Text = "Candidate Info";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.HighlightText;
            label6.Location = new Point(49, 308);
            label6.Name = "label6";
            label6.Size = new Size(86, 24);
            label6.TabIndex = 4;
            label6.Text = "Address";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.HighlightText;
            label5.Location = new Point(30, 255);
            label5.Name = "label5";
            label5.Size = new Size(103, 24);
            label5.TabIndex = 3;
            label5.Text = "Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.HighlightText;
            label4.Location = new Point(30, 199);
            label4.Name = "label4";
            label4.Size = new Size(105, 24);
            label4.TabIndex = 2;
            label4.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.HighlightText;
            label3.Location = new Point(37, 142);
            label3.Name = "label3";
            label3.Size = new Size(96, 24);
            label3.TabIndex = 1;
            label3.Text = "FullName";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.HighlightText;
            label2.Location = new Point(16, 85);
            label2.Name = "label2";
            label2.Size = new Size(126, 24);
            label2.TabIndex = 0;
            label2.Text = "CandidateID";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Coral;
            groupBox2.Controls.Add(btnSearch);
            groupBox2.Controls.Add(txtKeyWord);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label8);
            groupBox2.Location = new Point(556, 94);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(566, 97);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.Olive;
            btnSearch.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnSearch.ForeColor = SystemColors.HighlightText;
            btnSearch.Location = new Point(386, 65);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(174, 26);
            btnSearch.TabIndex = 9;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtKeyWord
            // 
            txtKeyWord.Location = new Point(152, 65);
            txtKeyWord.Name = "txtKeyWord";
            txtKeyWord.Size = new Size(228, 23);
            txtKeyWord.TabIndex = 8;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = SystemColors.HighlightText;
            label9.Location = new Point(6, 65);
            label9.Name = "label9";
            label9.Size = new Size(126, 24);
            label9.TabIndex = 7;
            label9.Text = "CandidateID";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.HighlightText;
            label8.Location = new Point(164, 19);
            label8.Name = "label8";
            label8.Size = new Size(91, 28);
            label8.TabIndex = 6;
            label8.Text = "Search";
            // 
            // dgvCandidates
            // 
            dgvCandidates.BackgroundColor = SystemColors.ControlLightLight;
            dgvCandidates.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCandidates.Location = new Point(553, 208);
            dgvCandidates.Name = "dgvCandidates";
            dgvCandidates.RowTemplate.Height = 25;
            dgvCandidates.Size = new Size(569, 246);
            dgvCandidates.TabIndex = 3;
            dgvCandidates.SelectionChanged += dgvCandidates_SelectionChanged;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(128, 128, 255);
            btnAdd.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.ForeColor = SystemColors.HighlightText;
            btnAdd.Location = new Point(12, 475);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(168, 36);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(128, 128, 255);
            btnUpdate.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdate.ForeColor = SystemColors.HighlightText;
            btnUpdate.Location = new Point(190, 475);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(168, 36);
            btnUpdate.TabIndex = 5;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(128, 128, 255);
            btnDelete.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.ForeColor = SystemColors.HighlightText;
            btnDelete.Location = new Point(368, 475);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(168, 36);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnList
            // 
            btnList.BackColor = Color.FromArgb(128, 128, 255);
            btnList.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnList.ForeColor = SystemColors.HighlightText;
            btnList.Location = new Point(571, 475);
            btnList.Name = "btnList";
            btnList.Size = new Size(168, 36);
            btnList.TabIndex = 7;
            btnList.Text = "Display List";
            btnList.UseVisualStyleBackColor = false;
            btnList.Click += btnList_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(128, 128, 255);
            btnClear.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnClear.ForeColor = SystemColors.HighlightText;
            btnClear.Location = new Point(768, 475);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(168, 36);
            btnClear.TabIndex = 8;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.FromArgb(128, 64, 0);
            btnExit.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnExit.ForeColor = SystemColors.HighlightText;
            btnExit.Location = new Point(954, 475);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(168, 36);
            btnExit.TabIndex = 9;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // CandidatesManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = SystemColors.Info;
            ClientSize = new Size(1134, 539);
            Controls.Add(btnExit);
            Controls.Add(btnClear);
            Controls.Add(btnList);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(dgvCandidates);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            ForeColor = SystemColors.InfoText;
            Name = "CandidatesManagement";
            Text = "CandidatesManagement";
            Load += CandidatesManagement1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCandidates).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label7;
        private Label label9;
        private Label label8;
        private TextBox txtKeyWord;
        private DataGridView dgvCandidates;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnList;
        private Button btnClear;
        private Button btnExit;
        private Button btnSearch;
        private TextBox txtAddress;
        private TextBox txtPassWord;
        private TextBox txtUserName;
        private TextBox txtFullName;
        private TextBox txtID;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
    }
}
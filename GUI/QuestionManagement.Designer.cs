namespace GUI
{
    partial class QuestionManagement
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
            dgvQuestion = new DataGridView();
            groupBox2 = new GroupBox();
            dgvAnswers = new DataGridView();
            groupBox4 = new GroupBox();
            cobSubject = new ComboBox();
            label3 = new Label();
            txtContextQuestion = new TextBox();
            label2 = new Label();
            groupBox3 = new GroupBox();
            btnUpdateAnswer = new Button();
            radAns4 = new RadioButton();
            radAns3 = new RadioButton();
            radAns2 = new RadioButton();
            radAns1 = new RadioButton();
            txtAns4 = new TextBox();
            txtAns2 = new TextBox();
            txtAns3 = new TextBox();
            txtAns1 = new TextBox();
            label4 = new Label();
            btnExit = new Button();
            btnClear = new Button();
            btnList = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            groupBox5 = new GroupBox();
            btnSearch = new Button();
            label5 = new Label();
            txtKeyword = new TextBox();
            label6 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvQuestion).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAnswers).BeginInit();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox5.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(21, 21);
            label1.Name = "label1";
            label1.Size = new Size(340, 50);
            label1.TabIndex = 0;
            label1.Text = "Question Manager";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgvQuestion);
            groupBox1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.ForeColor = Color.IndianRed;
            groupBox1.Location = new Point(12, 102);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(511, 315);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Information Questions";
            // 
            // dgvQuestion
            // 
            dgvQuestion.BackgroundColor = SystemColors.ControlLightLight;
            dgvQuestion.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvQuestion.Location = new Point(9, 28);
            dgvQuestion.Name = "dgvQuestion";
            dgvQuestion.RowTemplate.Height = 25;
            dgvQuestion.Size = new Size(485, 267);
            dgvQuestion.TabIndex = 0;
            dgvQuestion.SelectionChanged += dgvQuestion_SelectionChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgvAnswers);
            groupBox2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            groupBox2.ForeColor = Color.IndianRed;
            groupBox2.Location = new Point(573, 102);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(511, 315);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Information Answers";
            // 
            // dgvAnswers
            // 
            dgvAnswers.BackgroundColor = SystemColors.ControlLightLight;
            dgvAnswers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAnswers.Location = new Point(17, 28);
            dgvAnswers.Name = "dgvAnswers";
            dgvAnswers.RowTemplate.Height = 25;
            dgvAnswers.Size = new Size(477, 267);
            dgvAnswers.TabIndex = 1;
            // 
            // groupBox4
            // 
            groupBox4.BackColor = Color.IndianRed;
            groupBox4.Controls.Add(cobSubject);
            groupBox4.Controls.Add(label3);
            groupBox4.Controls.Add(txtContextQuestion);
            groupBox4.Controls.Add(label2);
            groupBox4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            groupBox4.ForeColor = SystemColors.HighlightText;
            groupBox4.Location = new Point(12, 435);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(511, 173);
            groupBox4.TabIndex = 4;
            groupBox4.TabStop = false;
            groupBox4.Text = "Content Questions ";
            // 
            // cobSubject
            // 
            cobSubject.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            cobSubject.FormattingEnabled = true;
            cobSubject.Location = new Point(165, 112);
            cobSubject.Name = "cobSubject";
            cobSubject.Size = new Size(316, 24);
            cobSubject.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 115);
            label3.Name = "label3";
            label3.Size = new Size(65, 21);
            label3.TabIndex = 2;
            label3.Text = "Subject:";
            // 
            // txtContextQuestion
            // 
            txtContextQuestion.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtContextQuestion.Location = new Point(160, 56);
            txtContextQuestion.Name = "txtContextQuestion";
            txtContextQuestion.Size = new Size(321, 22);
            txtContextQuestion.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 55);
            label2.Name = "label2";
            label2.Size = new Size(148, 21);
            label2.TabIndex = 0;
            label2.Text = "Content Question : ";
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.IndianRed;
            groupBox3.Controls.Add(btnUpdateAnswer);
            groupBox3.Controls.Add(radAns4);
            groupBox3.Controls.Add(radAns3);
            groupBox3.Controls.Add(radAns2);
            groupBox3.Controls.Add(radAns1);
            groupBox3.Controls.Add(txtAns4);
            groupBox3.Controls.Add(txtAns2);
            groupBox3.Controls.Add(txtAns3);
            groupBox3.Controls.Add(txtAns1);
            groupBox3.Controls.Add(label4);
            groupBox3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            groupBox3.ForeColor = SystemColors.HighlightText;
            groupBox3.Location = new Point(573, 435);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(511, 184);
            groupBox3.TabIndex = 5;
            groupBox3.TabStop = false;
            groupBox3.Text = "Content  Answers";
            // 
            // btnUpdateAnswer
            // 
            btnUpdateAnswer.BackColor = Color.Olive;
            btnUpdateAnswer.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnUpdateAnswer.ForeColor = SystemColors.HighlightText;
            btnUpdateAnswer.Location = new Point(26, 115);
            btnUpdateAnswer.Name = "btnUpdateAnswer";
            btnUpdateAnswer.Size = new Size(159, 35);
            btnUpdateAnswer.TabIndex = 11;
            btnUpdateAnswer.Text = "Update Answer";
            btnUpdateAnswer.UseVisualStyleBackColor = false;
            btnUpdateAnswer.Click += btnUpdateAnswer_Click;
            // 
            // radAns4
            // 
            radAns4.AutoSize = true;
            radAns4.Location = new Point(214, 150);
            radAns4.Name = "radAns4";
            radAns4.Size = new Size(14, 13);
            radAns4.TabIndex = 9;
            radAns4.TabStop = true;
            radAns4.UseVisualStyleBackColor = true;
            // 
            // radAns3
            // 
            radAns3.AutoSize = true;
            radAns3.Location = new Point(214, 115);
            radAns3.Name = "radAns3";
            radAns3.Size = new Size(14, 13);
            radAns3.TabIndex = 8;
            radAns3.TabStop = true;
            radAns3.UseVisualStyleBackColor = true;
            // 
            // radAns2
            // 
            radAns2.AutoSize = true;
            radAns2.Location = new Point(214, 77);
            radAns2.Name = "radAns2";
            radAns2.Size = new Size(14, 13);
            radAns2.TabIndex = 7;
            radAns2.TabStop = true;
            radAns2.UseVisualStyleBackColor = true;
            // 
            // radAns1
            // 
            radAns1.AutoSize = true;
            radAns1.Location = new Point(214, 37);
            radAns1.Name = "radAns1";
            radAns1.Size = new Size(14, 13);
            radAns1.TabIndex = 6;
            radAns1.TabStop = true;
            radAns1.UseVisualStyleBackColor = true;
            // 
            // txtAns4
            // 
            txtAns4.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtAns4.Location = new Point(259, 141);
            txtAns4.Name = "txtAns4";
            txtAns4.Size = new Size(235, 22);
            txtAns4.TabIndex = 5;
            // 
            // txtAns2
            // 
            txtAns2.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtAns2.Location = new Point(259, 68);
            txtAns2.Name = "txtAns2";
            txtAns2.Size = new Size(235, 22);
            txtAns2.TabIndex = 4;
            // 
            // txtAns3
            // 
            txtAns3.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtAns3.Location = new Point(259, 105);
            txtAns3.Name = "txtAns3";
            txtAns3.Size = new Size(235, 22);
            txtAns3.TabIndex = 3;
            // 
            // txtAns1
            // 
            txtAns1.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtAns1.Location = new Point(259, 28);
            txtAns1.Name = "txtAns1";
            txtAns1.Size = new Size(235, 22);
            txtAns1.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(49, 56);
            label4.Name = "label4";
            label4.Size = new Size(118, 29);
            label4.TabIndex = 1;
            label4.Text = "Content: ";
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.FromArgb(128, 64, 64);
            btnExit.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnExit.ForeColor = SystemColors.HighlightText;
            btnExit.Location = new Point(364, 703);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(159, 35);
            btnExit.TabIndex = 6;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(128, 128, 255);
            btnClear.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnClear.ForeColor = SystemColors.HighlightText;
            btnClear.Location = new Point(187, 703);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(159, 35);
            btnClear.TabIndex = 7;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnList
            // 
            btnList.BackColor = Color.FromArgb(128, 128, 255);
            btnList.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnList.ForeColor = SystemColors.HighlightText;
            btnList.Location = new Point(12, 703);
            btnList.Name = "btnList";
            btnList.Size = new Size(159, 35);
            btnList.TabIndex = 8;
            btnList.Text = "Display List";
            btnList.UseVisualStyleBackColor = false;
            btnList.Click += btnList_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(128, 128, 255);
            btnDelete.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnDelete.ForeColor = SystemColors.HighlightText;
            btnDelete.Location = new Point(364, 644);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(159, 35);
            btnDelete.TabIndex = 9;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(128, 128, 255);
            btnUpdate.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnUpdate.ForeColor = SystemColors.HighlightText;
            btnUpdate.Location = new Point(187, 644);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(159, 35);
            btnUpdate.TabIndex = 10;
            btnUpdate.Text = "Update Question";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(128, 128, 255);
            btnAdd.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnAdd.ForeColor = SystemColors.HighlightText;
            btnAdd.Location = new Point(12, 644);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(159, 35);
            btnAdd.TabIndex = 11;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // groupBox5
            // 
            groupBox5.BackColor = Color.IndianRed;
            groupBox5.Controls.Add(btnSearch);
            groupBox5.Controls.Add(label5);
            groupBox5.Controls.Add(txtKeyword);
            groupBox5.Controls.Add(label6);
            groupBox5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            groupBox5.ForeColor = SystemColors.HighlightText;
            groupBox5.Location = new Point(573, 625);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(511, 113);
            groupBox5.TabIndex = 12;
            groupBox5.TabStop = false;
            groupBox5.Text = "Search";
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.Peru;
            btnSearch.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnSearch.ForeColor = SystemColors.HighlightText;
            btnSearch.Location = new Point(334, 52);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(162, 27);
            btnSearch.TabIndex = 12;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(78, 104);
            label5.Name = "label5";
            label5.Size = new Size(0, 21);
            label5.TabIndex = 2;
            // 
            // txtKeyword
            // 
            txtKeyword.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtKeyword.Location = new Point(96, 57);
            txtKeyword.Name = "txtKeyword";
            txtKeyword.Size = new Size(232, 22);
            txtKeyword.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 56);
            label6.Name = "label6";
            label6.Size = new Size(84, 21);
            label6.TabIndex = 0;
            label6.Text = "Keyword : ";
            // 
            // QuestionManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = SystemColors.Info;
            ClientSize = new Size(1099, 752);
            Controls.Add(groupBox5);
            Controls.Add(btnAdd);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnList);
            Controls.Add(btnClear);
            Controls.Add(btnExit);
            Controls.Add(groupBox3);
            Controls.Add(groupBox4);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "QuestionManagement";
            Text = "QuestionManagement";
            Load += QuestionManagement_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvQuestion).EndInit();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvAnswers).EndInit();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private DataGridView dgvQuestion;
        private DataGridView dgvAnswers;
        private GroupBox groupBox4;
        private GroupBox groupBox3;
        private Label label2;
        private TextBox txtContextQuestion;
        private Label label3;
        private TextBox txtAns4;
        private TextBox txtAns2;
        private TextBox txtAns3;
        private TextBox txtAns1;
        private Label label4;
        private RadioButton radAns1;
        private RadioButton radAns4;
        private RadioButton radAns3;
        private RadioButton radAns2;
        private Button btnExit;
        private Button btnClear;
        private Button btnList;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
        private GroupBox groupBox5;
        private Button btnSearch;
        private Label label5;
        private TextBox txtKeyword;
        private Label label6;
        private ComboBox cobSubject;
        private Button btnUpdateAnswer;
    }
}
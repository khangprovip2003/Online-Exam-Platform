namespace GUI
{
    partial class ScoreCandidate
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
            btnExit = new Button();
            btnList = new Button();
            dgvScore = new DataGridView();
            groupBox2 = new GroupBox();
            dtpDateTime = new DateTimePicker();
            btnSearch = new Button();
            label9 = new Label();
            label8 = new Label();
            groupBox1 = new GroupBox();
            txtScore = new TextBox();
            label7 = new Label();
            label4 = new Label();
            label5 = new Label();
            dtpExamDate = new DateTimePicker();
            label2 = new Label();
            cobSubject = new ComboBox();
            txtFullName = new TextBox();
            label3 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvScore).BeginInit();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.FromArgb(128, 64, 0);
            btnExit.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnExit.ForeColor = SystemColors.HighlightText;
            btnExit.Location = new Point(958, 472);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(168, 36);
            btnExit.TabIndex = 19;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnList
            // 
            btnList.BackColor = Color.DarkSeaGreen;
            btnList.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnList.ForeColor = SystemColors.HighlightText;
            btnList.Location = new Point(16, 470);
            btnList.Name = "btnList";
            btnList.Size = new Size(168, 36);
            btnList.TabIndex = 17;
            btnList.Text = "Display List Score";
            btnList.UseVisualStyleBackColor = false;
            btnList.Click += btnList_Click;
            // 
            // dgvScore
            // 
            dgvScore.BackgroundColor = SystemColors.ControlLightLight;
            dgvScore.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvScore.Location = new Point(557, 205);
            dgvScore.Name = "dgvScore";
            dgvScore.RowTemplate.Height = 25;
            dgvScore.Size = new Size(569, 246);
            dgvScore.TabIndex = 13;
            dgvScore.SelectionChanged += dgvScore_SelectionChanged;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.DarkSeaGreen;
            groupBox2.Controls.Add(dtpDateTime);
            groupBox2.Controls.Add(btnSearch);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label8);
            groupBox2.Location = new Point(560, 91);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(566, 97);
            groupBox2.TabIndex = 12;
            groupBox2.TabStop = false;
            // 
            // dtpDateTime
            // 
            dtpDateTime.CustomFormat = "dd/mm/yyyy";
            dtpDateTime.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dtpDateTime.Format = DateTimePickerFormat.Short;
            dtpDateTime.Location = new Point(132, 64);
            dtpDateTime.Name = "dtpDateTime";
            dtpDateTime.Size = new Size(248, 27);
            dtpDateTime.TabIndex = 26;
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
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = SystemColors.HighlightText;
            label9.Location = new Point(6, 65);
            label9.Name = "label9";
            label9.Size = new Size(111, 24);
            label9.TabIndex = 7;
            label9.Text = "DATETIME";
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
            // groupBox1
            // 
            groupBox1.BackColor = Color.DarkSeaGreen;
            groupBox1.Controls.Add(txtScore);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(dtpExamDate);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(cobSubject);
            groupBox1.Controls.Add(txtFullName);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(16, 91);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(524, 360);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            // 
            // txtScore
            // 
            txtScore.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtScore.Location = new Point(156, 287);
            txtScore.Name = "txtScore";
            txtScore.ReadOnly = true;
            txtScore.Size = new Size(277, 27);
            txtScore.TabIndex = 27;
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
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(70, 287);
            label4.Name = "label4";
            label4.Size = new Size(59, 25);
            label4.TabIndex = 26;
            label4.Text = "Score";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(34, 102);
            label5.Name = "label5";
            label5.Size = new Size(95, 25);
            label5.TabIndex = 20;
            label5.Text = "FullName";
            // 
            // dtpExamDate
            // 
            dtpExamDate.CustomFormat = "dd/mm/yyyy";
            dtpExamDate.Enabled = false;
            dtpExamDate.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dtpExamDate.Format = DateTimePickerFormat.Short;
            dtpExamDate.Location = new Point(156, 223);
            dtpExamDate.Name = "dtpExamDate";
            dtpExamDate.Size = new Size(274, 27);
            dtpExamDate.TabIndex = 25;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(34, 223);
            label2.Name = "label2";
            label2.Size = new Size(100, 25);
            label2.TabIndex = 21;
            label2.Text = "ExamDate";
            // 
            // cobSubject
            // 
            cobSubject.Enabled = false;
            cobSubject.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            cobSubject.FormattingEnabled = true;
            cobSubject.Location = new Point(153, 166);
            cobSubject.Name = "cobSubject";
            cobSubject.Size = new Size(277, 28);
            cobSubject.TabIndex = 24;
            // 
            // txtFullName
            // 
            txtFullName.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtFullName.Location = new Point(153, 103);
            txtFullName.Name = "txtFullName";
            txtFullName.ReadOnly = true;
            txtFullName.Size = new Size(277, 27);
            txtFullName.TabIndex = 22;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(54, 165);
            label3.Name = "label3";
            label3.Size = new Size(75, 25);
            label3.TabIndex = 23;
            label3.Text = "Subject";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 27.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(16, 28);
            label1.Name = "label1";
            label1.Size = new Size(241, 42);
            label1.TabIndex = 10;
            label1.Text = "Exam Result";
            // 
            // ScoreCandidate
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = SystemColors.Info;
            ClientSize = new Size(1147, 513);
            Controls.Add(btnExit);
            Controls.Add(btnList);
            Controls.Add(dgvScore);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "ScoreCandidate";
            Text = "ScoreCandidate";
            Load += ScoreCandidate_Load;
            ((System.ComponentModel.ISupportInitialize)dgvScore).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnExit;
        private Button btnList;
        private DataGridView dgvScore;
        private GroupBox groupBox2;
        private Button btnSearch;
        private Label label9;
        private Label label8;
        private GroupBox groupBox1;
        private Label label7;
        private Label label1;
        private TextBox txtScore;
        private Label label4;
        private Label label5;
        private DateTimePicker dtpExamDate;
        private Label label2;
        private ComboBox cobSubject;
        private TextBox txtFullName;
        private Label label3;
        private DateTimePicker dtpDateTime;
    }
}
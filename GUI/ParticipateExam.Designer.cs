namespace GUI
{
    partial class ParticipateExam
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
            components = new System.ComponentModel.Container();
            groupBox1 = new GroupBox();
            cobQuestion = new ComboBox();
            label4 = new Label();
            dtpExamDate = new DateTimePicker();
            cobSubject = new ComboBox();
            label3 = new Label();
            txtFullName = new TextBox();
            label2 = new Label();
            label1 = new Label();
            gtbQuestionAnswer = new GroupBox();
            panel1 = new Panel();
            lblAnswer4 = new Label();
            lblQuestion = new Label();
            radAns1 = new RadioButton();
            lblAnswer2 = new Label();
            radAns2 = new RadioButton();
            radAns3 = new RadioButton();
            lblAnswer3 = new Label();
            radAns4 = new RadioButton();
            lblAnswer1 = new Label();
            btnNext = new Button();
            btnBack = new Button();
            btnFinish = new Button();
            btnStart = new Button();
            btnExit = new Button();
            proTime = new ProgressBar();
            timeExam = new System.Windows.Forms.Timer(components);
            groupBox1.SuspendLayout();
            gtbQuestionAnswer.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.IndianRed;
            groupBox1.Controls.Add(cobQuestion);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(dtpExamDate);
            groupBox1.Controls.Add(cobSubject);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtFullName);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(26, 37);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(888, 141);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // cobQuestion
            // 
            cobQuestion.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            cobQuestion.FormattingEnabled = true;
            cobQuestion.Items.AddRange(new object[] { "10", "30", "50" });
            cobQuestion.Location = new Point(600, 89);
            cobQuestion.Name = "cobQuestion";
            cobQuestion.Size = new Size(277, 28);
            cobQuestion.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(429, 84);
            label4.Name = "label4";
            label4.Size = new Size(165, 25);
            label4.TabIndex = 7;
            label4.Text = "Number Question";
            // 
            // dtpExamDate
            // 
            dtpExamDate.CustomFormat = "dd/mm/yyyy";
            dtpExamDate.Enabled = false;
            dtpExamDate.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dtpExamDate.Format = DateTimePickerFormat.Short;
            dtpExamDate.Location = new Point(130, 86);
            dtpExamDate.Name = "dtpExamDate";
            dtpExamDate.Size = new Size(274, 27);
            dtpExamDate.TabIndex = 6;
            // 
            // cobSubject
            // 
            cobSubject.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            cobSubject.FormattingEnabled = true;
            cobSubject.Location = new Point(600, 34);
            cobSubject.Name = "cobSubject";
            cobSubject.Size = new Size(277, 28);
            cobSubject.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(519, 34);
            label3.Name = "label3";
            label3.Size = new Size(75, 25);
            label3.TabIndex = 4;
            label3.Text = "Subject";
            // 
            // txtFullName
            // 
            txtFullName.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtFullName.Location = new Point(130, 33);
            txtFullName.Name = "txtFullName";
            txtFullName.ReadOnly = true;
            txtFullName.Size = new Size(271, 27);
            txtFullName.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(17, 84);
            label2.Name = "label2";
            label2.Size = new Size(100, 25);
            label2.TabIndex = 1;
            label2.Text = "ExamDate";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(17, 28);
            label1.Name = "label1";
            label1.Size = new Size(95, 25);
            label1.TabIndex = 0;
            label1.Text = "FullName";
            // 
            // gtbQuestionAnswer
            // 
            gtbQuestionAnswer.Controls.Add(panel1);
            gtbQuestionAnswer.Location = new Point(224, 238);
            gtbQuestionAnswer.Name = "gtbQuestionAnswer";
            gtbQuestionAnswer.Size = new Size(690, 293);
            gtbQuestionAnswer.TabIndex = 1;
            gtbQuestionAnswer.TabStop = false;
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.Controls.Add(lblAnswer4);
            panel1.Controls.Add(lblQuestion);
            panel1.Controls.Add(radAns1);
            panel1.Controls.Add(lblAnswer2);
            panel1.Controls.Add(radAns2);
            panel1.Controls.Add(radAns3);
            panel1.Controls.Add(lblAnswer3);
            panel1.Controls.Add(radAns4);
            panel1.Controls.Add(lblAnswer1);
            panel1.Location = new Point(2, 9);
            panel1.Name = "panel1";
            panel1.Size = new Size(688, 284);
            panel1.TabIndex = 18;
            // 
            // lblAnswer4
            // 
            lblAnswer4.AutoSize = true;
            lblAnswer4.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblAnswer4.Location = new Point(75, 245);
            lblAnswer4.Name = "lblAnswer4";
            lblAnswer4.Size = new Size(69, 18);
            lblAnswer4.TabIndex = 17;
            lblAnswer4.Text = "Answer4";
            // 
            // lblQuestion
            // 
            lblQuestion.AutoSize = true;
            lblQuestion.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblQuestion.Location = new Point(32, 35);
            lblQuestion.Name = "lblQuestion";
            lblQuestion.Size = new Size(54, 21);
            lblQuestion.TabIndex = 0;
            lblQuestion.Text = "label5";
            // 
            // radAns1
            // 
            radAns1.AutoSize = true;
            radAns1.Location = new Point(32, 98);
            radAns1.Name = "radAns1";
            radAns1.Size = new Size(14, 13);
            radAns1.TabIndex = 10;
            radAns1.TabStop = true;
            radAns1.UseVisualStyleBackColor = true;
            // 
            // lblAnswer2
            // 
            lblAnswer2.AutoSize = true;
            lblAnswer2.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblAnswer2.Location = new Point(75, 148);
            lblAnswer2.Name = "lblAnswer2";
            lblAnswer2.Size = new Size(69, 18);
            lblAnswer2.TabIndex = 16;
            lblAnswer2.Text = "Answer2";
            // 
            // radAns2
            // 
            radAns2.AutoSize = true;
            radAns2.Location = new Point(32, 195);
            radAns2.Name = "radAns2";
            radAns2.Size = new Size(14, 13);
            radAns2.TabIndex = 11;
            radAns2.TabStop = true;
            radAns2.UseVisualStyleBackColor = true;
            // 
            // radAns3
            // 
            radAns3.AutoSize = true;
            radAns3.Location = new Point(32, 148);
            radAns3.Name = "radAns3";
            radAns3.Size = new Size(14, 13);
            radAns3.TabIndex = 12;
            radAns3.TabStop = true;
            radAns3.UseVisualStyleBackColor = true;
            // 
            // lblAnswer3
            // 
            lblAnswer3.AutoSize = true;
            lblAnswer3.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblAnswer3.Location = new Point(75, 195);
            lblAnswer3.Name = "lblAnswer3";
            lblAnswer3.Size = new Size(69, 18);
            lblAnswer3.TabIndex = 15;
            lblAnswer3.Text = "Answer3";
            // 
            // radAns4
            // 
            radAns4.AutoSize = true;
            radAns4.Location = new Point(32, 245);
            radAns4.Name = "radAns4";
            radAns4.Size = new Size(14, 13);
            radAns4.TabIndex = 13;
            radAns4.TabStop = true;
            radAns4.UseVisualStyleBackColor = true;
            // 
            // lblAnswer1
            // 
            lblAnswer1.AutoSize = true;
            lblAnswer1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblAnswer1.Location = new Point(75, 98);
            lblAnswer1.Name = "lblAnswer1";
            lblAnswer1.Size = new Size(69, 18);
            lblAnswer1.TabIndex = 14;
            lblAnswer1.Text = "Answer1";
            // 
            // btnNext
            // 
            btnNext.BackColor = Color.DarkKhaki;
            btnNext.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnNext.ForeColor = SystemColors.ControlLightLight;
            btnNext.Location = new Point(680, 201);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(234, 31);
            btnNext.TabIndex = 3;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Click += btnNext_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.DarkKhaki;
            btnBack.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnBack.ForeColor = SystemColors.ControlLightLight;
            btnBack.Location = new Point(224, 201);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(238, 31);
            btnBack.TabIndex = 4;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // btnFinish
            // 
            btnFinish.BackColor = Color.FromArgb(128, 64, 64);
            btnFinish.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnFinish.ForeColor = SystemColors.ControlLightLight;
            btnFinish.Location = new Point(12, 496);
            btnFinish.Name = "btnFinish";
            btnFinish.Size = new Size(195, 35);
            btnFinish.TabIndex = 5;
            btnFinish.Text = "Finish";
            btnFinish.UseVisualStyleBackColor = false;
            btnFinish.Click += btnFinish_Click;
            // 
            // btnStart
            // 
            btnStart.BackColor = Color.Peru;
            btnStart.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnStart.ForeColor = SystemColors.ControlLightLight;
            btnStart.Location = new Point(12, 238);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(195, 35);
            btnStart.TabIndex = 6;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = false;
            btnStart.Click += btnStart_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.FromArgb(128, 64, 64);
            btnExit.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnExit.ForeColor = SystemColors.ControlLightLight;
            btnExit.Location = new Point(12, 442);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(195, 35);
            btnExit.TabIndex = 7;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // proTime
            // 
            proTime.Location = new Point(226, 562);
            proTime.Minimum = 1;
            proTime.Name = "proTime";
            proTime.Size = new Size(688, 23);
            proTime.TabIndex = 8;
            proTime.Value = 1;
            // 
            // timeExam
            // 
            timeExam.Interval = 1000;
            timeExam.Tick += timeExam_Tick;
            // 
            // ParticipateExam
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = SystemColors.Info;
            ClientSize = new Size(936, 614);
            Controls.Add(proTime);
            Controls.Add(btnExit);
            Controls.Add(btnStart);
            Controls.Add(btnFinish);
            Controls.Add(btnBack);
            Controls.Add(btnNext);
            Controls.Add(gtbQuestionAnswer);
            Controls.Add(groupBox1);
            Name = "ParticipateExam";
            Text = "ParticipateExam";
            Load += ParticipateExam_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            gtbQuestionAnswer.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private Label label2;
        private TextBox txtFullName;
        private Label label3;
        private ComboBox cobSubject;
        private DateTimePicker dtpExamDate;
        private ComboBox cobQuestion;
        private Label label4;
        private GroupBox gtbQuestionAnswer;
        private Button btnNext;
        private Button btnBack;
        private Label lblQuestion;
        private Label lblAnswer1;
        private RadioButton radAns4;
        private RadioButton radAns3;
        private RadioButton radAns2;
        private RadioButton radAns1;
        private Label lblAnswer4;
        private Label lblAnswer2;
        private Label lblAnswer3;
        private Button btnFinish;
        private Button btnStart;
        private Button btnExit;
        private ProgressBar proTime;
        private System.Windows.Forms.Timer timeExam;
        private Panel panel1;
    }
}
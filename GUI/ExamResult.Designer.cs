namespace GUI
{
    partial class ExamResult
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
            btnExit = new Button();
            btnScore = new TextBox();
            label4 = new Label();
            dtpExamDate = new DateTimePicker();
            cobSubject = new ComboBox();
            label3 = new Label();
            txtFullName = new TextBox();
            label2 = new Label();
            label5 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.DarkSeaGreen;
            groupBox1.Controls.Add(btnExit);
            groupBox1.Controls.Add(btnScore);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(dtpExamDate);
            groupBox1.Controls.Add(cobSubject);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtFullName);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(42, 38);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(715, 363);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.DarkKhaki;
            btnExit.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnExit.ForeColor = SystemColors.ControlLightLight;
            btnExit.Location = new Point(501, 179);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(195, 35);
            btnExit.TabIndex = 17;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnScore
            // 
            btnScore.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnScore.Location = new Point(183, 286);
            btnScore.Name = "btnScore";
            btnScore.ReadOnly = true;
            btnScore.Size = new Size(277, 27);
            btnScore.TabIndex = 16;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(97, 286);
            label4.Name = "label4";
            label4.Size = new Size(59, 25);
            label4.TabIndex = 15;
            label4.Text = "Score";
            // 
            // dtpExamDate
            // 
            dtpExamDate.CustomFormat = "dd/mm/yyyy";
            dtpExamDate.Enabled = false;
            dtpExamDate.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dtpExamDate.Format = DateTimePickerFormat.Short;
            dtpExamDate.Location = new Point(183, 222);
            dtpExamDate.Name = "dtpExamDate";
            dtpExamDate.Size = new Size(274, 27);
            dtpExamDate.TabIndex = 14;
            // 
            // cobSubject
            // 
            cobSubject.Enabled = false;
            cobSubject.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            cobSubject.FormattingEnabled = true;
            cobSubject.Location = new Point(180, 165);
            cobSubject.Name = "cobSubject";
            cobSubject.Size = new Size(277, 28);
            cobSubject.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(81, 164);
            label3.Name = "label3";
            label3.Size = new Size(75, 25);
            label3.TabIndex = 12;
            label3.Text = "Subject";
            // 
            // txtFullName
            // 
            txtFullName.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtFullName.Location = new Point(180, 102);
            txtFullName.Name = "txtFullName";
            txtFullName.ReadOnly = true;
            txtFullName.Size = new Size(277, 27);
            txtFullName.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(61, 222);
            label2.Name = "label2";
            label2.Size = new Size(100, 25);
            label2.TabIndex = 10;
            label2.Text = "ExamDate";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(61, 101);
            label5.Name = "label5";
            label5.Size = new Size(95, 25);
            label5.TabIndex = 9;
            label5.Text = "FullName";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(232, 19);
            label1.Name = "label1";
            label1.Size = new Size(235, 50);
            label1.TabIndex = 0;
            label1.Text = "Exam Result";
            // 
            // ExamResult
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = SystemColors.Info;
            ClientSize = new Size(799, 424);
            Controls.Add(groupBox1);
            Name = "ExamResult";
            Text = "ExamResults";
            Load += ExamResult_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private DateTimePicker dtpExamDate;
        private ComboBox cobSubject;
        private Label label3;
        private TextBox txtFullName;
        private Label label2;
        private Label label5;
        private TextBox btnScore;
        private Label label4;
        private Button btnExit;
    }
}
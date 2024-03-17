namespace GUI
{
    partial class TeacherInterFace
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
            btnCandidates = new Button();
            btnQuestion = new Button();
            btnScoreList = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.IndianRed;
            label1.Location = new Point(41, 43);
            label1.Name = "label1";
            label1.Size = new Size(321, 50);
            label1.TabIndex = 0;
            label1.Text = "Teacher Manager";
            // 
            // btnCandidates
            // 
            btnCandidates.BackColor = Color.FromArgb(128, 128, 255);
            btnCandidates.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnCandidates.ForeColor = SystemColors.ControlLightLight;
            btnCandidates.Location = new Point(41, 145);
            btnCandidates.Name = "btnCandidates";
            btnCandidates.Size = new Size(322, 44);
            btnCandidates.TabIndex = 1;
            btnCandidates.Text = "Candidates Management";
            btnCandidates.UseVisualStyleBackColor = false;
            btnCandidates.Click += btnCandidates_Click;
            // 
            // btnQuestion
            // 
            btnQuestion.BackColor = Color.FromArgb(192, 192, 0);
            btnQuestion.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnQuestion.ForeColor = SystemColors.ControlLightLight;
            btnQuestion.Location = new Point(41, 219);
            btnQuestion.Name = "btnQuestion";
            btnQuestion.Size = new Size(322, 44);
            btnQuestion.TabIndex = 2;
            btnQuestion.Text = "Question Management";
            btnQuestion.UseVisualStyleBackColor = false;
            btnQuestion.Click += btnQuestion_Click;
            // 
            // btnScoreList
            // 
            btnScoreList.BackColor = Color.FromArgb(0, 192, 0);
            btnScoreList.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnScoreList.ForeColor = SystemColors.ControlLightLight;
            btnScoreList.Location = new Point(41, 285);
            btnScoreList.Name = "btnScoreList";
            btnScoreList.Size = new Size(322, 44);
            btnScoreList.TabIndex = 3;
            btnScoreList.Text = "View Candidates' Score List";
            btnScoreList.UseVisualStyleBackColor = false;
            btnScoreList.Click += btnScoreList_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.FromArgb(128, 64, 64);
            btnExit.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnExit.ForeColor = SystemColors.ControlLightLight;
            btnExit.Location = new Point(41, 353);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(322, 44);
            btnExit.TabIndex = 4;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // TeacherInterFace
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = SystemColors.Info;
            ClientSize = new Size(423, 419);
            Controls.Add(btnExit);
            Controls.Add(btnScoreList);
            Controls.Add(btnQuestion);
            Controls.Add(btnCandidates);
            Controls.Add(label1);
            Name = "TeacherInterFace";
            Text = "Teacher Managerment";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnCandidates;
        private Button btnQuestion;
        private Button btnScoreList;
        private Button btnExit;
    }
}
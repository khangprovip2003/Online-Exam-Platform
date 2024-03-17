namespace GUI
{
    partial class CandidateInterface
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
            btnScore = new Button();
            btnParticipate = new Button();
            label1 = new Label();
            lblFullName = new Label();
            SuspendLayout();
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.FromArgb(128, 64, 64);
            btnExit.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnExit.ForeColor = SystemColors.ControlLightLight;
            btnExit.Location = new Point(37, 296);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(322, 44);
            btnExit.TabIndex = 9;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnScore
            // 
            btnScore.BackColor = Color.FromArgb(0, 192, 0);
            btnScore.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnScore.ForeColor = SystemColors.ControlLightLight;
            btnScore.Location = new Point(37, 213);
            btnScore.Name = "btnScore";
            btnScore.Size = new Size(322, 44);
            btnScore.TabIndex = 8;
            btnScore.Text = "View Scoreboard";
            btnScore.UseVisualStyleBackColor = false;
            btnScore.Click += btnScore_Click;
            // 
            // btnParticipate
            // 
            btnParticipate.BackColor = Color.FromArgb(192, 192, 0);
            btnParticipate.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnParticipate.ForeColor = SystemColors.ControlLightLight;
            btnParticipate.Location = new Point(37, 134);
            btnParticipate.Name = "btnParticipate";
            btnParticipate.Size = new Size(322, 44);
            btnParticipate.TabIndex = 7;
            btnParticipate.Text = "Take the English Proficiency Quiz";
            btnParticipate.UseVisualStyleBackColor = false;
            btnParticipate.Click += btnParticipate_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.IndianRed;
            label1.Location = new Point(22, 31);
            label1.Name = "label1";
            label1.Size = new Size(364, 50);
            label1.TabIndex = 5;
            label1.Text = "Candidate Interface";
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblFullName.ForeColor = Color.FromArgb(128, 64, 0);
            lblFullName.Location = new Point(77, 81);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(81, 37);
            lblFullName.TabIndex = 11;
            lblFullName.Text = "Hello";
            // 
            // CandidateInterface
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = SystemColors.Info;
            ClientSize = new Size(398, 367);
            Controls.Add(lblFullName);
            Controls.Add(btnExit);
            Controls.Add(btnScore);
            Controls.Add(btnParticipate);
            Controls.Add(label1);
            Name = "CandidateInterface";
            Text = "CandidateInterface";
            Load += CandidateInterface_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnExit;
        private Button btnScore;
        private Button btnParticipate;
        private Label label1;
        private Label lblFullName;
    }
}
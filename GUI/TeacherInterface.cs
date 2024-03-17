using Repository.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class TeacherInterFace : Form
    {
        public TeacherInterFace()
        {
            InitializeComponent();
        }

        private void btnCandidates_Click(object sender, EventArgs e)
        {
            using (CandidatesManagement candidatesManagement = new CandidatesManagement())
            {
                this.Hide();
                candidatesManagement.ShowDialog();
                this.Show();
            }
        }

        private void btnQuestion_Click(object sender, EventArgs e)
        {
            using (QuestionManagement questionManagement = new QuestionManagement())
            {
                this.Hide();
                questionManagement.ShowDialog();
                this.Show();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to cancel Teacher Interface?", "Cancel Teacher Interface", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                UserSession.ClearSession();
                this.Close();
            }
        }

        private void btnScoreList_Click(object sender, EventArgs e)
        {
            using (ScoreManagement scoreManagement = new ScoreManagement())
            {
                this.Hide();
                scoreManagement.ShowDialog();
                this.Show();
            }
        }
    }
}

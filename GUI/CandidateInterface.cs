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
    public partial class CandidateInterface : Form
    {
        public CandidateInterface()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to cancel Candidate Interface?", "Cancel Candidate Interface", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                UserSession.ClearSession();
                this.Close();
            }
        }

        private void btnParticipate_Click(object sender, EventArgs e)
        {
            using (ParticipateExam participateExam = new ParticipateExam())
            {
                participateExam.Owner = this;
                this.Hide();
                participateExam.ShowDialog();
            }
            this.Show();
        }

        private void CandidateInterface_Load(object sender, EventArgs e)
        {
            lblFullName.Text = UserSession.SessionCandidate.FullName;
        }

        private void btnScore_Click(object sender, EventArgs e)
        {
            using (ScoreCandidate scoreCandidate = new ScoreCandidate())
            {
                this.Hide();
                scoreCandidate.ShowDialog();
                this.Show();
            }
        }
    }
}

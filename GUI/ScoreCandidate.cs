using Repository.Entities;
using Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Formats.Asn1.AsnWriter;

namespace GUI
{
    public partial class ScoreCandidate : Form
    {
        private ResultServices _service = new ResultServices();
        private CandidateServices _serviceCandidate = new CandidateServices();
        private SubjectServices _serviceSubject = new SubjectServices();
        public int candidateID = UserSession.SessionCandidate.CandidateId;
        public ScoreCandidate()
        {
            InitializeComponent();
        }
        private void RefreshResultGrid()
        {
            var score = _service.GetAllScoresById(candidateID).Select(p => new
            {
                ResultID = p.ResultId,
                CandidateID = p.CandidateId,
                SubjectName = p.Subject.SubjectName,
                Score = p.Score,
                ExameDate = p.ExamDate,
                CandidateName = p.CandidateName
            }).ToList();
            dgvScore.DataSource = null;
            dgvScore.DataSource = score;
            //dgvScore.Columns["Candidate"].Visible = false;
            //dgvScore.Columns["Subject"].Visible = false;
        }
        private void ScoreCandidate_Load(object sender, EventArgs e)
        {
            RefreshResultGrid();
        }

        private void dgvScore_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvScore.SelectedRows.Count > 0)
            {
                var selectedResult = (Result)dgvScore.SelectedRows[0].DataBoundItem;
                txtFullName.Text = _serviceCandidate.GetACandidate(selectedResult.CandidateId).FullName;
                cobSubject.SelectedValue = selectedResult.SubjectId;
                cobSubject.DataSource = _serviceSubject.GetAllSubjects();
                cobSubject.DisplayMember = "SubjectName";
                cobSubject.ValueMember = "SubjectId";
                dtpExamDate.Value = selectedResult.ExamDate;
                txtScore.Text = selectedResult.Score.ToString("F2");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DateTime selectedDate = dtpDateTime.Value.Date;
            var results = _service.GetScoresByDateAndCandidateId(selectedDate, candidateID);
            if (results.Count == 0)
            {
                MessageBox.Show("No results found for the selected date.", "Search Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            dgvScore.DataSource = null;
            dgvScore.DataSource = results;
            dgvScore.Columns["Candidate"].Visible = false;
            dgvScore.Columns["Subject"].Visible = false;
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            RefreshResultGrid();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to cancel Result Exam?", "Cancel Result Exam", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}

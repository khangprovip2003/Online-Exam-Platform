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

namespace GUI
{
    public partial class ScoreManagement : Form
    {
        private SubjectServices _serviceSubject = new SubjectServices();
        private ResultServices _service = new ResultServices();
        public ScoreManagement()
        {
            InitializeComponent();
        }
        private void RefreshResultGrid()
        {
            var score = _service.GetAllResults();
            dgvScore.DataSource = null;
            dgvScore.DataSource = score;
            dgvScore.Columns["Candidate"].Visible = false;
            dgvScore.Columns["Subject"].Visible = false;
        }

        private void ScoreManagement_Load(object sender, EventArgs e)
        {
            RefreshResultGrid();
        }

        private void dgvScore_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvScore.SelectedRows.Count > 0)
            {
                var selectedResult = (Result)dgvScore.SelectedRows[0].DataBoundItem;
                txtFullName.Text = selectedResult.CandidateName;
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
            string candidateName = txtSearch.Text.Trim();
            if (!string.IsNullOrEmpty(candidateName))
            {
                var results = _service.GetScoresByDateAndFullName(selectedDate, candidateName);
                if (results.Count > 0)
                {
                    dgvScore.DataSource = results;
                }
                else
                {
                    MessageBox.Show("No results found for the selected date and name.", "Search Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                var resultsByDate = _service.GetScoresByDate(selectedDate);
                if (resultsByDate.Count > 0)
                {
                    dgvScore.DataSource = resultsByDate;
                }
                else
                {
                    MessageBox.Show("No results found for the selected date.", "Search Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            dgvScore.Refresh();
            dgvScore.Columns["Candidate"].Visible = false;
            dgvScore.Columns["Subject"].Visible = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to cancel Score Management?", "Cancel Score Management", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            RefreshResultGrid();
        }
    }
}

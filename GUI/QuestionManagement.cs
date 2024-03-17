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
    public partial class QuestionManagement : Form
    {
        private QuestionServices _service = new QuestionServices();
        private AnswerServices _serviceKey = new AnswerServices();
        private SubjectServices _serviceSubject = new SubjectServices();
        public QuestionManagement()
        {
            InitializeComponent();
        }

        private void RefreshTeacherGrid()
        {
            int teacherId = UserSession.SessionEmployee.EmployeeId;
            var question = _service.GetAllQuestions(teacherId);
            dgvQuestion.DataSource = null;
            dgvQuestion.DataSource = question;
            dgvQuestion.Columns["Employee"].Visible = false;
            dgvQuestion.Columns["Subject"].Visible = false;
            dgvQuestion.Columns["Answers"].Visible = false;

            var answers = _serviceKey.GetAllAnswers(teacherId);
            dgvAnswers.DataSource = null;
            dgvAnswers.DataSource = answers;
            dgvQuestion.Columns["Employee"].Visible = false;
            dgvQuestion.Columns["Subject"].Visible = false;
            dgvQuestion.Columns["Answers"].Visible = false;

            cobSubject.DataSource = _serviceSubject.GetAllSubjects();
            cobSubject.DisplayMember = "SubjectName";
            cobSubject.ValueMember = "SubjectId";
        }
        private void Clear()
        {
            txtContextQuestion.Clear();
            txtAns1.Clear();
            txtAns2.Clear();
            txtAns3.Clear();
            txtAns4.Clear();
            radAns1.Checked = false;
            radAns2.Checked = false;
            radAns3.Checked = false;
            radAns4.Checked = false;
            cobSubject.SelectedIndex = -1;
        }
        private void QuestionManagement_Load(object sender, EventArgs e)
        {
            RefreshTeacherGrid();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to cancel Question Manager?", "Cancel Question Manager", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void dgvQuestion_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvQuestion.SelectedRows.Count > 0)
            {
                var selectedQuestion = (Question)dgvQuestion.SelectedRows[0].DataBoundItem;
                txtContextQuestion.Text = selectedQuestion.Content;
                cobSubject.SelectedValue = selectedQuestion.SubjectId;
                var answersList = _serviceKey.GetAllAnswersByQuestionId(selectedQuestion.QuestionId);
                if (answersList.Count >= 4)
                {
                    radAns1.Checked = answersList[0].AnswerType.Trim().Equals("1");
                    txtAns1.Text = answersList[0].Content;

                    radAns2.Checked = answersList[1].AnswerType.Trim().Equals("1");
                    txtAns2.Text = answersList[1].Content;

                    radAns3.Checked = answersList[2].AnswerType.Trim().Equals("1");
                    txtAns3.Text = answersList[2].Content;

                    radAns4.Checked = answersList[3].AnswerType.Trim().Equals("1");
                    txtAns4.Text = answersList[3].Content;
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtKeyword.Text) == true)
            {
                MessageBox.Show("The Search keyword is required !!!", "Search keyword required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int teacherId = UserSession.SessionEmployee.EmployeeId;
            var question = _service.SearchQuestions(txtKeyword.Text.Trim(), teacherId);
            dgvQuestion.DataSource = null;
            dgvQuestion.DataSource = question;
            dgvQuestion.Columns["Employee"].Visible = false;
            dgvQuestion.Columns["Subject"].Visible = false;
            dgvQuestion.Columns["Answers"].Visible = false;

            var answers = _serviceKey.SearchAnswers(txtKeyword.Text.Trim(), teacherId);
            dgvAnswers.DataSource = null;
            dgvAnswers.DataSource = answers;
            dgvQuestion.Columns["Employee"].Visible = false;
            dgvQuestion.Columns["Subject"].Visible = false;
            dgvQuestion.Columns["Answers"].Visible = false;

            cobSubject.DataSource = _serviceSubject.GetAllSubjects();
            cobSubject.DisplayMember = "SubjectName";
            cobSubject.ValueMember = "SubjectId";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            int teacherId = UserSession.SessionEmployee.EmployeeId;
            var question = _service.GetAllQuestions(teacherId);
            dgvQuestion.DataSource = null;
            dgvQuestion.DataSource = question;
            dgvQuestion.Columns["Employee"].Visible = false;
            dgvQuestion.Columns["Subject"].Visible = false;
            dgvQuestion.Columns["Answers"].Visible = false;

            var answers = _serviceKey.GetAllAnswers(teacherId);
            dgvAnswers.DataSource = null;
            dgvAnswers.DataSource = answers;
            dgvAnswers.Columns["Question"].Visible = false;

            cobSubject.DataSource = _serviceSubject.GetAllSubjects();
            cobSubject.DisplayMember = "SubjectName";
            cobSubject.ValueMember = "SubjectId";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtContextQuestion.Text) ||
                string.IsNullOrWhiteSpace(txtAns1.Text) ||
                string.IsNullOrWhiteSpace(txtAns2.Text) ||
                string.IsNullOrWhiteSpace(txtAns3.Text) ||
                string.IsNullOrWhiteSpace(txtAns4.Text) ||
                cobSubject.SelectedIndex == -1)
            {
                MessageBox.Show("All fields are required and cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!radAns1.Checked && !radAns2.Checked && !radAns3.Checked && !radAns4.Checked)
            {
                MessageBox.Show("Please select the correct answer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string content = txtContextQuestion.Text.Trim();
            int subjectId = (int)cobSubject.SelectedValue;
            bool isDuplicate = _service.CheckForDuplicateContent(content, subjectId);
            if (isDuplicate)
            {
                MessageBox.Show("This question content already exists.", "Duplicate Content", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Question newQuestion = new Question()
            {
                Content = txtContextQuestion.Text.Trim(),
                SubjectId = (int)cobSubject.SelectedValue,
                EmployeeId = UserSession.SessionEmployee.EmployeeId
            };
            int questionId = _service.AddAQuestion(newQuestion);
            if (questionId > 0)
            {
                List<Answer> answers = new List<Answer>()
                {
                    new Answer() { QuestionId = questionId, Content = txtAns1.Text.Trim(), AnswerType = radAns1.Checked ? "1" : "0" },
                    new Answer() { QuestionId = questionId, Content = txtAns2.Text.Trim(), AnswerType = radAns2.Checked ? "1" : "0" },
                    new Answer() { QuestionId = questionId, Content = txtAns3.Text.Trim(), AnswerType = radAns3.Checked ? "1" : "0" },
                    new Answer() { QuestionId = questionId, Content = txtAns4.Text.Trim(), AnswerType = radAns4.Checked ? "1" : "0" }
                };
                foreach (Answer answer in answers)
                {
                    _serviceKey.AddAAnswer(answer);
                }
                RefreshTeacherGrid();
                Clear();
            }
            else
            {
                MessageBox.Show("There was an error adding the question.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvQuestion.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Please select a question from the list to update content question.", "Select Question", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtContextQuestion.Text) ||
                string.IsNullOrWhiteSpace(txtAns1.Text) ||
                string.IsNullOrWhiteSpace(txtAns2.Text) ||
                string.IsNullOrWhiteSpace(txtAns3.Text) ||
                string.IsNullOrWhiteSpace(txtAns4.Text) ||
              cobSubject.SelectedIndex == -1)
            {
                MessageBox.Show("All fields are required and cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!radAns1.Checked && !radAns2.Checked && !radAns3.Checked && !radAns4.Checked)
            {
                MessageBox.Show("Please select the correct answer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string content = txtContextQuestion.Text.Trim();
            int subjectId = (int)cobSubject.SelectedValue;
            bool isDuplicate = _service.CheckForDuplicateContent(content, subjectId);
            if (isDuplicate)
            {
                MessageBox.Show("This question content already exists.", "Duplicate Content", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var selectedQuestion = (Question)dgvQuestion.SelectedRows[0].DataBoundItem;
            selectedQuestion.Content = txtContextQuestion.Text.Trim();
            selectedQuestion.SubjectId = (int)cobSubject.SelectedValue;
            _service.UpdateAQuestion(selectedQuestion);
            RefreshTeacherGrid();
            Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvQuestion.SelectedRows.Count > 0)
            {
                var result = MessageBox.Show("Are you sure you want to delete the question and answers?", "Delete Question and Answer", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    var selectedQuestion = (Question)dgvQuestion.SelectedRows[0].DataBoundItem;
                    var answersToDelete = _serviceKey.GetAllAnswersByQuestionId(selectedQuestion.QuestionId);
                    foreach (var answer in answersToDelete)
                    {
                        _serviceKey.DeleteAAnswer(answer.AnswerId);
                    }
                    _service.DeleteAQuestion(selectedQuestion.QuestionId);
                    RefreshTeacherGrid();
                    Clear();
                }
            }
            else
            {
                MessageBox.Show("Please select a question to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdateAnswer_Click(object sender, EventArgs e)
        {
            if (dgvQuestion.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Please select a question from the list to update answer.", "Select Question", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtContextQuestion.Text) ||
               string.IsNullOrWhiteSpace(txtAns1.Text) ||
               string.IsNullOrWhiteSpace(txtAns2.Text) ||
               string.IsNullOrWhiteSpace(txtAns3.Text) ||
               string.IsNullOrWhiteSpace(txtAns4.Text) ||
             cobSubject.SelectedIndex == -1)
            {
                MessageBox.Show("All fields are required and cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!radAns1.Checked && !radAns2.Checked && !radAns3.Checked && !radAns4.Checked)
            {
                MessageBox.Show("Please select the correct answer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var selectedQuestion = (Question)dgvQuestion.SelectedRows[0].DataBoundItem;
            selectedQuestion.Content = txtContextQuestion.Text.Trim();
            selectedQuestion.SubjectId = (int)cobSubject.SelectedValue;
            var answers = _serviceKey.GetAllAnswersByQuestionId(selectedQuestion.QuestionId);
            answers[0].Content = txtAns1.Text.Trim();
            answers[0].AnswerType = radAns1.Checked ? "1" : "0";

            answers[1].Content = txtAns2.Text.Trim();
            answers[1].AnswerType = radAns2.Checked ? "1" : "0";

            answers[2].Content = txtAns3.Text.Trim();
            answers[2].AnswerType = radAns3.Checked ? "1" : "0";

            answers[3].Content = txtAns4.Text.Trim();
            answers[3].AnswerType = radAns4.Checked ? "1" : "0";

            foreach (var answer in answers)
            {
                _serviceKey.UpdateAAnswer(answer);
            }
            RefreshTeacherGrid();
            Clear();
        }
    }
}
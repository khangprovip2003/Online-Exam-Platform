using Repository.Entities;
using Services;
using System;
using System.Collections;
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
    public partial class ParticipateExam : Form
    {
        private SubjectServices _serviceSubject = new SubjectServices();
        private QuestionServices _questionService = new QuestionServices();
        private AnswerServices _answerService = new AnswerServices();
        private ResultServices _resultService = new ResultServices();

        public int numberQuestion = 0;
        public int placeUser = 0;
        ArrayList Array_ContentQuestion = new ArrayList();
        ArrayList Array_Question = new ArrayList();
        ArrayList Array_Answer = new ArrayList();
        ArrayList Array_TypeAnswer = new ArrayList();
        ArrayList Type_TrueAnswer = new ArrayList();
        ArrayList Answer_Candidates = new ArrayList();

        public ParticipateExam()
        {
            InitializeComponent();
        }
        private void hiddenButton(bool hide)
        {
            btnBack.Visible = hide;
            btnNext.Visible = hide;
            btnFinish.Visible = hide;
            lblQuestion.Visible = hide;
            lblAnswer1.Visible = hide;
            lblAnswer2.Visible = hide;
            lblAnswer3.Visible = hide;
            lblAnswer4.Visible = hide;
            radAns1.Visible = hide;
            radAns2.Visible = hide;
            radAns3.Visible = hide;
            radAns4.Visible = hide;
        }
        private void ParticipateExam_Load(object sender, EventArgs e)
        {
            txtFullName.Text = UserSession.SessionCandidate.FullName;
            cobSubject.DataSource = _serviceSubject.GetAllSubjects();
            cobSubject.DisplayMember = "SubjectName";
            cobSubject.ValueMember = "SubjectId";
            cobQuestion.Text = "10";
            hiddenButton(false);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to Exit?", "Exit Participate Exam", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (cobSubject.SelectedItem == null || cobSubject.SelectedValue == null || string.IsNullOrWhiteSpace(cobSubject.SelectedValue.ToString()))
            {
                MessageBox.Show("Please select a valid subject from the list to start the exam.", "Invalid Subject", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cobQuestion.SelectedItem == null || string.IsNullOrWhiteSpace(cobQuestion.SelectedItem.ToString()))
            {
                MessageBox.Show("Please select a valid number of questions from the list to start the exam.", "Invalid Number of Questions", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            hiddenButton(true);
            btnStart.Visible = false;
            btnExit.Visible = false;
            AssignQuestion();
            showQuestion(0);
            timeExam.Start();
        }

        private void AssignQuestion()
        {
            if (cobQuestion.Text.Trim() == "10")
            {
                numberQuestion = 10;
                proTime.Maximum = 1 * 60;
            }
            else if (cobQuestion.Text.Trim() == "30")
            {
                numberQuestion = 30;
                proTime.Maximum = 30 * 60;
            }
            else
            {
                numberQuestion = 50;
                proTime.Maximum = 50 * 60;
            }
            int.TryParse(cobQuestion.Text.Trim(), out int numberOfQuestions);
            int subjectId = Convert.ToInt32(cobSubject.SelectedValue);
            var questions = _questionService.GetRandomQuestions(numberOfQuestions, subjectId);
            foreach (var question in questions)
            {
                Array_Question.Add(question.QuestionId.ToString());
                Array_ContentQuestion.Add(question.Content.Trim());
                Answer_Candidates.Add("No Answer");
                //var answers = _answerService.GetAllAnswersByQuestionId(question.QuestionId);
                var answers = _answerService.GetRandomAnswersByQuestionId(question.QuestionId);
                for (int j = 0; j < answers.Count; j++)
                {
                    var answer = answers[j];
                    Array_Answer.Add(answer.Content.Trim());
                    Array_TypeAnswer.Add(answer.AnswerType.Trim());
                    if (answer.AnswerType.Trim().Equals("1"))
                    {
                        Type_TrueAnswer.Add(Convert.ToString(j + 1));
                    }
                }
            }
        }

        public void showQuestion(int question)
        {
            lblQuestion.Text = "Question " + (question + 1) + " : " + Array_ContentQuestion[question].ToString();
            showAnswer(question);
        }

        public void showAnswer(int b)
        {
            lblAnswer1.Text = Array_Answer[0 + (b * 4)].ToString();
            lblAnswer2.Text = Array_Answer[1 + (b * 4)].ToString();
            lblAnswer3.Text = Array_Answer[2 + (b * 4)].ToString();
            lblAnswer4.Text = Array_Answer[3 + (b * 4)].ToString();
        }

        private void timeExam_Tick(object sender, EventArgs e)
        {
            proTime.Value++;
            if (proTime.Value == proTime.Maximum)
            {
                timeExam.Stop();
                MessageBox.Show("Exam time is over !!!");
                proTime.Value = 1;
                FinishExam();
            }
        }
        private void saveAnswers()
        {
            String answer = "";
            if (radAns1.Checked == true)
            {
                answer = "1";
            }
            if (radAns2.Checked == true)
            {
                answer = "2";
            }
            if (radAns3.Checked == true)
            {
                answer = "3";
            }
            if (radAns4.Checked == true)
            {
                answer = "4";
            }
            Answer_Candidates[placeUser] = answer;
        }
        private void AnswerCandidates()
        {
            if (Answer_Candidates[placeUser].ToString().Trim() == "1")
            {
                radAns1.Checked = true;
            }
            else if (Answer_Candidates[placeUser].ToString().Trim() == "2")
            {
                radAns2.Checked = true;
            }
            else if (Answer_Candidates[placeUser].ToString().Trim() == "3")
            {
                radAns3.Checked = true;
            }
            else if (Answer_Candidates[placeUser].ToString().Trim() == "4")
            {
                radAns4.Checked = true;
            }
            else
            {
                radAns1.Checked = false;
                radAns2.Checked = false;
                radAns3.Checked = false;
                radAns4.Checked = false;
            }
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (placeUser == numberQuestion - 1)
            {
                saveAnswers();
                showQuestion(numberQuestion - 1);
                AnswerCandidates();
            }
            else
            {
                saveAnswers();
                placeUser++;
                AnswerCandidates();
                showQuestion(placeUser);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (placeUser == 0)
            {
                showQuestion(0);
                AnswerCandidates();
            }
            else
            {
                saveAnswers();
                placeUser--;
                AnswerCandidates();
                showQuestion(placeUser);
            }
        }
        private void btnFinish_Click(object sender, EventArgs e)
        {
            FinishExam();

        }
        private void FinishExam()
        {
            var result = MessageBox.Show("Are you sure you want to Finish Exam?", "Finish Participate Exam", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                saveAnswers();
                timeExam.Stop();
                int AnswerTrue = 0;
                for (int i = 0; i < numberQuestion; i++)
                {
                    if (Answer_Candidates[i].ToString().Trim().Equals(Type_TrueAnswer[i].ToString().Trim()))
                    {
                        AnswerTrue++;
                    }
                }
                double score = (10 / (double)numberQuestion * AnswerTrue);

                Result newResult = new Result
                {
                    CandidateId = UserSession.SessionCandidate.CandidateId,
                    SubjectId = Convert.ToInt32(cobSubject.SelectedValue),
                    CandidateName = UserSession.SessionCandidate.FullName,
                    Score = (float)score,
                    ExamDate = dtpExamDate.Value,
                };
                _resultService.AddAResult(newResult);
                this.Close();
                using (ExamResult examResultForm = new ExamResult(newResult))
                {
                    this.Hide();
                    examResultForm.ShowDialog();
                }
            }
        }
    }
}

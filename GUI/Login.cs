using Microsoft.EntityFrameworkCore;
using Repository;
using Repository.Entities;
using Services;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace GUI
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text.Trim();
            string password = txtPassWord.Text.Trim();
            OnlineExamPlatformMember se = new OnlineExamPlatformMember();
            if (radCandidate.Checked)
            {
                Candidate candidates = se.checkLoginCandidates(username, password);
                if (candidates == null)
                {
                    MessageBox.Show("Login failed. Please check your credentials",
                                     "Wrong credentials", MessageBoxButtons.OK,
                                     MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    using (CandidateInterface candidateInterface = new CandidateInterface())
                    {
                        UserSession.SetSessionCandidate(candidates);
                        this.Hide();
                        candidateInterface.ShowDialog();
                        this.Show();
                    }
                }
            }
            else
            {
                Employee employees = se.checkLoginEmployee(username, password);
                if (employees == null)
                {
                    MessageBox.Show("Login failed. Please check your credentials",
                                     "Wrong credentials", MessageBoxButtons.OK,
                                     MessageBoxIcon.Error);
                    return;
                }
                if (employees.Position == 1)
                {
                    using (AdminInterface adminInterface = new AdminInterface())
                    {
                        this.Hide();
                        adminInterface.ShowDialog();
                        this.Show();
                    }
                }
                else
                {
                    using (TeacherInterFace teacherInterface = new TeacherInterFace())
                    {
                        UserSession.SetSessionEmployee(employees);
                        this.Hide();
                        teacherInterface.ShowDialog();
                        this.Show();
                    }
                }
            }
        }

        private void RoleRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            btnRegister.Visible = radCandidate.Checked;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit ?", "Notification !!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (btnRegister.Text == "Register")
            {
                using (Register register = new Register())
                {
                    this.Hide();
                    register.ShowDialog();
                    LoadSessionInfo();
                    this.Show();
                }
            }
        }
        private void LoadSessionInfo()
        {

            var sessionUser = UserSession.SessionCandidate;
            if (sessionUser != null)
            {
                txtUserName.Text = sessionUser.Username;
                txtPassWord.Text = sessionUser.Password;
                radCandidate.Checked = true;
            }
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            if (btnChangePassword.Text == "Change Password")
            {
                if (radCandidate.Checked)
                {
                    using (changePasswordCandidateForm changePasswordCandidateForm = new changePasswordCandidateForm())
                    {
                        this.Hide();
                        changePasswordCandidateForm.ShowDialog();
                        this.Show();
                    }
                }
                else
                {
                    using (ChangePasswordEmployeeForm changePasswordEmployeeForm = new ChangePasswordEmployeeForm())
                    {
                        this.Hide();
                        changePasswordEmployeeForm.ShowDialog();
                        this.Show();
                    }
                }
            }
        }
    }
}

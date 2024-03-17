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
    public partial class Register : Form
    {
        private OnlineExamPlatformMember _service = new OnlineExamPlatformMember();
        public Register()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to cancel registration?", "Cancel Registration", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFullName.Text) ||
             string.IsNullOrWhiteSpace(txtUserName.Text) ||
             string.IsNullOrWhiteSpace(txtPassWord.Text))
            {
                MessageBox.Show("All fields are required and cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!_service.IsUsernameAndPasswordUniqueCandidates(txtUserName.Text))
            {
                MessageBox.Show("The username already exist. Please choose different ones.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!txtPassWord.Text.Trim().Equals(txtRepeatPassword.Text.Trim()))
            {
                MessageBox.Show("The new password and repeat password do not match.", "Password Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Candidate newCandidate = new Candidate()
            {
                FullName = txtFullName.Text.Trim(),
                Username = txtUserName.Text.Trim(),
                Password = txtPassWord.Text.Trim(),
                Address = txtAddress.Text.Trim(),
            };
            _service.AddRegiter(newCandidate);
            UserSession.SetSessionCandidate(newCandidate);
            MessageBox.Show("You have successfully registered");
            this.Close();
        }
    }
}

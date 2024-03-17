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
    public partial class ChangePasswordEmployeeForm : Form
    {
        private OnlineExamPlatformMember _service = new OnlineExamPlatformMember();
        public ChangePasswordEmployeeForm()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to cancel Change Password Employee?", "Cancel Change Password", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text.Trim();
            string oldPassword = txtOldPass.Text.Trim();
            string newPassword = txtNewPass.Text.Trim();
            string repeatPassword = txtRepeatPass.Text.Trim();
            if (_service.IsUsernameAndPasswordUniquEmployee(userName, oldPassword))
            {
                MessageBox.Show("The old password or User Name is incorrect.", "Password Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!_service.IsUsernameAndPasswordUniquEmployee(userName, newPassword))
            {
                MessageBox.Show("The new password you have entered already exists.", "Password Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!newPassword.Equals(repeatPassword))
            {
                MessageBox.Show("The new password and repeat password do not match.", "Password Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var user = _service.GetAEmployeeToUpdate(userName, oldPassword);
            user.Password = newPassword;
            _service.UpdatePasswordEmployee(user);
            MessageBox.Show("Password changed successfully.", "Password Changed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}

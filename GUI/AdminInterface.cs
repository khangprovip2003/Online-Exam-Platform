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
    public partial class AdminInterface : Form
    {
        private EmployeeServices _service = new EmployeeServices();
        public AdminInterface()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to cancel Admin Interface?", "Cancel Admin Interface", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                UserSession.ClearSession();
                this.Close();
            }
        }
        private void RefreshTeacherGrid()
        {
            var teachers = _service.GetAllTeachers();
            dgvTeacher.DataSource = null;
            dgvTeacher.DataSource = teachers;
            dgvTeacher.Columns["Questions"].Visible = false;
        }
        private void AdminInterface_Load(object sender, EventArgs e)
        {
            RefreshTeacherGrid();
        }

        private void dgvTeacher_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvTeacher.SelectedRows.Count > 0)
            {
                var selectedTeacher = (Employee)dgvTeacher.SelectedRows[0].DataBoundItem;    // Have 1 object 
                txtID.Text = selectedTeacher.EmployeeId.ToString();
                txtFullName.Text = selectedTeacher.FullName;
                txtUserName.Text = selectedTeacher.Username;
                txtPassWord.Text = selectedTeacher.Password;
                txtAddress.Text = selectedTeacher.Address;
                txtPhoneNumber.Text = selectedTeacher.PhoneNumber;
            }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtKeyword.Text) == true)
            {
                MessageBox.Show("The Search keyword is required !!!", "Search keyword required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var teachers = _service.SearchTeachers(txtKeyword.Text.Trim());
            dgvTeacher.DataSource = null;
            dgvTeacher.DataSource = teachers;
            dgvTeacher.Columns["Questions"].Visible = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id;
            if (string.IsNullOrWhiteSpace(txtID.Text) || !int.TryParse(txtID.Text, out id))
            {
                MessageBox.Show("The Teacher ID is invalid!!!",
                    "Invalid Book ID",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            var result = MessageBox.Show("Are you sure you want to delete teacher?", "Delete teacher", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                _service.DeleteATeacher(id);
                RefreshTeacherGrid();
                ClearInputFields();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFullName.Text) ||
                string.IsNullOrWhiteSpace(txtUserName.Text) ||
                string.IsNullOrWhiteSpace(txtPassWord.Text))
            {
                MessageBox.Show("All fields are required and cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int? id = int.TryParse(txtID.Text.Trim(), out int parsedId) ? parsedId : (int?)null;
            if (!_service.IsUsernameAndPasswordUniqueAdd(txtUserName.Text, id))
            {
                MessageBox.Show("The username , ID already exist. Please choose different ones.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Employee newTeacher = new Employee()
            {
                FullName = txtFullName.Text.Trim(),
                Username = txtUserName.Text.Trim(),
                Password = txtPassWord.Text.Trim(),
                Position = 0,
                Address = txtAddress.Text.Trim(),
                PhoneNumber = txtPhoneNumber.Text.Trim()
            };
            _service.AddATeacher(newTeacher);
            RefreshTeacherGrid();
            ClearInputFields();
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtID.Text) &&
        int.TryParse(txtID.Text.Trim(), out int id) &&
        !string.IsNullOrWhiteSpace(txtFullName.Text) &&
        !string.IsNullOrWhiteSpace(txtUserName.Text) &&
        !string.IsNullOrWhiteSpace(txtPassWord.Text))
            {
                if (!_service.IsUsernameAndPasswordUnique(txtUserName.Text, id))
                {
                    MessageBox.Show("The username ,ID already exist. Please choose different ones.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                Employee updatedTeacher = new Employee()
                {
                    EmployeeId = id,
                    FullName = txtFullName.Text.Trim(),
                    Username = txtUserName.Text.Trim(),
                    Password = txtPassWord.Text.Trim(),
                    Position = 0,
                    Address = txtAddress.Text.Trim(),
                    PhoneNumber = txtPhoneNumber.Text.Trim()
                };
                _service.UpdateATeacher(updatedTeacher);
                RefreshTeacherGrid();
                ClearInputFields();
            }
            else
            {
                MessageBox.Show("Please ensure the ID is a number and all other fields are filled out correctly.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnListTeacher_Click(object sender, EventArgs e)
        {
            var teachers = _service.GetAllTeachers();
            dgvTeacher.DataSource = null;
            dgvTeacher.DataSource = teachers;
            dgvTeacher.Columns["Questions"].Visible = false;
        }
        private void ClearInputFields()
        {
            txtID.Clear();
            txtFullName.Clear();
            txtUserName.Clear();
            txtPassWord.Clear();
            txtAddress.Clear();
            txtPhoneNumber.Clear();
        }

        private void txtPhoneNumber_TextChanged(object sender, EventArgs e)
        {
            if (!long.TryParse(txtPhoneNumber.Text, out long phoneNumber) || txtPhoneNumber.Text.Length != 10)
            {
                MessageBox.Show("Số điện thoại không hợp lệ. Số điện thoại phải gồm đúng 10 chữ số.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPhoneNumber.Focus();
            }
        }

        private void txtPhoneNumber_Leave(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtPhoneNumber.Text, @"^\d{10}$"))
            {
                MessageBox.Show("The phone number is invalid. It must only contain numbers and be exactly 10 digits long.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPhoneNumber.Focus();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearInputFields();
        }
    }
}

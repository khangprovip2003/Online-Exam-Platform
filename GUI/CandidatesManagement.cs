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
    public partial class CandidatesManagement : Form
    {
        private CandidateServices _service = new CandidateServices();

        public CandidatesManagement()
        {
            InitializeComponent();
        }

        private void RefreshTeacherGrid()
        {
            var candidates = _service.GetAllCandidates();
            dgvCandidates.DataSource = null;
            dgvCandidates.DataSource = candidates;
            dgvCandidates.Columns["Results"].Visible = false;
        }

        private void ClearInputFields()
        {
            txtID.Clear();
            txtFullName.Clear();
            txtUserName.Clear();
            txtPassWord.Clear();
            txtAddress.Clear();
        }
        private void CandidatesManagement1_Load(object sender, EventArgs e)
        {
            RefreshTeacherGrid();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to cancel Candidates Management?", "Cancel Candidates Management", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void dgvCandidates_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvCandidates.SelectedRows.Count > 0)
            {
                var selectedCandidates = (Candidate)dgvCandidates.SelectedRows[0].DataBoundItem;    // Have 1 object 
                txtID.Text = selectedCandidates.CandidateId.ToString();
                txtFullName.Text = selectedCandidates.FullName;
                txtUserName.Text = selectedCandidates.Username;
                txtPassWord.Text = selectedCandidates.Password;
                txtAddress.Text = selectedCandidates.Address;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearInputFields();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            var candidates = _service.GetAllCandidates();
            dgvCandidates.DataSource = null;
            dgvCandidates.DataSource = candidates;
            dgvCandidates.Columns["Results"].Visible = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id;
            if (string.IsNullOrWhiteSpace(txtID.Text) || !int.TryParse(txtID.Text, out id))
            {
                MessageBox.Show("The Candidate ID is invalid!!!",
                    "Invalid Book ID",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            var result = MessageBox.Show("Are you sure you want to delete the Candidates?", "Delete Candidates", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                _service.DeleteACandidate(id);
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
                MessageBox.Show("The username, ID already exist. Please choose different ones.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Candidate newCandidate = new Candidate()
            {
                FullName = txtFullName.Text.Trim(),
                Username = txtUserName.Text.Trim(),
                Password = txtPassWord.Text.Trim(),
                Address = txtAddress.Text.Trim(),
            };
            _service.AddACandidate(newCandidate);
            RefreshTeacherGrid();
            ClearInputFields();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtKeyWord.Text) == true)
            {
                MessageBox.Show("The Search keyword is required !!!", "Search keyword required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var candidates = _service.SearchCandidates(txtKeyWord.Text.Trim());
            dgvCandidates.DataSource = null;
            dgvCandidates.DataSource = candidates;
            dgvCandidates.Columns["Results"].Visible = false;
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
                    MessageBox.Show("The username,ID already exist. Please choose different ones.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                Candidate updatedCandidate = new Candidate()
                {
                    CandidateId = id,
                    FullName = txtFullName.Text.Trim(),
                    Username = txtUserName.Text.Trim(),
                    Password = txtPassWord.Text.Trim(),
                    Address = txtAddress.Text.Trim(),
                };
                _service.UpdateACandidate(updatedCandidate);
                RefreshTeacherGrid();
                ClearInputFields();
            }
            else
            {
                MessageBox.Show("Please ensure the ID is a number and all other fields are filled out correctly.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

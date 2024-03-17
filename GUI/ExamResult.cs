using Repository;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GUI
{
    public partial class ExamResult : Form
    {
        private Result resultData;
        private SubjectServices _serviceSubject = new SubjectServices();
        public ExamResult(Result result)
        {
            InitializeComponent();
            resultData = result;
        }
        private void DisplayResultInfo()
        {
            txtFullName.Text = resultData.CandidateName;
            cobSubject.Text = _serviceSubject.GetASubject(resultData.SubjectId).SubjectName;
            dtpExamDate.Value = resultData.ExamDate;
            btnScore.Text = resultData.Score.ToString("N2");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to cancel Result Exam?", "Cancel Result Exam", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void ExamResult_Load(object sender, EventArgs e)
        {
            DisplayResultInfo();
        }
    }
}

using Repository.Entities;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Services
{
    public class QuestionServices
    {
        private QuestionDBContext _repo = new QuestionDBContext();


        public List<Question> GetAllQuestions(int empId)
        {
            var questions = _repo.GetAll().Where(emp => emp.EmployeeId == empId).ToList();
            return questions;
        }

        public List<Question> SearchQuestions(string keyword, int empId)
        {
            return _repo.GetAll().Where(b => (b.Content.Trim().ToLower().Contains(keyword.ToLower())) &&
                            b.EmployeeId == empId).ToList();
        }

        public bool CheckForDuplicateContent(string content, int subjectId)
        {
            return _repo.GetAll().Any(q => q.Content.Trim().Equals(content, StringComparison.OrdinalIgnoreCase) && q.SubjectId == subjectId);
        }

        public void DeleteAQuestion(int id)
        {
            _repo.Delete(id);
        }

        public int AddAQuestion(Question question)
        {
            _repo.Create(question);
            return question.QuestionId;
        }

        public void UpdateAQuestion(Question quetion)
        {
            _repo.Update(quetion);
        }

        public List<Question> GetRandomQuestions(int numberOfQuestions, int subjectId)
        {
            return _repo.RandomQuestion(numberOfQuestions, subjectId);
        }
    }
}

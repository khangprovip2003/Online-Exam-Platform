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
    public class AnswerServices
    {
        private AnswerDBContext _repo = new AnswerDBContext();


        public List<Answer> GetAllAnswers(int empId)
        {
            var answers = _repo.GetAll().Where(emp => emp.Question.EmployeeId == empId).ToList();
            return answers;
        }
        public List<Answer> GetAllAnswersByQuestionId(int questionId)
        {
            var answers = _repo.GetAll().Where(a => a.QuestionId == questionId).ToList();
            return answers;
        }

        public List<Answer> GetRandomAnswersByQuestionId(int questionId)
        {
            var answers = _repo.RandomAnswers(questionId).ToList();
            return answers;
        }
        public List<Answer> SearchAnswers(string keyword, int empId)
        {
            return _repo.GetAll().Where(b => (b.Question.Content.Trim().ToLower().Contains(keyword.ToLower())) &&
                           (b.Question.EmployeeId == empId)).ToList();
        }
        public void DeleteAAnswer(int id)
        {
            _repo.Delete(id);
        }

        public void AddAAnswer(Answer answer)
        {
            _repo.Create(answer);
        }

        public void UpdateAAnswer(Answer answer)
        {
            _repo.Update(answer);
        }
    }
}

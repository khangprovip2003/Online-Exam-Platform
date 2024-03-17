using Microsoft.EntityFrameworkCore;
using Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class QuestionDBContext
    {
        private OnlineExamPlatformDBContext _dbContext;

        public List<Question> GetAll()
        {
            _dbContext = new OnlineExamPlatformDBContext();
            return _dbContext.Questions.ToList();
        }
        public int Create(Question question)
        {
            _dbContext = new OnlineExamPlatformDBContext();
            _dbContext.Questions.Add(question);
            _dbContext.SaveChanges();
            return question.QuestionId;
        }

        public void Update(Question question)
        {
            _dbContext = new OnlineExamPlatformDBContext();
            _dbContext.Questions.Update(question);
            _dbContext.SaveChanges();
        }

        public void Delete(int id)
        {
            _dbContext = new OnlineExamPlatformDBContext();
            var question = _dbContext.Questions.FirstOrDefault(b => b.QuestionId == id);
            if (question != null)
            {
                _dbContext.Questions.Remove(question);
                _dbContext.SaveChanges();
            }
        }
        public List<Question> RandomQuestion(int numberOfQuestions, int subjectId)
        {
            _dbContext = new OnlineExamPlatformDBContext();
            var randomQuestions = _dbContext.Questions
                                            .Where(q => q.SubjectId == subjectId)
                                            .OrderBy(q => Guid.NewGuid())
                                            .Take(numberOfQuestions)
                                            .Include(q => q.Subject)
                                            .ToList();
            return randomQuestions;
        }
    }
}

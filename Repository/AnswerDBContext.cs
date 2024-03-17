using Microsoft.EntityFrameworkCore;
using Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class AnswerDBContext
    {
        private OnlineExamPlatformDBContext _dbContext;

        public List<Answer> GetAll()
        {
            _dbContext = new OnlineExamPlatformDBContext();
            return _dbContext.Answers.Include(question => question.Question).ToList();
        }
        public List<Answer> RandomAnswers(int questionId)
        {
            _dbContext = new OnlineExamPlatformDBContext();
            return _dbContext.Answers.Where(a => a.QuestionId == questionId).OrderBy(a => Guid.NewGuid()).Include(question => question.Question).ToList();
        }
        public void Create(Answer answer)
        {
            _dbContext = new OnlineExamPlatformDBContext();
            _dbContext.Answers.Add(answer);
            _dbContext.SaveChanges();
        }

        public void Update(Answer answer)
        {
            _dbContext = new OnlineExamPlatformDBContext();
            _dbContext.Answers.Update(answer);
            _dbContext.SaveChanges();
        }

        public void Delete(int id)
        {
            _dbContext = new OnlineExamPlatformDBContext();
            var answer = _dbContext.Answers.FirstOrDefault(b => b.AnswerId == id);
            if (answer != null)
            {
                _dbContext.Answers.Remove(answer);
                _dbContext.SaveChanges();
            }
        }
    }
}

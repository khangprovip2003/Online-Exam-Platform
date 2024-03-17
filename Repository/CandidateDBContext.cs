using Microsoft.EntityFrameworkCore;
using Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class CandidateDBContext
    {
        private OnlineExamPlatformDBContext _dbContext;

        public Candidate? GetCandidatesLogin(string username)
        {
            OnlineExamPlatformDBContext db = new OnlineExamPlatformDBContext();
            var candidate = db.Candidates.FirstOrDefault(x => x.Username.Trim().ToLower() == username.ToLower());
            if (candidate != null && candidate.Username.Trim().Equals(username, StringComparison.Ordinal))
            {
                return candidate;
            }
            return null;
        }


        public Candidate? GetCandidate(int id)
        {
            _dbContext = new OnlineExamPlatformDBContext();
            return _dbContext.Candidates.FirstOrDefault(x => x.CandidateId == id);
        }

        public List<Candidate> GetAll()
        {
            _dbContext = new OnlineExamPlatformDBContext();
            return _dbContext.Candidates.ToList();
        }

        public void Create(Candidate candidate)
        {
            _dbContext = new OnlineExamPlatformDBContext();
            _dbContext.Candidates.Add(candidate);
            _dbContext.SaveChanges();
        }

        public void Update(Candidate candidate)
        {
            _dbContext = new OnlineExamPlatformDBContext();
            _dbContext.Candidates.Update(candidate);
            _dbContext.SaveChanges();
        }

        public void Delete(int id)
        {
            _dbContext = new OnlineExamPlatformDBContext();
            var candidate = _dbContext.Candidates.FirstOrDefault(b => b.CandidateId == id);
            if (candidate != null)
            {
                _dbContext.Candidates.Remove(candidate);
                _dbContext.SaveChanges();
            }
        }


    }
}

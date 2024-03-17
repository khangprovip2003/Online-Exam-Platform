using Repository;
using Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class ResultServices
    {
        private ResultDBContext _repo = new ResultDBContext();

        public List<Result> GetAllResults()
        {
            var results = _repo.GetAll().ToList();
            return results;
        }

        public void AddAResult(Result result)
        {
            _repo.Create(result);
        }

        public List<Result> GetAllScoresById(int cadId)
        {
            var results = _repo.GetAll().Where(cad => cad.CandidateId == cadId).ToList();
            return results;
        }

        public List<Result> GetScoresByDateAndCandidateId(DateTime date, int candidateId)
        {
            return _repo.GetAll()
                        .Where(r => r.CandidateId == candidateId && r.ExamDate.Date == date.Date)
                        .ToList();
        }

        public List<Result> GetScoresByDate(DateTime date)
        {
            return _repo.GetAll()
                .Where(r => r.ExamDate.Date == date.Date)
                .ToList();
        }

        public List<Result> GetScoresByDateAndFullName(DateTime date, string fullName)
        {
            return _repo.GetAll()
                        .Where(r => r.ExamDate.Date == date.Date &&
                                    r.CandidateName.Trim().ToLower().Contains(fullName.ToLower()))
                        .ToList();
        }
    }
}

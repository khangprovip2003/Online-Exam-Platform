using Microsoft.EntityFrameworkCore;
using Repository;
using Repository.Entities;

namespace Services
{
    public class CandidateServices
    {
        private CandidateDBContext _repo = new CandidateDBContext();

        public List<Candidate> GetAllCandidates()
        {
            var candidates = _repo.GetAll().ToList();
            return candidates;
        }
        public bool IsUsernameAndPasswordUniqueAdd(string username, int? id)
        {
            bool exists = _repo.GetAll().Any(emp =>
                          emp.Username.Trim().Equals(username.Trim()) ||
                                             emp.CandidateId == id);
            return !exists;
        }

        public bool IsUsernameAndPasswordUnique(string username, int? excludedEmployeeId = null)
        {
            bool exists = _repo.GetAll().Where(emp => (!excludedEmployeeId.HasValue || emp.CandidateId != excludedEmployeeId)).Any(emp =>
                          emp.Username.Trim().Equals(username.Trim()));
            return !exists;
        }
        public void DeleteACandidate(int id)
        {
            _repo.Delete(id);
        }

        public Candidate? GetACandidate(int id)
        {
            return _repo.GetCandidate(id);
        }
        public void AddACandidate(Candidate candidate)
        {
            _repo.Create(candidate);
        }

        public void UpdateACandidate(Candidate candidate)
        {
            _repo.Update(candidate);
        }

        public List<Candidate> SearchCandidates(string keyword)
        {
            return _repo.GetAll().Where(b => b.FullName.ToLower().Contains(keyword.ToLower())).ToList();
        }
    }
}

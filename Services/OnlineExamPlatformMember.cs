using Microsoft.EntityFrameworkCore;
using Repository;
using Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class OnlineExamPlatformMember
    {
        public Employee checkLoginEmployee(String username, String password)
        {
            EmployeeDBContext repo = new EmployeeDBContext();
            Employee employees = repo.GetEmployeeLogin(username);
            return employees != null && employees.Password.Trim() == password ? employees : null;
        }

        public Candidate checkLoginCandidates(String username, String password)
        {
            CandidateDBContext repo = new CandidateDBContext();
            Candidate candidates = repo.GetCandidatesLogin(username);
            return candidates != null && candidates.Password.Trim() == password ? candidates : null;
        }

        public bool IsUsernameAndPasswordChangePass(string username, string password)
        {
            CandidateDBContext repo = new CandidateDBContext();
            bool exists = repo.GetAll().Any(emp =>
                          emp.Username.Trim().Equals(username.Trim(), StringComparison.OrdinalIgnoreCase) &&
                          emp.Password.Trim().Equals(password.Trim(), StringComparison.OrdinalIgnoreCase));
            return !exists;
        }
        public bool IsUsernameAndPasswordUniqueCandidates(string username)
        {
            CandidateDBContext repo = new CandidateDBContext();
            bool exists = repo.GetAll().Any(emp =>
                          emp.Username.Trim().Equals(username.Trim(), StringComparison.OrdinalIgnoreCase));
            return !exists;
        }
        public bool IsUsernameAndPasswordUniquEmployee(string username, string password)
        {
            EmployeeDBContext repo = new EmployeeDBContext();
            bool exists = repo.GetAll().Any(emp =>
                          emp.Username.Trim().Equals(username.Trim(), StringComparison.OrdinalIgnoreCase) &&
                          emp.Password.Trim().Equals(password.Trim(), StringComparison.OrdinalIgnoreCase));
            return !exists;
        }
        public void AddRegiter(Candidate candidate)
        {
            CandidateDBContext repo = new CandidateDBContext();
            repo.Create(candidate);
        }
        public Candidate? GetACandidateToUpdate(string username, string password)
        {
            CandidateDBContext repo = new CandidateDBContext();
            return repo.GetAll().FirstOrDefault(emp =>
                          emp.Username.Trim().Equals(username.Trim(), StringComparison.OrdinalIgnoreCase) &&
                          emp.Password.Trim().Equals(password.Trim(), StringComparison.OrdinalIgnoreCase));

        }
        public Employee? GetAEmployeeToUpdate(string username, string password)
        {
            EmployeeDBContext repo = new EmployeeDBContext();
            return repo.GetAll().FirstOrDefault(emp =>
                          emp.Username.Trim().Equals(username.Trim(), StringComparison.OrdinalIgnoreCase) &&
                          emp.Password.Trim().Equals(password.Trim(), StringComparison.OrdinalIgnoreCase));

        }
        public void UpdatePasswordCandidate(Candidate candidate)
        {
            CandidateDBContext repo = new CandidateDBContext();
            repo.Update(candidate);
        }

        public void UpdatePasswordEmployee(Employee employee)
        {
            EmployeeDBContext repo = new EmployeeDBContext();
            repo.Update(employee);
        }
    }
}

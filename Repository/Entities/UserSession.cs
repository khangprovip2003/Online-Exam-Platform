using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Entities
{
    public static partial class UserSession
    {

        public static Employee SessionEmployee { get; private set; }

        public static Candidate SessionCandidate { get; private set; }

        public static void SetSessionEmployee(Employee employee)
        {
            SessionEmployee = employee;
            SessionCandidate = null;
        }

        public static void SetSessionCandidate(Candidate candidate)
        {
            SessionCandidate = candidate;
            SessionEmployee = null;
        }

        public static void ClearSession()
        {
            SessionEmployee = null;
            SessionCandidate = null;
        }
    }
}

using System;
using System.Collections.Generic;

namespace Repository.Entities
{
    public partial class Candidate
    {
        public Candidate()
        {
            Results = new HashSet<Result>();
        }

        public int CandidateId { get; set; }
        public string FullName { get; set; } = null!;
        public string Username { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string? Address { get; set; }

        public virtual ICollection<Result> Results { get; set; }
    }
}

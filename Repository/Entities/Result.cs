using System;
using System.Collections.Generic;

namespace Repository.Entities
{
    public partial class Result
    {
        public int ResultId { get; set; }
        public int CandidateId { get; set; }
        public string CandidateName { get; set; } = null!;
        public int SubjectId { get; set; }
        public float Score { get; set; }
        public DateTime ExamDate { get; set; }

        public virtual Candidate Candidate { get; set; } = null!;
        public virtual Subject Subject { get; set; } = null!;
    }
}

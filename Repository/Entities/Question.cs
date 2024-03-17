using System;
using System.Collections.Generic;

namespace Repository.Entities
{
    public partial class Question
    {
        public Question()
        {
            Answers = new HashSet<Answer>();
        }

        public int QuestionId { get; set; }
        public string Content { get; set; } = null!;
        public int SubjectId { get; set; }
        public int EmployeeId { get; set; }

        public virtual Employee Employee { get; set; } = null!;
        public virtual Subject Subject { get; set; } = null!;
        public virtual ICollection<Answer> Answers { get; set; }
    }
}

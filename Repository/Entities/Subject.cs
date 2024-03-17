using System;
using System.Collections.Generic;

namespace Repository.Entities
{
    public partial class Subject
    {
        public Subject()
        {
            Questions = new HashSet<Question>();
            Results = new HashSet<Result>();
        }

        public int SubjectId { get; set; }
        public string SubjectName { get; set; } = null!;

        public virtual ICollection<Question> Questions { get; set; }
        public virtual ICollection<Result> Results { get; set; }
    }
}

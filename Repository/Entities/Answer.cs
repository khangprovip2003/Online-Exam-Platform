using System;
using System.Collections.Generic;

namespace Repository.Entities
{
    public partial class Answer
    {
        public int QuestionId { get; set; }
        public int AnswerId { get; set; }
        public string Content { get; set; } = null!;
        public string AnswerType { get; set; } = null!;

        public virtual Question Question { get; set; } = null!;
    }
}

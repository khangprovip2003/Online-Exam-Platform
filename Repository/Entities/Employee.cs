using System;
using System.Collections.Generic;

namespace Repository.Entities
{
    public partial class Employee
    {
        public Employee()
        {
            Questions = new HashSet<Question>();
        }

        public int EmployeeId { get; set; }
        public string FullName { get; set; } = null!;
        public string Username { get; set; } = null!;
        public string Password { get; set; } = null!;
        public int Position { get; set; }
        public string? Address { get; set; }
        public string? PhoneNumber { get; set; }

        public virtual ICollection<Question> Questions { get; set; }
    }
}

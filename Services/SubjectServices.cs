using Repository;
using Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class SubjectServices
    {
        private SubjectDBContext _repo = new SubjectDBContext();

        public List<Subject> GetAllSubjects()
        {
            var subjects = _repo.GetAll().ToList();
            return subjects;
        }
        public Subject? GetASubject(int id)
        {
            return _repo.GetSubject(id);
        }
    }
}

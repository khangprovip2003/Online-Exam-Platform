using Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class SubjectDBContext
    {
        private OnlineExamPlatformDBContext _dbContext;

        public List<Subject> GetAll()
        {
            _dbContext = new OnlineExamPlatformDBContext();
            return _dbContext.Subjects.ToList();
        }
        public Subject? GetSubject(int id)
        {
            _dbContext = new OnlineExamPlatformDBContext();
            return _dbContext.Subjects.FirstOrDefault(x => x.SubjectId == id);
        }
    }
}

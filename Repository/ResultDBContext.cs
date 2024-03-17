using Microsoft.EntityFrameworkCore;
using Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class ResultDBContext
    {
        private OnlineExamPlatformDBContext _dbContext;

        public List<Result> GetAll()
        {
            _dbContext = new OnlineExamPlatformDBContext();
            return _dbContext.Results.Include(q => q.Subject).ToList();
        }
        public void Create(Result result)
        {
            _dbContext = new OnlineExamPlatformDBContext();
            _dbContext.Results.Add(result);
            _dbContext.SaveChanges();
        }
    }
}

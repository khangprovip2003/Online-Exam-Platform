using Microsoft.EntityFrameworkCore;
using Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class EmployeeDBContext
    {
        private OnlineExamPlatformDBContext _dbContext;

        public Employee? GetEmployeeLogin(string username)
        {
            _dbContext = new OnlineExamPlatformDBContext();
            var employee = _dbContext.Employees.FirstOrDefault(x => x.Username.Trim().ToLower() == username.ToLower());
            if (employee != null && employee.Username.Trim().Equals(username, StringComparison.Ordinal))
            {
                return employee;
            }
            return null;
        }

        public Employee? GetEmployee(int id)
        {
            _dbContext = new OnlineExamPlatformDBContext();
            return _dbContext.Employees.FirstOrDefault(x => x.EmployeeId == id);
        }
        public List<Employee> GetAll()
        {
            _dbContext = new OnlineExamPlatformDBContext();
            return _dbContext.Employees.ToList();
        }

        public void Create(Employee employee)
        {
            _dbContext = new OnlineExamPlatformDBContext();
            _dbContext.Employees.Add(employee);
            _dbContext.SaveChanges();
        }

        public void Update(Employee employee)
        {
            _dbContext = new OnlineExamPlatformDBContext();
            _dbContext.Employees.Update(employee);
            _dbContext.SaveChanges();
        }
        public void Delete(int id)
        {
            _dbContext = new OnlineExamPlatformDBContext();
            var employee = _dbContext.Employees.FirstOrDefault(b => b.EmployeeId == id);
            if (employee != null)
            {
                _dbContext.Employees.Remove(employee);
                _dbContext.SaveChanges();
            }
        }

    }
}

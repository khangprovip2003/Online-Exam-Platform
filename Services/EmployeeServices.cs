using Repository;
using Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class EmployeeServices
    {
        private EmployeeDBContext _repo = new EmployeeDBContext();


        public List<Employee> GetAllTeachers()
        {
            var teachers = _repo.GetAll().Where(emp => emp.Position == 0).ToList();
            return teachers;
        }
        public bool IsUsernameAndPasswordUniqueAdd(string username, int? id)
        {
            bool exists = _repo.GetAll().Where(emp => emp.Position == 0).Any(emp =>
                          emp.Username.Equals(username.Trim()) ||
                                             emp.EmployeeId == id);
            return !exists;
        }

        public bool IsUsernameAndPasswordUnique(string username, int? excludedEmployeeId = null)
        {
            bool exists = _repo.GetAll().Where(emp => emp.Position == 0 &
                      (!excludedEmployeeId.HasValue || emp.EmployeeId != excludedEmployeeId)).Any(emp =>
                          emp.Username.Equals(username.Trim()));
            return !exists;
        }

        public List<Employee> SearchTeachers(string keyword)
        {
            return _repo.GetAll().Where(b => (b.FullName.ToLower().Contains(keyword.ToLower()) ||
                            b.PhoneNumber.ToLower().Contains(keyword.Trim().ToLower())) &&
                            b.Position == 0).ToList();
        }

        public void DeleteATeacher(int id)
        {
            _repo.Delete(id);
        }

        public void AddATeacher(Employee teacher)
        {
            _repo.Create(teacher);
        }

        public void UpdateATeacher(Employee teacher)
        {
            _repo.Update(teacher);
        }
    }
}

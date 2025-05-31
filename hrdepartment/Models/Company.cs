using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hrdepartment.Models
{
    internal class Company
    {
        public List<Department> Departments { get; set; }

        public Company()
        {
            Departments = new List<Department>();
        }

        public void AddDepaertment(Department department)
        {
            Departments.Add(department);
        }

        public void AddDepartment(Department department)
        {
            Departments.Add(department);
        }

        public void RemoveDepartment ( int departmentId)
        {
            var departmentToRemove = Departments.FirstOrDefault(d => d.Id == departmentId);
            if (departmentToRemove != null)
            {
                Departments.Remove(departmentToRemove);
            }
        }
    }
}

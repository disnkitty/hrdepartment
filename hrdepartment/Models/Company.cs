using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace hrdepartment.Models
{
    internal class Company
    {
        public List<Department> Departments { get; set; }
        public List<Order> Orders { get; set; }
        public Company()
        {
            Departments = new List<Department>();
            Orders = new List<Order>();
        }

        public void AddDepartment(Department department)
        {
            Departments.Add(department);
        }

        public void RemoveDepartment(int departmentId)
        {
            var departmentToRemove = Departments.FirstOrDefault(d => d.Id == departmentId);
            if (departmentToRemove != null)
            {
                Departments.Remove(departmentToRemove);
            }
        }

        public void EditDepartment(string name, Department updatedDepartment)
        {
            var existing = Departments.FirstOrDefault(d => d.Name == name);
            if (existing != null)
            {
                existing.Name = updatedDepartment.Name;
                existing.Manager = updatedDepartment.Manager;
                existing.Id = updatedDepartment.Id;
            }
        }

        //прикази
        public void CreateOrder(Order order)
        {
            Orders.Add(order);
        }



    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.IO;
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

        public void GenerateRetirementOrders()
        {
            var pensionEmployees = Departments
                .SelectMany(d => d.Employees)
                .Where(e => e.Age >= 60)
                .ToList();

            foreach (var employee in pensionEmployees)
            {
                var order = new Order
                {
                    Id = Guid.NewGuid().ToString(),
                    Date = DateTime.Now,
                    OrderType = "Звільнення",
                    Employee = employee,
                    Description = "Звільнення у зв’язку з досягненням пенсійного віку"
                };

                Orders.Add(order);
                var fileName = $"order_{employee.LastName}_{employee.Id}.txt";
                order.GenerateOrderTextFile(fileName);
            }
        }

        public void ExportAllOrders(string filePath)
        {
            var lines = new List<string>();

            foreach (var order in Orders)
            {
                lines.Add($"Наказ №{order.Id}");
                lines.Add($"Дата: {order.Date.ToShortDateString()}");
                lines.Add($"Тип: {order.OrderType}");
                lines.Add($"Співробітник: {order.Employee.LastName} {order.Employee.FirstName} {order.Employee.MiddleName}");
                lines.Add($"Опис: {order.Description}");
                lines.Add("");
            }

            File.WriteAllLines(filePath, lines);
        }


        public void GenerateTransferOrder(Employee employee, Department newDepartment, string reason)
        {
            var order = new Order
            {
                Id = Guid.NewGuid().ToString(),
                Date = DateTime.Now,
                OrderType = "Переведення",
                Employee = employee,
                Description = reason
            };

            Orders.Add(order);

            var oldDepartment = Departments.FirstOrDefault(d => d.Employees.Contains(employee));
            oldDepartment?.Employees.Remove(employee);
            newDepartment.AddEmployee(employee);
            employee.Department = newDepartment;

            var fileName = $"transfer_order_{employee.LastName}_{employee.Id}.txt";
            order.GenerateOrderTextFile(fileName);
        }
        public List<Employee> SearchEmployees(string lastName = null, string position = null, string departmentName = null)
        {
            return Departments
                .SelectMany(d => d.Employees)
                .Where(e =>
                    (lastName == null || e.LastName.Contains(lastName)) &&
                    (position == null || e.Position == position) &&
                    (departmentName == null || e.Department.Name == departmentName))
                .ToList();
        }

        public List<Employee> GetPensionEmployees()
        {
            return Departments
                .SelectMany(d => d.Employees)
                .Where(e => e.Age >= 60)
                .ToList();
        }
        public List<Employee> GetEmployeesByDepartment(int departmentId)
        {
            var department = Departments.FirstOrDefault(d => d.Id == departmentId);
            return department?.Employees ?? new List<Employee>();
        }
        


    }
}

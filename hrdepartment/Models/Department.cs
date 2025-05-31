using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hrdepartment.Models
{
    internal class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Employee Manager { get; set; }
        public List<Employee> Employees { get; set; }

        public Department()
        {
            Employees = new List<Employee>();
        }


        public int GetEmployeeCount()
        {
            return Employees.Count;
        }



        //methods

        public void AddEmployee(Employee employee)
        {
            Employees.Add(employee);
        }

        public void EditEmployee(Employee updatedEmployee)
        {
            var existingEmployee = Employees.FirstOrDefault(e => e.Id == updatedEmployee.Id);

            if (existingEmployee != null)
            {
                existingEmployee.LastName = updatedEmployee.LastName;
                existingEmployee.FirstName = updatedEmployee.FirstName;
                existingEmployee.MiddleName = updatedEmployee.MiddleName;
                existingEmployee.DateOfBirth = updatedEmployee.DateOfBirth;
                existingEmployee.PassportData = updatedEmployee.PassportData;
                existingEmployee.Education = updatedEmployee.Education;
                existingEmployee.Specialty = updatedEmployee.Specialty;
                existingEmployee.Position = updatedEmployee.Position;
                existingEmployee.Salary = updatedEmployee.Salary;
                existingEmployee.HireDate = updatedEmployee.HireDate;
                existingEmployee.Department = updatedEmployee.Department;
                existingEmployee.LastAppointmentDate = updatedEmployee.LastAppointmentDate;
            }
        }

        public void RemoveEmployee(int employeeId)
        {
            var employeeToRemove = Employees.FirstOrDefault(e => e.Id == employeeId);
            if (employeeToRemove != null)
            {
                Employees.Remove(employeeToRemove);
            }
        }

        public Employee GetEmployeeById(int id)
        {
            return Employees.FirstOrDefault(e => e.Id == id);
        }

        public List<Employee> FindEmployeesByLastName(string lastName)
        {
            return Employees.Where(e => e.LastName == lastName).ToList();
        }


        public List<Employee> GetEmployeesByDepartmentName(string departmentName)
        {
            return Employees.Where( e => e.Department!=null && e.Department.Name == departmentName).ToList();

        }


    }


}



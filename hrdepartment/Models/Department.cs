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





    }


}



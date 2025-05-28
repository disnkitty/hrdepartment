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
            public string Manager { get; set; }    
            public List<Employee> Employees { get; set; }    

            public Department()
            {
                Employees = new List<Employee>();
            }
        }
    }



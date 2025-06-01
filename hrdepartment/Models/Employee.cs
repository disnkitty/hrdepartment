using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hrdepartment.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string LastName { get; set; }

        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public DateTime DateOfBirth { get; set; }
       

        public string PassportData { get; set; }
        public string Education { get; set; }
        public string Specialty { get; set; }
        public string Position { get; set; }
        public decimal Salary { get; set; }


        public DateTime HireDate { get; set; } //Дата прийому на роботу
        public Department Department { get; set; }
        public DateTime LastAppointmentDate { get; set; }//Дата останнього призначення


        //методи
        public string FullName => $"{LastName} {FirstName} {MiddleName}";
        public int Age => DateTime.Now.Year - DateOfBirth.Year;
        public string DepartmentName => Department?.Name;
        public string FullInfo => $"{Position}, {Department?.Name}";



    }
}

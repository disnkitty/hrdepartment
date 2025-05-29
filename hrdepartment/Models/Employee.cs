using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hrdepartment.Models
{
    internal class Employee
    {
        public int Id { get; set; }
        public string LastName { get; set; }

        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int Age
        {
            get
            {
                var today = DateTime.Today;
                int age = today.Year - DateOfBirth.Year;
                if (DateOfBirth > today.AddYears(-age)) age--;
                return age;
            }
        }

        public string PassportData { get; set; }
        public string Education { get; set; }
        public string Specialty { get; set; }
        public string Position { get; set; }
        public decimal Salary { get; set; }
       

        public DateTime HireDate { get; set; } //Дата прийому на роботу
        public Department Department { get; set; }
        public DateTime LastAppointmentDate { get; set; }//Дата останнього призначення

    }
}

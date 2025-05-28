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
        public string PassportData { get; set; }
        public string Education { get; set; }
        public string Specialty { get; set; }
        public string Position { get; set; }
        public string Salary { get; set; }
        public string HireDate { get; set; }
        public Department Department { get; set; }
        public DateTime LastAppointmentDate { get; set; }

    }
}

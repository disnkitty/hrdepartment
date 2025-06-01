using hrdepartment.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hrdepartment
{
    public partial class EmployeeDetailsForm : Form
    {
        public EmployeeDetailsForm()
        {
            InitializeComponent();
        }

        private void EditDetailsemployee_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Нажата кнопка Edit");
        }
        private Employee currentEmployee;

        public void SetEmployee(Employee employee)
        {
            currentEmployee = employee;

            label1.Text = currentEmployee.LastName;
            label2.Text = currentEmployee.FirstName;
            label3.Text = currentEmployee.MiddleName;
            label4.Text = currentEmployee.DateOfBirth.ToShortDateString();
            label5.Text = currentEmployee.Age.ToString();
            label6.Text = currentEmployee.PassportData;
            label7.Text = currentEmployee.Education;
            label8.Text = currentEmployee.Specialty;
            label9.Text = currentEmployee.Department.Name;
            label10.Text = currentEmployee.Position;
            label11.Text = currentEmployee.Salary.ToString("C");
            label12.Text = currentEmployee.HireDate.ToShortDateString();
            label13.Text = currentEmployee.LastAppointmentDate.ToShortDateString();
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

    }
}

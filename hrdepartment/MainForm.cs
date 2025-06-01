using hrdepartment.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace hrdepartment
{
    public partial class MainForm : Form
    {
        private Company company = new Company();

        public MainForm()
        {
            InitializeComponent();

            company.AddDepartment(new Department { Id = 1, Name = "HR" });
            company.AddDepartment(new Department { Id = 2, Name = "IT" });
            company.AddDepartment(new Department { Id = 3, Name = "Sales" });

            var department = new Department { Id = 1, Name = "IT-відділ" };
            var employee1 = new Employee
            {
                Id = 1,
                LastName = "Іваненко",
                FirstName = "Іван",
                MiddleName = "Іванович",
                DateOfBirth = new DateTime(1985, 5, 10),
                PassportData = "AB123456",
                Education = "Вища",
                Specialty = "Програміст",
                Position = "Senior Developer",
                Salary = 50000,
                HireDate = new DateTime(2010, 6, 1),
                LastAppointmentDate = new DateTime(2020, 1, 1),
                Department = department
            };

            department.AddEmployee(employee1);
            company.AddDepartment(department);

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = company.Departments.SelectMany(d => d.Employees).ToList();

            id.DataPropertyName = "Id";
            FullName.DataPropertyName = "FullName";
            Age.DataPropertyName = "Age";
            departmentColumn.DataPropertyName = "DepartmentName";
            Position.DataPropertyName = "Position";
            FullInfo.DataPropertyName = "FullInfo";

            this.Load += MainForm_Load;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            departmentComboBox.Items.Clear();
            foreach (var dept in company.Departments)
            {
                departmentComboBox.Items.Add(dept.Name);
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var employee = (Employee)dataGridView1.Rows[e.RowIndex].DataBoundItem;
                var detailsForm = new EmployeeDetailsForm();
                detailsForm.SetEmployee(employee);
                detailsForm.ShowDialog();
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}

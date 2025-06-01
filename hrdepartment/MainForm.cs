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
    public partial class MainForm : Form
    {
        private Company company;

        public MainForm()
        {
            InitializeComponent();
            company = new Company();

            company.AddDepartment(new Department { Id = 1, Name = "HR" });
            company.AddDepartment(new Department { Id = 2, Name = "IT" });
            company.AddDepartment(new Department { Id = 3, Name = "Sales" });

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

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}

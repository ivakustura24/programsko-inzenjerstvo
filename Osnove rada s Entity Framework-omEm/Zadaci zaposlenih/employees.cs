using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _11_EmployeesTasks
{
    public partial class TasksFrm : Form
    {
        public TasksFrm()
        {
            InitializeComponent();
        }

        private void TasksFrm_Load(object sender, EventArgs e)
        {
            dgvEmployees.DataSource = GetEmployees();
            dgvEmployees.Columns["Tasks"].Visible = false;

            dgvTasks.DataSource = GetTasks();
            dgvTasks.Columns["Employee"].Visible = false;

            List <int > priority = new List<int>()
            {
                1,2,3,4,5
            };

            cmbPriority.DataSource = priority;
        }

        private object GetTasks()
        {
            using (var context = new EF_DBEntities())
            {
                return context.Tasks.ToList();
            }
        }

        private object GetEmployees()
        {
            using (var context = new EF_DBEntities())
            {
                return context.Employees.ToList();
            }
        }
        private void Osvjezi()
        {
            
            Employee selectedEmployee = GetEmployee();
            dgvTasks.DataSource = GetEmployeesTasks(selectedEmployee);
        }
        private void dgvEmployees_SelectionChanged(object sender, EventArgs e)
        {
            Osvjezi();
        }

        private object GetEmployeesTasks(Employee selectedEmployee)
        {
            using (var context = new EF_DBEntities())
            {
                context.Employees.Attach(selectedEmployee);
                return selectedEmployee.Tasks.ToList();
            }
        }

        private Employee GetEmployee()
        {
            return dgvEmployees.CurrentRow.DataBoundItem as Employee;
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            using (var context = new EF_DBEntities())
            {
                string fname = tbFirstName.Text;
                string lname = tbLastName.Text;

                Employee employee = new Employee()
                {
                    FirstName = fname,
                    LastName = lname
                };
                context.Employees.Add(employee);
                context.SaveChanges();
            }
           dgvEmployees.DataSource = GetEmployees();
           tbFirstName.Clear();
           tbLastName.Clear(); 
        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            using (var context = new EF_DBEntities())
            {
                string description = tbDescription.Text;
                int priority = int.Parse(cmbPriority.SelectedItem.ToString());
                Employee employee = GetEmployee();
                context.Employees.Attach(employee);
                Task task = new Task()
                {
                    Description = description,
                    Priority = priority,
                    EmployeeId = employee.Id
                };
                context.Tasks.Add(task);
                context.SaveChanges();

            }
            tbDescription.Clear();
            
            Osvjezi();
        }

        private void btnDeleteTask_Click(object sender, EventArgs e)
        {
           
            using (var context = new EF_DBEntities())
            {
                Task task = dgvTasks.CurrentRow.DataBoundItem as Task;
                context.Tasks.Attach(task);
                context.Tasks.Remove(task);
                context.SaveChanges();
            }
            Osvjezi();
        }
    }
}

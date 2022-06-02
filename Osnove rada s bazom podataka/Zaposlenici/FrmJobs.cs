using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EmployeeJobLogic;
namespace ADO_EmployeesJob
{
    public partial class FrmJobs : Form
    {
        JobRepository _jobRepository = new JobRepository();
        Employee emp = new Employee();
        EmployeeRepository _employeeRepository = new EmployeeRepository();
        public FrmJobs(Employee employee)
        {
            InitializeComponent();
            emp = employee;
        }

        private void FrmJobs_Load(object sender, EventArgs e)
        {
            Osvjezi();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Job job = dgvJobs.CurrentRow.DataBoundItem as Job;
            int i = _employeeRepository.Update(emp, job);
            FrmEmployees frmEmployees = new FrmEmployees();
            frmEmployees.Show();
            this.Close();
        }
        private void Osvjezi()
        {
            dgvJobs.DataSource = _jobRepository.GetJobs();
        }
    }
}

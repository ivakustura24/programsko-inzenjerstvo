using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JobEmployeesLogic;

namespace ADO_Jobs
{
    public partial class FrmJobsEmployees : Form
    {
        private JobRepository _jobRepository = new JobRepository();
        private EmployeeRepository _employeeRepository = new EmployeeRepository();
        public FrmJobsEmployees()
        {
            InitializeComponent();
        }

        private void FrmJobsEmployees_Load(object sender, EventArgs e)
        {
            Osvjezi();
        }

        private void dgvJobs_SelectionChanged(object sender, EventArgs e)
        {
            Job job = dgvJobs.CurrentRow.DataBoundItem as Job;
            int jobid = job.Id;
            dgvEmployees.DataSource = _employeeRepository.GetEmployees(jobid);
        }

        private void btnAddJob_Click(object sender, EventArgs e)
        {
            string description = txtDescription.Text.ToString();
            int min = int.Parse(txtMinLevel.Text);
            int max = int.Parse(txtMaxLevel.Text);
            _jobRepository.InsertJob(description, min, max);
            Osvjezi();
        }

        public void Osvjezi()
        {
           dgvJobs.DataSource = _jobRepository.GetJobs();
           
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADO_Employees
{
    public partial class FrmAddEmployee : Form
    {
        JobRepository _jobRepository = new JobRepository();
        PublisherRepository _publisherRepository = new PublisherRepository();
        EmployeeRepository _employeeRepository = new EmployeeRepository();
        public FrmAddEmployee()
        {
            InitializeComponent();
        }

        private void FrmAddEmployee_Load(object sender, EventArgs e)
        {
            List<Job> jobs = _jobRepository.GetJobs();
            List<Publisher> publisher = _publisherRepository.GetPublishers();
            List<string> _jobs = new List<string>();
            foreach (Job job in jobs)
            {
                cmbJob.Items.Add(job.JobDesc);
            }
            cmbJob.Items.Add(_jobs);
            List<string> _publisher = new List<string>();
            foreach(Publisher p in publisher)
            {
                cmbPublisher.Items.Add(p.PubName);
            }
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string empid = txtEmpId.Text;
            string fname = txtFName.Text;
            string lname = txtLName.Text;
            string jobSelected = cmbJob.SelectedItem as String;
            string publisher = cmbPublisher.SelectedItem as String;
            List<Publisher> publishers = _publisherRepository.GetPublishers();
            List<Job> jobs = _jobRepository.GetJobs();
            int jobid = 0;
            foreach (Job j in jobs)
            {
                if(j.JobDesc == jobSelected)
                {
                    jobid = j.JobId;
                }
            }
            string pubid = "";
            
            foreach(Publisher p in publishers)
            {
                if(p.PubName== publisher)
                {
                    pubid = p.PubId;
                }
            }
       
            int i= _employeeRepository.Insert( empid, fname, lname,jobid, pubid);
            FrmEmployees employees = new FrmEmployees();
            employees.Show();
            this.Close();
        }
    }
}

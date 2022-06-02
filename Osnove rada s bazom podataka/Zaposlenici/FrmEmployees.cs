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
    public partial class FrmEmployees : Form
    {
        EmployeeRepository _employeeRepository = new EmployeeRepository();
        public FrmEmployees()
        {
            InitializeComponent();
            Osvjezi();
        }

        private void FrmEmployees_Load(object sender, EventArgs e)
        {
            Osvjezi();
        }

        private void btnChangeJob_Click(object sender, EventArgs e)
        {
            Employee emp = dgvEmployees.CurrentRow.DataBoundItem as Employee;
            FrmJobs jobsfrm = new FrmJobs(emp);
            jobsfrm.Show();
            this.Hide();
        }

        public void Osvjezi()
        {
            dgvEmployees.DataSource = _employeeRepository.GetEmployees();
            
        }
    }
}

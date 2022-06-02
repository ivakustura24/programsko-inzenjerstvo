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

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            FrmAddEmployee frmAddEmployee = new FrmAddEmployee();
            frmAddEmployee.Show();
            this.Hide();
        }

        public void Osvjezi()
        {
            dgvEmployees.DataSource = _employeeRepository.GetEmployees();
        }
    }
}

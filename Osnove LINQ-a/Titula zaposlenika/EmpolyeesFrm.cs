using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _04_titula_zaposlenika
{
    public partial class EmployeesFrm : Form
    {
        public EmployeesFrm()
        {
            InitializeComponent();
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            ShowAllF();
        }

        private void ShowAllF()
        {
            using (var context = new NorthwindEntities())
            {
                var query = from e in context.Employees
                            select new { e.FirstName, e.LastName, e.Title, e.City, e.Country };
                dgvEmployees.DataSource = query.ToList();

            }
        }

        private void EmployeesFrm_Load(object sender, EventArgs e)
        {
            ShowAllF();
            FillTitles();
        }

        private void FillTitles()
        {
            using (var context = new NorthwindEntities())
            {
                var query = from e in context.Employees
                            select e.Title.ToString();

                cmbTitle.DataSource = query.Distinct().ToList();
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            var title = cmbTitle.SelectedItem as string;
            using (var context = new NorthwindEntities())
            {
                var query = from f in context.Employees
                            where title == f.Title
                            select new
                            {
                                f.FirstName,
                                f.LastName,
                                f.Title,
                                f.City,
                                f.Country
                            };

                dgvEmployees.DataSource = query.ToList();

            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string find = TbName.Text.ToString();

            using (var context = new NorthwindEntities())
            {
                var query = from l in context.Employees
                            where l.FirstName.Contains (find) || l.LastName.Contains (find) 
                            select new
                            {
                                l.FirstName,
                                l.LastName,
                                l.Title,
                                l.City,
                                l.Country
                            };

                dgvEmployees.DataSource = query.ToList();

            }
        }
    }
}
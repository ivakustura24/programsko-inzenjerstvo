using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _14_Izvrseni_zadatci
{
    public partial class tasksFrm : Form
    {
        public tasksFrm()
        {
            InitializeComponent();
        }

        private void tasksFrm_Load(object sender, EventArgs e)
        {
            Osvjezi();
            List<int> priority = new List<int>()
            {
                1,2,3,4,5
            };
            cmbPriority.DataSource = priority;
        }

        private void Osvjezi()
        {
            OsvjeziOtvorene();
            OsvjeziIzvrsene();
            
        }

        private void OsvjeziIzvrsene()
        {
            dgvIzvrseni.DataSource = DohvatiIzvrsene();
            dgvIzvrseni.Columns["Employee"].Visible = false;
        }

        private object DohvatiIzvrsene()
        {
            using (var context = new EF_DBEntities())
            {
                return context.Tasks.Where(t => t.Completed == true).ToList();
            }
        }

        private void OsvjeziOtvorene()
        {
            dgvOtvoreni.DataSource = DohvatiOtvorene();
            dgvOtvoreni.Columns["Employee"].Visible = false;
        }

        private object DohvatiOtvorene()
        {
            using (var context = new EF_DBEntities())
            {
                return context.Tasks.Where(t => t.Completed == false).ToList();
            }
        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            using (var context = new EF_DBEntities())
            {
                string description = tbDescription.Text;
                int priority = int.Parse(cmbPriority.SelectedItem.ToString());

                Task newTask = new Task()
                {
                    Description = description,
                    Priority = priority
                };

                context.Tasks.Add(newTask);
                context.SaveChanges();
            }

            Osvjezi();
                

        }

        private void btnMarkAsComplete_Click(object sender, EventArgs e)
        {
            Task choosenTask = DohvatiOdabraniZadatak();

            using (var context = new EF_DBEntities())
            {
                context.Tasks.Attach(choosenTask);
                choosenTask.Completed = true;
                context.SaveChanges();
            }
            Osvjezi();
        }

        private Task DohvatiOdabraniZadatak()
        {
            return dgvOtvoreni.CurrentRow.DataBoundItem as Task;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _08_AssignmentStatus
{
    public partial class AssignmentFRm : Form
    {
        public AssignmentFRm()
        {
            InitializeComponent();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            AddNew addnew = new AddNew();
            addnew.ShowDialog();
            Osvjezi();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Assignments assignments = dgvAssignments.CurrentRow.DataBoundItem as Assignments;
            using (var context = new EF_DBEntities())
            {
                context.Assignments.Attach(assignments);
                context.Assignments.Remove(assignments);
                context.SaveChanges();
            }
            Osvjezi();
        }

        private void Osvjezi()
        {
            dgvAssignments.DataSource = DohvatiZadatke();
            dgvAssignments.Columns[5].Visible = false;
        }

        private void AssignmentFRm_Load(object sender, EventArgs e)
        {
            Osvjezi();
        }

        private object DohvatiZadatke()
        {
            using (var context = new EF_DBEntities())
            {
                return context.Assignments.ToList();
            }
        }
    }
}

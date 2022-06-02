using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _07_Assingments
{
    public partial class AssignmentResultFrm : Form
    {
        public AssignmentResultFrm()
        {
            InitializeComponent();
        }

        private void AssignmentResultFrm_Load(object sender, EventArgs e)
        {
            dgvStatuses.DataSource = GetStatuses();
            dgvAssignments.DataSource = GetAssignments();
            dgvAssignments.Columns["AssignmentStatus"].Visible = false;
        }

        private object GetAssignments()
        {
            using (var context = new EF_DBEntities())
            {
                return context.Assignments.ToList();
            }
            

        }

        private object GetStatuses()
        {
            using (var context = new EF_DBEntities())
            {
                return context.AssignmentStatuses.ToList();
            }
        }
        private void Osvjezi()
        {
            AssignmentStatus status = GetStatus();
            dgvAssignments.DataSource = GetAssignments(status);
        }
        private void dgvStatuses_SelectionChanged(object sender, EventArgs e)
        {
            Osvjezi();
        }

        private AssignmentStatus GetStatus()
        {
            return dgvStatuses.CurrentRow.DataBoundItem as AssignmentStatus;
        }

        private object GetAssignments(AssignmentStatus status)
        {
            using (var context = new EF_DBEntities())
            {
                context.AssignmentStatuses.Attach(status);
                return status.Assignments.ToList();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (var context = new EF_DBEntities())
            {
                string student = tbStudent.Text;
                string description = tbDescription.Text;
                int point = int.Parse(tbPoints.Text.ToString());
                AssignmentStatus status = dgvStatuses.CurrentRow.DataBoundItem as AssignmentStatus;
                context.AssignmentStatuses.Attach(status);

                Assignment assignment = new Assignment()
                {
                    Student = student,
                    Description = description,
                    Points = point,
                    IdAssignmentStatuses = status.Id
                };

                context.Assignments.Add(assignment);
                context.SaveChanges();
            }
            Osvjezi();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Assignment assignment = GetAssignment();
            using (var context = new EF_DBEntities())
            {
                context.Assignments.Attach(assignment);
                context.Assignments.Remove(assignment);
                context.SaveChanges();
            }
            Osvjezi();
        }

        private Assignment GetAssignment()
        {
           return dgvAssignments.CurrentRow.DataBoundItem as Assignment;
        }
    }
}

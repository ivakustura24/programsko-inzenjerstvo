using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentiTimoviLib;

namespace Studenti_i_timovi
{
    public partial class NoviStudentForm : Form
    {
        public NoviStudentForm()
        {
            InitializeComponent();
        }

        private void odustanibutton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ureduButton_Click(object sender, EventArgs e)
        {
           
            string JMBAG = JMBAGtexbox.Text;
            string ime = Imetextbox.Text;
            string prezime = prezimetextbox.Text;
            Student student= new Student(JMBAG,ime,prezime); 
            KolegijManager.DodajNovogStudenta(student);
            FormiranjeForm form = new FormiranjeForm();
            form.Show();
            this.Hide();
        }
    }
}

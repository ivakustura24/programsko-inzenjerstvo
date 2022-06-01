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
    public partial class FormiranjeForm : Form
    {
        List<Student> nedodijeljeni = new List<Student>();
        List<Tim> timovi = new List<Tim>();
        List<Student> clanovi = new List<Student>();
        public FormiranjeForm()
        {
            InitializeComponent();
        }

        private void FormiranjeForm_Load(object sender, EventArgs e)
        {
            Osvjezi();
        }
        public void Osvjezi()
        {

            nedodijeljeni = KolegijManager.DohvatiNedodijeljeneStudente();
            NedodijeljeniListBox.DataSource = null;
            NedodijeljeniListBox.DataSource = nedodijeljeni;
          
            timovi = KolegijManager.DohvatiTimove();
            TimoviListBox.DataSource = null;
            TimoviListBox.DataSource = timovi;

            clanovi = KolegijManager.DohvatiStudenteTima(TimoviListBox.SelectedItem as Tim);
            ClanoviListBox.DataSource = null;
            ClanoviListBox.DataSource = clanovi;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            NoviStudentForm formiranje = new NoviStudentForm();
            formiranje.ShowDialog();
            this.Hide();
            Osvjezi();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Student student = NedodijeljeniListBox.SelectedItem as Student;
            Tim tim = TimoviListBox.SelectedItem as Tim;
            KolegijManager.DodajUTim(student, tim);
            Osvjezi();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Student student = ClanoviListBox.SelectedItem as Student;
            Tim tim = TimoviListBox.SelectedItem as Tim;
            KolegijManager.UkloniIzTima(student, tim);
            Osvjezi();
        }

        private void TimoviListBox_Click(object sender, EventArgs e)
        {
            Tim tim = TimoviListBox.SelectedItem as Tim;
            ClanoviListBox.DataSource = KolegijManager.DohvatiStudenteTima(tim);
        }
    }
}

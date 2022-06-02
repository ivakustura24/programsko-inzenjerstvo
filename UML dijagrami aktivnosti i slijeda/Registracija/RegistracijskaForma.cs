using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _14_Registracija
{
    public partial class RegistracijskaForma : Form
    {
        public RegistracijskaForma()
        {
            InitializeComponent();
        }

        private void buttonRegistriraj_Click(object sender, EventArgs e)
        {
            Registrator registrator = new Registrator();
            string ime = tbIme.Text.ToString();
            string prezime = tbPrezime.Text.ToString();
            bool dodan =registrator.Registriraj(ime, prezime);
            if (dodan == true)
            {
                MessageBox.Show("Korisnik uspješno dodan! ");
            }
            else
            {
                MessageBox.Show("Korisnik već postoji!");
            }
        }
    }
}

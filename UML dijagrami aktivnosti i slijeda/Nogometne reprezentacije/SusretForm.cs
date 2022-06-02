using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _08_Nogometne_reprezentacije
{
    public partial class SusretForm : Form
    {
        public SusretForm()
        {
            InitializeComponent();
        }

        private void buttonEvidentiraj_Click(object sender, EventArgs e)
        {
            KontrolaSusreta kontrolaSusreta = new KontrolaSusreta();
            string domacin = tbDomacin.Text.ToString();
            string gost = tbGost.Text.ToString();
            string rezultat = tbRezultat.Text.ToString();

            Susret susret = kontrolaSusreta.EvidentirajSusret(domacin, gost, rezultat);
            PrikaziPodatke(susret);
        }

        private void PrikaziPodatke (Susret susret)
        {
            string podatci = $"{susret.Domacin.Naziv} {susret.BrojPogodakaDomacin} : {susret.BrojPogodakaGost} {susret.Gost.Naziv}";
            MessageBox.Show(podatci);
        }
    }
}

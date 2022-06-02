using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _16_Streaming_servis
{
    public partial class FilmoviForm : Form
    {
        public FilmoviForm()
        {
            InitializeComponent();
        }
        StreamingServis servis = new StreamingServis();
        private void btnOsvjezi_Click(object sender, EventArgs e)
        {
            Osvjezi();
         
        }
        public void Osvjezi()
        {
            List<Film> neodgledaniFilmovi = servis.DohvatiNeodgledaneFilmove();
            dgwfilmovi.DataSource = null;
            dgwfilmovi.DataSource = neodgledaniFilmovi;
        }

        private void btnPogledaj_Click(object sender, EventArgs e)
        {
            Film odabraniFilm = dgwfilmovi.CurrentRow.DataBoundItem as Film;
            servis.PogledajFilm(odabraniFilm);
            Osvjezi();
        }
    }
}

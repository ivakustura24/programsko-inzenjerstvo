using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _07_Filmovi
{
    public partial class FilmoviForm : Form
    {
        public FilmoviForm()
        {
            InitializeComponent();
        }

        private void FilmoviForm_Load(object sender, EventArgs e)
        {
            Streaming_Servis streaming_Servis = new Streaming_Servis();
            List<Film> zapocetiFilmovi = streaming_Servis.DohvatiZapoceteFilmove();
            PrikaziFilmove(zapocetiFilmovi);
        }

        private void PrikaziFilmove(List<Film> zapocetiFilmovi)
        {
            dgwFilmovi.DataSource = zapocetiFilmovi;    
        }
    }
}

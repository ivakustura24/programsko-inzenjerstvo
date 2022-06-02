using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventura2
{
    public partial class FrmInventura : Form
    {
        private InventuraRepository _repository = new InventuraRepository();
        public FrmInventura()
        {
            InitializeComponent();
        }

        private void FrmInventura_Load(object sender, EventArgs e)
        {
            dgvInventurniZapisi.DataSource = _repository.DohvatiZapise();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            string artikl = txtArtikl.Text.ToString();
            int kolicina = int.Parse(txtKolicina.Text.ToString());
            int stvkolicina = int.Parse(txtStvarnaKolicina.Text.ToString());
            string zaduzen = txtZaduzen.Text.ToString();
            InventurniZapis inventurni = new InventurniZapis()
            {
                Artikl = artikl,
                Kolicina = kolicina,
                StvarnaKolicina = stvkolicina,
                Razlika = stvkolicina - kolicina,
                Zaduzen = zaduzen
            };
            int i= _repository.DodajZapis(inventurni);
            osvjezi();
        }

        private void btnFiltriraj_Click(object sender, EventArgs e)
        {
            string zaduzen = textBox1.Text.ToString();
            dgvInventurniZapisi.DataSource = _repository.DohvatiZapise(zaduzen);
        }

        private void btnPrikaziSve_Click(object sender, EventArgs e)
        {
            osvjezi();
        }

        public void osvjezi()
        {
            dgvInventurniZapisi.DataSource = _repository.DohvatiZapise();
        }
    }
}

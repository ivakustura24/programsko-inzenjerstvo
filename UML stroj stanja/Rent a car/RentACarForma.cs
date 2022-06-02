using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STATE_RentACar
{
    public partial class RentACarForma : Form
    {
        private Vozilo _vozilo;
        public RentACarForma()
        {
            InitializeComponent();
        }

        private void RentACarForma_Load(object sender, EventArgs e)
        {
            _vozilo = new Vozilo("VŽ-100-NO", "Ford focus, 1.6 tdi");

            txtRegistracija.Text = _vozilo.Registracija;
            txtOpisModela.Text = _vozilo.Model;
            OsvjeziGumbe();
            
        }

        private void btnRezerviraj_Click(object sender, EventArgs e)
        {
            _vozilo.RezervirajVozilo();
            txtDatumRezervacije.Text = _vozilo.DatumRezervacije.ToString();
            OsvjeziGumbe();
        }

        private void btnPredaj_Click(object sender, EventArgs e)
        {
            _vozilo.PredajVozilo();
            txtDatumPredavanja.Text = _vozilo.DatumPredavanja.ToString();
            OsvjeziGumbe();
        }

        private void btnPregledaj_Click(object sender, EventArgs e)
        {
            _vozilo.PregledajVozilo(txtPregledNapravio.Text);
            OsvjeziGumbe();
        }

        private void btnUciniRaspolozivim_Click(object sender, EventArgs e)
        {
            _vozilo.UciniRaspolozivim();
            OsvjeziGumbe();
        }

        private void btnAktivirajVozilo_Click(object sender, EventArgs e)
        {
            _vozilo.AktivirajVozilo();
            OsvjeziGumbe();
        }

        private void btnDeaktivirajVozilo_Click(object sender, EventArgs e)
        {
            _vozilo.DeaktivirajVozilo();
            OsvjeziGumbe();
        }

        private void OsvjeziGumbe()
        {
            txtStatusVozila.Text = _vozilo.StatusVozila.TrenutniStatus.ToString();

            btnRezerviraj.Enabled = _vozilo.StatusVozila.TrenutniStatus == Status.Raspoloživ;
            btnPredaj.Enabled = _vozilo.StatusVozila.TrenutniStatus == Status.Rezerviran;
            btnPregledaj.Enabled = _vozilo.StatusVozila.TrenutniStatus == Status.UUporabi;

            btnUciniRaspolozivim.Enabled = _vozilo.StatusVozila.TrenutniStatus == Status.NaPregledu;
            btnAktivirajVozilo.Enabled = _vozilo.StatusVozila.TrenutniStatus == Status.UKvaru;
            btnDeaktivirajVozilo.Enabled = _vozilo.StatusVozila.TrenutniStatus == Status.Raspoloživ;
        }
    }
}
    
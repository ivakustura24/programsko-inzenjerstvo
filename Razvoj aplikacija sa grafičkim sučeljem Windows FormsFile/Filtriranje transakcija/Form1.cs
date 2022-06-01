using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BankaLib;

namespace Filtirranje_transakcija
{
    public partial class PopisTransakcijaForm : Form
    {
        public Racun racun1 = new Racun();
        
        public PopisTransakcijaForm()
        {
            InitializeComponent();
        }

        private void PopisTransakcijaForm_Load(object sender, EventArgs e)
        {
            List<Transakcija> list = new List<Transakcija>();
            list = Banka.DohvatiPopisTransakcija();
            TransakcijeDataGridView.DataSource = list;
            List <Racun> lista = Banka.DohvatiPopisRacuna();
            RacunComboBox.DataSource = lista;
            SveRadio.Checked = true;


        }

        private void FiltrirajButton_Click(object sender, EventArgs e)
        {
            Racun racun = RacunComboBox.SelectedItem as Racun;
            if (SveRadio.Checked)
            {
                List<Transakcija> transakcija1 = new List<Transakcija>();
                transakcija1 = racun.DohvatiIsplate();
                transakcija1.AddRange(racun.DohvatiUplate());
                TransakcijeDataGridView.DataSource = transakcija1;
            }
            else if (IsplataRadio.Checked)
            {
                List<Transakcija> transakcija2 = new List<Transakcija>();
                transakcija2 = racun.DohvatiIsplate();
                TransakcijeDataGridView.DataSource = transakcija2;  
            }
            else if (UplateRadio.Checked)
            {
                List <Transakcija> transakcija3 = new List<Transakcija>();
                transakcija3 = racun.DohvatiUplate();
                TransakcijeDataGridView.DataSource = transakcija3;  
            }
        }

        private void OcistiButton_Click(object sender, EventArgs e)
        {
            RacunComboBox.SelectedIndex = 0;
            SveRadio.Checked = true;
            Racun racun = RacunComboBox.SelectedItem as Racun;
            List<Transakcija> transakcija1 = new List<Transakcija>();
            transakcija1 = racun.DohvatiIsplate();
            transakcija1.AddRange(racun.DohvatiUplate());
            TransakcijeDataGridView.DataSource = transakcija1;
        }

        private void DetaljiButton_Click(object sender, EventArgs e)
        {
            racun1 = RacunComboBox.SelectedItem as Racun;
            DetaljiRacunaForm detalji = new DetaljiRacunaForm();
            detalji.DohvatiRacun(racun1);
            detalji.ShowDialog();
        }
    }
}

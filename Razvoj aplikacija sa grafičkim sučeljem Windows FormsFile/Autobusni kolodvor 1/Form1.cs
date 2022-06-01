using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutobusniKolodvorLib;

namespace Autobusni_kolodvor_1
{
    public partial class KreirajKartuForm : Form
    {
        private VrstaKarte vrstakarte { get; set; }
        public bool povratna { get; set; }
        public bool prtljaga { get; set; }
        public Linija linija1 { get; set; }

        private Popis_autobusnih_linija popis= new Popis_autobusnih_linija();
        public KreirajKartuForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void OdaberiLinijuButton_Click(object sender, EventArgs e)
        {
            Popis_autobusnih_linija form = new Popis_autobusnih_linija();
            form.ShowDialog();
            this.Hide();


        }
        public void UnosLinije()
        {
            PolazisteTextBox.Text = linija1.Polaziste;
            OdredisteTextBox.Text = linija1.Odrediste;
            UdaljenostTextBox.Text = linija1.Udaljenost.ToString();
            AutoprijevoznikTextBox.Text = linija1.Autoprijevoznik;
            this.Show();
        }

        private void KreirajKartuButton_Click(object sender, EventArgs e)
        {

            VrstaKarte vrsta=VrstaKarte.Regularna;
            bool prtljaga = false;
            bool povratna = false;
            if (RegularnaRadio.Checked)
                vrsta = VrstaKarte.Regularna;
            if (StudentskaButton.Checked)
                vrsta = VrstaKarte.Studentska;
            if (PrtljagaCheckBox.Checked)
                prtljaga = true;
            if (PovratnaCheckBox.Checked)
                povratna = true;
            Karta nova = AutobusniKolodvor.KreirajKartu(linija1, vrsta, povratna, prtljaga);
            int nov= nova.BrojKarte;
            BrojKarteTextBox.Text = nov.ToString();
            double cijena = nova.Cijena;
            CijenaKarteTextBox.Text = cijena.ToString();

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutobusniKolodvorLib2;

namespace Autobusni_kolodvor_2
{
    public partial class KupiKartu : Form
    {
        public Karta karta;
        AutobusneLinijeForm forma = new AutobusneLinijeForm() ;
        AutobusniKolodvor autobusni = new AutobusniKolodvor();
        Linija linija = new Linija() ;

        public KupiKartu()
        {
            InitializeComponent();
        
        }

        private void IspisiButton_Click(object sender, EventArgs e)
        {
            
            bool povratna = PovratnaCheckBox.Checked;
            bool prtljaga = PrtljagaCheckBox.Checked;
            string vrstaKarte = VrstaKarteComboBox.SelectedItem.ToString();
            VrstaKarte vrsta;
            if (vrstaKarte == "Regularna")
                vrsta = VrstaKarte.Regularna;
            else
                vrsta = VrstaKarte.Studentska;
            Karta kartanova = autobusni.KupiKartu(linija, vrsta, povratna, prtljaga);
            IspisTextBox.Text = $"Broj karte: {kartanova.BrojKarte} \r\nRelacija: {kartanova.Linija.Polaziste} - {kartanova.Linija.Odrediste} \r\nUdaljenost{kartanova.Linija.Udaljenost} \r\nAutoprijevoznik {kartanova.Linija.Autoprijevoznik}\r\nVrsta karte {kartanova.Vrsta}\r\nPovratna: {kartanova.Povratna}\r\nNaplati prtljagu: {kartanova.Prtljaga}\r\n-------------------------- \r\nCijena karte = {kartanova.Cijena}";
      
        }
        public void VratiLiniju(Linija linija2)
        {
            linija = linija2;
        }

        private void KupiKartu_Load(object sender, EventArgs e)
        {
            List<VrstaKarte> List = new List<VrstaKarte>();
            List.Add(VrstaKarte.Regularna);
            List.Add(VrstaKarte.Studentska);
            VrstaKarteComboBox.DataSource = List;
        }
    }
}

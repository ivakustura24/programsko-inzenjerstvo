using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STATE_Reklamacija
{
    public partial class ReklamacijaForm : Form
    {
        private Reklamacija _reklamacija;
        public ReklamacijaForm()
        {
            InitializeComponent();
        }

        private void ReklamacijaForm_Load(object sender, EventArgs e)
        {
            _reklamacija = new Reklamacija
            {
                Id = 1112,
                Opis = "Tablet je stigao sa puknutim ekranom..."
            };

            txtIdReklamacije.Text = _reklamacija.Id.ToString();
            txtOpisReklamacije.Text = _reklamacija.Opis;
            OsvjeziGumbe();
        }

        private void btnDodijeliAgenta_Click(object sender, EventArgs e)
        {
            _reklamacija.DodijeliAgenta(txtAgent.Text);
            OsvjeziGumbe();
        }

        private void btnOcijeni_Click(object sender, EventArgs e)
        {
            if (radOpravdana.Checked == true)
            {
                _reklamacija.Prihvati();
            }
            else
            {
                _reklamacija.Odbij();
            }
            OsvjeziGumbe();
        }

        private void btnObradiŽalbu_Click(object sender, EventArgs e)
        {
            if (rbPristigla.Checked == true)
            {
                _reklamacija.VratiUPostupak();
            }
            else
            {
                _reklamacija.KonačnoOdbij();
            }
            OsvjeziGumbe();
        }

        private void OsvjeziGumbe()
        {
            txtIdReklamacije.Text = _reklamacija.Id.ToString();
            txtOpisReklamacije.Text = _reklamacija.Opis.ToString();
            txtStatusReklamacije.Text = _reklamacija.Stanje.TrenutnoStanje.ToString();

            btnDodijeliAgenta.Enabled = _reklamacija.Stanje.TrenutnoStanje == Stanje.Podnesena;
            btnOcijeni.Enabled = _reklamacija.Stanje.TrenutnoStanje == Stanje.URazmatranju;
            btnObradiŽalbu.Enabled = _reklamacija.Stanje.TrenutnoStanje == Stanje.Odbijena;
        }
    }
}

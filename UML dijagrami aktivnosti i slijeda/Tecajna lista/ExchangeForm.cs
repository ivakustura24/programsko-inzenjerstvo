using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BankLib;

namespace _18_Tecajna_lista
{
    public partial class ExchangeForm : Form
    {
        public ExchangeForm()
        {
            InitializeComponent();
        }

        private void btnShowRates_Click(object sender, EventArgs e)
        {
            Exchange exchange = new Exchange();
            List<ExchangeRate> rates = exchange.GetExchangeRates();
            ShowExchangeRates(rates);
        }

        private void ShowExchangeRates(List<ExchangeRate> rates)
        {
            dgwExchangeRates.DataSource = rates;
        }
    }
}

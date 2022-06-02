using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02_Konverzija_valuta
{
    public partial class FrmConverter : Form
    {
        public FrmConverter()
        {
            InitializeComponent();
        }

        private void buttonConvert_Click(object sender, EventArgs e)
        {
            string firstCurrency = cbFirstCurrency.SelectedItem.ToString();
            string secondCurrency = cbSecondCurrency.SelectedItem.ToString();
            CurrencyFactory currencyFactory = new CurrencyFactory ();
            Currency currency1 = currencyFactory.GetCurrency(firstCurrency);
            Currency currency2 = currencyFactory.GetCurrency(secondCurrency);
            double amount = double.Parse(tbAmount.Text.ToString());
            double convertedAmount = currency1.ConvertTo(currency2, amount);
            ShowResult (convertedAmount);
        }
        private void ShowResult (double convertedAmount)
        {
            tbConvertedAmount.Text=convertedAmount.ToString();
        }

        private void FrmConverter_Load(object sender, EventArgs e)
        {
            CurrencyFactory currencyFactory = new CurrencyFactory ();
            foreach (Currency c in currencyFactory.ExchangeRates)
            {
                cbFirstCurrency.Items.Add(c.Name);
                cbSecondCurrency.Items.Add(c.Name);
            }
         

        }
    }
}

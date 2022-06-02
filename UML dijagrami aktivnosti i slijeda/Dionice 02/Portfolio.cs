using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StocksLib;

namespace _05_Dionice_02
{
    public partial class PortfolioForm : Form
    {
        public PortfolioForm()
        {
            InitializeComponent();
        }

        private void buttonShowPortfolio_Click(object sender, EventArgs e)
        {
            StockPortfolio stockPortfolio = new StockPortfolio();
            List <Stock> stocks= stockPortfolio.GetMyStocks();
            DisplayData(stocks);
        }
        private void DisplayData (List <Stock> stocks)
        {
            dgwStocks.DataSource = stocks;
            double total = 0;
            foreach (Stock s in stocks)
            {
                total += s.Worth;
            }
            tbTotal.Text = total.ToString();
         
        }
    }
}

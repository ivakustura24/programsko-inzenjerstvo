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

namespace Dionice
{
    internal partial class StocksForm : Form
    {
        public StocksForm()
        {
            InitializeComponent();
        }

        private void btShowStocks_Click(object sender, EventArgs e)
        {
            StockManager stockManager = new StockManager();
            List <Stock> stocks = stockManager.GetStocks();
            ShowData(stocks);
        }

        private void ShowData (List <Stock> stocks)
        {
            dataGridView1.DataSource = stocks;
        }
    }
}

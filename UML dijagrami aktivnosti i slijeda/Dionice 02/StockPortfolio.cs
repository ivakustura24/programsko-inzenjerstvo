using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StocksLib;

namespace _05_Dionice_02
{
    internal class StockPortfolio
    {
        public List<Stock> GetMyStocks() {

            List<Stock> stocks = new List<Stock>();
            List<string> ownedStocksData = StockExchangeAPI.GetOwnedStocksData();
            foreach (string s in ownedStocksData)
            {
                string[] polje = s.Split(';');
                double price = StockExchangeAPI.GetStockPrice(polje[0]);
                Stock stock = new Stock(polje[0], double.Parse(polje[1]), price);

                stocks.Add(stock);
            }

            return stocks;
    
        }

    }
}

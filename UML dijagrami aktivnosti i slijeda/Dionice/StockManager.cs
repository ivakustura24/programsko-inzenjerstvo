using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StocksLib;
namespace Dionice
{
    internal class StockManager
    {

        public List <Stock> GetStocks()
        {
            List<Stock> stocks= new List<Stock>();
            
            List<string> stocksData = StockExchangeAPI.GetStocksData();
            foreach (string s in stocksData)
            {
                Stock stock =StockParser.ParseStock(s);
                stocks.Add(stock);
            }

            return stocks; 
        }
    }
}

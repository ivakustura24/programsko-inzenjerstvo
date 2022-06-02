using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StocksLib;
namespace Dionice
{
    internal static class StockParser
    {
        public static Stock ParseStock (string item)
        {
            string[] polje = item.Split(';');
            string name = polje[0];
            double currentPrice = double.Parse(polje[1]);
            double previousPrice = double.Parse(polje[2]);
            double difference = Math.Round(((currentPrice - previousPrice) / previousPrice) * 100 , 2);
            Stock stock = new Stock(name, currentPrice, previousPrice, difference);

            return stock;
        }

    }
}

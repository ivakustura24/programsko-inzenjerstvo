using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StocksLib;
namespace Dionice
{
    internal class Stock
    {
        public string Name { get; set; }    
        public double CurrentPrice { get; set; }
        public double PreviousPrice { get; set; }
        public double Difference { get; set; }

        public Stock (string name, double currentPrice, double previousPrice, double difference)
        {
            Name = name;
            CurrentPrice = currentPrice;
            PreviousPrice = previousPrice;
            Difference = difference;

        }
    }
}

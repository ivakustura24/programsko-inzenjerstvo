using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Konverzija_valuta
{
    internal class Currency
    {
        public string Name { get; set; }
        public double ExchangeRate { get; set; }


        public double ConvertTo ( Currency currency2, double amount)
        {
            double conversion = 0;
            double rate1 = this.ExchangeRate;
            double rate2 = currency2.ExchangeRate;
            double rate = rate1 / rate2;
            conversion = rate * amount;
            return conversion;
            
        }
    }
}

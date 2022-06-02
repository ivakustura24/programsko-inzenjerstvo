using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_Tecajna_lista
{
    internal static class ExchangeParser
    {

        public static ExchangeRate ParseRate(string item)
        {
            string[] array = item.Split(';');
            string name = array[0];
            double rate = double.Parse(array[1]);
            ExchangeRate exchangeRate = new ExchangeRate(name, rate);
            return exchangeRate;
        }
    }
}

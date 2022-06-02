using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankLib;

namespace _18_Tecajna_lista
{
    internal class Exchange
    {
        public List<ExchangeRate> GetExchangeRates()
        {
            List<string> exchangeData = BankAPI.GetExchangeData();
            List<ExchangeRate> rates = new List<ExchangeRate>();

            foreach (string item in exchangeData)
            {
                ExchangeRate exchangeRate = ExchangeParser.ParseRate(item);
                rates.Add(exchangeRate);
            }
            return rates;
        }
        

    }
}

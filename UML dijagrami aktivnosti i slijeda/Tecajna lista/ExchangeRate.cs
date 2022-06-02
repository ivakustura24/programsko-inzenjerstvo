using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_Tecajna_lista
{
    internal class ExchangeRate
    {
        public string Name { get; set; }
        public double Rate { get; set; }

        public ExchangeRate (string name, double rate)
        {
            Name = name;
            Rate = rate;
        }
    }
}

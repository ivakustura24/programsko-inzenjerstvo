using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Dionice_02
{
    internal class Stock
    {

        public string Name { get; set; }
        public double Amount { get; set; }
        public double Price { get; set; }
        public double Worth { get; set; }

        public Stock(string name, double amount, double price)
        {
            Name = name;
            Amount = amount;
            Price = price;
            Worth = price * amount;
        }
    }
}

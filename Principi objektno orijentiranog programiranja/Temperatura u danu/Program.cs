using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperatura_u_danu
{
    
    internal class Program
    {
        static Reporter reporter = new Reporter();
        static void Main(string[] args)
        {
            Console.WriteLine("TEMPERATURE REPORT");
            Console.WriteLine("--------------------------------");
            reporter.GenerateReport();
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prvenstvo
{
    internal class Reprezentacija
    {
        public string Oznaka { get; set; }
        public string NazivReprezentacije { get; set; }

        
        public Reprezentacija(string oznaka, string nazivReprezentacije)
        {
            Oznaka = oznaka;
            NazivReprezentacije = nazivReprezentacije;
        }

     }
}

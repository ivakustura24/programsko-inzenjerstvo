using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotelske_sobe
{
    enum StatusSobe { Rezervirana, Slobodna };
    internal class Soba
    {
        public string Oznaka { get; set; }
        public int Kapacitet { get; set; }
        public StatusSobe Status { get; set; }

        public Soba(string oznaka, int kapacitet, StatusSobe status)
        {
            Oznaka = oznaka;
            Kapacitet = kapacitet;
            Status = status;
        }

    }
}

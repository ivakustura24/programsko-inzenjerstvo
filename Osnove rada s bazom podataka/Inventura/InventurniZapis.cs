using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventura2
{
    public class InventurniZapis
    {
        public int Id { get; set; }
        public string Artikl { get; set; }
        public int Kolicina { get; set; }
        public int StvarnaKolicina { get; set; }
        public int Razlika { get; set; }
        public string Zaduzen { get; set; }
        public InventurniZapis()
        {

        }
    }
}

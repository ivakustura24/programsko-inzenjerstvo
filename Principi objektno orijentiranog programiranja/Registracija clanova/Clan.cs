using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registracija_clanova_2
{
    internal class Clan
    {
        public string EmailAdresa { get; set; }
        public string Lozinka { get; set; }
        public Clan(string emailadresa, string lozinka)
        {
            EmailAdresa = emailadresa;
            Lozinka = lozinka;
        }
    }
}

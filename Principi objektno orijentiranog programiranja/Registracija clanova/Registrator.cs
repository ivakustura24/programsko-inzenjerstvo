using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registracija_clanova_2
{
    
    internal class Registrator
    {
        static Validator validator = new Validator();
        private List<Clan> clan;
        
        public Registrator()
        {
            clan = new List<Clan>();
            clan.Add(new Clan("ilukic@foi.hr", "1234561"));
            clan.Add(new Clan("ikustura@foi.hr", "6789341"));
            clan.Add(new Clan("apuljic@foi.hr", "1234543"));
        }
        private bool EmailZauzet (string emailAdresa)
        {
            foreach (Clan c in clan)
            {
                if (c.EmailAdresa == emailAdresa)
                    return true;

            }
            return false;
        }
        public void RegistrirajClana (string email, string lozinka)
        {
            if (EmailZauzet(email) == true)
                Console.WriteLine("Već postoji član s navedenim emailom!");
            else if (validator.ValidirajEmail(email) == false)
                Console.WriteLine("Email adresa je neispravnog oblika");
            else if (validator.ValidirajLozinku(lozinka) == false)
                Console.WriteLine("Lozinka mora imati između 6 i 10 znakova!");
            else
            {
                Console.WriteLine("Član je uspješno registriran!");
                clan.Add(new Clan(email,lozinka));
            }
        }
    }
}

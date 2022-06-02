using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otvaranje_e_mail_računa
{
    internal class Program
    {
        static EmailServer Server = new EmailServer();
        static void Main(string[] args)
        {
            KorisnickiRacun _korisnickiRacun = new KorisnickiRacun();
            Console.WriteLine("Otvaranje email korisničnog računa: ");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Unesite vaše ime:");
            string ime = Console.ReadLine();
            Console.WriteLine("Unesite vaše prezime ");
            string prezime = Console.ReadLine();
            Console.WriteLine("------------------------------------");
            _korisnickiRacun = Server.KreirajKorisnickiRacun(ime, prezime);
            Console.WriteLine("Podaci za vaš email korisnički račun sz sljedeći: ");
            Console.WriteLine($"Ime: {_korisnickiRacun.Ime}");
            Console.WriteLine($"Prezime: {_korisnickiRacun.Prezime}");
            Console.WriteLine($"Email: {_korisnickiRacun.Email}");
            Console.WriteLine($"Email skraćeni: {_korisnickiRacun.SkraceniEmail}");
            Console.WriteLine($"Lozinka: {_korisnickiRacun.Lozinka}");
            Console.ReadLine();
        }
    }
}

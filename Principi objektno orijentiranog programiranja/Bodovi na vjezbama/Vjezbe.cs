using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bodovi_na_vjezbama
{
    internal class Vjezbe
    {
        public int brojVjezbe { get; set; }
        public Student Student { get; set; }
        public int Bodovi { get; set; }
        public Vjezbe() { }
        public List<Student> studenti = new List<Student>();
        public List<Vjezbe> vjezbe = new List<Vjezbe>();


        public Vjezbe(int brojvjezbe, Student student, int bodovi)
        {
            brojVjezbe = brojvjezbe;
            Student = student;
            Bodovi = bodovi;
        }
        public Student DohvatiStudenta(int id)
        {
            foreach (Student s in studenti)
            {
                if (s.Id == id)
                    return s;
            }
            return null;
        }
        public void DodajStudenta(int id, string ime, string prezime)
        {
            Student s = new Student();
            int i = 0;
            foreach (Student stud in studenti)
            {
                if (stud.Id == id)
                {
                    Console.WriteLine($"Student s id {id} već postoji!");
                    i++;
                }
            }
            if (i == 0)
            {
                s.Id = id;
                s.Ime = ime;
                s.Prezime = prezime;
                studenti.Add(s);
                Console.WriteLine("Uspješno se dodali studenta!");
            }
        }

        public void DodajVjezbuOcijeni(int broj, Student student, int bodovi)
        {
            Vjezbe v = new Vjezbe();
            v.brojVjezbe = broj;
            v.Student = student;
            v.Bodovi = bodovi;
            vjezbe.Add(v);
        }
        public void IspisBodova()
        {
            
            foreach (Student s in studenti)
            {
                int ukupno = 0;
                Console.WriteLine($"STUDENT: {s.Ime} {s.Prezime}: ");
                foreach (Vjezbe v in vjezbe)
                {
                    if (v.Student == s)
                    {
                        Console.WriteLine($"Rbr: {v.brojVjezbe} || Bodovi: {v.Bodovi}");
                        ukupno += v.Bodovi;
                    }
                }
                Console.WriteLine($"Ukupni bodovi studenta {s.Ime} {s.Prezime}: {ukupno}.");
            }
        }
    }
}
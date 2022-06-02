using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bodovi_na_vjezbama
{
    internal class Student
    {
        public int Id { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }

        public Student() { }
        public Student (int id, string ime, string prezime)
        {
            Id =id;
            Ime = ime;
            Prezime = prezime;
        }
 
    }
}

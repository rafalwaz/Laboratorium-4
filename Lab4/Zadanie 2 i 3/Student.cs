using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB4_3
{
    internal class Student : IStudent
    {
        public string Imię { get; set; }
        public string Nazwisko { get; set; }
        public string Uczelnia { get; set; }
        public string Kierunek { get; set; }
        public int Rok { get; set; }
        public int Semestr { get; set; }

        public void ZwrocPelnaNazwe()
        {
            Console.WriteLine($"{Imię} {Nazwisko} - {Semestr} semestr {Rok} roku, {Kierunek} ({Uczelnia})");
        }
        public string WypiszPelnaNazweIUczelnie()
        {
            return $"{Imię} {Nazwisko} - {Semestr} semestr {Rok} roku, {Kierunek} ({Uczelnia})";
        }

        public bool GetEducationInfo()
        {
            throw new NotImplementedException();
        }
    }
}

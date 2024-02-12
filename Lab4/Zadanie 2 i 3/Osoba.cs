using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB4_3
{
    internal class Osoba : IOsoba
    {
        public string Imię { get; set; }
        public string Nazwisko { get; set; }
        public string Pesel { get; set; }

        public virtual void SetFirstName(string imię)
        {
            Imię = imię;
        }

        public virtual void SetLastName(string nazwisko)
        {
            Nazwisko = nazwisko;
        }

        public virtual void SetPesel(string pesel)
        {
            Pesel = pesel;
        }

        
        public int GetAge()
        {
            int rok = int.Parse(Pesel.Substring(0, 2));
            int currentYear = DateTime.Now.Year;
            return currentYear - (2000 + rok);
        }

        public char GetGender()
        {
            return (Int32.Parse(Pesel.Substring(9, 1)) % 2 == 0) ? 'K' : 'M';
        }

        
        public virtual string GetEducationInfo()
        {
            return "Osoba";
        }

        public virtual string GetFullName()
        {
            return $"{Imię} {Nazwisko}";
        }

        
        public virtual bool CanGoAloneToHome()
        {
            return false;
        }
        public void ZwrocPelnaNazwe()
        {
            Console.WriteLine($"{Imię} {Nazwisko}");
        }
    }
}

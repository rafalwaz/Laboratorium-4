using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB4_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Zadanie 2
            Nauczyciel nauczyciel = new Nauczyciel();
            nauczyciel.SetFirstName("Jan");
            nauczyciel.SetLastName("Nowak");
            nauczyciel.SetPesel("89121410146");
            nauczyciel.SetSchool("Wyższa Szkoła Informatyki i Zarządzania w Rzeszowie");
            nauczyciel.SetAcademicTitle("inżynier");

            Uczeń uczen1 = new Uczeń();
            uczen1.SetFirstName("Anna");
            uczen1.SetLastName("Kowalska");
            uczen1.SetPesel("05121012345");
            uczen1.SetSchool("Wyższa Szkoła Informatyki i Zarządzania w Rzeszowie");
            uczen1.SetCanGoHomeAlone(true);

            Uczeń uczen2 = new Uczeń();
            uczen2.SetFirstName("Adam");
            uczen2.SetLastName("Ostrowski");
            uczen2.SetPesel("07110254321");
            uczen2.SetSchool("Wyższa Szkoła Informatyki i Zarządzania w Rzeszowie");
            uczen2.SetCanGoHomeAlone(false);

            nauczyciel.AddStudent(uczen1);
            nauczyciel.AddStudent(uczen2);

            Console.WriteLine("Informacje o nauczycielu:");
            Console.WriteLine(nauczyciel.GetEducationInfo());

            Console.WriteLine("\nInformacje o uczniach:");
            Console.WriteLine(uczen1.GetEducationInfo());
            Console.WriteLine(uczen2.GetEducationInfo());

            Console.WriteLine("\nLista uczniów, którzy mogą iść sami do domu:");
            nauczyciel.WhichStudentCanGoHomeAlone(DateTime.Now);

            Console.ReadLine();

            // Zadanie 3a 
            List<IOsoba> listaOsob = new List<IOsoba>
            {
            new Nauczyciel { Imię = "Jan", Nazwisko = "Nowak", Pesel = "89121410146", TytulNaukowy = "inżynier" },
            new Uczeń { Imię = "Anna", Nazwisko = "Kowalska", Pesel = "08312823924", Szkoła = "Wyższa Szkoła Informatyki i Zarządzania w Rzeszowie", MozeSamWracacDoDomu = true },
            new Uczeń { Imię = "Adam", Nazwisko = "Ostrowski", Pesel = "02281757916", Szkoła = "Wyższa Szkoła Informatyki i Zarządzania w Rzeszowie", MozeSamWracacDoDomu = false }
        };

            // Zadanie 3b 
            Console.WriteLine("Wypisanie osób:");
            listaOsob.WypiszOsoby();
            Console.WriteLine();

            // Zadanie 3c
            Console.WriteLine("Posortowanie osób po nazwisku:");
            listaOsob.PosortujOsobyPoNazwisku();
            Console.WriteLine();

            // Zadanie 3d

            List<IStudent> listaStudentow = new List<IStudent>
            {
            new StudentWSIiZ { Imię = "Adam", Nazwisko = "Ostrowski", Uczelnia = "WSIiZ", Kierunek = "Informatyka", Rok = 2, Semestr = 3 },
            new StudentWSIiZ { Imię = "Karolina", Nazwisko = "Kowalczyk", Uczelnia = "WSIiZ", Kierunek = "Zarządzanie", Rok = 1, Semestr = 2 }
            };

            Console.WriteLine("Informacje o studentach:");
            foreach (var student in listaStudentow)
            {
                student.ZwrocPelnaNazwe();
            }
            Console.WriteLine();

            // Zadanie 3e
            Console.WriteLine("Przeciążenie metody z zadania 2 dla klasy StudentWSIiZ:");
            foreach (var student in listaStudentow)
            {
                Console.WriteLine(student.GetEducationInfo());
            }

            Console.ReadLine();
        }
    }
}

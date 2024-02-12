using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB4_3
{
    internal class Nauczyciel : Uczeń
    {
        public string TytulNaukowy { get; set; }
        public List<Uczeń> PodwladniUczniowie;

        public Nauczyciel()
        {
            PodwladniUczniowie = new List<Uczeń>();
        }

        public void SetAcademicTitle(string tytulNaukowy)
        {
            TytulNaukowy = tytulNaukowy;
        }
        public void AddStudent(Uczeń uczeń)
        {
            PodwladniUczniowie.Add(uczeń);
        }

        public void WhichStudentCanGoHomeAlone(DateTime dateToCheck)
        {
            Console.WriteLine($"Uczniowie, którzy mogą iść sami do domu w dniu {dateToCheck.ToShortDateString()}:");
            foreach (var uczeń in PodwladniUczniowie)
            {
                if (uczeń.CanGoAloneToHome())
                {
                    Console.WriteLine($"{uczeń.GetFullName()} (wiek: {uczeń.GetAge()}, płeć: {uczeń.GetGender()})");
                }
            }
        }

        public override string GetEducationInfo()
        {
            return $"Nauczyciel, Tytuł naukowy: {TytulNaukowy}, Liczba uczniów: {PodwladniUczniowie.Count}";
        }

        
    }
}

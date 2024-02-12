using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB4_3
{
    internal interface IStudent : IOsoba
    {
        string Uczelnia { get; set; }
        string Kierunek { get; set; }
        int Rok { get; set; }
        int Semestr { get; set; }

        bool GetEducationInfo();
    }
}

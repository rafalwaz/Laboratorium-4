using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB4_3
{
    internal class Uczeń : Osoba
    {
        public string Szkoła { get; set; }
        public bool MozeSamWracacDoDomu { get; set; }

        public void SetSchool(string szkoła)
        {
            Szkoła = szkoła;
        }

        public void ChangeSchool(string nowaSzkoła)
        {
            Szkoła = nowaSzkoła;
        }

        public void SetCanGoHomeAlone(bool mozeSamWracacDoDomu)
        {
            MozeSamWracacDoDomu = mozeSamWracacDoDomu;
        }

        public override string GetEducationInfo()
        {
            return $"Uczeń, Szkoła: {Szkoła}";
        }

        public override bool CanGoAloneToHome()
        {
            if (GetAge() < 12)
            {
                return MozeSamWracacDoDomu;
            }
            return true;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB4_3
{
    internal static class RozszerzOsoby
    {
        public static void WypiszOsoby(this List<IOsoba> listaOsob)
        {
            foreach (var osoba in listaOsob)
            {
                osoba.ZwrocPelnaNazwe();
            }
        }

        public static void PosortujOsobyPoNazwisku(this List<IOsoba> listaOsob)
        {
            var posortowanaLista = listaOsob.OrderBy(o => o.Nazwisko).ThenBy(o => o.Imię).ToList();
            foreach (var osoba in posortowanaLista)
            {
                osoba.ZwrocPelnaNazwe();
            }
        }
    }
}

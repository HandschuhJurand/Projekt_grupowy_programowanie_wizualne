using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gry_karciane
{
    public static class Historia
    {
        private static List<Rozgrywka> rozgrywki = new List<Rozgrywka>();

        public static void DodajRozgrywke(Rozgrywka rozgrywka)
        {
            rozgrywki.Add(rozgrywka);
        }

        public static List<Rozgrywka> PobierzRozgrywki()
        {
            return rozgrywki;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using gry_karciane;

namespace gry_karciane
{
    public class Rozgrywka
    {
        public string NazwaGry { get; set; }          
        public string Gracz1Login { get; set; }       
        public string Gracz2Login { get; set; }     
        public string ZwyciezcaLogin { get; set; }     

        public Rozgrywka(string nazwaGry, string gracz1, string gracz2, string zwyciezca)
        {
            NazwaGry = nazwaGry;
            Gracz1Login = gracz1;
            Gracz2Login = gracz2;
            ZwyciezcaLogin = zwyciezca;
        }
    }
}

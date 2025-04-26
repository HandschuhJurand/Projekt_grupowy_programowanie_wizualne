using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using gry_karciane;


namespace gry_karciane
{
   public class Gracz
    {
        public string Login { get; set; }

        public Gracz(string login)
        {
            Login = login;
        }

        public override string ToString()
        {
            return Login;
        }

    }
}

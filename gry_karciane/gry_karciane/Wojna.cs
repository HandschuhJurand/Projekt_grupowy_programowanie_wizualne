using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gry_karciane
{
    public partial class Wojna : Form
    {
        private Queue<Karta> karty_p1;
        private Queue<Karta> karty_p2;
        private List<Karta> stos_wojny = new List<Karta>();
        public Wojna()
        {
            InitializeComponent();
            Start_gry();
        }

        private void Start_gry()
        {
            var talia = Karta.Stworz_talie();
            var losowa_liczba = new Random();
            talia = talia.OrderBy(x => losowa_liczba.Next()).ToList();

            karty_p1 = new Queue<Karta>(talia.Take(26));
            karty_p2 = new Queue<Karta>(talia.Skip(26).Take(26));

            stos_wojny.Clear();
            label_wynik.Text = "Start";
            label_liczba_kart_p1.Text = $"Karty: {karty_p1.Count}";
            label_liczba_kart_p2.Text = $"Karty: {karty_p2.Count}";
            label_karta_p1.Text = "";
            label_karta_p2.Text = "";
        }
        private void button_ruch_Click(object sender, EventArgs e)
        {
            if (karty_p1.Count == 0 || karty_p2.Count == 0)
            {
                string zwyciezca;

                if (karty_p1.Count > karty_p2.Count)
                {
                    zwyciezca = SesjaGracza.Gracz1.Login;
                }
                else
                {
                    zwyciezca = SesjaGracza.Gracz2.Login;
                }

                MessageBox.Show($"KONIEC GRY! Wygral: {zwyciezca}");
                Historia.DodajRozgrywke(new Rozgrywka ("Wojna", SesjaGracza.Gracz1.Login, SesjaGracza.Gracz2.Login, zwyciezca));
                this.Close();
                return;
            }

            var karta1 = karty_p1.Dequeue();
            var karta2 = karty_p2.Dequeue();

            stos_wojny.Add(karta1);
            stos_wojny.Add(karta2);

            label_karta_p1.Text = karta1.ToString();
            label_karta_p2.Text = karta2.ToString();

            if (karta1.Wartosc > karta2.Wartosc)
            {
                foreach (var k in stos_wojny)
                {
                    karty_p1.Enqueue(k);
                }
                stos_wojny.Clear();
                label_wynik.Text = $"{SesjaGracza.Gracz1.Login} wygrywa ture";
            }
            else if (karta2.Wartosc > karta1.Wartosc)
            {
                foreach (var k in stos_wojny)
                {
                    karty_p2.Enqueue(k);
                }
                stos_wojny.Clear();
                label_wynik.Text = $"{SesjaGracza.Gracz2.Login} wygrywa ture";
            }
            else
            {
                label_wynik.Text = "WOJNA";

                for(int i = 0; i < 3; i++)
                {
                    if (karty_p1.Count > 0)
                    {
                        stos_wojny.Add(karty_p1.Dequeue());
                    }
                    if (karty_p2.Count > 0)
                    {
                        stos_wojny.Add(karty_p2.Dequeue());
                    }
                }
            }

            label_liczba_kart_p1.Text = $"Karty: {karty_p1.Count}";
            label_liczba_kart_p2.Text = $"Karty: {karty_p2.Count}";
        }

        private void Wojna_Load(object sender, EventArgs e)
        {

        }

        private class Karta
        {
            public string Kolor { get; set; }
            public int Wartosc { get; set; }

            public Karta(string kolor, int wartosc)
            {
                Kolor = kolor;
                Wartosc = wartosc;
            }

            public override string ToString()
            {
                string nazwa;
                switch (Wartosc)
                {
                    case 11:
                        nazwa = "J";
                        break;
                    case 12:
                        nazwa = "D";
                        break;
                    case 13:
                        nazwa = "K";
                        break;
                    case 14:
                        nazwa = "A";
                        break;
                    default:
                        nazwa = Wartosc.ToString();
                        break;
                }
                return $"{nazwa} {Kolor}";
            }

            public static List<Karta> Stworz_talie()
            {
                var kolory = new[] { "Kier", "Karo", "Trefl", "Pik" };
                var talia = new List<Karta>();
                foreach (var kolor in kolory)
                {
                    for (int wartosc = 2; wartosc <= 14; wartosc++)
                    {
                        talia.Add(new Karta(kolor, wartosc));
                    }
                }
                return talia;
            }
        }
    }
}

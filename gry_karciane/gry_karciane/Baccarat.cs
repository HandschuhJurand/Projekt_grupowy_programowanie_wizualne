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
    public partial class Baccarat : Form
    {
        private List<Karta> talia;
        private Random losowa_liczba;
        private int aktualna_tura = 1;
        private int punkty_gracz1 = 0;
        private int punkty_gracz2 = 0;
        private List<Karta> karty_gracza = new List<Karta>();
        private List<Karta> karty_krupiera = new List<Karta>();

        public Baccarat()
        {
            InitializeComponent();
            losowa_liczba = new Random();
            talia = Karta.Stworz_talie();
            Potasuj_talie();
            
            // Ustawienie nazw graczy
            label_p1.Text = SesjaGracza.Gracz1.Login;
            label_p2.Text = SesjaGracza.Gracz2.Login;
            
            Aktualizuj_UI();
        }

        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is RadioButton radioButton && radioButton.Checked)
            {
                string grupa = radioButton.Tag.ToString();
                // Odznacz pozostałe radio buttony z tej samej grupy
                foreach (Control control in this.Controls)
                {
                    if (control is RadioButton rb && rb.Tag?.ToString() == grupa && rb != radioButton)
                    {
                        rb.Checked = false;
                    }
                }
            }
        }

        private void Aktualizuj_UI()
        {
            label_tury.Text = $"Tura: {aktualna_tura}";
            label_p1_punkty.Text = $"Punkty: {punkty_gracz1}";
            label_p2_punkty.Text = $"Punkty: {punkty_gracz2}";
            
            // Czyszczenie radio buttonów
            radioButton_p1_gracz.Checked = false;
            radioButton_p1_krupier.Checked = false;
            radioButton_p1_remis.Checked = false;
            radioButton_p2_gracz.Checked = false;
            radioButton_p2_krupier.Checked = false;
            radioButton_p2_remis.Checked = false;
        }

        private void Potasuj_talie()
        {
            talia = Karta.Stworz_talie();
            talia = talia.OrderBy(x => losowa_liczba.Next()).ToList();
        }

        private int Oblicz_sume_kart(List<Karta> karty)
        {
            int suma = 0;
            foreach (var karta in karty)
            {
                int wartosc = karta.Wartosc;
                if (wartosc == 14) wartosc = 1; // As jest wart 1
                else if (wartosc > 10) wartosc = 10; // Figury są warte 10
                suma += wartosc;
            }
            return suma % 10; // Zwracamy ostatnią cyfrę
        }

        private void button_rozdanie_Click(object sender, EventArgs e)
        {
            // Sprawdzenie czy gracze obstawili
            if (!Sprawdz_obstawienia())
            {
                MessageBox.Show("Oboje gracze muszą obstawić przed rozdaniem!");
                return;
            }

            // Rozdanie kart
            karty_gracza.Clear();
            karty_krupiera.Clear();
            
            // Pobieranie 4 kart z talii
            for (int i = 0; i < 4; i++)
            {
                if (talia.Count == 0)
                {
                    Potasuj_talie();
                }
                if (i < 2)
                    karty_gracza.Add(talia[0]);
                else
                    karty_krupiera.Add(talia[0]);
                talia.RemoveAt(0);
            }

            // Wyświetlenie kart
            pictureBox_p1.Image = Image.FromFile(Wczytaj_obraz(karty_gracza[0]));
            pictureBox_p2.Image = Image.FromFile(Wczytaj_obraz(karty_gracza[1]));
            pictureBox_b1.Image = Image.FromFile(Wczytaj_obraz(karty_krupiera[0]));
            pictureBox_b2.Image = Image.FromFile(Wczytaj_obraz(karty_krupiera[1]));

            // Obliczenie sum
            int suma_gracza = Oblicz_sume_kart(karty_gracza);
            int suma_krupiera = Oblicz_sume_kart(karty_krupiera);
            
            label_suma_gracz.Text = $"Suma: {suma_gracza}";
            label_suma_krupier.Text = $"Suma: {suma_krupiera}";

            // Sprawdzenie wyników i przyznanie punktów
            Sprawdz_wyniki(suma_gracza, suma_krupiera);

            // Przejście do następnej tury
            aktualna_tura++;
            if (aktualna_tura > 10)
            {
                if (punkty_gracz1 == punkty_gracz2)
                {
                    MessageBox.Show("Remis! Rozgrywamy dodatkowe tury!");
                }
                else
                {
                    string zwyciezca = punkty_gracz1 > punkty_gracz2 ? 
                        SesjaGracza.Gracz1.Login : SesjaGracza.Gracz2.Login;
                    MessageBox.Show($"Koniec gry! Wygrywa: {zwyciezca}");
                    Historia.DodajRozgrywke(new Rozgrywka("Baccarat", 
                        SesjaGracza.Gracz1.Login, SesjaGracza.Gracz2.Login, zwyciezca));
                    this.Close();
                }
            }
            else
            {
                Aktualizuj_UI();
            }
        }

        private bool Sprawdz_obstawienia()
        {
            bool gracz1_obstawil = radioButton_p1_gracz.Checked || 
                                 radioButton_p1_krupier.Checked || 
                                 radioButton_p1_remis.Checked;
            bool gracz2_obstawil = radioButton_p2_gracz.Checked || 
                                 radioButton_p2_krupier.Checked || 
                                 radioButton_p2_remis.Checked;
            return gracz1_obstawil && gracz2_obstawil;
        }

        private void Sprawdz_wyniki(int suma_gracza, int suma_krupiera)
        {
            string wynik;
            if (suma_gracza > suma_krupiera)
                wynik = "gracz";
            else if (suma_krupiera > suma_gracza)
                wynik = "krupier";
            else
                wynik = "remis";

            // Sprawdzenie obstawień gracza 1
            if ((wynik == "gracz" && radioButton_p1_gracz.Checked) ||
                (wynik == "krupier" && radioButton_p1_krupier.Checked))
                punkty_gracz1++;
            else if (wynik == "remis" && radioButton_p1_remis.Checked)
                punkty_gracz1 += 5;

            // Sprawdzenie obstawień gracza 2
            if ((wynik == "gracz" && radioButton_p2_gracz.Checked) ||
                (wynik == "krupier" && radioButton_p2_krupier.Checked))
                punkty_gracz2++;
            else if (wynik == "remis" && radioButton_p2_remis.Checked)
                punkty_gracz2 += 5;

            // Aktualizacja wyświetlania punktów
            label_p1_punkty.Text = $"Punkty: {punkty_gracz1}";
            label_p2_punkty.Text = $"Punkty: {punkty_gracz2}";
        }

        private void button_koniec_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private string Wczytaj_obraz(Karta karta)
        {
            string wartosc;
            switch (karta.Wartosc)
            {
                case 11: wartosc = "J"; break;
                case 12: wartosc = "D"; break;
                case 13: wartosc = "K"; break;
                case 14: wartosc = "A"; break;
                default: wartosc = karta.Wartosc.ToString(); break;
            }
            string kolor = karta.Kolor.ToLower();
            string sciezka = System.IO.Path.Combine("cards", $"{wartosc}_{kolor}.png");
            if (!System.IO.File.Exists(sciezka))
            {
                MessageBox.Show($"Brak pliku: {sciezka}");
            }
            return sciezka;
        }

        private void Baccarat_Load(object sender, EventArgs e)
        {

        }
    }
}

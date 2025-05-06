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
    public partial class oczko : Form
    {
        private List<Karta> talia;
        private List<Karta> kartyGracz1;
        private List<Karta> kartyGracz2;
        private Random losowa;
        private int aktualnyGracz;
        private int kartDobranych;
        private bool pierwszaTuraGracz1;
        private bool pierwszaTuraGracz2;
        private bool gracz1ZakonczylDobieranie;
        private bool gracz2ZakonczylDobieranie;

        public oczko()
        {
            InitializeComponent();
        }

        private void oczko_Load(object sender, EventArgs e)
        {
            Start_gry();
        }

        private void Start_gry()
        {
            // Inicjalizacja zmiennych
            talia = Stworz_talie();
            kartyGracz1 = new List<Karta>();
            kartyGracz2 = new List<Karta>();
            losowa = new Random();
            aktualnyGracz = 1;
            kartDobranych = 0;
            pierwszaTuraGracz1 = true;
            pierwszaTuraGracz2 = true;
            gracz1ZakonczylDobieranie = false;
            gracz2ZakonczylDobieranie = false;

            // Tasowanie talii
            talia = talia.OrderBy(x => losowa.Next()).ToList();

            // Inicjalizacja interfejsu
            label_tura.Text = $"Tura gracza: {SesjaGracza.Gracz1.Login}";
            label_wartosc_kart.Text = "Suma wynikająca z wszystkich posiadanych kart: 0";

            // Dezaktywacja przycisku kontynuuj na początku gry
            button_zakoncz.Enabled = false;

            // Wyczyść pictureBox
            WyczyscObrazKarty();
        }

        // Metoda do czyszczenia obrazu karty
        private void WyczyscObrazKarty()
        {
            if (pictureBox_o1.Image != null)
            {
                pictureBox_o1.Image.Dispose();
                pictureBox_o1.Image = null;
            }
        }

        // Kontynuuj albo pasuj
        private void button_zakoncz_Click(object sender, EventArgs e)
        {
            // Zmiana tury
            if (aktualnyGracz == 1)
            {
                aktualnyGracz = 2;
                label_tura.Text = $"Tura gracza: {SesjaGracza.Gracz2.Login}";
                kartDobranych = 0;

                // Wyczyść obraz karty przy zmianie gracza
                WyczyscObrazKarty();

                // Jeśli to pierwsza tura gracza 2, dezaktywuj przycisk kontynuuj
                if (pierwszaTuraGracz2)
                {
                    button_zakoncz.Enabled = false;
                }
                else
                {
                    // W kolejnych turach przycisk kontynuuj/pasuj jest od razu dostępny
                    button_zakoncz.Enabled = true;
                }

                // Wyświetl wartość kart dla drugiego gracza
                label_wartosc_kart.Text = $"Suma wynikająca z wszystkich posiadanych kart: {ObliczWartoscKart(kartyGracz2)}";
            }
            else
            {
                // Koniec gry - porównanie wyników
                ZakonczGre();
            }
        }

        // Dobieranie karty
        private void button_dobierz_Click(object sender, EventArgs e)
        {
            if (talia.Count == 0)
            {
                MessageBox.Show("Brak kart w talii!");
                return;
            }

            // Dobierz kartę z talii
            Karta dobranaKarta = talia[0];
            talia.RemoveAt(0);

            // Dodaj kartę do odpowiedniego gracza
            if (aktualnyGracz == 1)
            {
                kartyGracz1.Add(dobranaKarta);
                kartDobranych++;

                // Wyświetl kartę
                if (pictureBox_o1.Image != null)
                {
                    pictureBox_o1.Image.Dispose();
                }
                pictureBox_o1.Image = Image.FromFile(Wczytaj_obraz(dobranaKarta));

                // Aktualizuj sumę kart
                label_wartosc_kart.Text = $"Suma wynikająca z wszystkich posiadanych kart: {ObliczWartoscKart(kartyGracz1)}";

                // Aktywuj przycisk kontynuuj po dobraniu dwóch kart w pierwszej turze
                if (pierwszaTuraGracz1 && kartDobranych >= 2)
                {
                    button_zakoncz.Enabled = true;
                    pierwszaTuraGracz1 = false;
                }
                else if (!pierwszaTuraGracz1)
                {
                    // W kolejnych turach przycisk kontynuuj jest zawsze aktywny
                    button_zakoncz.Enabled = true;
                }

                // Sprawdź, czy gracz nie przekroczył 21
                if (ObliczWartoscKart(kartyGracz1) > 21)
                {
                    DialogResult result = MessageBox.Show($"{SesjaGracza.Gracz1.Login} przekroczył 21 punktów! Przegrywa turę.", "Przekroczono limit", MessageBoxButtons.OK);

                    // Zamknij formularz po kliknięciu OK
                    if (result == DialogResult.OK)
                    {
                        ZakonczGre(); // Użyj istniejącej metody, która już dodaje dane do historii
                    }
                }
                else if (ObliczWartoscKart(kartyGracz1) == 21)
                {
                    MessageBox.Show($"{SesjaGracza.Gracz1.Login} osiągnął dokładnie 21 punktów!");
                    button_zakoncz.Enabled = true;
                }
            }
            else // Gracz 2
            {
                kartyGracz2.Add(dobranaKarta);
                kartDobranych++;

                // Wyświetl kartę
                if (pictureBox_o1.Image != null)
                {
                    pictureBox_o1.Image.Dispose();
                }
                pictureBox_o1.Image = Image.FromFile(Wczytaj_obraz(dobranaKarta));

                // Aktualizuj sumę kart
                label_wartosc_kart.Text = $"Suma wynikająca z wszystkich posiadanych kart: {ObliczWartoscKart(kartyGracz2)}";

                // Aktywuj przycisk kontynuuj po dobraniu dwóch kart w pierwszej turze
                if (pierwszaTuraGracz2 && kartDobranych >= 2)
                {
                    button_zakoncz.Enabled = true;
                    pierwszaTuraGracz2 = false;
                }
                else if (!pierwszaTuraGracz2)
                {
                    // W kolejnych turach przycisk kontynuuj jest zawsze aktywny
                    button_zakoncz.Enabled = true;
                }

                // Sprawdź, czy gracz nie przekroczył 21
                if (ObliczWartoscKart(kartyGracz2) > 21)
                {
                    MessageBox.Show($"{SesjaGracza.Gracz2.Login} przekroczył 21 punktów! Przegrywa turę.");
                    ZakonczGre();
                }
                else if (ObliczWartoscKart(kartyGracz2) == 21)
                {
                    MessageBox.Show($"{SesjaGracza.Gracz2.Login} osiągnął dokładnie 21 punktów!");
                    button_zakoncz.Enabled = true;
                }
            }
        }

        // Obliczenie wartości kart gracza
        private int ObliczWartoscKart(List<Karta> karty)
        {
            int suma = 0;
            int iloscAsow = 0;

            foreach (var karta in karty)
            {
                if (karta.Wartosc >= 11 && karta.Wartosc <= 13) // Walet, Dama, Król
                {
                    suma += 10;
                }
                else if (karta.Wartosc == 14) // As
                {
                    suma += 11;
                    iloscAsow++;
                }
                else // Pozostałe karty
                {
                    suma += karta.Wartosc;
                }
            }

            // Jeżeli suma przekracza 21 i mamy asy, to traktujemy je jako 1
            while (suma > 21 && iloscAsow > 0)
            {
                suma -= 10; // Zmniejszamy wartość asa z 11 na 1
                iloscAsow--;
            }

            return suma;
        }

        // Zakończenie gry i wyłonienie zwycięzcy
        private void ZakonczGre()
        {
            int wartoscGracz1 = ObliczWartoscKart(kartyGracz1);
            int wartoscGracz2 = ObliczWartoscKart(kartyGracz2);
            string zwyciezca;

            // Gracz 1 przekroczył 21
            if (wartoscGracz1 > 21 && wartoscGracz2 <= 21)
            {
                zwyciezca = SesjaGracza.Gracz2.Login;
            }
            // Gracz 2 przekroczył 21
            else if (wartoscGracz2 > 21 && wartoscGracz1 <= 21)
            {
                zwyciezca = SesjaGracza.Gracz1.Login;
            }
            // Obaj gracze przekroczyli 21 lub mają tę samą wartość
            else if ((wartoscGracz1 > 21 && wartoscGracz2 > 21) || wartoscGracz1 == wartoscGracz2)
            {
                zwyciezca = "Remis";
                MessageBox.Show($"KONIEC GRY! Remis! Gracz1: {wartoscGracz1}, Gracz2: {wartoscGracz2}");
                DodajHistorieZamknijForm("Remis");
                return;
            }
            // Porównanie wartości kart
            else
            {
                zwyciezca = wartoscGracz1 > wartoscGracz2 ? SesjaGracza.Gracz1.Login : SesjaGracza.Gracz2.Login;
            }

            MessageBox.Show($"KONIEC GRY! Wygrywa: {zwyciezca}! Gracz1: {wartoscGracz1}, Gracz2: {wartoscGracz2}");
            DodajHistorieZamknijForm(zwyciezca);
        }

        // Metoda do dodawania wpisu do historii i zamykania formularza
        private void DodajHistorieZamknijForm(string zwyciezca)
        {
            // Dodaj rozgrywkę do historii, jeśli klasa Historia istnieje
            try
            {
                Historia.DodajRozgrywke(new Rozgrywka("Oczko", SesjaGracza.Gracz1.Login, SesjaGracza.Gracz2.Login, zwyciezca));
            }
            catch
            {
                // Ignoruj jeśli klasa Historia nie istnieje
            }

            this.Close();
        }

        // Stworzenie talii kart
        private List<Karta> Stworz_talie()
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

        // Ścieżka do obrazu karty
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

        // Klasa reprezentująca kartę
        private class Karta
        {
            public string Kolor { get; set; }
            public int Wartosc { get; set; }

            public Karta(string kolor, int wartosc)
            {
                Kolor = kolor;
                Wartosc = wartosc;
            }
        }
    }
}
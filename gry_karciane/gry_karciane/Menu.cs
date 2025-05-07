namespace gry_karciane
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button_dodaj_graczy_Click(object sender, EventArgs e)
        {
            FormLogin formLogin = new FormLogin();
            formLogin.ShowDialog();
        }

        private void button_historia_Click(object sender, EventArgs e)
        {
            FormHistoria formHistoria = new FormHistoria();
            formHistoria.ShowDialog();
        }

        private void button_koniec_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_gra2_Click(object sender, EventArgs e)
        {
            Wojna wojna = new Wojna();
            wojna.ShowDialog();
        }

        private void button_gra3_Click(object sender, EventArgs e)
        {
            Baccarat baccarat = new Baccarat();
            baccarat.ShowDialog();
        }

        private void button_gra1_Click(object sender, EventArgs e)
        {
            oczko oczko = new oczko();
            oczko.ShowDialog();
        }
    }
}

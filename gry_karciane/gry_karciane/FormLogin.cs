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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void labelGracz1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxGracz1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxGracz2_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonZapisz_Click(object sender, EventArgs e)
        {
            var login1 = textBoxGracz1.Text.Trim();
            var login2 = textBoxGracz2.Text.Trim();

            if (string.IsNullOrEmpty(login1) || string.IsNullOrEmpty(login2))
            {
                MessageBox.Show("Podaj login dla obu graczy!");
                return;
            }

            SesjaGracza.Gracz1 = new Gracz(login1);
            SesjaGracza.Gracz2 = new Gracz(login2);

            MessageBox.Show($"Gracze zapisani:\nGracz 1: {login1}\nGracz 2: {login2}");
            this.Close();
        }

        private void buttonAnuluj_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }
    }
}

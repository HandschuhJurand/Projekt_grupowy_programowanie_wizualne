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
    public partial class FormHistoria : Form
    {
        public FormHistoria()
        {
            InitializeComponent();
        }

        private void FormHistoria_Load(object sender, EventArgs e)
        {
            var listaRozgrywek = Historia.PobierzRozgrywki();
            dataGridViewHistoria.DataSource = listaRozgrywek;

            int wygraneGracz1 = listaRozgrywek.Count(r => r.ZwyciezcaLogin == SesjaGracza.Gracz1.Login);
            int wygraneGracz2 = listaRozgrywek.Count(r => r.ZwyciezcaLogin == SesjaGracza.Gracz2.Login);

            labelWynikGracz1.Text = $"{SesjaGracza.Gracz1.Login}: {wygraneGracz1} wygranych";
            labelWynikGracz2.Text = $"{SesjaGracza.Gracz2.Login}: {wygraneGracz2} wygranych";
        
        }

        private void dataGridViewHistoria_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void labelWynikGracz1_Click(object sender, EventArgs e)
        {

        }

        private void labelWynikGracz2_Click(object sender, EventArgs e)
        {

        }
    }
}

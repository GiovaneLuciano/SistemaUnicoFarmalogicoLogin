using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaUnicoFarmalogicoLogin
{
    public partial class PaginaSolicitarNovaRetirada : Form
    {
        public PaginaSolicitarNovaRetirada()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ButtonSolicitar_Click(object sender, EventArgs e)
        {
            TelaConsultarPacientes FormMain = new TelaConsultarPacientes();
            FormMain.Show();
            this.Hide();
            MessageBox.Show("Exame Foi Solicitado");
        }

        private void buttonEspecificarExame_Click(object sender, EventArgs e)
        {

            PaginaSolicitarExame FormMain = new PaginaSolicitarExame();
            FormMain.Show();
            this.Hide();

        }
    }
}

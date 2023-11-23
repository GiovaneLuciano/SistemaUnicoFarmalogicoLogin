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
    public partial class PaginaSolicitarExame : Form
    {
        public PaginaSolicitarExame()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            PaginaSolicitarNovaRetirada FormMain = new PaginaSolicitarNovaRetirada();
            FormMain.Show();
            this.Hide();
            MessageBox.Show("Exame Foi Salvo !");
        }
    }
}

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
    public partial class TelaConsultarPacientes : Form
    {
        public TelaConsultarPacientes()
        {
            InitializeComponent();
        }

        private void toolStripContainer1_ContentPanel_Load(object sender, EventArgs e)
        {

        }

        private void toolStripContainer1_RightToolStripPanel_Click(object sender, EventArgs e)
        {

        }

        private void toolStripContainer1_TopToolStripPanel_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textNascimento_Click(object sender, EventArgs e)
        {

        }

        private void buttonSolicitarNovaRe_Click(object sender, EventArgs e)
        {
            PaginaSolicitarNovaRetirada FormMain = new PaginaSolicitarNovaRetirada();
            FormMain.Show();
            this.Hide();
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}

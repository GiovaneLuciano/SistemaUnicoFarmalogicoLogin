using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaUnicoFarmalogicoLogin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String Cpf = "46719505820";
            TelaConsultarPacientes FormMain = new TelaConsultarPacientes();
            FormMain.Show();
            this.Hide();
        }

        private void textConsultarCpf_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

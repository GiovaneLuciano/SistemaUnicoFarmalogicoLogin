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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void buttonEntrar_Click(object sender, EventArgs e)
        {
            String User = "Leonardo";
            String Password = "102030";

            if(textLogin.Text == User & textSenha.Text == Password)
            {
                MessageBox.Show("Acesso Liberado");
                Form1 FormMain = new Form1();
                FormMain.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Login/Senha Incorretos!");
            }
        }
    }
}

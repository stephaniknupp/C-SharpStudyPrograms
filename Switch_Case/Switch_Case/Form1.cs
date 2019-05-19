using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Switch_Case
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cboSemana_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cboSemana.Text)
            {
                case "Domingo":
                    MessageBox.Show("Hoje tem domingão do faustão", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    break;
                case "Segunda":
                    MessageBox.Show("A não SEGUNDA não, chega logo FDS", "Triste Notícia :'(", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    break;
                case "Terça":
                    MessageBox.Show("Você escolheu Terça que é o 3º dia da semana", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    break;
                case "Quarta":
                    MessageBox.Show("Você escolheu Quarta que é o 4º dia da semana", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    break;
                case "Quinta":
                    MessageBox.Show("Você escolheu Quinta que é o 5º dia da semana", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    break;
                case "Sexta":
                    MessageBox.Show("Você escolheu Sexta que é o 6º dia da semana", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    break;
                case "Sábado":
                    MessageBox.Show("Você escolheu Sábado que é o último dia da semana", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    break;

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 novo = new Form2();
            novo.Show();
            this.Visible = false;
        }
    }
}

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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            switch (cboOpcao.Text)
            {
                case "1 ou 2":
                    lblRes.Text = "O Dia de seu rodízio é Segunda-Feira!";
                    break;
                case "3 ou 4":
                    lblRes.Text = "O Dia de seu rodízio é Terça-Feria!";
                    break;
                case "5 ou 6":
                    lblRes.Text = "O Dia de seu rodízo é Quarta-Feira!";
                    break;
                case "7 ou 8":
                    lblRes.Text = "O Dia de seu rodízio é Quinta-Feira!";
                    break;
                case "9 ou 0":
                    lblRes.Text = "O Dia de seu rodízio é Sexta-Feira!";
                    break;

            }

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Form1 novo = new Form1();
            novo.Show();
            this.Visible = false;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculo_media
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double num1, num2, num3, resultado;
            num1 = Convert.ToDouble(txtNota1.Text);
            num2 = Convert.ToDouble(txtNota2.Text);
            num3 = Convert.ToDouble(txtNota3.Text);
            resultado = (num1 + num2 + num3) / 3;
            txtMedia.Text = resultado.ToString();
            if (resultado < 5)
                MessageBox.Show(" BEM VINDO REPETENTE KKK", "E AI VERGONHA DA FAMÍLIA", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            else if (resultado >= 7)
                MessageBox.Show("AEEW PARABENS MEN TU PASSOU", "CUNGRATULEICHON", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            else
                MessageBox.Show("ESTUDA PRA RECU", "EAE MEN", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            txtNota1.Text = "";
            txtNota2.Text = "";
            txtNota3.Text = "";
            txtMedia.Text = "";
         

           
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

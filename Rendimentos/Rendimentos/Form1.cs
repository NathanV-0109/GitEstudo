using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Rendimentos
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double vp = double.Parse(txtVP.Text);
            double pmt = double.Parse(txtPMT.Text);
            double i = double.Parse(txtI.Text);
            double n = double.Parse(txtN.Text);

            string escolha1 = cboEscolha1.Text;
            string escolha2 = cboescolha2.Text;

            i = i / 100.0;

            if (escolha1 == "Anual")
            {
                i = (Math.Pow((1 + i), (1.0 / 12.0))) - 1;
            }

            if (escolha2 == "Anual")
            {
                n = n * 12;
            }
            

            double resultado = ((pmt * (Math.Pow((1 + i), n) - 1)) / i) + vp * (Math.Pow((1+i), n));

            txtVF.Text = String.Format("{0:f2}", resultado);
        }

        private void btnCalculaPMT_Click(object sender, EventArgs e)
        {
            double vp = double.Parse(txtVP.Text);
            double i = double.Parse(txtI.Text);
            double n = double.Parse(txtN.Text);
            double vf = double.Parse(txtVF.Text);

            i = i / 100.0;

            if (cboEscolha1.Text == "Anual")
            {
                i = (Math.Pow((1 + i), (1.0 / 12.0))) - 1;
            }

            if (cboescolha2.Text == "Anual")
            {
                n = n * 12;
            }
            

            double resultado = (i*vf)/(Math.Pow((1+i),n) - 1);

            txtPMT.Text = String.Format("{0:f2}", resultado);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void btnAjuda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Os valores de VP, VF e PMT são em Reais(R$)\nO valor de I, quando em ano(Valor literal) e mês(0,i) \nO valor de N, pode ser meses ou anos, mas fique atento a opção escolhida");
        }

        private void txtVF_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

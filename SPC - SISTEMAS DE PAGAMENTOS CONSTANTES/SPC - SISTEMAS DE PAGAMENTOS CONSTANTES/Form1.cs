using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace SPC___SISTEMAS_DE_PAGAMENTOS_CONSTANTES
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtArquivo.ScrollBars = ScrollBars.Vertical;
            // Allow the TAB key to be entered in the TextBox control.
            txtArquivo.AcceptsReturn = true;
            // Allow the TAB key to be entered in the TextBox control.
            txtArquivo.AcceptsTab = true;
            // Set WordWrap to true to allow text to wrap to the next line.
            txtArquivo.WordWrap = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtArquivo2.Text = "";
            txtArquivo1.Text = "";
            txtArquivo.Text = "";

            try
            {

                double devedor = double.Parse(txtDevedor.Text.Replace(",", "").Replace(".", ","));
                double porcentagem = double.Parse(txtTaxa.Text.Replace("%", ""));
                decimal prestacoes = (numPrest.Value);
                double entrada = double.Parse(txtEntrada.Text.Replace(",", "").Replace(".", ","));


                devedor = devedor - entrada;

                int prest = Convert.ToInt32(prestacoes);

                double i = porcentagem / 100.0;

                double pagamentos = devedor * ((Math.Pow((1 + i), prest) * i)) / (((Math.Pow((1 + i), prest) - 1)));

                double[] juros = new double[prest + 1];
                juros[0] = 0;

                double[] amortizacao = new double[prest + 1];
                amortizacao[0] = 0;

                double[] saldodevedor = new double[prest + 1];
                saldodevedor[0] = devedor;

                double[] jurosacumulados = new double[prest + 1];
                jurosacumulados[0] = 0;

                double[] aacumulada = new double[prest + 1];
                aacumulada[0] = 0;

                string[] vetoracumulador = new string[prest + 1];


                File.Delete("SAC.txt");
                string texto = "Pagamento" + "|" + "Juros" + "|" + "Amortização" + "|" + "S D" + "|" + "J A" + "|" + "A A" + Environment.NewLine;
                File.AppendAllText("SAC.txt", texto);

                txtArquivo2.Text = (string.Format("Pagamentos") + "          |              " + string.Format("Juros") + "            |           " + string.Format("Amortização") + "          |         " + string.Format("S. Devedor") + "          |          " + string.Format("J. Acumulados") + "         |         " + string.Format("A. Acumulada") + Environment.NewLine);
                txtArquivo1.Text = (string.Format("R$ 0,00") + "               |     " + string.Format("R${0:f2}", juros[0]) + "          |        " + string.Format("R${0:f2}", amortizacao[0]) + "    |        " + string.Format("R${0:f2}", saldodevedor[0]) + "  |         " + string.Format("R${0:f2}", jurosacumulados[0]) + "           |        " + string.Format("R$ {0:f2}", aacumulada[0]) + Environment.NewLine);
                for (int j = 1; j < prest + 1; j++)
                {

                    juros[j] = saldodevedor[j - 1] * i;
                    amortizacao[j] = pagamentos - juros[j];
                    saldodevedor[j] = saldodevedor[j - 1] - amortizacao[j];
                    jurosacumulados[j] = juros[j] + jurosacumulados[j - 1];
                    aacumulada[j] = amortizacao[j] + aacumulada[j - 1];



                    vetoracumulador[j] = (string.Format("{0}", j) + " | " + string.Format("R${0:f2}", pagamentos) + "    |    " + string.Format("R${0:f2}", juros[j]) + "    |    " + string.Format("R${0:f2}", amortizacao[j]) + "    |    " + string.Format("R${0:f2}", saldodevedor[j]) + "    |    " + string.Format("R${0:f2}", jurosacumulados[j]) + "   |   " + string.Format("R$ {0:f2}", aacumulada[j]) + Environment.NewLine);
                    File.AppendAllText("SAC.txt", vetoracumulador[j], Encoding.UTF8);

                    txtArquivo.Text += vetoracumulador[j];

                }
            }
            catch 
            {
                MessageBox.Show("Digite Valores Válidos");
            }

            
            
            
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtArquivo2.Text = "";
            txtArquivo1.Text = "";
            txtArquivo.Text = "";

            try
            {

                double devedor = double.Parse(txtDevedor.Text.Replace(",", "").Replace(".", ","));
                double porcentagem = double.Parse(txtTaxa.Text.Replace("%", ""));
                decimal prestacoes = (numPrest.Value);
                double entrada = double.Parse(txtEntrada.Text.Replace(",", "").Replace(".", ","));


                devedor -= entrada;

                int prest = Convert.ToInt32(prestacoes);
                double i = porcentagem / 100.0;

                double[] pagamentos = new double[prest + 1];
                pagamentos[0] = devedor * ((Math.Pow((1 + i), prest) * i)) / (((Math.Pow((1 + i), prest) - 1)));

                double[] juros = new double[prest + 1];
                juros[0] = 0;


                double[] saldodevedor = new double[prest + 1];
                saldodevedor[0] = devedor;

                double amortizacao = saldodevedor[0] / prest;

                double[] jurosacumulados = new double[prest + 1];
                jurosacumulados[0] = 0;

                double[] aacumulada = new double[prest + 1];
                aacumulada[0] = 0;

                string[] vetoracumulador = new string[prest + 1];


                File.Delete("SAC.txt");
                string texto = (string.Format("Pagamentos") + "        |        " + string.Format("Juros") + "        |        " + string.Format("Amortização") + "       |       " + string.Format("S. Devedor") + "        |        " + string.Format("J. Acumulados") + "       |       " + string.Format("A. Acumulada") + Environment.NewLine);
                File.AppendAllText("SAC.txt", texto);

                txtArquivo2.Text = (string.Format("Pagamentos") + "        |        " + string.Format("Juros") + "        |        " + string.Format("Amortização") + "       |       " + string.Format("S. Devedor") + "        |        " + string.Format("J. Acumulados") + "       |       " + string.Format("A. Acumulada") + Environment.NewLine);
                txtArquivo1.Text = (string.Format("R$ 0,00") + "      |      " + string.Format("R${0:f2}", juros[0]) + "      |      " + string.Format("R${0:f2}", amortizacao) + "      |      " + string.Format("R${0:f2}", saldodevedor[0]) + "       |       " + string.Format("R${0:f2}", jurosacumulados[0]) + "      |      " + string.Format("R$ {0:f2}", aacumulada[0]) + Environment.NewLine);
                for (int j = 1; j < prest + 1; j++)
                {

                    juros[j] = saldodevedor[j - 1] * i;
                    pagamentos[j] = juros[j] + amortizacao;
                    saldodevedor[j] = saldodevedor[j - 1] - amortizacao;
                    jurosacumulados[j] = juros[j] + jurosacumulados[j - 1];
                    aacumulada[j] = amortizacao + aacumulada[j - 1];



                    vetoracumulador[j] = (string.Format("{0}", j) + " | " + string.Format("R${0:f2}", pagamentos[j]) + "    |    " + string.Format("R${0:f2}", juros[j]) + "    |    " + string.Format("R${0:f2}", amortizacao) + "    |    " + string.Format("R${0:f2}", saldodevedor[j]) + "    |    " + string.Format("R${0:f2}", jurosacumulados[j]) + "   |   " + string.Format("R$ {0:f2}", aacumulada[j]) + Environment.NewLine);
                    File.AppendAllText("SAC.txt", vetoracumulador[j], Encoding.UTF8);

                    txtArquivo.Text += vetoracumulador[j];

                }
            }
            catch
            {
                MessageBox.Show("Digite Valores Válidos");
            }
            
            
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Soma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                int tamanho = txtValor.Text.Length;
                string[] divisao = new string[tamanho];
                int soma = 0;

                for (int i = 0; i < tamanho; i++)
                {
                    divisao[i] = txtValor.Text[i].ToString();
                    soma += Int32.Parse(divisao[i].Substring(0, 1));
                }

                txtResultado.Text = soma.ToString();
            }
            catch
            {
                MessageBox.Show("Digite um Valor Válido");
            }

            
        }
    }
}

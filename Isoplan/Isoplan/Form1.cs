using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Isoplan
{
    public partial class ProjetoIsoplan : Form
    {
        public ProjetoIsoplan()
        {
            InitializeComponent();
            num.Clear();
        }

       

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }
        List<float> num = new List<float>();
        
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double[] k = new double[28];
            k[0] = 13.97f;
            k[1] = 4.53f;
            k[2] = 3.31f;
            k[3] = 2.87f;
            k[4] = 2.65f;
            k[5] = 2.52f;
            k[6] = 2.43f;
            k[7] = 2.37f;
            k[8] = 2.32f;
            k[9] = 2.28f;
            k[10] = 2.25f;
            k[11] = 2.23f;
            k[12] = 2.21f;
            k[13] = 2.2f;
            k[14] = 2.18f;
            k[15] = 2.17f;
            k[16] = 2.16f;
            k[17] = 2.15f;
            k[18] = 2.14f;
            k[19] = 2.13f;
            k[20] = 2.11f;
            k[21] = 2.09f;
            k[22] = 2.07f;
            k[23] = 2.06f;
            k[24] = 2.06f;
            k[25] = 2.05f;
            k[26] = 2.025f;
            k[27] = 2f;






            try
            {
                num.Clear();


                Calculos Valor = new Calculos();

                num.Add(float.Parse(txtLeitura1.Text));
                num.Add(float.Parse(txtLeitura2.Text));
                num.Add(float.Parse(txtLeitura3.Text));

                double soma = Math.Pow(Valor.DesvioPadrao(num) / Math.Sqrt(num.Count), 2) + Math.Pow(double.Parse(txtU2.Text), 2) + Math.Pow(double.Parse(txtU3.Text), 2);

                txtMedia.Text = (Valor.Media(num)).ToString();
                txtDP.Text = (Valor.DesvioPadrao(num)).ToString();
                txtU1.Text = (Valor.DesvioPadrao(num) / Math.Sqrt(num.Count)).ToString();
                txtUc.Text = Math.Sqrt(soma).ToString();

                txtVeff.Text = (Math.Pow(Math.Sqrt(soma), 4) / ((Math.Pow((Valor.DesvioPadrao(num)) / Math.Sqrt(num.Count), 4)) / (num.Count - 1))).ToString();

                txtGrau1.Text = (Math.Truncate(Convert.ToDouble(txtVeff.Text))).ToString();
                txtGrau2.Text = (Math.Truncate(Convert.ToDouble(txtVeff.Text)) + 1).ToString();

                for (int i = 1; i < k.Length; i++)
                {
                    if (double.Parse(txtGrau1.Text) == i)
                    {
                       
                       txtValores1.Text = k[i - 1].ToString();
                       break;
           
                    }
                    else
                    {
                        if (double.Parse(txtGrau1.Text) >= 20 && double.Parse(txtGrau1.Text) < 25)
                        {
                            txtValores1.Text = k[19].ToString();
                            break;
                        }
                        if (double.Parse(txtGrau1.Text) >= 25 && double.Parse(txtGrau1.Text) < 30)
                        {
                            txtValores1.Text = k[20].ToString();
                            break;
                        }
                        if (double.Parse(txtGrau1.Text) >= 30 && double.Parse(txtGrau1.Text) < 35)
                        {
                            txtValores1.Text = k[21].ToString();
                            break;
                        }
                        if (double.Parse(txtGrau1.Text) >= 35 && double.Parse(txtGrau1.Text) < 40)
                        {
                            txtValores1.Text = k[22].ToString();
                            break;
                        }
                        if (double.Parse(txtGrau1.Text) >= 40 && double.Parse(txtGrau1.Text) < 45)
                        {
                            txtValores1.Text = k[23].ToString();
                            break;
                        }
                        if (double.Parse(txtGrau1.Text) >= 45 && double.Parse(txtGrau1.Text) < 50)
                        {
                            txtValores1.Text = k[24].ToString();
                            break;
                        }
                        if (double.Parse(txtGrau1.Text) >= 50 && double.Parse(txtGrau1.Text) < 100)
                        {
                            txtValores1.Text = k[25].ToString();
                            break;
                        }

                        txtValores1.Text = k[27].ToString();
                    }

                }
            

                    for (int j= 1; j < k.Length; j++)
                    {
                        if (double.Parse(txtGrau2.Text) == j)
                        {

                            txtValores2.Text = k[j - 1].ToString();
                            break;
                        }
                        else
                        {
                            if (double.Parse(txtGrau2.Text) >= 20 && double.Parse(txtGrau2.Text) < 25)
                            {
                                txtValores2.Text = k[19].ToString();
                                break;
                            }
                            if (double.Parse(txtGrau2.Text) >= 25 && double.Parse(txtGrau2.Text) < 30)
                            {
                                txtValores2.Text = k[20].ToString();
                                break;
                            }
                            if (double.Parse(txtGrau2.Text) >= 30 && double.Parse(txtGrau2.Text) < 35)
                            {
                                txtValores2.Text = k[21].ToString();
                                break;
                            }
                            if (double.Parse(txtGrau2.Text) >= 35 && double.Parse(txtGrau2.Text) < 40)
                            {
                                txtValores2.Text = k[22].ToString();
                                break;
                            }
                            if (double.Parse(txtGrau2.Text) >= 40 && double.Parse(txtGrau2.Text) < 45)
                            {
                                txtValores2.Text = k[23].ToString();
                                break;
                            }
                            if (double.Parse(txtGrau2.Text) >= 45 && double.Parse(txtGrau2.Text) < 50)
                            {
                                txtValores2.Text = k[24].ToString();
                                break;
                            }

                            if (double.Parse(txtGrau2.Text) >= 50 && double.Parse(txtGrau2.Text) < 100)
                            {
                                txtValores2.Text = k[25].ToString();
                                break;
                            }

                            txtValores2.Text = k[27].ToString();
                        }
                    }
            
                

                txtK.Text = (Valor.interpolacao(double.Parse(txtValores1.Text), double.Parse(txtValores2.Text), double.Parse(txtGrau1.Text), double.Parse(txtGrau2.Text), double.Parse(txtVeff.Text))).ToString();
                txtUfinal.Text = (double.Parse(txtK.Text) * double.Parse(txtUc.Text)).ToString();
            }
            catch
            {
                MessageBox.Show("Digite Valores Válidos, e todos os campos");
            }
            }
    

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnCalcularK_Click(object sender, EventArgs e)
        {
            try
            {
                Calculos Valor = new Calculos();


                if (txtVeff.Text == "")
                    btnCalcularK.Enabled = true;
                else
                {
                    txtK.Text = (Valor.interpolacao(double.Parse(txtValores1.Text), double.Parse(txtValores2.Text), double.Parse(txtGrau1.Text), double.Parse(txtGrau2.Text), double.Parse(txtVeff.Text))).ToString();
                }
            }
            catch
            {
                MessageBox.Show("Digite Valores Válidos, e todos os campos");
            }
        }

        private void btnCalcularUf_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtK.Text == "")
                    btnCalcularUf.Enabled = true;
                else
                {
                    txtUfinal.Text = (double.Parse(txtK.Text) * double.Parse(txtUc.Text)).ToString();
                }
            }
            catch
            {
                MessageBox.Show("Digite Valores Válidos, e todos os campos");
            }
        }

        private void btnAjuda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Passo 1 - Digite os Valores nas Lacunas até a identificação U3,e aperte Botão Calcular \nPasso 2 - com o valor de Veff, procure na tabela o intervalo onde se encontra o seu Veff e assim preencha as lacunas Grau, e logo a frente das lacunas grau, colocar o valor de k para cada valor de intervalo, e aperte o botão Calcular K \nPasso - 3 Agora com o valor de K, seu Ufinal pode ser calculado");
        }

        private void ProjetoIsoplan_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void txtGrau1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

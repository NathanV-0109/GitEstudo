using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace IsoplanCertificado
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataTable Tbl;
        DataTable Tbl2;
        List<float> Valores = new List<float>();
        Calculos Valor = new Calculos();
        private void button1_Click(object sender, EventArgs e)
        {

            Tbl = new DataTable();
            // Adiciona os nomes e tipos das colunas
            Tbl.Columns.Add("Ponto", typeof(double));
            Tbl.Columns.Add("Referência", typeof(double));
            Tbl.Columns.Add("Leitura 1", typeof(double));
            Tbl.Columns.Add("Leitura 2", typeof(double));
            Tbl.Columns.Add("Leitura 3", typeof(double));

           

            DataRow linha;

            for (int i = 1; i <= nudPontos.Value; i++)
            {
                linha = Tbl.NewRow();

                linha[0] = 0f;
                linha[1] = 12f;
                linha[2] = 12.0041d;
                linha[3] = 11.9982d;
                linha[4] = 11.9919d;

                Tbl.Rows.Add(linha);
            }

            tbl.DataSource = Tbl;
          

        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            double[] k = new double[28];
            k[0] = 13.97d;
            k[1] = 4.53d;
            k[2] = 3.31d;
            k[3] = 2.87d;
            k[4] = 2.65d;
            k[5] = 2.52d;
            k[6] = 2.43d;
            k[7] = 2.37d;
            k[8] = 2.32d;
            k[9] = 2.28d;
            k[10] = 2.25d;
            k[11] = 2.23d;
            k[12] = 2.21d;
            k[13] = 2.2d;
            k[14] = 2.18d;
            k[15] = 2.17d;
            k[16] = 2.16d;
            k[17] = 2.15d;
            k[18] = 2.14d;
            k[19] = 2.13d;
            k[20] = 2.11d;
            k[21] = 2.09d;
            k[22] = 2.07d;
            k[23] = 2.06d;
            k[24] = 2.06d;
            k[25] = 2.05d;
            k[26] = 2.025d;
            k[27] = 2d;

            Tbl2 = new DataTable();
            Tbl2.Columns.Add("Ponto", typeof(double));
            Tbl2.Columns.Add("Referência", typeof(double));
            Tbl2.Columns.Add("Cal Ponto", typeof(double));
            Tbl2.Columns.Add("Referência Corrente", typeof(double));
            Tbl2.Columns.Add("Leitura 1", typeof(double));
            Tbl2.Columns.Add("Leitura 2", typeof(double));
            Tbl2.Columns.Add("Leitura 3", typeof(double));
            Tbl2.Columns.Add("Média", typeof(double));
            Tbl2.Columns.Add("Erro", typeof(double));
            Tbl2.Columns.Add("U", typeof(double));
            Tbl2.Columns.Add("k", typeof(double));
            Tbl2.Columns.Add("Critério de Aceitação", typeof(double));
            Tbl2.Columns.Add("Situação", typeof(string));

            DataRow linha;

            
           

           
            
           

            for (int i = 0; i < nudPontos.Value; i++)
            {

                    double u1 = 0;
                    linha = Tbl2.NewRow();

                    linha[0] = tbl.Rows[i].Cells[0].Value;
                    linha[1] = tbl.Rows[i].Cells[1].Value;
                    linha[2] = tbl.Rows[i].Cells[0].Value;
                    linha[3] = tbl.Rows[i].Cells[1].Value;
                    linha[4] = tbl.Rows[i].Cells[2].Value;
                    linha[5] = tbl.Rows[i].Cells[3].Value;
                    linha[6] = tbl.Rows[i].Cells[4].Value;
                    Valores.Add(float.Parse(tbl.Rows[i].Cells[2].Value.ToString()));
                    Valores.Add(float.Parse(tbl.Rows[i].Cells[3].Value.ToString()));
                    Valores.Add(float.Parse(tbl.Rows[i].Cells[4].Value.ToString()));
                    linha[7] = Math.Round(Valor.Media(Valores), 4);
                    linha[8] = Math.Round((Valor.Media(Valores) - float.Parse(tbl.Rows[i].Cells[1].Value.ToString())) ,4);

                    u1 = Valor.DesvioPadrao(Valores) / Math.Sqrt(Valores.Count);
                    double soma = (Math.Pow(u1, 2) + Math.Pow(0.005688585, 2));
                    
                    double veff = (Math.Pow(Math.Sqrt(soma), 4) / ((Math.Pow((Valor.DesvioPadrao(Valores)) / Math.Sqrt(Valores.Count), 4)) / (Valores.Count - 1)));
                    double Grau1 = (Math.Truncate(Convert.ToDouble(veff)));
                    double Grau2 = (Math.Truncate(Convert.ToDouble(veff)) + 1);
                    double Valores1 = 0;
                    double Valores2 = 0;

                    for (int z = 1; z < k.Length; z++)
                    {
                        if (Grau1 == z)
                        {

                            Valores1 = k[z - 1];
                            break;

                        }
                        else
                        {
                            if (Grau1 >= 20 && Grau1 < 25)
                            {
                                Valores1 = Valor.interpolacao(k[19], k[20], 20, 25, Grau1);
                                break;
                            }
                            if (Grau1 >= 25 && Grau1 < 30)
                            {
                                Valores1 = Valor.interpolacao(k[20], k[21], 25, 30, Grau1);
                                break;
                            }
                            if (Grau1 >= 30 && Grau1 < 35)
                            {
                                Valores1 = Valor.interpolacao(k[21], k[22], 30, 35, Grau1);
                                break;
                            }
                            if (Grau1 >= 35 && Grau1 < 40)
                            {
                                Valores1 = Valor.interpolacao(k[22], k[23], 35, 40, Grau1);
                                break;
                            }
                            if (Grau1 >= 40 && Grau1 < 45)
                            {
                                Valores1 = Valor.interpolacao(k[23], k[24], 40, 45, Grau1);
                                break;
                            }
                            if (Grau1 >= 45 && Grau1 < 50)
                            {
                                Valores1 = Valor.interpolacao(k[24], k[25], 45, 50, Grau1);
                                break;
                            }
                            if (Grau1 >= 50 && Grau1 < 100)
                            {
                                Valores1 = Valor.interpolacao(k[25], k[26], 50, 100, Grau1);
                                break;
                            }

                            Valores1 = k[27];
                        }

                    }

                    for (int j = 1; j < k.Length; j++)
                    {
                        if (Grau2 == j)
                        {

                            Valores2 = k[j - 1];
                            break;

                        }
                        else
                        {
                            if (Grau2 >= 20 && Grau2 < 25)
                            {
                                Valores2 = Valor.interpolacao(k[19], k[20], 20, 25, Grau2);
                                break;
                            }
                            if (Grau2 >= 25 && Grau2 < 30)
                            {
                                Valores2 = Valor.interpolacao(k[20], k[21], 25, 30, Grau2);
                                break;
                            }
                            if (Grau2 >= 30 && Grau2 < 35)
                            {
                                Valores2 = Valor.interpolacao(k[21], k[22], 30, 35, Grau2);
                                break;
                            }
                            if (Grau2 >= 35 && Grau2 < 40)
                            {
                                Valores2 = Valor.interpolacao(k[22], k[23], 35, 40, Grau2);
                                break;
                            }
                            if (Grau2 >= 40 && Grau2 < 45)
                            {
                                Valores2 = Valor.interpolacao(k[23], k[24], 40, 45, Grau2);
                                break;
                            }
                            if (Grau2 >= 45 && Grau2 < 50)
                            {
                                Valores2 = Valor.interpolacao(k[24], k[25], 45, 50, Grau2);
                                break;
                            }
                            if (Grau2 >= 50 && Grau2 < 100)
                            {
                                Valores2 = Valor.interpolacao(k[25], k[26], 50, 100, Grau2);
                                break;
                            }

                            Valores2 = k[27];
                        }

                    }
                    linha[9] = Math.Round((Math.Sqrt(soma) * Valor.interpolacao(Valores1, Valores2, Grau1, Grau2, veff)), 4);
                    linha[10] = Valor.interpolacao(Valores1, Valores2 , Grau1, Grau2, veff);

       
                    Tbl2.Rows.Add(linha);
                    Valores.Clear();
                    soma = 0;
                    veff = 0;
                    Grau1 = 0;
                    Grau2 = 0;
                    Valores1 = 0;
                    Valores2 = 0;


                    
              
            }

            tbl2.DataSource = Tbl2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= nudPontos.Value; i++)
            {
                if ((etbl2.Rows[i].Cells[8].Value + tbl2.Rows[i].Cells[9].Value < tbl2.Rows[i].Cells[11].Value))
                    MessageBox.Show("Aprovado");
                else
                    MessageBox.Show("Reprovado");
            }
        }
    }
}

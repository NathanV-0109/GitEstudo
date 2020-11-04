using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using FtdAdapter;
using Modbus.Data;
using Modbus.Device;
using Modbus.Utility;
using System.IO;

namespace TransMod
{
    public partial class Form1 : Form
    {
        public struct Dados
        {
            public string TempoAtual;
            public string ValorAtual;
        }
        public Form1()
        {
            InitializeComponent();
            chartDinamico.Legends.Clear();
            chartDinamico.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            chartDinamico.Series[1].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            chartDinamico.Series[2].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            chartDinamico.Series[3].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            chartDinamico.Series[4].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            chartDinamico.Series[5].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            chartDinamico.Series[6].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            chartDinamico.Series[7].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;

            chartHistorico.Legends.Clear();
            chartHistorico.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            chartHistorico.Series[1].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            chartHistorico.Series[2].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            chartHistorico.Series[3].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            chartHistorico.Series[4].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            chartHistorico.Series[5].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            chartHistorico.Series[6].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            chartHistorico.Series[7].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
        }
        public bool testaconexao = false;
        public ushort[] auxiliar;
        public double[] final;
        public string texto = "";
        public string nomeArquivo = "";
        public int contador = 0;
        private void button1_Click(object sender, EventArgs e)
        {
          
            if (cbPorta.SelectedIndex == -1)
            {
                MessageBox.Show("Escolha a porta");
                return;
            }
            
            string COM = cbPorta.SelectedItem.ToString();
            
            if (ckbLeitura.Checked == true && cbPorta.SelectedIndex != -1)
            {
                try
                {
                    auxiliar = MySample.Driver.ModbusSerialRtuMasterReadRegisters(COM);

                    
                    lblCH1.Text = (CasasDecimais.QtdCasas(Convert.ToDouble(auxiliar[0]), casas[0])).ToString();
                    lblCH2.Text = (CasasDecimais.QtdCasas(Convert.ToDouble(auxiliar[1]), casas[1])).ToString();
                    lblCH3.Text = (CasasDecimais.QtdCasas(Convert.ToDouble(auxiliar[2]), casas[2])).ToString();
                    lblCH4.Text = (CasasDecimais.QtdCasas(Convert.ToDouble(auxiliar[3]), casas[3])).ToString();
                    lblCH5.Text = (CasasDecimais.QtdCasas(Convert.ToDouble(auxiliar[4]), casas[4])).ToString();
                    lblCH6.Text = (CasasDecimais.QtdCasas(Convert.ToDouble(auxiliar[5]), casas[5])).ToString();
                    lblCH7.Text = (CasasDecimais.QtdCasas(Convert.ToDouble(auxiliar[6]), casas[6])).ToString();
                    lblCH8.Text = (CasasDecimais.QtdCasas(Convert.ToDouble(auxiliar[7]), casas[7])).ToString();

                    testaconexao = true;
                    
                    lblConexao.Text = "Conectado";
                }
                catch
                {
                    testaconexao = false;
                    lblConexao.Text = "Desconectado";            
                    return;
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblData.Text = DateTime.Now.ToString("dd/MM/yyyy");
            lblHora.Text = DateTime.Now.ToString("HH:mm:ss");
            
            if(testaconexao)
            {
                 btnConectar.PerformClick();
            }

            if (lblConexao.Text == "Desconectado")
            {
          
                btnConectar.PerformClick();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            timer2.Start();
            timerGraf.Start();
            
        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {

            saveFileDialog1.Filter = "Arquivo Texto(*.txt)|*.txt|Arquivos Csv(*.csv)|*.csv";
            saveFileDialog1.FileName = "";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                nomeArquivo = saveFileDialog1.FileName;
                txtCaminho.Text = Path.GetFullPath(nomeArquivo);
            }
        }

        private void ckbLeitura_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbLeitura.Checked == false)
                lblConexao.Text = "Desconectado";
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (chbHabilitaSalvar.Checked && numTempoSalvamento.Value != 0 && txtCaminho.Text != "")
            {
                texto = "";
                File.AppendAllText(nomeArquivo, texto);
                if(File.ReadAllLines(nomeArquivo).Length == 0)
                   texto += "DATA|HORA|PONTO 1|PONTO 2|PONTO 3|PONTO 4|PONTO 5|PONTO 6|PONTO 7|PONTO 8|" + Environment.NewLine;

                timer2.Interval = Convert.ToInt32(numTempoSalvamento.Value)*1000;

                    texto += String.Format("{0}|{1}", DateTime.Now.ToString("dd/MM/yyyy"), DateTime.Now.ToString("HH:mm:ss"));
                    for(int j=0; j < auxiliar.Length; j++)
                        texto += String.Format("|{0}", auxiliar[j]);
                    texto += Environment.NewLine;

                File.AppendAllText(nomeArquivo, texto);
            }
        }
        public int [] casas = new int[8];
            
        private void btnCasasDec_Click(object sender, EventArgs e)
        {
            Form2 tela = new Form2();
            this.Hide();
            tela.ShowDialog();
            this.Show();
            
            casas[0] = CasasDecimais.a;
            casas[1] = CasasDecimais.b;
            casas[2] = CasasDecimais.c;
            casas[3] = CasasDecimais.d;
            casas[4] = CasasDecimais.e;
            casas[5] = CasasDecimais.f;
            casas[6] = CasasDecimais.g;
            casas[7] = CasasDecimais.h;
            
        }

        private void timerGraf_Tick(object sender, EventArgs e)
        {
            if (testaconexao)
            {
                if (chartDinamico.Series[0].Points.Count > 5)
                {
                    chartDinamico.Series[0].Points.RemoveAt(0);
                    chartDinamico.Update();
                }
                chartDinamico.Series[0].Points.AddXY(DateTime.Now.ToString("HH:mm:ss"), Convert.ToDouble(lblCH1.Text));

                if (chartDinamico.Series[1].Points.Count > 5)
                {
                    chartDinamico.Series[1].Points.RemoveAt(0);
                    chartDinamico.Update();
                }
                chartDinamico.Series[1].Points.AddXY(DateTime.Now.ToString("HH:mm:ss"), Convert.ToDouble(lblCH2.Text));

                if (chartDinamico.Series[2].Points.Count > 5)
                {
                    chartDinamico.Series[2].Points.RemoveAt(0);
                    chartDinamico.Update();
                }
                chartDinamico.Series[2].Points.AddXY(DateTime.Now.ToString("HH:mm:ss"), Convert.ToDouble(lblCH3.Text));

                if (chartDinamico.Series[3].Points.Count > 5)
                {
                    chartDinamico.Series[3].Points.RemoveAt(0);
                    chartDinamico.Update();
                }
                chartDinamico.Series[3].Points.AddXY(DateTime.Now.ToString("HH:mm:ss"), Convert.ToDouble(lblCH4.Text));

                if (chartDinamico.Series[4].Points.Count > 5)
                {
                    chartDinamico.Series[4].Points.RemoveAt(0);
                    chartDinamico.Update();
                }
                chartDinamico.Series[4].Points.AddXY(DateTime.Now.ToString("HH:mm:ss"), Convert.ToDouble(lblCH5.Text));

                if (chartDinamico.Series[5].Points.Count > 5)
                {
                    chartDinamico.Series[5].Points.RemoveAt(0);
                    chartDinamico.Update();
                }
                chartDinamico.Series[5].Points.AddXY(DateTime.Now.ToString("HH:mm:ss"), Convert.ToDouble(lblCH6.Text));

                if (chartDinamico.Series[6].Points.Count > 5)
                {
                    chartDinamico.Series[6].Points.RemoveAt(0);
                    chartDinamico.Update();
                }
                chartDinamico.Series[6].Points.AddXY(DateTime.Now.ToString("HH:mm:ss"), Convert.ToDouble(lblCH7.Text));

                if (chartDinamico.Series[7].Points.Count > 5)
                {
                    chartDinamico.Series[7].Points.RemoveAt(0);
                    chartDinamico.Update();
                }
                chartDinamico.Series[7].Points.AddXY(DateTime.Now.ToString("HH:mm:ss"), Convert.ToDouble(lblCH8.Text));

                //MessageBox.Show(chartDinamico.Series[0].XValueMember);
            }
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            double variavel = Convert.ToDouble(txtUpdateTime.Text);
            timerGraf.Interval = Convert.ToInt32(variavel * 3600000);

            if(rdHoras.Checked)
                timerGraf.Interval = Convert.ToInt32(variavel * 3600000);
            else if(rdMinutos.Checked)
                timerGraf.Interval = Convert.ToInt32(variavel * 60000);
            else
                timerGraf.Interval = Convert.ToInt32(variavel * 1000);
        }

        private void chartHistorico_Click(object sender, EventArgs e)
        {

        }

        private void txtCaminho_TextChanged(object sender, EventArgs e)
        {

        }

        private void chbHabilitaSalvar_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (rdHabHistorico.Checked)
            {
                pnlHistorico.Visible = true;
                pnlDinamico.Visible = false;
            }
        }

        private void rdHabDinamic_CheckedChanged(object sender, EventArgs e)
        {
            if (rdHabDinamic.Checked)
            {
                pnlDinamico.Visible = true;
                pnlHistorico.Visible = false;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSelecHistorico_MouseClick(object sender, MouseEventArgs e)
        {
            openFileDialog1.Filter = "Arquivo Texto(*.txt)|*.txt";
            openFileDialog1.FileName = "";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                nomeArquivo = openFileDialog1.FileName;
                txtSelecHistorico.Text = Path.GetFullPath(nomeArquivo);
            }
        }

        private void btnGeraGrafico_Click(object sender, EventArgs e)
        {
            string[] dadosTemp;
            string[] dadosTratados;//criei agora
            
            int numeroLinhas = File.ReadAllLines(txtSelecHistorico.Text).Length;
            Dados[] dados = new Dados[numeroLinhas];

            
            if (File.Exists(txtSelecHistorico.Text))
            {
                /*
                dadosTemp = File.ReadAllLines(nomeArquivo);
                for (int i = 1; i < numeroLinhas; i++)
                {
                    dados[i].TempoAtual = dadosTemp[i].Split('|')[1];

                    for(int j = 0; j < 9; j++) {
                        for(int 
                        dados[i].ValorAtual = dadosTemp[i].Split('|')[j];
                        }

                    for (int k = 0; k < 8; k++)
                    {
                        
                        chartHistorico.Series[k].Points.AddXY(dados[i].TempoAtual, Convert.ToDouble(dados[i].ValorAtual));
                        chartHistorico.Update();
                    }
                }
                 * */
                dadosTemp = File.ReadAllLines(nomeArquivo);//cada posicao do vetor equivale a cada linha
                for (int i = 1; i < numeroLinhas; i++)
                {
                    dadosTratados = dadosTemp[i].Split('|'); //para cada posicao dos dadosTemp faz o split e separa seus itens
                    for (int j = 2; j < dadosTratados.Length; j++)
                    {
                        dados[i].TempoAtual = dadosTratados[1];
                        dados[i].ValorAtual = dadosTratados[j];
                        
                        chartHistorico.Series[j-2].Points.AddXY(dados[i].TempoAtual, Convert.ToDouble(dados[i].ValorAtual));
                        chartHistorico.Update();
                       
                    }

                 
                }

            }

        }
    }
}

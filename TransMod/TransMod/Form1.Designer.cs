namespace TransMod
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series13 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series14 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series15 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series16 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btnConectar = new System.Windows.Forms.Button();
            this.lblCH1 = new System.Windows.Forms.Label();
            this.lblCH2 = new System.Windows.Forms.Label();
            this.lblCH3 = new System.Windows.Forms.Label();
            this.lblCH4 = new System.Windows.Forms.Label();
            this.lblCH8 = new System.Windows.Forms.Label();
            this.lblCH7 = new System.Windows.Forms.Label();
            this.lblCH6 = new System.Windows.Forms.Label();
            this.lblCH5 = new System.Windows.Forms.Label();
            this.cbPorta = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ckbLeitura = new System.Windows.Forms.CheckBox();
            this.txtCaminho = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.numTempoSalvamento = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.chbHabilitaSalvar = new System.Windows.Forms.CheckBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.lblConexao = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.btnCasasDec = new System.Windows.Forms.Button();
            this.chartDinamico = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timerGraf = new System.Windows.Forms.Timer(this.components);
            this.txtUpdateTime = new System.Windows.Forms.TextBox();
            this.btnOkTempo = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.rdHoras = new System.Windows.Forms.RadioButton();
            this.rdMinutos = new System.Windows.Forms.RadioButton();
            this.rdSegundos = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdHabHistorico = new System.Windows.Forms.RadioButton();
            this.rdHabDinamic = new System.Windows.Forms.RadioButton();
            this.chartHistorico = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pnlDinamico = new System.Windows.Forms.Panel();
            this.pnlHistorico = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSelecHistorico = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnGeraGrafico = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numTempoSalvamento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDinamico)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartHistorico)).BeginInit();
            this.pnlDinamico.SuspendLayout();
            this.pnlHistorico.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConectar
            // 
            this.btnConectar.Location = new System.Drawing.Point(416, 175);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(74, 25);
            this.btnConectar.TabIndex = 0;
            this.btnConectar.Text = "Conectar";
            this.btnConectar.UseVisualStyleBackColor = true;
            this.btnConectar.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblCH1
            // 
            this.lblCH1.AutoSize = true;
            this.lblCH1.BackColor = System.Drawing.Color.Cyan;
            this.lblCH1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCH1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCH1.Location = new System.Drawing.Point(12, 9);
            this.lblCH1.Name = "lblCH1";
            this.lblCH1.Padding = new System.Windows.Forms.Padding(25, 5, 25, 5);
            this.lblCH1.Size = new System.Drawing.Size(112, 36);
            this.lblCH1.TabIndex = 1;
            this.lblCH1.Text = "label1";
            // 
            // lblCH2
            // 
            this.lblCH2.AutoSize = true;
            this.lblCH2.BackColor = System.Drawing.Color.Cyan;
            this.lblCH2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCH2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCH2.Location = new System.Drawing.Point(152, 9);
            this.lblCH2.Name = "lblCH2";
            this.lblCH2.Padding = new System.Windows.Forms.Padding(25, 5, 25, 5);
            this.lblCH2.Size = new System.Drawing.Size(112, 36);
            this.lblCH2.TabIndex = 2;
            this.lblCH2.Text = "label1";
            // 
            // lblCH3
            // 
            this.lblCH3.AutoSize = true;
            this.lblCH3.BackColor = System.Drawing.Color.Cyan;
            this.lblCH3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCH3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCH3.Location = new System.Drawing.Point(289, 9);
            this.lblCH3.Name = "lblCH3";
            this.lblCH3.Padding = new System.Windows.Forms.Padding(25, 5, 25, 5);
            this.lblCH3.Size = new System.Drawing.Size(112, 36);
            this.lblCH3.TabIndex = 3;
            this.lblCH3.Text = "label1";
            // 
            // lblCH4
            // 
            this.lblCH4.AutoSize = true;
            this.lblCH4.BackColor = System.Drawing.Color.Cyan;
            this.lblCH4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCH4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCH4.Location = new System.Drawing.Point(432, 9);
            this.lblCH4.Name = "lblCH4";
            this.lblCH4.Padding = new System.Windows.Forms.Padding(25, 5, 25, 5);
            this.lblCH4.Size = new System.Drawing.Size(112, 36);
            this.lblCH4.TabIndex = 4;
            this.lblCH4.Text = "label1";
            // 
            // lblCH8
            // 
            this.lblCH8.AutoSize = true;
            this.lblCH8.BackColor = System.Drawing.Color.Cyan;
            this.lblCH8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCH8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCH8.Location = new System.Drawing.Point(432, 61);
            this.lblCH8.Name = "lblCH8";
            this.lblCH8.Padding = new System.Windows.Forms.Padding(25, 5, 25, 5);
            this.lblCH8.Size = new System.Drawing.Size(112, 36);
            this.lblCH8.TabIndex = 8;
            this.lblCH8.Text = "label1";
            // 
            // lblCH7
            // 
            this.lblCH7.AutoSize = true;
            this.lblCH7.BackColor = System.Drawing.Color.Cyan;
            this.lblCH7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCH7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCH7.Location = new System.Drawing.Point(289, 61);
            this.lblCH7.Name = "lblCH7";
            this.lblCH7.Padding = new System.Windows.Forms.Padding(25, 5, 25, 5);
            this.lblCH7.Size = new System.Drawing.Size(112, 36);
            this.lblCH7.TabIndex = 7;
            this.lblCH7.Text = "label1";
            // 
            // lblCH6
            // 
            this.lblCH6.AutoSize = true;
            this.lblCH6.BackColor = System.Drawing.Color.Cyan;
            this.lblCH6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCH6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCH6.Location = new System.Drawing.Point(152, 61);
            this.lblCH6.Name = "lblCH6";
            this.lblCH6.Padding = new System.Windows.Forms.Padding(25, 5, 25, 5);
            this.lblCH6.Size = new System.Drawing.Size(112, 36);
            this.lblCH6.TabIndex = 6;
            this.lblCH6.Text = "label1";
            // 
            // lblCH5
            // 
            this.lblCH5.AutoSize = true;
            this.lblCH5.BackColor = System.Drawing.Color.Cyan;
            this.lblCH5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCH5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCH5.Location = new System.Drawing.Point(12, 61);
            this.lblCH5.Name = "lblCH5";
            this.lblCH5.Padding = new System.Windows.Forms.Padding(25, 5, 25, 5);
            this.lblCH5.Size = new System.Drawing.Size(112, 36);
            this.lblCH5.TabIndex = 5;
            this.lblCH5.Text = "label1";
            // 
            // cbPorta
            // 
            this.cbPorta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPorta.FormattingEnabled = true;
            this.cbPorta.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4",
            "COM5",
            "COM6",
            "COM7",
            "COM8",
            "COM9"});
            this.cbPorta.Location = new System.Drawing.Point(289, 178);
            this.cbPorta.Name = "cbPorta";
            this.cbPorta.Size = new System.Drawing.Size(121, 21);
            this.cbPorta.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(192, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Selecionar Porta: ";
            // 
            // ckbLeitura
            // 
            this.ckbLeitura.AutoSize = true;
            this.ckbLeitura.Location = new System.Drawing.Point(36, 174);
            this.ckbLeitura.Name = "ckbLeitura";
            this.ckbLeitura.Size = new System.Drawing.Size(99, 17);
            this.ckbLeitura.TabIndex = 11;
            this.ckbLeitura.Text = "Habilitar Leitura";
            this.ckbLeitura.UseVisualStyleBackColor = true;
            this.ckbLeitura.CheckedChanged += new System.EventHandler(this.ckbLeitura_CheckedChanged);
            // 
            // txtCaminho
            // 
            this.txtCaminho.Location = new System.Drawing.Point(152, 310);
            this.txtCaminho.Name = "txtCaminho";
            this.txtCaminho.Size = new System.Drawing.Size(269, 20);
            this.txtCaminho.TabIndex = 12;
            this.txtCaminho.TextChanged += new System.EventHandler(this.txtCaminho_TextChanged);
            this.txtCaminho.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBox1_MouseClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 313);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Selecionar Caminho  : ";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(429, 317);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(56, 13);
            this.lblData.TabIndex = 14;
            this.lblData.Text = "Datatinha ";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Location = new System.Drawing.Point(528, 317);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(44, 13);
            this.lblHora.TabIndex = 15;
            this.lblHora.Text = "Horinha";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // numTempoSalvamento
            // 
            this.numTempoSalvamento.Location = new System.Drawing.Point(152, 351);
            this.numTempoSalvamento.Name = "numTempoSalvamento";
            this.numTempoSalvamento.Size = new System.Drawing.Size(81, 20);
            this.numTempoSalvamento.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 353);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Tempo Salvamento [s]";
            // 
            // chbHabilitaSalvar
            // 
            this.chbHabilitaSalvar.AutoSize = true;
            this.chbHabilitaSalvar.Location = new System.Drawing.Point(36, 197);
            this.chbHabilitaSalvar.Name = "chbHabilitaSalvar";
            this.chbHabilitaSalvar.Size = new System.Drawing.Size(94, 17);
            this.chbHabilitaSalvar.TabIndex = 18;
            this.chbHabilitaSalvar.Text = "Habilita Salvar";
            this.chbHabilitaSalvar.UseVisualStyleBackColor = true;
            this.chbHabilitaSalvar.CheckedChanged += new System.EventHandler(this.chbHabilitaSalvar_CheckedChanged);
            // 
            // lblConexao
            // 
            this.lblConexao.AutoSize = true;
            this.lblConexao.Location = new System.Drawing.Point(237, 261);
            this.lblConexao.Name = "lblConexao";
            this.lblConexao.Size = new System.Drawing.Size(80, 13);
            this.lblConexao.TabIndex = 19;
            this.lblConexao.Text = "Desconectado!";
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // btnCasasDec
            // 
            this.btnCasasDec.Location = new System.Drawing.Point(225, 126);
            this.btnCasasDec.Name = "btnCasasDec";
            this.btnCasasDec.Size = new System.Drawing.Size(141, 31);
            this.btnCasasDec.TabIndex = 20;
            this.btnCasasDec.Text = "Casas Decimais";
            this.btnCasasDec.UseVisualStyleBackColor = true;
            this.btnCasasDec.Click += new System.EventHandler(this.btnCasasDec_Click);
            // 
            // chartDinamico
            // 
            chartArea1.Name = "ChartArea1";
            this.chartDinamico.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartDinamico.Legends.Add(legend1);
            this.chartDinamico.Location = new System.Drawing.Point(18, 57);
            this.chartDinamico.Name = "chartDinamico";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Series2";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.Name = "Series3";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Legend = "Legend1";
            series4.Name = "Series4";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series5.Legend = "Legend1";
            series5.Name = "Series5";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series6.Legend = "Legend1";
            series6.Name = "Series6";
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series7.Legend = "Legend1";
            series7.Name = "Series7";
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series8.Legend = "Legend1";
            series8.Name = "Series8";
            this.chartDinamico.Series.Add(series1);
            this.chartDinamico.Series.Add(series2);
            this.chartDinamico.Series.Add(series3);
            this.chartDinamico.Series.Add(series4);
            this.chartDinamico.Series.Add(series5);
            this.chartDinamico.Series.Add(series6);
            this.chartDinamico.Series.Add(series7);
            this.chartDinamico.Series.Add(series8);
            this.chartDinamico.Size = new System.Drawing.Size(575, 393);
            this.chartDinamico.TabIndex = 21;
            this.chartDinamico.Text = "chart1";
            // 
            // timerGraf
            // 
            this.timerGraf.Interval = 1000;
            this.timerGraf.Tick += new System.EventHandler(this.timerGraf_Tick);
            // 
            // txtUpdateTime
            // 
            this.txtUpdateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUpdateTime.Location = new System.Drawing.Point(113, 464);
            this.txtUpdateTime.Name = "txtUpdateTime";
            this.txtUpdateTime.Size = new System.Drawing.Size(143, 38);
            this.txtUpdateTime.TabIndex = 22;
            // 
            // btnOkTempo
            // 
            this.btnOkTempo.Location = new System.Drawing.Point(262, 463);
            this.btnOkTempo.Name = "btnOkTempo";
            this.btnOkTempo.Size = new System.Drawing.Size(51, 39);
            this.btnOkTempo.TabIndex = 23;
            this.btnOkTempo.Text = "-->";
            this.btnOkTempo.UseVisualStyleBackColor = true;
            this.btnOkTempo.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(226, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 24);
            this.label4.TabIndex = 24;
            this.label4.Text = "Gráfico Dinâmico";
            // 
            // rdHoras
            // 
            this.rdHoras.AutoSize = true;
            this.rdHoras.Checked = true;
            this.rdHoras.Location = new System.Drawing.Point(22, 456);
            this.rdHoras.Name = "rdHoras";
            this.rdHoras.Size = new System.Drawing.Size(48, 17);
            this.rdHoras.TabIndex = 25;
            this.rdHoras.TabStop = true;
            this.rdHoras.Text = "Hora";
            this.rdHoras.UseVisualStyleBackColor = true;
            // 
            // rdMinutos
            // 
            this.rdMinutos.AutoSize = true;
            this.rdMinutos.Location = new System.Drawing.Point(22, 479);
            this.rdMinutos.Name = "rdMinutos";
            this.rdMinutos.Size = new System.Drawing.Size(57, 17);
            this.rdMinutos.TabIndex = 26;
            this.rdMinutos.Text = "Minuto";
            this.rdMinutos.UseVisualStyleBackColor = true;
            // 
            // rdSegundos
            // 
            this.rdSegundos.AutoSize = true;
            this.rdSegundos.Location = new System.Drawing.Point(22, 502);
            this.rdSegundos.Name = "rdSegundos";
            this.rdSegundos.Size = new System.Drawing.Size(68, 17);
            this.rdSegundos.TabIndex = 27;
            this.rdSegundos.Text = "Segundo";
            this.rdSegundos.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdHabHistorico);
            this.groupBox1.Controls.Add(this.rdHabDinamic);
            this.groupBox1.Location = new System.Drawing.Point(623, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(84, 70);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gráfico";
            // 
            // rdHabHistorico
            // 
            this.rdHabHistorico.AutoSize = true;
            this.rdHabHistorico.Location = new System.Drawing.Point(9, 39);
            this.rdHabHistorico.Name = "rdHabHistorico";
            this.rdHabHistorico.Size = new System.Drawing.Size(66, 17);
            this.rdHabHistorico.TabIndex = 1;
            this.rdHabHistorico.TabStop = true;
            this.rdHabHistorico.Text = "Histórico";
            this.rdHabHistorico.UseVisualStyleBackColor = true;
            this.rdHabHistorico.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // rdHabDinamic
            // 
            this.rdHabDinamic.AutoSize = true;
            this.rdHabDinamic.Location = new System.Drawing.Point(9, 16);
            this.rdHabDinamic.Name = "rdHabDinamic";
            this.rdHabDinamic.Size = new System.Drawing.Size(69, 17);
            this.rdHabDinamic.TabIndex = 0;
            this.rdHabDinamic.TabStop = true;
            this.rdHabDinamic.Text = "Dinâmico";
            this.rdHabDinamic.UseVisualStyleBackColor = true;
            this.rdHabDinamic.CheckedChanged += new System.EventHandler(this.rdHabDinamic_CheckedChanged);
            // 
            // chartHistorico
            // 
            chartArea2.Name = "ChartArea1";
            this.chartHistorico.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartHistorico.Legends.Add(legend2);
            this.chartHistorico.Location = new System.Drawing.Point(33, 43);
            this.chartHistorico.Name = "chartHistorico";
            series9.ChartArea = "ChartArea1";
            series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series9.Legend = "Legend1";
            series9.Name = "Series1";
            series10.ChartArea = "ChartArea1";
            series10.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series10.Legend = "Legend1";
            series10.Name = "Series2";
            series11.ChartArea = "ChartArea1";
            series11.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series11.Legend = "Legend1";
            series11.Name = "Series3";
            series12.ChartArea = "ChartArea1";
            series12.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series12.Legend = "Legend1";
            series12.Name = "Series4";
            series13.ChartArea = "ChartArea1";
            series13.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series13.Legend = "Legend1";
            series13.Name = "Series5";
            series14.ChartArea = "ChartArea1";
            series14.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series14.Legend = "Legend1";
            series14.Name = "Series6";
            series15.ChartArea = "ChartArea1";
            series15.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series15.Legend = "Legend1";
            series15.Name = "Series7";
            series16.ChartArea = "ChartArea1";
            series16.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series16.Legend = "Legend1";
            series16.Name = "Series8";
            this.chartHistorico.Series.Add(series9);
            this.chartHistorico.Series.Add(series10);
            this.chartHistorico.Series.Add(series11);
            this.chartHistorico.Series.Add(series12);
            this.chartHistorico.Series.Add(series13);
            this.chartHistorico.Series.Add(series14);
            this.chartHistorico.Series.Add(series15);
            this.chartHistorico.Series.Add(series16);
            this.chartHistorico.Size = new System.Drawing.Size(560, 358);
            this.chartHistorico.TabIndex = 29;
            this.chartHistorico.Text = "chart1";
            this.chartHistorico.Click += new System.EventHandler(this.chartHistorico_Click);
            // 
            // pnlDinamico
            // 
            this.pnlDinamico.Controls.Add(this.rdSegundos);
            this.pnlDinamico.Controls.Add(this.rdMinutos);
            this.pnlDinamico.Controls.Add(this.rdHoras);
            this.pnlDinamico.Controls.Add(this.label4);
            this.pnlDinamico.Controls.Add(this.btnOkTempo);
            this.pnlDinamico.Controls.Add(this.txtUpdateTime);
            this.pnlDinamico.Controls.Add(this.chartDinamico);
            this.pnlDinamico.Location = new System.Drawing.Point(617, 83);
            this.pnlDinamico.Name = "pnlDinamico";
            this.pnlDinamico.Size = new System.Drawing.Size(606, 524);
            this.pnlDinamico.TabIndex = 30;
            this.pnlDinamico.Visible = false;
            // 
            // pnlHistorico
            // 
            this.pnlHistorico.Controls.Add(this.btnGeraGrafico);
            this.pnlHistorico.Controls.Add(this.label5);
            this.pnlHistorico.Controls.Add(this.txtSelecHistorico);
            this.pnlHistorico.Controls.Add(this.chartHistorico);
            this.pnlHistorico.Location = new System.Drawing.Point(617, 83);
            this.pnlHistorico.Name = "pnlHistorico";
            this.pnlHistorico.Size = new System.Drawing.Size(606, 524);
            this.pnlHistorico.TabIndex = 31;
            this.pnlHistorico.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 441);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "Selecionar Caminho  : ";
            // 
            // txtSelecHistorico
            // 
            this.txtSelecHistorico.Location = new System.Drawing.Point(152, 438);
            this.txtSelecHistorico.Name = "txtSelecHistorico";
            this.txtSelecHistorico.Size = new System.Drawing.Size(269, 20);
            this.txtSelecHistorico.TabIndex = 30;
            this.txtSelecHistorico.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtSelecHistorico.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtSelecHistorico_MouseClick);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnGeraGrafico
            // 
            this.btnGeraGrafico.Location = new System.Drawing.Point(427, 426);
            this.btnGeraGrafico.Name = "btnGeraGrafico";
            this.btnGeraGrafico.Size = new System.Drawing.Size(95, 43);
            this.btnGeraGrafico.TabIndex = 32;
            this.btnGeraGrafico.Text = "GERAR";
            this.btnGeraGrafico.UseVisualStyleBackColor = true;
            this.btnGeraGrafico.Click += new System.EventHandler(this.btnGeraGrafico_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1261, 619);
            this.Controls.Add(this.pnlHistorico);
            this.Controls.Add(this.pnlDinamico);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCasasDec);
            this.Controls.Add(this.lblConexao);
            this.Controls.Add(this.chbHabilitaSalvar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numTempoSalvamento);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCaminho);
            this.Controls.Add(this.ckbLeitura);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbPorta);
            this.Controls.Add(this.lblCH8);
            this.Controls.Add(this.lblCH7);
            this.Controls.Add(this.lblCH6);
            this.Controls.Add(this.lblCH5);
            this.Controls.Add(this.lblCH4);
            this.Controls.Add(this.lblCH3);
            this.Controls.Add(this.lblCH2);
            this.Controls.Add(this.lblCH1);
            this.Controls.Add(this.btnConectar);
            this.Name = "Form1";
            this.Text = "TesteCom2";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numTempoSalvamento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDinamico)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartHistorico)).EndInit();
            this.pnlDinamico.ResumeLayout(false);
            this.pnlDinamico.PerformLayout();
            this.pnlHistorico.ResumeLayout(false);
            this.pnlHistorico.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConectar;
        private System.Windows.Forms.ComboBox cbPorta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox ckbLeitura;
        private System.Windows.Forms.TextBox txtCaminho;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.NumericUpDown numTempoSalvamento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chbHabilitaSalvar;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label lblConexao;
        private System.Windows.Forms.Timer timer2;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        public System.Windows.Forms.Label lblCH1;
        public System.Windows.Forms.Label lblCH2;
        public System.Windows.Forms.Label lblCH3;
        public System.Windows.Forms.Label lblCH4;
        public System.Windows.Forms.Label lblCH8;
        public System.Windows.Forms.Label lblCH7;
        public System.Windows.Forms.Label lblCH6;
        public System.Windows.Forms.Label lblCH5;
        public System.Windows.Forms.Button btnCasasDec;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDinamico;
        private System.Windows.Forms.Timer timerGraf;
        private System.Windows.Forms.TextBox txtUpdateTime;
        private System.Windows.Forms.Button btnOkTempo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rdHoras;
        private System.Windows.Forms.RadioButton rdMinutos;
        private System.Windows.Forms.RadioButton rdSegundos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdHabHistorico;
        private System.Windows.Forms.RadioButton rdHabDinamic;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartHistorico;
        private System.Windows.Forms.Panel pnlDinamico;
        private System.Windows.Forms.Panel pnlHistorico;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSelecHistorico;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnGeraGrafico;
    }
}


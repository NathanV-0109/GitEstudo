namespace Rendimentos
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
            this.txtVP = new System.Windows.Forms.TextBox();
            this.txtVF = new System.Windows.Forms.TextBox();
            this.txtI = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPMT = new System.Windows.Forms.TextBox();
            this.txtN = new System.Windows.Forms.TextBox();
            this.btnCalculaVF = new System.Windows.Forms.Button();
            this.btnCalculaPMT = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cboEscolha1 = new System.Windows.Forms.ComboBox();
            this.cboescolha2 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAjuda = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtVP
            // 
            this.txtVP.Location = new System.Drawing.Point(113, 99);
            this.txtVP.Name = "txtVP";
            this.txtVP.Size = new System.Drawing.Size(95, 20);
            this.txtVP.TabIndex = 0;
            // 
            // txtVF
            // 
            this.txtVF.Location = new System.Drawing.Point(113, 257);
            this.txtVF.Name = "txtVF";
            this.txtVF.Size = new System.Drawing.Size(180, 20);
            this.txtVF.TabIndex = 1;
            this.txtVF.TextChanged += new System.EventHandler(this.txtVF_TextChanged);
            // 
            // txtI
            // 
            this.txtI.Location = new System.Drawing.Point(113, 172);
            this.txtI.Name = "txtI";
            this.txtI.Size = new System.Drawing.Size(95, 20);
            this.txtI.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Rendimento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "VP";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 256);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "VF";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(35, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "PMT";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(35, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 24);
            this.label5.TabIndex = 7;
            this.label5.Text = "I";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(35, 206);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 24);
            this.label6.TabIndex = 8;
            this.label6.Text = "N";
            // 
            // txtPMT
            // 
            this.txtPMT.Location = new System.Drawing.Point(113, 138);
            this.txtPMT.Name = "txtPMT";
            this.txtPMT.Size = new System.Drawing.Size(180, 20);
            this.txtPMT.TabIndex = 9;
            // 
            // txtN
            // 
            this.txtN.Location = new System.Drawing.Point(113, 211);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(95, 20);
            this.txtN.TabIndex = 10;
            // 
            // btnCalculaVF
            // 
            this.btnCalculaVF.Location = new System.Drawing.Point(309, 255);
            this.btnCalculaVF.Name = "btnCalculaVF";
            this.btnCalculaVF.Size = new System.Drawing.Size(75, 23);
            this.btnCalculaVF.TabIndex = 11;
            this.btnCalculaVF.Text = "Calcular VF";
            this.btnCalculaVF.UseVisualStyleBackColor = true;
            this.btnCalculaVF.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCalculaPMT
            // 
            this.btnCalculaPMT.Location = new System.Drawing.Point(309, 136);
            this.btnCalculaPMT.Name = "btnCalculaPMT";
            this.btnCalculaPMT.Size = new System.Drawing.Size(78, 23);
            this.btnCalculaPMT.TabIndex = 12;
            this.btnCalculaPMT.Text = "Calcula PMT";
            this.btnCalculaPMT.UseVisualStyleBackColor = true;
            this.btnCalculaPMT.Click += new System.EventHandler(this.btnCalculaPMT_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(86, 102);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "R$";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(86, 143);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(21, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "R$";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(86, 264);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(21, 13);
            this.label11.TabIndex = 17;
            this.label11.Text = "R$";
            // 
            // cboEscolha1
            // 
            this.cboEscolha1.FormattingEnabled = true;
            this.cboEscolha1.Items.AddRange(new object[] {
            "Mensal",
            "Anual"});
            this.cboEscolha1.Location = new System.Drawing.Point(235, 172);
            this.cboEscolha1.Name = "cboEscolha1";
            this.cboEscolha1.Size = new System.Drawing.Size(121, 21);
            this.cboEscolha1.TabIndex = 18;
            this.cboEscolha1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // cboescolha2
            // 
            this.cboescolha2.FormattingEnabled = true;
            this.cboescolha2.Items.AddRange(new object[] {
            "Mensal",
            "Anual"});
            this.cboescolha2.Location = new System.Drawing.Point(217, 211);
            this.cboescolha2.Name = "cboescolha2";
            this.cboescolha2.Size = new System.Drawing.Size(121, 21);
            this.cboescolha2.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(56, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 20);
            this.label9.TabIndex = 20;
            this.label9.Text = "Índice";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 50);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "VP - Valor Presente";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(9, 77);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(155, 13);
            this.label12.TabIndex = 22;
            this.label12.Text = "PMT - Valor depositado ao mês";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(9, 101);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(57, 13);
            this.label13.TabIndex = 23;
            this.label13.Text = "I - Taxa(%)";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(9, 121);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(54, 13);
            this.label14.TabIndex = 24;
            this.label14.Text = "N- Tempo";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Location = new System.Drawing.Point(427, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(173, 143);
            this.panel1.TabIndex = 25;
            // 
            // btnAjuda
            // 
            this.btnAjuda.Location = new System.Drawing.Point(527, 151);
            this.btnAjuda.Name = "btnAjuda";
            this.btnAjuda.Size = new System.Drawing.Size(64, 25);
            this.btnAjuda.TabIndex = 26;
            this.btnAjuda.Text = "Ajuda";
            this.btnAjuda.UseVisualStyleBackColor = true;
            this.btnAjuda.Click += new System.EventHandler(this.btnAjuda_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(214, 175);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(15, 13);
            this.label15.TabIndex = 27;
            this.label15.Text = "%";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 335);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.btnAjuda);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cboescolha2);
            this.Controls.Add(this.cboEscolha1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnCalculaPMT);
            this.Controls.Add(this.btnCalculaVF);
            this.Controls.Add(this.txtN);
            this.Controls.Add(this.txtPMT);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtI);
            this.Controls.Add(this.txtVF);
            this.Controls.Add(this.txtVP);
            this.Name = "Form1";
            this.Text = "Rendimento";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtVP;
        private System.Windows.Forms.TextBox txtVF;
        private System.Windows.Forms.TextBox txtI;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPMT;
        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.Button btnCalculaVF;
        private System.Windows.Forms.Button btnCalculaPMT;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cboEscolha1;
        private System.Windows.Forms.ComboBox cboescolha2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAjuda;
        private System.Windows.Forms.Label label15;
    }
}


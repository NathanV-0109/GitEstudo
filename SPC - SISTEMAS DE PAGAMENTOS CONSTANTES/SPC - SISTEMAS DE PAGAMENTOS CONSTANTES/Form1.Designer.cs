namespace SPC___SISTEMAS_DE_PAGAMENTOS_CONSTANTES
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDevedor = new System.Windows.Forms.MaskedTextBox();
            this.txtTaxa = new System.Windows.Forms.MaskedTextBox();
            this.numPrest = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.txtArquivo = new System.Windows.Forms.TextBox();
            this.txtArquivo1 = new System.Windows.Forms.TextBox();
            this.txtArquivo2 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.txtEntrada = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numPrest)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(281, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sistemas de Pagamentos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Saldo do Devedor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(232, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Taxa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(387, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nº de Prestações";
            // 
            // txtDevedor
            // 
            this.txtDevedor.Location = new System.Drawing.Point(78, 99);
            this.txtDevedor.Mask = "000.000,00";
            this.txtDevedor.Name = "txtDevedor";
            this.txtDevedor.Size = new System.Drawing.Size(100, 20);
            this.txtDevedor.TabIndex = 4;
            // 
            // txtTaxa
            // 
            this.txtTaxa.Location = new System.Drawing.Point(235, 100);
            this.txtTaxa.Mask = "000.00%";
            this.txtTaxa.Name = "txtTaxa";
            this.txtTaxa.Size = new System.Drawing.Size(100, 20);
            this.txtTaxa.TabIndex = 5;
            // 
            // numPrest
            // 
            this.numPrest.Location = new System.Drawing.Point(390, 99);
            this.numPrest.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.numPrest.Name = "numPrest";
            this.numPrest.Size = new System.Drawing.Size(120, 20);
            this.numPrest.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(656, 101);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Gerar SPC";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtArquivo
            // 
            this.txtArquivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArquivo.Location = new System.Drawing.Point(29, 198);
            this.txtArquivo.Multiline = true;
            this.txtArquivo.Name = "txtArquivo";
            this.txtArquivo.Size = new System.Drawing.Size(781, 139);
            this.txtArquivo.TabIndex = 9;
            // 
            // txtArquivo1
            // 
            this.txtArquivo1.Enabled = false;
            this.txtArquivo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArquivo1.Location = new System.Drawing.Point(29, 170);
            this.txtArquivo1.Multiline = true;
            this.txtArquivo1.Name = "txtArquivo1";
            this.txtArquivo1.Size = new System.Drawing.Size(781, 22);
            this.txtArquivo1.TabIndex = 10;
            // 
            // txtArquivo2
            // 
            this.txtArquivo2.Enabled = false;
            this.txtArquivo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArquivo2.Location = new System.Drawing.Point(29, 142);
            this.txtArquivo2.Multiline = true;
            this.txtArquivo2.Name = "txtArquivo2";
            this.txtArquivo2.Size = new System.Drawing.Size(781, 22);
            this.txtArquivo2.TabIndex = 11;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(656, 72);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "GerarSAC";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtEntrada
            // 
            this.txtEntrada.Location = new System.Drawing.Point(535, 98);
            this.txtEntrada.Mask = "000.000,00";
            this.txtEntrada.Name = "txtEntrada";
            this.txtEntrada.Size = new System.Drawing.Size(100, 20);
            this.txtEntrada.TabIndex = 13;
            this.txtEntrada.Text = "00000000";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(532, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Entrada";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 360);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtEntrada);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtArquivo2);
            this.Controls.Add(this.txtArquivo1);
            this.Controls.Add(this.txtArquivo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.numPrest);
            this.Controls.Add(this.txtTaxa);
            this.Controls.Add(this.txtDevedor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numPrest)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox txtDevedor;
        private System.Windows.Forms.MaskedTextBox txtTaxa;
        private System.Windows.Forms.NumericUpDown numPrest;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtArquivo;
        private System.Windows.Forms.TextBox txtArquivo1;
        private System.Windows.Forms.TextBox txtArquivo2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.MaskedTextBox txtEntrada;
        private System.Windows.Forms.Label label5;
    }
}


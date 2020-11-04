namespace CalculoIncerteza
{
    partial class VF
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
            this.txtI = new System.Windows.Forms.TextBox();
            this.txtMeses = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.txtVF = new System.Windows.Forms.Label();
            this.btnCalcula = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtVP
            // 
            this.txtVP.Location = new System.Drawing.Point(72, 44);
            this.txtVP.Name = "txtVP";
            this.txtVP.Size = new System.Drawing.Size(107, 20);
            this.txtVP.TabIndex = 0;
            // 
            // txtI
            // 
            this.txtI.Location = new System.Drawing.Point(72, 86);
            this.txtI.Name = "txtI";
            this.txtI.Size = new System.Drawing.Size(107, 20);
            this.txtI.TabIndex = 1;
            // 
            // txtMeses
            // 
            this.txtMeses.Location = new System.Drawing.Point(72, 127);
            this.txtMeses.Name = "txtMeses";
            this.txtMeses.Size = new System.Drawing.Size(107, 20);
            this.txtMeses.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "VP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(9, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "i";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Meses";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(72, 188);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(107, 20);
            this.textBox4.TabIndex = 6;
            // 
            // txtVF
            // 
            this.txtVF.AutoSize = true;
            this.txtVF.Location = new System.Drawing.Point(31, 191);
            this.txtVF.Name = "txtVF";
            this.txtVF.Size = new System.Drawing.Size(20, 13);
            this.txtVF.TabIndex = 7;
            this.txtVF.Text = "VF";
            // 
            // btnCalcula
            // 
            this.btnCalcula.Location = new System.Drawing.Point(197, 188);
            this.btnCalcula.Name = "btnCalcula";
            this.btnCalcula.Size = new System.Drawing.Size(75, 23);
            this.btnCalcula.TabIndex = 8;
            this.btnCalcula.Text = "Calcular VF";
            this.btnCalcula.UseVisualStyleBackColor = true;
            // 
            // VF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnCalcula);
            this.Controls.Add(this.txtVF);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMeses);
            this.Controls.Add(this.txtI);
            this.Controls.Add(this.txtVP);
            this.Name = "VF";
            this.Text = "VF";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtVP;
        private System.Windows.Forms.TextBox txtI;
        private System.Windows.Forms.TextBox txtMeses;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label txtVF;
        private System.Windows.Forms.Button btnCalcula;
    }
}
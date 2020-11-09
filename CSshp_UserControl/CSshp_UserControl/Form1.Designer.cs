namespace CSshp_UserControl
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
            this.ucEstados1 = new CSshp_UserControl.ucEstados();
            this.btnSelectEstado = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ucEstados1
            // 
            this.ucEstados1.Location = new System.Drawing.Point(12, 12);
            this.ucEstados1.Name = "ucEstados1";
            this.ucEstados1.Size = new System.Drawing.Size(394, 84);
            this.ucEstados1.TabIndex = 0;
            // 
            // btnSelectEstado
            // 
            this.btnSelectEstado.Location = new System.Drawing.Point(91, 121);
            this.btnSelectEstado.Name = "btnSelectEstado";
            this.btnSelectEstado.Size = new System.Drawing.Size(293, 23);
            this.btnSelectEstado.TabIndex = 1;
            this.btnSelectEstado.Text = "Estado Selecionado";
            this.btnSelectEstado.UseVisualStyleBackColor = true;
            this.btnSelectEstado.Click += new System.EventHandler(this.btnSelectEstado_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 261);
            this.Controls.Add(this.btnSelectEstado);
            this.Controls.Add(this.ucEstados1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private ucEstados ucEstados1;
        private System.Windows.Forms.Button btnSelectEstado;
    }
}


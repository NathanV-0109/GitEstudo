using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QualCaractere
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
           
            txtResultado.Text = "";

            if (txtCaracter.Text.Length > 1 || txtCaracter.Text.Length <= 0)
            {
                txtCaracter.Text = "";
                MessageBox.Show("Só um caractere Amigão");
                return;
            }
    

             char caractere = char.Parse(txtCaracter.Text);
             int ascii = Convert.ToInt32(caractere);

             if (ascii > 64 && ascii < 91)
                txtResultado.Text = "É uma string maiúscula";
             else if (ascii > 96 && ascii < 123)
                txtResultado.Text = "É uma string Minúscula";
             else if (ascii > 47 && ascii < 58)
                txtResultado.Text = "É um número";
             else
                txtResultado.Text = "É um caracere Especial";
            
        }
    }
}

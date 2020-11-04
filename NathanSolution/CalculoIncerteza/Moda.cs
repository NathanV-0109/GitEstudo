using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CalculoIncerteza
{
    public partial class Moda : Form
    {
        public Moda()
        {
            InitializeComponent();
            num.Clear();
        }

       
        private void button1_Click(object sender, EventArgs e)
        {
            num.Add(float.Parse(txtAdicionar.Text));
            
        }
        List<float> num = new List<float>();
        private void button2_Click(object sender, EventArgs e)
        {
           
            Calculos Moda = new Calculos();
            
            txtResultado.Text = Moda.Moda(num).ToString();
        }
    }
}

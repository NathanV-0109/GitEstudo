using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TrianguloPascal
{
    public partial class Form1 : Form
    {
        public List<Panel> painel = new List<Panel>();
        public Form1()
        {
            InitializeComponent();

            painel.Add(painel1);
            painel.Add(painel2);
            painel.Add(painel3);
            painel.Add(painel4);
            painel.Add(painel5);
            painel.Add(painel6);
            painel.Add(painel7);
            painel.Add(painel8);
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                if (c.GetType() == typeof(Panel))
                {
                    foreach (Label a in c.Controls)
                    {
                        var path = new System.Drawing.Drawing2D.GraphicsPath();

                        Rectangle PathRect = new Rectangle(0, 0, a.Width, a.Height);
                        path.AddRectangle(PathRect);
                        a.Region = new Region(path);
                        
                    }
                }
            }

            /*Panel[] painel = new Panel[8];
            painel[0] = painel1;
            painel[1] = painel2;
            painel[2] = painel3;
            painel[3] = painel4;
            painel[4] = painel5;
            painel[5] = painel6;
            painel[6] = painel7;
            painel[7] = painel8;*/
            int aux = 0;

            try
            {
                aux = Int32.Parse(txtnum.Text);


                int i = 0;

                if (aux < 8 && aux >= 0)
                {

                    foreach (Panel A in painel)
                    {
                        A.Visible = false;
                    }



                    foreach (Panel A in painel)
                    {
                        if (i == aux)
                            break;
                        A.Visible = true;
                        i++;
                    }

                }
                else
                    MessageBox.Show("Vai dar não meu parceiro");
                txtnum.Text = " ";
            }
            catch
            {
                MessageBox.Show("Digite um Valor Válido");
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            foreach(Control c in this .Controls)
            {
                if (c.GetType() == typeof(Panel))
                {
                    foreach (Label a in c.Controls)
                    {
                        var path = new System.Drawing.Drawing2D.GraphicsPath();
                        path.AddEllipse(0, 0, a.Width, a.Height);

                        a.Region = new Region(path);
                    }
                }
            }

            try
            {
                int aux = Int32.Parse(txtnum.Text);
                int i = 0;

                if (aux < 8 && aux >= 0)
                {

                    foreach (Panel A in painel)
                    {
                        A.Visible = false;
                    }



                    foreach (Panel A in painel)
                    {
                        if (i == aux)
                            break;
                        A.Visible = true;
                        i++;
                    }
                }
                else
                    MessageBox.Show("Vai dar não meu parceiro");
                txtnum.Text = " ";
            }
            catch
            {
                MessageBox.Show("Digite um Valor válido");
            }
            








        

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace Interfaces
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
         
        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(txtNum1.Text);
            int b = Convert.ToInt32(txtNum2.Text);

            MessageBox.Show(string.Format("{0}", MinhaDLL.Class1.soma(a,b)));
        }
    }
}

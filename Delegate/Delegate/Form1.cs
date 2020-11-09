using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Delegate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public delegate void MeuDelegate(string a);
        private void button1_Click(object sender, EventArgs e)
        {
            MeuDelegate objDelegate = new MeuDelegate(MostraMsg);
            objDelegate("Olá, fui invocado pelo delegate");
        }
        private void MostraMsg(string a)
        {
            MessageBox.Show(a);
        }
    }
}

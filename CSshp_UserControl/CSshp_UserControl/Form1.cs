using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CSshp_UserControl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSelectEstado_Click(object sender, EventArgs e)
        {
            MessageBox.Show(string.Format("Id = {0}, Nome: {1}", ucEstados1.estadoSelecionado.Id.ToString(), ucEstados1.estadoSelecionado.Nome.ToString()));
        }
    }
}

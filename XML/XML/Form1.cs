using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;

namespace XML
{
    public partial class Form1 : Form
    {
        List<Pessoa> aux = new List<Pessoa>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSerializar_Click(object sender, EventArgs e)
        {
            aux.Add(new Pessoa
            {
                Nome = txtNome.Text,
                Idade = int.Parse(txtIdade.Text),
                Email = txtEmail.Text
            });

            FileStream fs = new FileStream("etset.xml", FileMode.Create);
            XmlSerializer xs = new XmlSerializer(typeof(List<Pessoa>));
            xs.Serialize(fs, aux);

            fs.Close();
        }
    }
}

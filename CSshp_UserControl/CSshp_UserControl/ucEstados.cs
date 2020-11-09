using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CSshp_UserControl
{
    public partial class ucEstados : UserControl
    {
        public ucEstados()
        {
            InitializeComponent();
        }
        public Estado estadoSelecionado
        {
            get
            {
                return (Estado)cboEstados.SelectedItem;
            }
        }
        private void ucEstados_Load(object sender, EventArgs e)
        {
            List<Estado> estados = new List<Estado>();
            estados.Add(new Estado() { Id = 1, Nome = "Acre" });
            estados.Add(new Estado() { Id = 2, Nome = "Alagoas" });
            estados.Add(new Estado() { Id = 3, Nome = "Amapá" });
            estados.Add(new Estado() { Id = 4, Nome = "Amazonas" });
            estados.Add(new Estado() { Id = 5, Nome = "Bahia" });
            estados.Add(new Estado() { Id = 6, Nome = "Ceará" });
            estados.Add(new Estado() { Id = 7, Nome = "Distrito Federal" });
            estados.Add(new Estado() { Id = 8, Nome = "Espírito Santo" });
            estados.Add(new Estado() { Id = 9, Nome = "Goiás" });
            estados.Add(new Estado() { Id = 10, Nome = "Maranhão"});
            cboEstados.DataSource = estados;
            cboEstados.ValueMember = "Id";
            cboEstados.DisplayMember = "Nome";
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TransMod
{
    public partial class Form2 : Form
    {
        
        public Form2()
        {
            InitializeComponent();
            nupDec1.Value = CasasDecimais.a;
            nupDec2.Value = CasasDecimais.b;
            nupDec3.Value = CasasDecimais.c;
            nupDec4.Value = CasasDecimais.d;
            nupDec5.Value = CasasDecimais.e;
            nupDec6.Value = CasasDecimais.f;
            nupDec7.Value = CasasDecimais.g;
            nupDec8.Value = CasasDecimais.h;
        }

        public void nupDec1_ValueChanged(object sender, EventArgs e)
        {
            CasasDecimais.a = (int)nupDec1.Value;
        }

        private void nupDec2_ValueChanged(object sender, EventArgs e)
        {
            CasasDecimais.b = (int)nupDec2.Value;
        }

        private void nupDec3_ValueChanged(object sender, EventArgs e)
        {
            CasasDecimais.c = (int)nupDec3.Value;
        }

        private void nupDec4_ValueChanged(object sender, EventArgs e)
        {
            CasasDecimais.d = (int)nupDec4.Value;
        }

        private void nupDec5_ValueChanged(object sender, EventArgs e)
        {
            CasasDecimais.e = (int)nupDec5.Value;
        }

        private void nupDec6_ValueChanged(object sender, EventArgs e)
        {
            CasasDecimais.f = (int)nupDec6.Value;
        }

        private void nupDec7_ValueChanged(object sender, EventArgs e)
        {
            CasasDecimais.g = (int)nupDec7.Value;
        }

        private void nupDec8_ValueChanged(object sender, EventArgs e)
        {
            CasasDecimais.h = (int)nupDec8.Value;
        }

       

    }
}

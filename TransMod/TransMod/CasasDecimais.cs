using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TransMod
{
    class CasasDecimais
    {
        public static double QtdCasas(double numero, int numeroCasas)
        {
            
            if (numeroCasas == 1)
                numero = numero / 10;   
            else if (numeroCasas == 2)
                numero = numero / 100;
            else if (numeroCasas == 3)
                numero = numero / 1000;
            else if (numeroCasas == 4)
                numero = numero / 10000;
            return numero;
        }

        public static int a;
        public static int b;
        public static int c;
        public static int d;
        public static int e;
        public static int f;
        public static int g;
        public static int h;
    }
}

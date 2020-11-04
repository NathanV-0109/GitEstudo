using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AreaTriangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            double a;
            double b;
            double c;
            double p;
            double area;

            Console.WriteLine("Digite um Valor do Primeiro Lado");
            a = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite um Valor do Segundo Lado");
            b = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite um Valor do Terceiro Lado");
            c = double.Parse(Console.ReadLine());

            if ((b - c) < a && a < (b + c))
            {
                if ((a - c) < b && b < (a + c))
                    if ((a - b) < c && c < (a + b))
                    {
                        Console.WriteLine("Esse triangulo Existe");

                        p = (a + b + c) / 2;

                        area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

                        Console.WriteLine("E sua Área é {0:f2}",area);
                    }
            }

            else
                Console.WriteLine("Esse triangulo Não Existe");
                   

            Console.ReadKey();

        }
    }
}

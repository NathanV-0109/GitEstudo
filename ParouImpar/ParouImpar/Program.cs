using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ParouImpar
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor;


            while (true)
            {
                try
                {
                    Console.WriteLine("Digite um Valor Inteiro: ");
                    valor = Int32.Parse(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine("Apenas númeror inteiros coleguinha!!!");
                    Console.ReadKey();
                }
                Console.Clear();
            }

             if (valor % 2 == 0)
             {
                Console.WriteLine("Número Par");
             }
             else
             {
                 Console.WriteLine("Número Ímpar");
             }

           
             Console.ReadKey();
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Matriz_identidade
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            bool passa = false;

            while(passa == false)
            {
                try
                {
                    Console.WriteLine("Digite o Valor de n: ");
                    n = Int32.Parse(Console.ReadLine());
                    passa = true;
                    Console.Clear();
                }
                catch
                {
                    Console.WriteLine("Um valor Válido, inteiro de preferencia");

                }
            }

            int[,] matriz = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == j)
                        matriz[i, j] = 1;
                    else
                        matriz[i, j] = 0;
                }
            }


            for (int i = 0; i < n; i++)
            {
                Console.Write("|");
                for (int j = 0; j < n; j++)
                {
                    Console.Write(" ");
                    Console.Write(matriz[i, j]);
                    Console.Write(" ");

                }
                Console.Write("|");
                Console.Write("\n");
            }


            Console.ReadKey();
        }
    }
}

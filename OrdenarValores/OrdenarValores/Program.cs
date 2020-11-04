using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OrdenarValores
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int n = 0;
            bool passa = false;

            while (passa == false)
            {

                try
                {
                    Console.WriteLine("Quantos Valores quer inserir? ");
                    n = Int32.Parse(Console.ReadLine());
                    passa = true;
                    Console.Clear();
                }
                catch
                {
                    Console.WriteLine("Digite um valor válido");
                }
            }

            int[] vetor = new int[n];

            for (int i = 0; i < n; i++)
            {
                try
                {
                    Console.WriteLine("Digite os Valores: ");
                    vetor[i] = Int32.Parse(Console.ReadLine());
                    Console.Clear();
                }
                catch
                {
                    Console.WriteLine("Digite um Valor Válido");
                    i--;
                }
            }

            Ordena(vetor, n);

            Console.ReadKey();
        }

        static void Ordena(int [] vetor, int n)
        {
            int aux;
            int[] ordenado = new int[n];
            for (int i = 0; i < vetor.Length-1 ; i++)
            {
                for (int j = i + 1; j < vetor.Length; j++)
                {
                    if(vetor[i] > vetor[j])
                    {
                        aux = vetor[i];
                        vetor[i] = vetor[j];
                        vetor[j] = aux;
                    }
                }
               
            }
            foreach (int aux1 in vetor)
            {
                Console.WriteLine(aux1);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MediaIdades
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vetor = new int[5];
            double media;

            for (int i = 0; i < vetor.Length; i++)
            {
                Console.WriteLine("Qual sua Idade?");
                vetor[i] = int.Parse(Console.ReadLine());
            }
            media = Convert.ToDouble((vetor[0] + vetor[1] + vetor[2] + vetor[3] + vetor[4])) / 5;
            Console.WriteLine("A Média das Idades é {0}", media);

            Console.ReadKey();
        }
    }
}

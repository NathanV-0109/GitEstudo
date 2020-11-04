using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Conversao
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor = 0;
            char u;
            double conversao;
            string resposta;

            bool teste;
            do
            {
                do
                {
                    Console.WriteLine("Digite um VALOR para converter: ");
                    try
                    {

                        valor = Int32.Parse(Console.ReadLine());
                        teste = true;
                    }
                    catch
                    {
                        Console.WriteLine("Digite um VALOR Válido");
                        teste = false;
                    }
                } while (teste == false);


                Console.Write("Pressione uma das opções dadas: \n" +
                "P -> CONVERTE DE POLEGADAS PARA CENTÍMETROS. \n" +
                "G -> CONVERTE DE GALÕES PARA LITROS \n" +
                "M -> CONVERTE DE MILHAS PARA KILÔMETROS \n");
                u = Char.Parse(Console.ReadLine());


                switch (u)
                {
                    case 'P':

                        conversao = valor * 2.54;
                        Console.WriteLine("{0} Polegadas são {1} Centímetros(cm)", valor, conversao);
                        break;

                    case 'p':

                        conversao = valor * 2.54;
                        Console.WriteLine("{0} Polegadas são {1} Centímetros(cm)", valor, conversao);
                        break;

                    case 'G':

                        conversao = valor * 3.785;
                        Console.WriteLine("{0} Galões são {1} Litros(l)", valor, conversao);
                        break;

                    case 'g':

                        conversao = valor * 3.785;
                        Console.WriteLine("{0} Galões são {1} Litros(l)", valor, conversao);
                        break;

                    case 'M':

                        conversao = valor * 1.609;
                        Console.WriteLine("{0} Milhas são {1} Kilômetros(km)", valor, conversao);
                        break;

                    case 'm':

                        conversao = valor * 1.609;
                        Console.WriteLine("{0} Milhas são {1} Kilômetros(km)", valor, conversao);
                        break;
                    default:
                        Console.WriteLine("Digite uma Opção Válida");
                        break;

                };
                Console.WriteLine("Continuar? (S/N)");
                resposta = Console.ReadLine().ToUpper(); ;
            } while (resposta == "S");

            Console.ReadKey();

        }
    }
}

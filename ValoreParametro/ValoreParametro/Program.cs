using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ValoreParametro
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 2;

            //O primeiro caso se identifica por parametro por valor, na qual o metodo gera uma copia do valor recebido, mas não altera o original
            valor(numero);
            Console.WriteLine("Parametro por VALOR: \n");
            Console.WriteLine("Esse é o parametro por Valor: {0}, na qual não se altera ao valor recebido(o que acontece no metodo, fica no metodo), no caso 2 \n", numero);

            //O segundo caso se identifica por parametro por referencia, onde o metodo em si altera de fato o valor original
            valorR(ref numero);
            Console.WriteLine("Parametro por REFERÊNCIA: \n");
            Console.WriteLine("Esse é o parametro por referencia: {0}, na qual alterou o valor original executando o metodo e atribuindo um novo valor a variavel", numero);

            Console.ReadKey();

        }
        static void valor(int n)
        {
            n = n * 2;
        }

        static void valorR(ref int a)
        {
            a = a * 2;
        }
    }
}

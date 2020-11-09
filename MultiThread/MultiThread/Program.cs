using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace MultiThread
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Teste de MultiThread");

            Thread sub = new Thread(SubThread);
            sub.Start();

            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("OI, sou a thread principal");
            }

            Console.ReadKey();
        }
        static void SubThread()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("OI, sou a subthread");
            }
        }
    }
}

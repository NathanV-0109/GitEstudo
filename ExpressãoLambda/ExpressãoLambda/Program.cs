using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Linq;

namespace ExpressãoLambda
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] times = { "Palmeiras", "são Paulo", "Flamengo", "Ituano" };

            IEnumerable<string> timesFiltrados = Enumerable.Where(times, n => n.Length > 6);

            IEnumerable<string> consulta = times.Where(n => n.Contains("s")).OrderBy(n => n.Length).Select(n => n.ToUpper());

            foreach (string n in consulta)
                Console.Write(n + "|");

            Console.WriteLine("");
            foreach (string n in timesFiltrados)
                Console.Write(n + "|");

            Console.ReadKey();

        }
    }
}

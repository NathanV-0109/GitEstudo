using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.IO;


namespace JsoneXML
{
    class Program
    {
        static void Main(string[] args)
        {

            var pessoa = new pessoa(1, "JOÃO", "da Silva", "Joao.silva@expt.com", 50);

            var xml = new XmlSerializer(typeof(pessoa));

            using (var fileStream = new FileStream("Teste.xml", FileMode.Create))
            {
                xml.Serialize(fileStream, pessoa);
            }

            Console.WriteLine("Serialização Concluida");
        }
    }
}

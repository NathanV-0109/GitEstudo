using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.IO;

namespace CriptografiaTeste
{
    class Program
    {
      
        static void Main(string[] args)
        {
            using (Aes aes = Aes.Create())
            {
                Console.Write("Digite um Texto para criptografia: ");
                string texto = Console.ReadLine();
                
                
                byte[] crypto = Criptografia.Encrypt(texto, aes.Key , aes.IV );
                string textodescriptografado = Criptografia.Decrypt(crypto, aes.Key, aes.IV);

                Console.WriteLine("Seu texto CRIPTOGRAFAFO: {0}", System.Text.Encoding.UTF8.GetString(crypto));
                Console.WriteLine("Seu texto DESCRIPTOGRAFADO: {0}", textodescriptografado);
                
            }
            Console.ReadKey();
        }
    }
}

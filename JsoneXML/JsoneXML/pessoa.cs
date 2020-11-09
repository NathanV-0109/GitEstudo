using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JsoneXML
{
    public class pessoa
    {
        public int Id { get; set; }
        public string PrimeiroNome { get; set; }
        public string UltimoNome { get; set; }
        public string Email { get; set; }
        public int Idade;

        public pessoa() { }

        public pessoa(int id, string primeironome, string ultimonome, string email, int idade)
        {
            Id = id;
            PrimeiroNome = primeironome;
            UltimoNome = ultimonome;
            Email = email;
            Idade = idade;
        }
    }
}

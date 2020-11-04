using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;


namespace NomeseSalarios
{
    class Program
    {
        static void Main(string[] args)
        {
            //vetor onde aloca o arquivo inicial
            string[] vetor = new string[10];
            //vetor de nomes após separação do vetor
            string[] nomes = new string[10];
            //vetor de salarios após separação do vetor
            double[] salarios = new double[10];

            //Vetor final com valores atualizados
            string[] vetornovo = new string[10];

            //leitura e atribução
            vetor = File.ReadAllLines("EX3.txt");
           
            //Processo de separação
            for (int i = 0; i < 10; i++)
            {
                nomes[i] = vetor[i].Split('|')[0];
                salarios[i] = double.Parse(vetor[i].Split('|')[1]); 
            }

            //Processo de reajuste salarial
            for (int i = 0; i < 10; i++)
            {
                if (salarios[i] < 300)
                    salarios[i] = salarios[i] + salarios[i] * 0.5;
                else if (salarios[i]>=300 && salarios[i]<700)
                    salarios[i] = salarios[i] + salarios[i] * 0.4;
                else if(salarios[i] >= 700)
                    salarios[i] = salarios[i] + salarios[i] * 0.3;
            }

            //Processo de atualização de arquivo
            File.Delete("EX3NOVO.txt");

            for (int i = 0; i < 10; i++)
            {
                vetornovo[i] = nomes[i] + "|" +  salarios[i].ToString()+ Environment.NewLine;
                File.AppendAllText("EX3NOVO.txt", vetornovo[i]);
            }
           
        }
    }
}

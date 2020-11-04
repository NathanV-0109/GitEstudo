using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalculoIncerteza
{
    class Calculos
    {
        public float Media(List<float> num)
        {
            return num.Average();
        }

        public float Mediana(List<float> num)
        {
            num.Sort();
            float num1, num2;
            if (num.Count % 2 != 0)
                return num.ElementAt(num.Count / 2);
            else 
            {
                num1 = num.ElementAt(num.Count / 2);
                num2 = num.ElementAt(num.Count / 2 - 1);
                return (num1 + num2) / 2;
            }                                      
        }

        public float Moda(List<float> num)
        {
            num.Sort();
            int qtdp = num.Count;

            int aux = 0;
            int qtd1 = 0;

            List<float> qtd = new List<float>();
            List<float> valor = new List<float>();
           

            for (int i = 0; i < qtdp; i++)
            {
                if (num.ElementAt(aux) == num.ElementAt(i))
                {
                    qtd1++;

                    if (num[qtdp - 1] == num.ElementAt(i))
                    {                      
                        valor.Add(num.ElementAt(aux));
                        qtd.Add(qtd1);
                        aux = i;
                        qtd1 = 0;
                    }
                }
                else
                {
                    valor.Add(num.ElementAt(aux));
                    qtd.Add(qtd1);
                    aux = i;
                    i--;
                    qtd1 = 0;
                }
            }

            aux = 0;
            for (int i = 0; i < qtd.Count; i++)
            {
                if (qtd.ElementAt(aux) <= qtd.ElementAt(i))
                
                    aux = i;
                
                else
                   valor.Add(valor.ElementAt(aux));
            }


            return valor[valor.Count - 1];
        }

        public float DesvioPadrao(List<float> num)
        {
            float media = Media(num);
            double soma = 0;
            double resultado = 0;
            float dp = 0;

            for (int i = 0; i < num.Count; i++)
            {
                soma += Math.Pow(Convert.ToInt32(num.ElementAt(i))- media , 2);
            }

            resultado = soma / num.Count;

           

            return dp;


        }

        public double ValorFuturo(double Vp, double i, int meses)
        {

            double resultado = Vp * (Math.Pow((1 + i), meses));

            return resultado;
        }

        public double ValorPresente(double Vf, double i, int meses)
        {
            double resultado = Vf / (Math.Pow((1 + i), meses));

            return resultado;
        }

        public double TaxaMensal(double Vp, double Vf, int meses)
        {
            double resultado = Math.Pow((Vf/Vp), (1.0/meses)) - 1;

            return resultado;
        }

        public double interpolacao(double a, double b, double c, double d, double grau)
        {
            double resultado = ((a - b) / (c - d)) * (grau - c) + a;

            return resultado;

        }

    }
}

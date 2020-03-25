using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Features
{
    public class Calculadora
    {
        public static decimal Somar(List<decimal> numeros)
        {
            decimal soma = 0m;

            foreach (var numero in numeros)
            {
                soma += numero;
            }

            return soma;
        }

        public static decimal Subtrair(List<decimal> numeros)
        {
            decimal subtracao = 0m;

            foreach (var numero in numeros)
            {
                subtracao -= numero;
            }

            return subtracao;
        }

        public static decimal Multiplicar(List<decimal> numeros)
        {
            decimal multiplicacao = 0m;

            foreach (var numero in numeros)
            {
                multiplicacao += numero;
            }

            return multiplicacao;
        }

        public static decimal Dividir(decimal n1, decimal n2)
        {
            return n1 / n2;
        }
    }
}

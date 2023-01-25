using BasicSoma.Basic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicSoma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá, Boas Vindas ao Calculatrix!");
            Operacoes operacoes = new Operacoes();
            Console.WriteLine("O valor é: " + operacoes.Soma.Calcular(10, 10));
            Console.WriteLine("O valor é: " + operacoes.Subtracao.Calcular(30, 15));
            Console.WriteLine("O valor é: " + operacoes.Divisao.Calcular(657, 98));
            Console.WriteLine("O valor é: " + operacoes.Multiplicacao.Calcular(9, 48));

            Console.ReadKey();
        }
    }
}

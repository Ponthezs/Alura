using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_ConversoesEOutrosTipos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double salario = 3000.15;
            Console.WriteLine(salario);

            int salarioInteiro = (int)salario;
            Console.WriteLine(salarioInteiro);

            //O long é um tipo de variável de 64 bits
            long x = 2000000000000000000;
            Console.WriteLine(x);

            short y = 15000;
            Console.WriteLine(y);

            float altura = 1.62f;
            Console.WriteLine(altura);

            Console.WriteLine("Tecle enter para fechar ...");
            Console.ReadLine();

            float pontoFlutuante = 3.14f;

            double salario = 3000.10;
            int valor = (int)salario;
            Console.WriteLine(valor);

            double valor1 = 0.2;
            double valor2 = 0.1;
            double total = valor1 + valor2;

            Console.WriteLine(total);


        }
    }
}

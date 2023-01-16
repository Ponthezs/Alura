using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_CirandoVariaveisPontosFlutuantes
{
    internal class Program
    {
        static void Main(string[] args)
        {

                Console.WriteLine("Projeto 3 - Variáveis Ponto Flutuante");

                double salario;
            salario = 3000.10;
        
                salario = 3000;

                double idade;

                idade = 7.0 / 5;

                Console.WriteLine(idade);

                Console.WriteLine(salario);

                Console.WriteLine("Tecle enter para fechar...");
                Console.ReadLine();

            ///////////////////////////////////////////////////////////
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
            Console.ReadLine();///


        }
    }
    
}

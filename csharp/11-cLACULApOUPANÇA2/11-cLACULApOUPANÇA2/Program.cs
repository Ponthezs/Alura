using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_cLACULApOUPANÇA2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 11 - Calcula Poupança");

            /*
            while (mes <= 12)
            {
                investimento = investimento + investimento * 0.005;
                Console.WriteLine("No mês " + mes + " você tem R$ " + investimento);
                //mes = mes + 1;
                mes += 1;
            }
            */

            double investimento = 1000;

            for (int mes = 1; mes <= 12; mes++)
            {
                investimento *= 1.005;
                Console.WriteLine("No mês " + mes + " você tem R$ " + investimento);
            }

            Console.WriteLine("Tecle enter para fechar ...");
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_InvestimentoALongoPrazo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 12 - Investindo a Longo prazo");

            double fatorRendimento = 1.005;
            double investimento = 1000;

            for (int anos = 1; anos <= 5; anos++)
            {
                for (int mes = 1; mes <= 12; mes++)
                {
                    investimento *= fatorRendimento;
                }

                fatorRendimento += 0.001;
            }

            Console.WriteLine("No mes " + mes);
            Console.WriteLine("Depois de 5 anos você terá R$ " + investimento);

            Console.WriteLine("Tecle enter para fechar ...");
            Console.ReadLine();
        }
    }
}

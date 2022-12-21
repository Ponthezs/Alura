using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_AtribuicoesdeVariaveis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 6 - Atribuições de variáveis");

            int idade = 30;
            int idadeAna = idade;

            Console.WriteLine(idadeAna);

            idade = 25;

            Console.WriteLine("Tecle enter para fechar ...");
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Condicionais
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 7 - Condicionais");

            int idadeJoao = 16;
            int quantidadePessoas = 2;

            bool acompanhado = quantidadePessoas > 1;
            bool grupo = false;

            if (idadeJoao >= 18 || acompanhado)
            {
                Console.WriteLine("Pode entrar!");
            }
            else
            {
                Console.WriteLine("Não pode entrar!");
            }

            Console.WriteLine("Tecle enter para fechar ...");
            Console.ReadLine();

        }
    }
}

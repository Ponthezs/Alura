using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_CaracteresEtexto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 5 - Caracteres e Textos");

            char letra = 'a';
            Console.WriteLine(letra);

            letra = (char)65;
            Console.WriteLine(letra);

            letra = (char)(65 + 1);
            Console.WriteLine(letra);

            letra = (char)(86 + 1);
            Console.WriteLine(letra);

            string primeiraFrase = "Alura - Cursos de tecnologia";
            Console.WriteLine(primeiraFrase);

            Console.WriteLine("Tecle enter para fechar ...");
            Console.ReadLine();

            string PrimeiraFrase = "Alura - Cursos de tecnologia ";
            Console.WriteLine(PrimeiraFrase + 2022);

            string vazia = "";
            Console.WriteLine(vazia);

            letra = ' ';

            string Cursos = "Cursos disponíveis: - Go - C# - Python - Java";
            Console.WriteLine(Cursos);

            Console.WriteLine("Tecle enter para fechar ...");
            Console.ReadLine();

            char letra = 'a';
            Console.WriteLine(letra);
            char valor = 65;                    // Não Compila!
            Console.WriteLine(valor);
            valor = (char)(valor + 1);         // Compila!
            Console.WriteLine(valor);
            string palavra = "alura cursos online de tecnologia";
            Console.WriteLine(palavra);
            palavra = palavra + 2020;
            Console.WriteLine(palavra);


        }
    }
}

using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ResgistraOcorrencia regConsole = new ResgistraOcorrencia(new RegistraConsole());
            regConsole.Registrar("Mensagem no console");

            ResgistraOcorrencia regDisco = new ResgistraOcorrencia(new ResgistraNoDisco(@"C:\Users\felipe.pontes\OneDrive\Documentos\Dev\Cursos\Alura\Alura\csharp\ConsoleApp1\log.txt"));
            regDisco.Registrar("Mensagem no disco");


            Console.ReadKey();
        }


    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class RegistraNoDisco : IRegistro
    {
        public void RegistraInfo(string mensagem)
        {
            Console.WriteLine("MENSAGEM NO CONSOLE");
        }
    }
}

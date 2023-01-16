using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioALR_Multiplos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 3; i < 100; i += 3)
            {
                Console.WriteLine(i);
            }
            int fatorial = 1;
            for (int i = 1; i < 11; i++)
            {
                fatorial *= i;
                Console.WriteLine("Fatorial de " + i + " = " + fatorial);
            }
        }
    }
}

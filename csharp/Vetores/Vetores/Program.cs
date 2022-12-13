using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vetores
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int[] primos = { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31 };

            int[] somas = new int[11];

            for (int i = 0; i < 11; i++)
            {
                somas[i] = 0;

                for (int j = 0; j <= i; j++)
                {
                    somas[i] += primos[j];
                }
            }

            Console.Write("somas: ", somas);

            for (int i = 0; i < 11; i++)
            {
                Console.Write(" {0}", somas[i]);
            }

            Console.WriteLine();
        }
    }
}

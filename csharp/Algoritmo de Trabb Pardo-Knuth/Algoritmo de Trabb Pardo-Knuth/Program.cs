using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Linq.Enumerable;
using static System.Math;

namespace Algoritmo_de_Trabb_Pardo_Knuth
{
    class Tpk
    {
        static double F(double t) => Sqrt(Abs(t)) + 5 * Pow(t, 3);

        static void Main()
        {
            var a = Range(0, 11).Select(_ => double.Parse(Console.ReadLine())).ToArray();
            foreach (var i in Range(0, a.Length).Reverse())
            {
                var y = F(a[i]);
                Console.WriteLine(y > 400 ? $"{i} TOO LARGE" : $"{i} {y}");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ponteiros
{
    class Test
    {
        unsafe static void WriteLocations()
        {
            int* p;
            int i;
            i = 10;
            p = &i;

            string addr;
            addr = int.Format((int)p, "X");

            Console.WriteLine(addr);
            Console.WriteLine(*p);

            *p = 333;

            Console.WriteLine(i);

            i = *(&i) + 10;

            Console.WriteLine(i);
        }

        static void Main()
        {
            WriteLocations();
        }
    }
}

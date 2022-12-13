using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversão_de_tipos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // converte uma string para um byte
            byte numero8bits = Convert.ToByte("123");

            // converte uma string para um short
            short numero16bits = Convert.ToInt16("1024");

            // converte uma string para um int
            int numero32bits = Convert.ToInt32("34123");

            // converte uma string para um double
            double numeroReal64bits = Convert.ToDouble("132123.12455");

            // converte um inteiro para uma string
            string palavra1 = Convert.ToString(123);

            // outra forma de se obter o mesmo resultado anterior
            string palavra2 = 123.ToString();
        }
    }
}

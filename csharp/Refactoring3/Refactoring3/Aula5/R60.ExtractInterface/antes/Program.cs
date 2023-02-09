using refatoracao.R60.ExtractInterface.depois;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactoring3.Aula5.R60.ExtractInterface.antes
{
    class Program
    {

        void Main()
        {
            var formatadorCNPJ = new CNPJFormatter();
            string codigoCNPJ = "12345678000099";
            ImprimirCodigoFormatadoCNPJ(formatadorCNPJ, codigoCNPJ);

            var formatadorCPF = new CPFFormatter();
            string codigoCPF = "12345678001";
            ImprimirCodigoFormatadoCPF(formatadorCPF, codigoCPF);

        }

        private static void ImprimirCodigoFormatadoCPF(CPFFormatter formatadorCPF, string codigoCPF)
        {
            Console.WriteLine($"Código formatado: {formatadorCPF.Format(codigoCPF)}");
        }

        private static void ImprimirCodigoFormatadoCNPJ(CNPJFormatter formatadorCNPJ, string codigoCNPJ)
        {
            Console.WriteLine($"Código formatado: {formatadorCNPJ.Format(codigoCNPJ)}");
        }
    }
}

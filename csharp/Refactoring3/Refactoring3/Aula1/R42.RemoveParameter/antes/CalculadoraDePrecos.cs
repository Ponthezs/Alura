using System;
using System.Collections.Generic;
using System.Text;

namespace refatoracao.R42.RemoveParameter.antes
{
    class Program
    {
        void Main()
        {
            var descontoFinal =
                new CalculadoraDePrecos()
                .GetDescontoFinal(23, 10, 3, true);

            Console.WriteLine($"Desconto final: {descontoFinal}");
        }
    }

    class CalculadoraDePrecos
    {
        private const decimal LIMITE_MAXIMO_DESCONTO_INICIAL = 50m;
        private const int LIMITE_MINIMO_QUANTIDADE = 100;
        private const int LIMITE_MINIMO_ANOS_CLIENTE = 4;
        private const decimal DESCONTO_MAXIMO = 50m;
        private const decimal INCREMENTO_DESCONTO_POR_QUANTIDADE = 15m;
        private const decimal INCREMENTO_DESCONTO_POR_TEMPO = 10m;

        public decimal GetDescontoFinal(decimal descontoInicial, int quantidade, int clienteHaQuantosAnos, bool clienteNegativado)
        {
            if (clienteNegativado)
            {
                return 0; //early return
            }

            var result = descontoInicial;
            if (descontoInicial > LIMITE_MAXIMO_DESCONTO_INICIAL)
            {
                result = DESCONTO_MAXIMO;
            }
            if (clienteHaQuantosAnos > LIMITE_MINIMO_ANOS_CLIENTE)
            {
                result += INCREMENTO_DESCONTO_POR_TEMPO;
            }
            return result;
        }
    }
}

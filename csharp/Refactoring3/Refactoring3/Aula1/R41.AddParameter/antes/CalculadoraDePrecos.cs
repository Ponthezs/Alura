using System;
using System.Collections.Generic;
using System.Text;

namespace refatoracao.R41.AddParameter.antes
{
    class Program
    {
        void Main()
        {
            var descontoCliente1 =
                new CalculadoraDePrecos()
                .GetDescontoFinal(23, 10, 3);

            Console.WriteLine($"Desconto final: {descontoCliente1}");

            var descontoCliente2 =
                new CalculadoraDePrecos()
                .GetDescontoFinal(30, 4, 5); //Mas este cliente é negativado!

            Console.WriteLine($"Desconto final: {descontoCliente2}");
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

        public decimal GetDescontoFinal(decimal descontoInicial, int quantidade, int clienteHaQuantosAnos)
        {
            var result = descontoInicial;
            if (descontoInicial > LIMITE_MAXIMO_DESCONTO_INICIAL)
            {
                result = DESCONTO_MAXIMO;
            }
            if (quantidade > LIMITE_MINIMO_QUANTIDADE)
            {
                result += INCREMENTO_DESCONTO_POR_QUANTIDADE;
            }
            if (clienteHaQuantosAnos > LIMITE_MINIMO_ANOS_CLIENTE)
            {
                result += INCREMENTO_DESCONTO_POR_TEMPO;
            }
            return result;
        }
    }
}

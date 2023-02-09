using System;
using System.Collections.Generic;
using System.Text;

namespace refatoracao.R47.ReplaceParameterWMethodCall.depois
{
    class Program
    {
        void Main(decimal descontoInicial, int quantidade, string cpfCliente)
        {
            var descontoCliente =
                new Cliente(cpfCliente)
                .GetDescontoFinal(descontoInicial, quantidade);

            Console.WriteLine($"Desconto final: {descontoCliente}");
        }
    }

    class Cliente
    {
        private const decimal LIMITE_MAXIMO_DESCONTO_INICIAL = 50m;
        private const int LIMITE_MINIMO_QUANTIDADE = 100;
        private const int PONTUACAO_MINIMA_CLIENTE_PREMIUM = 4;
        private const decimal DESCONTO_MAXIMO = 50m;
        private const decimal INCREMENTO_DESCONTO_POR_QUANTIDADE = 15m;
        private const decimal INCREMENTO_DESCONTO_PREMIUM = 10m;
        private readonly string cpfCliente;

        public Cliente(string cpfCliente)
        {
            this.cpfCliente = cpfCliente;
        }

        public decimal GetDescontoFinal(decimal descontoInicial, int quantidade)
        {
            int pontuacaoDoCliente = ServicoDeCredito.ClienteHaQuantosAnos(cpfCliente);
            bool clienteNegativado = ServicoDeCredito.VerificaClienteNegativado(cpfCliente);

            if (clienteNegativado)
            {
                return 0; //early return
            }

            var result = descontoInicial;
            if (descontoInicial > LIMITE_MAXIMO_DESCONTO_INICIAL)
            {
                result = DESCONTO_MAXIMO;
            }
            if (quantidade > LIMITE_MINIMO_QUANTIDADE)
            {
                result += INCREMENTO_DESCONTO_POR_QUANTIDADE;
            }
            if (pontuacaoDoCliente > PONTUACAO_MINIMA_CLIENTE_PREMIUM)
            {
                result += INCREMENTO_DESCONTO_PREMIUM;
            }
            return result;
        }
    }

    class ServicoDeCredito
    {
        internal static int ClienteHaQuantosAnos(string cpfCliente)
        {
            return 5;
        }

        internal static bool VerificaClienteNegativado(string cpfCliente)
        {
            return false;
        }
    }
}

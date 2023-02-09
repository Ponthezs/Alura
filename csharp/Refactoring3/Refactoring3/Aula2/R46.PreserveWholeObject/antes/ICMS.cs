using System;
using System.Collections.Generic;
using System.Text;

namespace refatoracao.R46.PreserveWholeObject.antes
{
    class Programa
    {
        void Main()
        {
            var nf = new NotaFiscal(1000, "SP");
            var valorProdutos = nf.ValorProdutos;
            var uf = nf.Uf;
            var valorImposto = ICMS.CalcularValor(valorProdutos, uf);
        }
    }

    class NotaFiscal
    {
        readonly decimal valorProdutos;
        public decimal ValorProdutos => valorProdutos;

        readonly string uf;
        public string Uf => uf;

        //...Uma nota fiscal tem vários outros membros,
        //mas vamos omiti-los para simplificar o código

        public NotaFiscal(decimal valorProdutos, string uf)
        {
            this.valorProdutos = valorProdutos;
            this.uf = uf;
        }
    }

    class ICMS
    {
        private const decimal ICMS_SP_PARA_SP = 0.18m;
        private const decimal ICMS_PADRAO = 0.15m;
        private const string SAO_PAULO = "SP";

        public static decimal CalcularValor(decimal valorProdutos, string uf)
        {
            if (uf == SAO_PAULO)
            {
                return valorProdutos * ICMS_SP_PARA_SP;
            }
            return valorProdutos * ICMS_PADRAO;
        }
    }
}

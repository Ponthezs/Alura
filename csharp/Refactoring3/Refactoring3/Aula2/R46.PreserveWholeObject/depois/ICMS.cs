using System;
using System.Collections.Generic;
using System.Text;

namespace refatoracao.R46.PreserveWholeObject.depois
{
    class Programa
    {
        void Main()
        {
            var nf = new NotaFiscal(1000, "SP");
            var valorImposto = ICMS.CalcularValor(nf);
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

        public static decimal CalcularValor(NotaFiscal nf)
        {
            if (nf.Uf == SAO_PAULO)
            {
                return nf.ValorProdutos * ICMS_SP_PARA_SP;
            }
            return nf.ValorProdutos * ICMS_PADRAO;
        }
    }
}

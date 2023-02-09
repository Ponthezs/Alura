using System;
using System.Collections.Generic;
using System.Text;

namespace refatoracao.R40.RenameMethod.antes
{
    class Programa
    {
        void Main()
        {
            var cliente1 = new PessoaFisica("Walter White", new Credito(10000, 9700));
            var cliente2 = new PessoaJuridica("Los Pollos Hermanos", new Credito(20000, 15000));

            Console.WriteLine($"Crédito disponível - Nome: {cliente1.GetNome()}, " +
                $"Valor: {cliente1.ObterCreditoDisponivel()}");

            Console.WriteLine($"Crédito disponível - Nome: {cliente2.GetRazaoSocial()}, " +
                $"Valor: {cliente2.GetCreditoDisponivel()}");
        }
    }

    class PessoaFisica
    {
        private readonly string nome;

        public string GetNome()
        {
            return nome;
        }

        private readonly Credito credito;
        internal Credito Credito => credito;

        public PessoaFisica(string nome, Credito credito)
        {
            this.nome = nome;
            this.credito = credito;
        }

        public decimal ObterCreditoDisponivel()
        {
            return credito.GetValor();
        }
    }

    class PessoaJuridica
    {
        private readonly string nome;

        public string GetRazaoSocial()
        {
            return nome;
        }

        private readonly Credito credito;
        internal Credito Credito => credito;

        public PessoaJuridica(string nome, Credito credito)
        {
            this.nome = nome;
            this.credito = credito;
        }

        public decimal GetCreditoDisponivel()
        {
            return credito.GetValor();
        }
    }

    class Credito
    {
        readonly decimal creditoTotal;
        public decimal CreditoTotal => creditoTotal;

        readonly decimal creditoUtilizado;
        public decimal CreditoUtilizado => creditoUtilizado;

        public Credito(decimal creditoTotal, decimal creditoUtilizado)
        {
            this.creditoTotal = creditoTotal;
            this.creditoUtilizado = creditoUtilizado;
        }

        public decimal GetValor()
        {
            //Obtém o valor do crédito disponível
            return this.creditoTotal - this.creditoUtilizado;
        }
    }
}

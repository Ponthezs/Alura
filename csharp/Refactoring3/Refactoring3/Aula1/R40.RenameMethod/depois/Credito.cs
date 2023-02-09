using System;
using System.Collections.Generic;
using System.Text;

namespace refatoracao.R40.RenameMethod.depois
{
    class Programa
    {
        void Main()
        {
            var cliente1 = new PessoaFisica("Walter White", new Credito(10000, 9700));
            var cliente2 = new PessoaJuridica("Los Pollos Hermanos", new Credito(20000, 15000));

            IList<IPessoa> clientes = new List<IPessoa>() { cliente1, cliente2 };

            foreach (var cliente in clientes)
            {
                Console.WriteLine($"Crédito disponível - Nome: {cliente.GetNome()}, " +
                    $"Valor: {cliente.GetCreditoDisponivel()}");
            }
        }
    }

    class PessoaFisica : IPessoa
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

        public decimal GetCreditoDisponivel()
        {
            return credito.GetCreditoDisponivel();
        }
    }

    class PessoaJuridica : IPessoa
    {
        private readonly string nome;

        public string GetNome()
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
            return credito.GetCreditoDisponivel();
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

        public decimal GetCreditoDisponivel()
        {
            return this.creditoTotal - this.creditoUtilizado;
        }
    }
}

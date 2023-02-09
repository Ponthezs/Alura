using System;
using System.Collections.Generic;
using System.Text;

namespace refatoracao.Parte3.Aula6.R63.ReplaceInheritanceWithDelegation.depois
{
    class Programa
    {
        void Teste()
        {
            var imovel =
                new Imovel("Rua dos Bobos, No. 0", 100000,
                new Proprietario("Vinicius de Moraes", "123456789-00"));
        }
    }

    class Proprietario
    {
        private readonly string nome;
        private readonly string cpf;

        public string Nome { get => nome; }
        public string CPF { get => cpf; }

        private readonly IList<Imovel> imoveis = new List<Imovel>();
        internal IList<Imovel> Imoveis => imoveis;

        private int numeroDeProcessos;
        public int NumeroDeProcessos { get => numeroDeProcessos; set => numeroDeProcessos = value; }

        public Proprietario(string nome, string cpf)
        {
            this.nome = nome;
            this.cpf = cpf;
        }
    }

    class Imovel
    {
        private Proprietario proprietario;
        internal Proprietario Proprietario { get => proprietario; set => proprietario = value; }

        private readonly String endereco;
        private decimal valor;

        public Imovel(string endereco, decimal valor, Proprietario proprietario)
        {
            this.proprietario = proprietario;
            this.endereco = endereco;
            this.valor = valor;
        }

    }
}

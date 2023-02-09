using System;
using System.Collections.Generic;
using System.Text;

namespace refatoracao.Parte3.Aula6.R63.ReplaceInheritanceWithDelegation.antes
{
    class Programa
    {
        void Teste()
        {
            var imovel = 
                new Imovel("Rua dos Bobos, No. 0", 100000, 
                            "Vinicius de Moraes", "123456789-00");
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

    class Imovel : Proprietario
    {
        private readonly String endereco;
        private decimal valor;

        public Imovel(string endereco, decimal valor, string nomeProprietario, string cpfProprietario) 
            : base(nomeProprietario, cpfProprietario)
        {
            this.endereco = endereco;
            this.valor = valor;
        }
    }
}

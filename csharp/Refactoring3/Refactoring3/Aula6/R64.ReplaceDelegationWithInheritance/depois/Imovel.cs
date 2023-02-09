using System;
using System.Collections.Generic;
using System.Text;

namespace refatoracao.Parte3.Aula6.R64.ReplaceDelegationWithInheritance.depois
{
    class Programa
    {
        void Teste()
        {
            var imovel =
                new Apartamento("Rua dos Bobos, No. 0", 100000, 200);
        }
    }

    class Imovel
    {
        private readonly String endereco;
        private decimal valorImovel;

        public string Endereco => endereco;
        public decimal ValorImovel { get => valorImovel; set => valorImovel = value; }

        public Imovel(string endereco, decimal valorImovel)
        {
            this.endereco = endereco;
            this.valorImovel = valorImovel;
        }
    }

    class Apartamento
    {
        private readonly Imovel imovel;
        private decimal valorCondominio;

        public string Endereco => imovel.Endereco;
        public decimal ValorImovel { get => imovel.ValorImovel; set => imovel.ValorImovel = value; }

        public Apartamento(string endereco, decimal valorImovel, decimal valorCondominio)
        {
            this.imovel = new Imovel(endereco, valorImovel);
            this.valorCondominio = valorCondominio;
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace refatoracao.Parte3.Aula5.R59.ExtractSuperclass.depois
{
    class Programa
    {
        void Teste()
        {
            var item1 = new Item(new Produto("Escova dental Dentinho Feliz", 15), 15, 3);
            var item2 = new Item(new Produto("Sabonete Flor da Manhã", 3), 3, 10);
            var item3 = new Item(new Produto("Desodorante Man Power", 20), 20, 2);

            string nomeCliente = "João Snow";
            string enderecoEntrega = "Castelo Estarque, Torre 2 - Vila do Norte";
            var pedido = new Pedido(nomeCliente, enderecoEntrega);
            var notaFiscal = new NotaFiscal(pedido);
        }
    }

    class Produto
    {
        readonly string nome;
        readonly decimal precoUnitario;
        public string Nome => nome;
        public decimal PrecoUnitario => precoUnitario;

        public Produto(string nome, decimal precoUnitario)
        {
            this.nome = nome;
            this.precoUnitario = precoUnitario;
        }
    }

    class Item
    {
        const decimal TAXA_IMPOSTO = 0.3m;

        readonly Produto produto;
        readonly decimal precoUnitario;
        readonly int quantidade;
        public decimal TotalDeImpostos => (quantidade * precoUnitario) * (1.0m + TAXA_IMPOSTO);

        public decimal PrecoUnitario => precoUnitario;
        public int Quantidade => quantidade;
        internal Produto Produto => produto;

        public decimal Total => quantidade * precoUnitario;

        public Item(Produto produto, decimal precoUnitario, int quantidade)
        {
            this.produto = produto;
            this.precoUnitario = precoUnitario;
            this.quantidade = quantidade;
        }
    }

    abstract class BasePedido
    {
        protected string nomeCliente;
        public string NomeCliente => nomeCliente;

        protected string enderecoEntrega;
        public string EnderecoEntrega => enderecoEntrega;

        protected readonly List<Item> itens = new List<Item>();
        internal IReadOnlyCollection<Item> Itens => new ReadOnlyCollection<Item>(itens);

        public decimal ValorDosItens()
        {
            return itens.Sum(i => i.Total);
        }
    }

    class Pedido : BasePedido
    {
        void Add(Item item)
        {
            itens.Add(item);
        }

        void Remove(Item item)
        {
            itens.Add(item);
        }

        public Pedido(string nomeCliente, string enderecoEntrega)
        {
            this.nomeCliente = nomeCliente;
            this.enderecoEntrega = enderecoEntrega;
        }
    }

    class NotaFiscal : BasePedido
    {
        public NotaFiscal(Pedido pedido)
        {
            this.itens.AddRange(pedido.Itens);
        }

        public decimal ValorDosImpostos()
        {
            return itens.Sum(i => i.TotalDeImpostos);
        }

        public decimal ValorFatura()
        {
            return ValorDosItens() + ValorDosImpostos();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Text;

namespace refatoracao.R62.FormTemplateMethod.antes
{
    class Program
    {
        void Main()
        {
            var cliente = new Cliente();

            //....
            //....
            //....

            var resumo = new Resumo(cliente).GetResumo();
            var resumoHTML = new ResumoHTML(cliente).GetResumo();
        }
    }

    class Cliente
    {
        private IList<Locacao> locacoes;
        public IList<Locacao> Locacoes
        {
            get { return locacoes; }
            set { locacoes = value; }
        }

        private double valorTotal;
        public double ValorTotal
        {
            get { return valorTotal; }
            set { valorTotal = value; }
        }

        private double pontosDeFidelidade;
        public double PontosDeFidelidade
        {
            get { return pontosDeFidelidade; }
            set { pontosDeFidelidade = value; }
        }

        private string nome;
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
    }

    internal class ResumoHTML
    {
        private Cliente cliente;

        public ResumoHTML(Cliente cliente)
        {
            this.cliente = cliente;
        }

        internal string GetResumo()
        {
            var resultado = new StringBuilder();
            resultado.AppendLine("<h1>Locações de <em>" + cliente.Nome + "</em></h1>");
            foreach (var locacao in cliente.Locacoes)
            {
                resultado.AppendLine(locacao.Filme.Titulo + "<br/>");
            }
            resultado.AppendLine("<p> Você deve: <em>R$ " + cliente.ValorTotal.ToString() + "</em></p>");
            resultado.AppendLine("Você ganhou: " + cliente.PontosDeFidelidade.ToString() + "</em> pontos.");
            return resultado.ToString();
        }
    }

    internal class Resumo
    {
        private Cliente cliente;

        public Resumo(Cliente cliente)
        {
            this.cliente = cliente;
        }

        internal string GetResumo()
        {
            var resultado = new StringBuilder();
            resultado.AppendLine("Resumo de locações de " + cliente.Nome);
            foreach (var locacao in cliente.Locacoes)
            {
                resultado.AppendLine("\t" + locacao.Filme.Titulo);
            }
            resultado.AppendLine("Total devido: " + cliente.ValorTotal.ToString());
            resultado.AppendLine($"Você ganhou: {cliente.PontosDeFidelidade.ToString()} pontos");
            return resultado.ToString();
        }
    }

    class Locacao
    {
        private Filme filme;

        public Filme Filme
        {
            get { return filme; }
            set { filme = value; }
        }
    }

    class Filme
    {
        private string titulo;

        public string Titulo
        {
            get { return titulo; }
            set { titulo = value; }
        }
    }
}

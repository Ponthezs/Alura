using System;
using System.Collections.Generic;
using System.Text;

namespace refatoracao.R57.PushDownField.depois
{
    class Programa
    {
        void Main()
        {
            Funcionario engenheiro = Funcionario.CriarFuncionario(Funcionario.TipoFuncionario.Engenheiro, "José da Silva", 1000);
            Funcionario vendedor = Funcionario.CriarFuncionario(Funcionario.TipoFuncionario.Vendedor, "Maria Bonita", 2000);
            Funcionario gerente = Funcionario.CriarFuncionario(Funcionario.TipoFuncionario.Gerente, "João das Neves", 3000);

            var valorFolhaDePagamento =
                engenheiro.Salario
                + vendedor.Salario
                + gerente.Salario;
        }
    }

    class Funcionario
    {
        public enum TipoFuncionario
        {
            Engenheiro = 0,
            Vendedor = 1,
            Gerente = 2
        }

        protected TipoFuncionario tipo;
        public TipoFuncionario Tipo { get; }

        protected string nome;
        public string Nome => nome;

        protected decimal salario;
        public decimal Salario => salario;

        protected Funcionario(string nome, decimal salario)
        {
            this.nome = nome;
            this.salario = salario;
        }

        public static Funcionario CriarFuncionario(TipoFuncionario tipo, string nome, decimal salario)
        {
            switch (tipo)
            {
                case TipoFuncionario.Engenheiro:
                    return new Engenheiro(nome, salario);
                case TipoFuncionario.Vendedor:
                    return new Vendedor(nome, salario);
                case TipoFuncionario.Gerente:
                    return new Gerente(nome, salario);
                default:
                    throw new ArgumentException("Tipo de funcionário inválido");
            }
        }
    }

    class Engenheiro : Funcionario
    {
        public Engenheiro(string nome, decimal salario) : base(nome, salario)
        {
            this.tipo = TipoFuncionario.Engenheiro;
        }
    }

    class Vendedor : Funcionario
    {
        private decimal comissao;
        public decimal Comissao => comissao;

        public Vendedor(string nome, decimal salario) : base(nome, salario)
        {
            this.tipo = TipoFuncionario.Vendedor;
        }

        public void DefinirComissao(decimal comissao)
        {
            if (comissao < 0)
            {
                throw new ArgumentException("Comissão não pode ser negativa");
            }

            if (comissao > .25m)
            {
                throw new ArgumentException("Comissão não pode exceder 25%");
            }

            this.comissao = comissao;
        }
    }

    class Gerente : Funcionario
    {
        private decimal bonus;
        public decimal Bonus => bonus;

        public Gerente(string nome, decimal salario) : base(nome, salario)
        {
            this.tipo = TipoFuncionario.Gerente;
        }

        public void DefinirBonus(decimal bonus)
        {
            if (bonus < 0)
            {
                throw new ArgumentException("Bônus não pode ser negativo");
            }

            if (bonus > salario)
            {
                throw new ArgumentException("Bônus não pode ser maior que o salário");
            }

            this.bonus = bonus;
        }
    }

}

using System;
using System.Collections.Generic;
using System.Text;

namespace refatoracao.R58.ExtractSubclass.depois
{
    class Programa
    {
        void Main()
        {
            Funcionario joao = new Funcionario(50);
            ItemDeServico s1 = new MaoDeObra(5, joao);
            ItemDeServico s2 = new MateriaPrima(15, 10);
            decimal totalDoServico = s1.GetPrecoTotal() + s2.GetPrecoTotal();
        }
    }

    abstract class ItemDeServico
    {
        private int quantidade;

        public ItemDeServico(int quantidade)
        {
            this.quantidade = quantidade;
        }
        public decimal GetPrecoTotal()
        {
            return quantidade * GetPrecoUnitario();
        }
        public int GetQuantidade()
        {
            return quantidade;
        }
        public abstract decimal GetPrecoUnitario();
    }

    class MaoDeObra : ItemDeServico
    {
        private Funcionario funcionario;

        public MaoDeObra(int quantidade, Funcionario funcionario)
            : base(quantidade)
        {
            this.funcionario = funcionario;
        }

        public override decimal GetPrecoUnitario()
        {
            return funcionario.GetCusto();
        }

        public Funcionario GetFuncionario()
        {
            return funcionario;
        }

    }

    class MateriaPrima : ItemDeServico
    {
        private decimal precoUnitario;

        public MateriaPrima(int quantidade, decimal precoUnitario)
            : base(quantidade)
        {
            this.precoUnitario = precoUnitario;
        }

        public override decimal GetPrecoUnitario()
        {
            return precoUnitario;
        }
    }

    class Funcionario
    {
        private decimal custo;
        public Funcionario(decimal custo)
        {
            this.custo = custo;
        }
        public decimal GetCusto()
        {
            return custo;
        }
    }
}

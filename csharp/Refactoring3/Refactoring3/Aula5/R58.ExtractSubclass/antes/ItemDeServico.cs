using System;
using System.Collections.Generic;
using System.Text;

namespace refatoracao.R58.ExtractSubclass.antes
{
    class Programa
    {
        void Main()
        {
            Funcionario joao = new Funcionario(50);
            ItemDeServico s1 = new ItemDeServico(5, 0, true, joao);
            ItemDeServico s2 = new ItemDeServico(15, 10, false, null);
            decimal totalDoServico = s1.GetPrecoTotal() + s2.GetPrecoTotal();
        }
    }

    class ItemDeServico
    {
        private int quantidade;
        private decimal precoUnitario;
        private Funcionario funcionario;
        private bool ehTrabalho;

        public ItemDeServico(int quantidade, decimal precoUnitario, bool ehMaoDeObra, Funcionario funcionario)
        {
            this.quantidade = quantidade;
            this.precoUnitario = precoUnitario;
            this.ehTrabalho = ehMaoDeObra;
            this.funcionario = funcionario;
        }
        public decimal GetPrecoTotal()
        {
            return quantidade * GetPrecoUnitario();
        }
        public int GetQuantidade()
        {
            return quantidade;
        }
        public decimal GetPrecoUnitario()
        {
            return (ehTrabalho) ? funcionario.GetCusto() : precoUnitario;
        }
        public Funcionario GetFuncionario()
        {
            return funcionario;
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

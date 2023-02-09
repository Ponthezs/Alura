using System;
using System.Collections.Generic;
using System.Text;

namespace refatoracao.R44.ParameterizeMethod.depois
{
    class Program
    {
        void Main()
        {
            var funcionario1 = new Funcionario("Tony Estarque", 10000);
            var funcionario2 = new Funcionario("Pedro Parques", 2000);

            funcionario1.DarAumento(5);
            funcionario2.DarAumento(10);
        }
    }

    class Funcionario
    {
        readonly string nome;
        public string Nome => nome;

        decimal salario;
        public decimal Salario => salario;

        public Funcionario(string nome, decimal salario)
        {
            this.nome = nome;
            this.salario = salario;
        }

        public void DarAumento(decimal aumento)
        {
            salario *= 1.0m + (aumento /100.0m);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace refatoracao.Parte3.Aula2.R45.ReplaceParameterWithExplicitMethods.antes
{
    class Program
    {
        void Main()
        {
            var funcionario1 = new Funcionario("Tony Estarque", 10000);
            var funcionario2 = new Funcionario("Pedro Parques", 2000);

            funcionario1.DarAumento(Funcionario.TIPO_AUMENTO_FIXO, 3000);
            funcionario2.DarAumento(Funcionario.TIPO_AUMENTO_PORCENTUAL, 10);
        }
    }

    class Funcionario
    {
        public const int TIPO_AUMENTO_FIXO = 0;
        public const int TIPO_AUMENTO_PORCENTUAL = 1;

        readonly string nome;
        public string Nome => nome;

        decimal salario;
        public decimal Salario => salario;

        public Funcionario(string nome, decimal salario)
        {
            this.nome = nome;
            this.salario = salario;
        }

        public void DarAumento(int tipo, decimal aumento)
        {
            switch (tipo)
            {
                case TIPO_AUMENTO_FIXO:
                    salario += aumento;
                    break;
                case TIPO_AUMENTO_PORCENTUAL:
                    salario *= (1.0m + aumento / 100.0m);
                    break;
                default:
                    throw new ArgumentException("Tipo de aumento inválido");
            }
        }
    }
}

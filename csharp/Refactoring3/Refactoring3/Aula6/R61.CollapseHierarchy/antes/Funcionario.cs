using System;
using System.Collections.Generic;
using System.Text;

namespace refatoracao.R61.CollapseHierarchy.antes
{
    class Programa
    {
        void Main()
        {
            var empregado = new Empregado("Walter White", "555-12345", "666-65432");
        }
    }

    abstract class Funcionario
    {
        public string Nome { get; set; }
        public string TelefoneFixo { get; set; }
        public string Celular { get; set; }

        public Funcionario(string nome, string telefoneFixo, string celular)
        {
            Nome = nome;
            TelefoneFixo = telefoneFixo;
            Celular = celular;
        }
    }

    class Empregado : Funcionario
    {
        public string CodigoFuncional { get; set; }

        public Empregado(string nome, string telefoneFixo, string celular) : base(nome, telefoneFixo, celular)
        {
        }
    }
}

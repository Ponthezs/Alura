using System;
using System.Collections.Generic;
using System.Text;

namespace refatoracao.R51.ReplaceConstructorWithFactoryMethod.depois
{
    class Programa
    {
        void Main()
        {
            Funcionario funcionario = Funcionario.CriarEngenheiro("José da Silva", 1000);
        }
    }

    enum TipoFuncionario
    {
        Vendedor = 0,
        Gerente = 1,
        Engenheiro = 2
    }

    class Funcionario
    {

        readonly TipoFuncionario tipo;
        public TipoFuncionario Tipo => tipo;

        readonly string nome;
        public string Nome => nome;

        readonly decimal salario;
        public decimal Salario => salario;

        private Funcionario(TipoFuncionario tipo, string nome, decimal salario)
        {
            this.tipo = tipo;
            this.nome = nome;
            this.salario = salario;

            LancarRegistrosNoBancoDeDados();
            GerarDocumentosFiscais();
            EnviarEmailDeBoasVindas();
        }

        public static Funcionario CriarVendedor(string nome, decimal salario)
        {
            var funcionario = new Funcionario(TipoFuncionario.Vendedor, nome, salario);
            funcionario.GerarRegistroDeComissao();
            return funcionario;
        }

        public static Funcionario CriarGerente(string nome, decimal salario)
        {
            var funcionario = new Funcionario(TipoFuncionario.Gerente, nome, salario);
            funcionario.GerarRegistroDeComissao();
            return funcionario;
        }

        public static Funcionario CriarEngenheiro(string nome, decimal salario)
        {
            return new Funcionario(TipoFuncionario.Engenheiro, nome, salario);
        }

        private void GerarRegistroDeBonus()
        {
            //método criado apenas para ilustração
        }

        private void GerarRegistroDeComissao()
        {
            //método criado apenas para ilustração
        }

        private void EnviarEmailDeBoasVindas()
        {
            //método criado apenas para ilustração
        }

        private void GerarDocumentosFiscais()
        {
            //método criado apenas para ilustração
        }

        private void LancarRegistrosNoBancoDeDados()
        {
            //método criado apenas para ilustração
        }
    }
}

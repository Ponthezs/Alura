using System;
using System.Collections.Generic;
using System.Text;

namespace refatoracao.R51.ReplaceConstructorWithFactoryMethod.antes
{
    class Programa
    {
        void Main()
        {
            Funcionario funcionario = new Funcionario(TipoFuncionario.Engenheiro, 
                "José da Silva", 1000);
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

        public Funcionario(TipoFuncionario tipo, string nome, decimal salario)
        {
            this.tipo = tipo;
            this.nome = nome;
            this.salario = salario;

            LancarRegistrosNoBancoDeDados();
            GerarDocumentosFiscais();
            EnviarEmailDeBoasVindas();

            switch (tipo)
            {
                case TipoFuncionario.Vendedor:
                    GerarRegistroDeComissao();
                    break;
                case TipoFuncionario.Gerente:
                    GerarRegistroDeBonus();
                    break;
                default:
                    break;
            }
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

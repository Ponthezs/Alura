using System;
using System.Collections.Generic;
using System.Text;

namespace refatoracao.R55.PullUpConstructorBody.antes
{
    class Programa
    {
        void Main()
        {
            var cliente1 = new PessoaJuridica("Alura Cursos Online S/A", "Rua XPTO", "123", "12345678/0001-22");
            var cliente2 = new PessoaFisica("João Snow", "Rua das Flores", "987", "123456789-12");
            var clientes = new List<Cliente> { cliente1, cliente2 };

            Console.WriteLine("Clientes");
            Console.WriteLine("========");
            foreach (var cliente in clientes)
            {
                Console.WriteLine($"{cliente.Nome}");
                Console.WriteLine($"{cliente.GetEndereco()}");
                Console.WriteLine("========");
            }
        }
    }

    abstract class Cliente
    {
        protected string nome;
        public string Nome => nome;

        protected string logradouro;
        protected string numero;

        public string GetEndereco()
        {
            return $"{logradouro} {numero}";
        }
    }

    class PessoaFisica : Cliente
    {
        private readonly string cpf;
        public string Cpf => cpf;

        public PessoaFisica(string nome, string logradouro, string numero, string cpf)
        {
            this.nome = nome;
            this.logradouro = logradouro;
            this.numero = numero;
            this.cpf = cpf;
        }
    }

    class PessoaJuridica : Cliente
    {
        private readonly string cnpj;
        public string Cnpj => cnpj;

        public PessoaJuridica(string nome, string logradouro, string numero, string cnpj)
        {
            this.nome = nome;
            this.logradouro = logradouro;
            this.numero = numero;
            this.cnpj = cnpj;
        }
    }

}

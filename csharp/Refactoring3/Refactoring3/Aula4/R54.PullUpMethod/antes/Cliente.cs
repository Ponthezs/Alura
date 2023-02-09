using System;
using System.Collections.Generic;
using System.Text;

namespace refatoracao.R54.PullUpMethod.antes
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

            Console.WriteLine($"{cliente1.Nome}");
            Console.WriteLine($"{cliente1.GetEndereco()}");
            Console.WriteLine("========");

            Console.WriteLine($"{cliente2.Nome}");
            Console.WriteLine($"{cliente2.GetEndereco()}");
        }
    }

    abstract class Cliente
    {
        private readonly string nome;
        public string Nome => nome;

        protected readonly string logradouro;
        protected readonly string numero;

        public Cliente(string nome, string logradouro, string numero)
        {
            this.nome = nome;
            this.logradouro = logradouro;
            this.numero = numero;
        }
    }

    class PessoaFisica : Cliente
    {
        private readonly string cpf;
        public string Cpf => cpf;

        public PessoaFisica(string nome, string logradouro, string numero, string cpf) 
            : base(nome, logradouro, numero)
        {
            this.cpf = cpf;
        }

        public string GetEndereco()
        {
            return $"{logradouro} {numero}";
        }
    }

    class PessoaJuridica : Cliente
    {
        private readonly string cnpj;
        public string Cnpj => cnpj;

        public PessoaJuridica(string nome, string logradouro, string numero, string cnpj) 
            : base(nome, logradouro, numero)
        {
            this.cnpj = cnpj;
        }

        public string GetEndereco()
        {
            return $"{logradouro} {numero}";
        }
    }

}

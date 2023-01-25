using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bankADM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Funcionario pedro = new Funcionario(0);
            pedro.Nome = "Pedro malazartes";
            pedro.Cpf = "123456789";
            pedro.Salario = 2000;

            Console.WriteLine(pedro.Nome);
            Console.WriteLine(pedro.GetBonificacao());

            Diretor roberta = new Diretor();
            roberta.Nome = "Roberta Silva";
            roberta.Cpf = "987654321";
            roberta.Salario = 5000;

            Console.WriteLine(roberta.Nome);
            Console.WriteLine(roberta.GetBonificacao());

            GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();
            gerenciador.Registrar(pedro);
            gerenciador.Registrar(roberta);

            Console.WriteLine("Total de bonificações: " + gerenciador.TotalDeBonificacao);

            Console.ReadLine();

        }
    }
}

using bankADM.Funcionarios;
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
            #region
            //Funcionario pedro = new Funcionario("123456789", 2000);
            //pedro.Nome = "Pedro malazartes";

            //Console.WriteLine(pedro.Nome);
            //Console.WriteLine(pedro.GetBonificacao());

            //Diretor roberta = new Diretor("987654321");
            //roberta.Nome = "Roberta Silva";

            //Console.WriteLine(roberta.Nome);
            //Console.WriteLine(roberta.GetBonificacao());

            //GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();
            //gerenciador.Registrar(pedro);
            //gerenciador.Registrar(roberta);

            //Console.WriteLine("Total de bonificações: " + gerenciador.TotalDeBonificacao);
            //Console.WriteLine("Total de funcionários: " + Funcionario.TotalDeFuncionarios);

            //pedro.AumentarSalario();
            //roberta.AumentarSalario();

            //Console.WriteLine("Novo salário do Pedro: " + pedro.Salario);
            //Console.WriteLine("Novo salário da Roberta " + roberta.Salario);
            #endregion

            CalcularBonificacao();

            void CalcularBonificacao()
            {
                GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();

                Designer ulisses = new Designer("123456");
                ulisses.Nome = "Ulisses Souza";

                Diretor paula = new Diretor("987456");
                paula.Nome = "Paula Souza";

                Auxiliar igor = new Auxiliar("74581");
                igor.Nome = "Igor Dias";

                GerenteDeContas camila = new GerenteDeContas("852963");
                camila.Nome = "Camila Oliveira";

                gerenciador.Registrar(camila);
                gerenciador.Registrar(igor);
                gerenciador.Registrar(paula);
                gerenciador.Registrar(ulisses);

                Console.WriteLine("Total de Bonificação = " + gerenciador.TotalDeBonificacao);
            }



            Console.ReadLine();

        }
    }
}

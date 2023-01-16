using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A31OPoderDosSets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //SETS = CONJUNTOS

            //DUAS propriedades do set
            //1. não permite duplicidade
            //2. os elementos não são mantidos em ordem específica

            //Desclarando set de alunos

            ISet<string> alunos = new HashSet<string>();

            //Adicionando: vanessa, ana, rafael
            alunos.Add("Vanessa Tonini");
            alunos.Add("Ana Losnak");
            alunos.Add("Rafael Nercessian");

            //Imprimindo
            Console.WriteLine(alunos);
            Console.WriteLine(string.Join(", ", alunos));

            //Qual a diferença pára umna lista?? vamos ver agora

            //Adicionando: priscila, rollo, fabio
            alunos.Add("Priscila Stuani");
            alunos.Add("Rollo Stome");
            alunos.Add("Fabio Gushiken");
            //Imprimindo
            Console.WriteLine(string.Join(", ", alunos));
            //e a ordem??

            //Removendo ana, adicionando marcelo
            alunos.Remove("Ana Losnak");
            alunos.Add("Marcelo Gutorhasi");
            //Imprimindo de novo
            Console.WriteLine(string.Join(", ", alunos));

            //Adicionando Gushiken de novo
            alunos.Add("Fabio Gushiken");
            //Imprimindo novamente
            Console.WriteLine(string.Join(", ", alunos));

            //Qual a vantagem do set sobre a lista? look-up!

            //Desempenho HashSet x List : escalabilidade X memória

            ///Mudar iset para icollection p/deixar mais flexível!

            //Ordenando: Sort 
            //alunos.Sort();

            //copiando: alunosEmLista
            List<string> alunosEmLista = new List<string>(alunos);

            //Ordenando copia
            alunosEmLista.Sort();
            //Imprimindo a copia
            Console.WriteLine(string.Join(", ", alunosEmLista));

            Console.ReadLine();



        }
    }
}

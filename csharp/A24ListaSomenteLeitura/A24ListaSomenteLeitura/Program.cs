using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A24ListaSomenteLeitura
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Curso csharpcolecoes = new Curso("C# Collections", "Marcelo Oliveira");
            csharpcolecoes.Adiciona(new Aula("Trabalhando com Listas", 21));
            Imprimir(csharpcolecoes.Aulas);

            //Adicionar 2 aulas
            csharpcolecoes.Adiciona(new Aula ("Criando uma Aula", 20));
            csharpcolecoes.Adiciona(new Aula("Modelando Coleções", 19));

            //Imprimir
            Imprimir(csharpcolecoes.Aulas);

            //Ordenar a lista de aulas
            //csharpcolecoes.Aulas.Sort();

            //Copiar a lista para outra lista
            List<Aula> aulasCopiadas = new List<Aula>(csharpcolecoes.Aulas);

            //Ordenar a cópia
            aulasCopiadas.Sort();
            Imprimir(aulasCopiadas);

            //Totaliza o tempo de curso
            Console.WriteLine(csharpcolecoes.TempoTotal);

            Console.WriteLine(csharpcolecoes);

            //Imprimir detalhes do curso


        }

        private static void Imprimir(IList<Aula> aulas)
        {
            Console.Clear();
            foreach (var aula in aulas)
            {
                Console.WriteLine(aula);
            }
        }

    }
}

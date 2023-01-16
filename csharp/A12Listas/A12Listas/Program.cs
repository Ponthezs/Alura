using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A12Listas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string aulaIntro = "Introdução às Coleções";
            string aulaModelando = "Modelando a Classe Aula";
            string aulaSets = "Trabalhando com Conjuntos";

            //List<string> aulas = new List<string>
            //{
            // aulaIntro,
            // aulaModelando,
            //aulaSets
            //};
          

            List<string> aulas = new List<string>();
            aulas.Add(aulaIntro);
            aulas.Add(aulaModelando);
            aulas.Add(aulaSets);


            Imprimir(aulas);
             
            Console.WriteLine("A primeira aula é " + aulas[0]);
            Console.WriteLine("A primeira aula é " + aulas.First()); // Maneira diferende de representar qual e a primeira aula

            Console.WriteLine("A última aula é" + aulas[aulas.Count - 1]);
            Console.WriteLine("A última aula é" + aulas.Last()); // Maneira diferende de representar qual e última aula

            aulas[0] = "Trabalhando com Listas";
            Imprimir(aulas);

            Console.WriteLine("A primeira aula 'Trabalhando' é: "
                + aulas.First(aula => aula.Contains("Trabalhando")));

            Console.WriteLine("A última aula 'Trabalhando' é: "
                + aulas.Last(aula => aula.Contains("Trabalhando")));

            Console.WriteLine("A primeira aula 'Conclusão' é: "
                + aulas.FirstOrDefault(aula => aula.Contains("Conclusão")));

            aulas.Reverse();
            Imprimir(aulas);

            //aulas.Reverse();  
            //Imprimir(aulas);   Caso queira resultado inicial 

            // remover o último elemento
            aulas.RemoveAt(aulas.Count - 1);

            aulas.Add("Conclusão");
            Imprimir(aulas);

            aulas.Sort();
            Imprimir(aulas);

            List<string> copia = aulas.GetRange(aulas.Count - 2, 2);
            Imprimir(copia);

            List<string> clone = new List<string>(aulas);
            Imprimir(clone);

            clone.RemoveRange(aulas.Count -2, 2);
            Imprimir(clone);

            Console.ReadLine();

        }

        private static void Imprimir(List<string> aulas)
        {
            //foreach ( var aula in aulas)
            //{
            //    Console.WriteLine(aula);
            //}

            //for (int i = 0; i < aulas.Count; i++)
            //{
            //    Console.WriteLine(aulas[i]);
            //}
            aulas.ForEach(aula =>
            {
                Console.WriteLine(aula);
            });

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A52Stack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var navegador = new Navegador();

            navegador.NavegarPara("Google.com");
            navegador.NavegarPara("Caelum.com.br");
            navegador.NavegarPara("Alura.com.br");
           

            navegador.PgAnterior();
            navegador.PgAnterior();


            navegador.Proximo();

        }

        private class Navegador
        {
            private readonly Stack<string> historicoAnterior = new Stack<string>();
            private readonly Stack<string> historicoProximo = new Stack<string>();

            private string atual = "Vazia";
            public Navegador()
            {
                Console.WriteLine("Página atual: " + atual);
            }

            internal void NavegarPara(string url)
            {
                historicoAnterior.Push(atual);
                atual = url;
                Console.WriteLine("Página atual: " + atual);
            }

            internal void PgAnterior()
            {
                if (historicoAnterior.Any())
                {
                    historicoProximo.Push(atual);
                atual = historicoAnterior.Pop();
                Console.WriteLine("Página atual: " + atual);

                }
                Console.ReadLine();
            }

            internal void Proximo()
            {
                historicoAnterior.Push(atual);
                atual = historicoProximo.Pop();
                Console.WriteLine("Página atual: " + atual);
            }
        }
    }
}

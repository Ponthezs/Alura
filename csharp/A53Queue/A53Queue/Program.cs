using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A53Queue
{
    internal class Program
    {
        static Queue<string> Pedagio = new Queue<string>();
        static void Main(string[] args)
        {
            //entrou: van
            //string veiculo = "van";
            Enfileirado("van");
            //entrou: kombi
            Enfileirado("Kombi");
            //entrou: guincho
            Enfileirado("Guincho");
            //entrou: Pickup
            Enfileirado("Pickup");

            //carro liberado
            Desenfilerar();
            //carro liverado
            Desenfilerar();

        }

        private static void Desenfilerar()
        {
            string veiculo = Pedagio.Dequeue();
            Console.WriteLine($"Saiu da fila: {veiculo}");
            ImprimirFila();
        }

        private static void Enfileirado(string veiculo)
        {
            Console.WriteLine($"Entrou na fila: {veiculo}");
            Pedagio.Enqueue(veiculo);
            ImprimirFila();
        }

        private static void ImprimirFila()
        {
            Console.WriteLine("FILA:");
            foreach (var v in Pedagio)
            {
                Console.WriteLine(v);
                
            }
        }
    }
}

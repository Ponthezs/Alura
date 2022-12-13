using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Passagem_de_parametros
{
    internal class Program
    {
        public struct Valor
        {
            public int x2;
        }

        public class Referencia
        {
            public int x1;
        }

        class Programa
        {
            // Objetos são passados por referência.
            public static void Alterar(Referencia r)
            {
                r.x1 = 10;
                Console.WriteLine("Valor de x1 dentro do método Alterar: " + r.x1);
            }

            // Estruturas são passadas por valor
            public static void AlteraLocal(Valor v)
            {
                v.x2 = 10;
                Console.WriteLine("\nValor de x2 dentro do método AlteraLocal: " + v.x2);
            }

            // Forçando a passagem por referência. A variável passada precisa ser iniciada.
            public static void ReferenciaForcada(ref Valor v)
            {
                v.x2 = 20;
                Console.WriteLine("\nValor de x2 dentro do método ReferenciaForcada: " + v.x2);
            }

            // Forçando a passagem por referência. Nesse caso a variável passada não precisa ser iniciada.
            public static void AlterarSaida(out int y)
            {
                y = 20;
                Console.WriteLine("\nValor de z dentro do método AlterarSaida: " + y);
            }

            public static void Main()
            {
                Valor v1 = new Valor();
                Referencia r1 = new Referencia();
                int z;

                v1.x2 = 0;
                r1.x1 = 0;

                Alterar(r1);
                Console.WriteLine("Valor de x1 após a execução do método Alterar: " + r1.x1);

                AlteraLocal(v1);
                Console.WriteLine("Valor de x2 após a execução do método: AlteraLocal: " + v1.x2);

                ReferenciaForcada(ref v1);
                Console.WriteLine("Valor de x2 após a execução do método: ReferenciaForcada: " + v1.x2);

                AlterarSaida(out z);
                Console.WriteLine("Valor de z após a execução do método: AlterarSaida: " + z);
            }
        }
    }

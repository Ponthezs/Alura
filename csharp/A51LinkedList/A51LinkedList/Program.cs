using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A51LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Imagine uma lista de frutas
            List<string> frutas = new List<string>
            {
                "Abacate", "Banana", "Caqui", "Damasco", "Figo"
            };
            //Vamos imprimir essa lista
            foreach (var fruta in frutas)
            {
                Console.WriteLine(fruta);
            }
            //Adicionar um elemento ao final de uma lis5ta é rápido

            //Pórem inserir no meio da lista exige mais esforço computacional

            //porque os elementos têm que ser deslocados para darem
            //espaço ao novo elemento!
            //E se tivermos que remover esse elemento, os elementos
            //seguintes precisam ser deslocados de novo!

            //Quanto maior a lista, mais ineficiente é a inserção
            //e remoção de elementos no meio dela!
            //Que coleção é apropriada para inserção/remoção rápida?

            //Apresentando LISTA LIGADA (LINKED LIST):
            //--Elementos não precisam estar em sequência em memória
            //--Cada elemento sabe quem é o anterior e o próximo
            //--Cada elemento é um "nó" que contém um valor

            //Como a ordem é mantida? Usando ponteiros

            //Instanciando uma nova lista ligada: dias da semana
            LinkedList<string> dias = new LinkedList<string>();
            //Adicionando um dia qualquer: "Quarta"
            var d4 = dias.AddFirst("Quarta");
            // "Quarta" é o primeiro elemento da lista ligada!
            //Cada elemento é um nó :LinkedListNode<T>

            //MAs e o valor "Quarta"? está na propriedade d4.value
            Console.WriteLine("da.Value: " + d4.Value);
            //E para adicionar mais intens? LinkedList não possui Add!
            //Podemos adicionar de 4 formas:
            // 1. Como primeiro nó
            // 2. Como último nó
            // 3. Antes de um nó conhecido
            // 4. Depois de um nó conhecido

            //Vamos adicionar segunda, antes de quarta:
            var d2 = dias.AddBefore(d4, "Segunda");

            //Agora d2 e d4 estão ligados!
            // - d2.Next é igual a d4
            // - d4.Previous é igual a d2
            // Continuando com nossa lista ligada,
            // Vamos adicionar terça depois de segunda
            var d3 = dias.AddAfter(d2, "terça");

            //Perceba que os "Ponteiros", ou referências
            //de d2 e d4 foram redirecionados para d3!!
            //Vamos adicionar sexta depois de quarta
            var d6 = dias.AddAfter(d4, "Sexta");

            //Sábado depois da sexta
            var d7 = dias.AddAfter(d6, "Sábado");
            //Quinta antes de sexta
            var d5 = dias.AddBefore(d6, "Quinta");
            //Domingo antes da segunda
            var d1 = dias.AddBefore(d2, "Domingo");

            //Agora vamos imprimir a lista!
            foreach (var dia in dias)
            {
                Console.WriteLine(dia);
                    
            
            }

            //LinkedList NÃO DÁ suporte ao acesso de índice: dias[0]
            //por isso podemos fazer um laço foreach mas não um for!
            var quarta = dias.Find("Quarta");

            //Para removermos um elemento, podemos tanto
            //remover pelo valor quanto pela
            //referência do LinkedListNode
            //dias.Remove("Qauarta") ou dias.Remove(d4);
            dias.Remove("Quarta");

            Console.ReadLine();
        }
    }
}

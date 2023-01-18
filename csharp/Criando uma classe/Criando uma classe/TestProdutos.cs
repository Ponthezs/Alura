using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Criando_uma_classe
{
    internal class TestProdutos
    {
        
            string nome;
            string fabricante;
            string codigoDeBarra;
            double valorUnitario;
            double valorDeCompra;
            double quantidadeEmEstoque;


        public void DadosDoProduto()
        {
            Console.WriteLine("Nome: " + nome);
            Console.WriteLine("Fabricante: " + fabricante);
            Console.WriteLine("Cód de Barras: " + codigoDeBarra);
            Console.WriteLine("Valor Unitário: " + valorUnitario);
            Console.WriteLine("Valor de Compra: " + valorDeCompra);
            Console.WriteLine("Estoque: " + quantidadeEmEstoque);
        }

        string email;
        string senha;

        public bool ValidaUsuarioESenha(string emailX, string senhaX)
        {
            if (emailX != null || senhaX != null)
            {
                if (email == emailX && senha == senhaX)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

    }
}

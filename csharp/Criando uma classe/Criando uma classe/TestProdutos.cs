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


        public class Pedido
        {
            public int numero_Pedido;
            public Cliente cliente;
            public ItemPedido item;
            public float total_Pedido;
        }

        public class ItemPedido
        {
            public int quantidade;
            public int numero_Pedido;
            public Produto produto1;
            public Produto produto2;
            public Produto produto3;
        }

        public class Produto
        {
            int codigo_Produto;
            string Descricao;
            double valor_Unitario;
            double quantidade;
        }
        public class Cliente
        {
            public string nome;
            public string cpf;
            public string email;
            public Endereco endereco;
        }

        public class Endereco
        {
            public string rua;
            public string bairro;
            public string cidade;
            public string cep;
            public int numero;
        }


        //        Cliente sarah = new Cliente();
        //        sarah.Nome = "Sarah Silva";
        //sarah.Profissao = "Professora";
        //sarah.Cpf = "11111111-12";

        //Cliente ester = new Cliente();
        //        ester.Nome = "Ester Almeida";
        //ester.Profissao = "Advogada";
        //ester.Cpf = "868524125-32";

        //Console.WriteLine("Total de clientes: "+ Cliente.TotalClientesCadastrados);

        //ContaCorrente contaAndre = new ContaCorrente(159, "152869-x");
        //        contaAndre.Titular = new Cliente();
        //        contaAndre.Titular.Nome = " André Pereira";
        //contaAndre.Titular.Profissao = "Auxiliar Administrativo";
        //contaAndre.Saldo = 100;

        //Console.WriteLine("Total de clientes: " + Cliente.TotalClientesCadastrados);


    }
}

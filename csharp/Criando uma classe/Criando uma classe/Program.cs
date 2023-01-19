using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Criando_uma_classe
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //    ContaCorrente contaDoAndre = new ContaCorrente();
            //    contaDoAndre.titular = "André Silva";
            //    contaDoAndre.numero_agencia = 15;
            //    contaDoAndre.conta = "1010-X";
            //    contaDoAndre.saldo = 100;

            //    Console.WriteLine("Saldo da conta do André = " + contaDoAndre.saldo);
            //    contaDoAndre.Depositar(1000);
            //    Console.WriteLine("Saldo da conta do André pós-depósito = " + contaDoAndre.saldo);
            //    if (contaDoAndre.Sacar(300) == true)
            //    {
            //        Console.WriteLine("Saldo da conta do André pós-saque = " + contaDoAndre.saldo);
            //    }
            //    else
            //    {
            //        Console.WriteLine("Saldo insuficiente para saque.");
            //    }

            //    ContaCorrente contaDaMaria = new ContaCorrente();
            //    contaDaMaria.titular = "Maria Souza";
            //    contaDaMaria.numero_agencia = 17;
            //    contaDaMaria.conta = "1010-5";
            //    contaDaMaria.saldo = 350;

            //    Console.WriteLine("Saldo da conta da Maria = " + contaDaMaria.saldo);


            //    contaDoAndre.Transferir(50, contaDaMaria);
            //    Console.WriteLine("Saldo do André = " + contaDoAndre.saldo);
            //    Console.WriteLine("Saldo da Maria = " + contaDaMaria.saldo);


            //    ContaCorrente contaDoPedro = new ContaCorrente();
            //    contaDoPedro.titular = "Pedro Silva";
            //    Console.WriteLine(contaDoPedro.titular);
            //    Console.WriteLine(contaDoPedro.conta);
            //    Console.WriteLine(contaDoPedro.numero_agencia);
            //    Console.WriteLine(contaDoPedro.saldo);

            //double valor = 300;
            //double valor2 = valor;

            //Console.WriteLine(valor == valor2);
            //Console.WriteLine(valor);''
            //Console.WriteLine(valor2);

            //ContaCorrente contaDoAndre = new ContaCorrente();
            //contaDoAndre.titular = "André Silva";
            //contaDoAndre.numero_agencia = 15;
            //contaDoAndre.conta = "1010-X";
            //contaDoAndre.saldo = 100;
            //Console.WriteLine("Saldo da conta do André = " + contaDoAndre.saldo);


            //ContaCorrente contaDoAndre2 = new ContaCorrente();
            //contaDoAndre2.titular = "André Silva";
            //contaDoAndre2.numero_agencia = 15;
            //contaDoAndre2.conta = "1010-X";
            //contaDoAndre2.saldo = 100;
            //Console.WriteLine("Saldo da conta do André = " + contaDoAndre2.saldo);


            //Console.WriteLine(contaDoAndre == contaDoAndre2);
            //Cliente cliente = new Cliente();
            //cliente.nome = "André Silva";
            //cliente.cpf = "123456789";
            //cliente.profissao = "Analista";
            //ContaCorrente conta = new ContaCorrente();
            //conta.titular = cliente;
            //conta.conta = "1010-X";
            //conta.numero_agencia = 15;
            //conta.saldo = 100;

            //Console.WriteLine("Titular = " + conta.titular.nome);
            //Console.WriteLine("Cpf = " + conta.titular.cpf);
            //Console.WriteLine("Profissao = " + conta.titular.profissao);
            //Console.WriteLine("Nº Conta = " + conta.conta);
            //Console.WriteLine("Saldo = " + conta.saldo);
            //Console.WriteLine("Nº Agência = " + conta.numero_agencia);

            //código omitido

            //ContaCorrente conta2 = new ContaCorrente();
            //conta2.titular.nome = "José Souza";
            //conta2.titular.profissao = "Tester";
            //conta2.titular.cpf = "987654321";
            //conta2.conta = "9999-X";
            //conta2.numero_agencia = 18;
            //conta2.saldo = 500;

            //Console.WriteLine(conta2.titular.nome);


            //ContaCorrente conta2 = new ContaCorrente();
            //conta2.titular = new Cliente();
            //conta2.titular.nome = "José Souza";
            //conta2.titular.profissao = "Tester";
            //conta2.titular.cpf = "987654321";
            //conta2.conta = "9999-X";
            //conta2.numero_agencia = 18;
            //conta2.saldo = 500;

            //Console.WriteLine(conta2.titular.nome);

            //ContaCorrente conta3 = new ContaCorrente();
            //conta3.DefinirSaldo(-10);
            //Console.WriteLine(conta3.ObterSaldo());

            //ContaCorrente conta3 = new ContaCorrente()
            //conta3.numero_agencia = 18;
            //conta3.Conta = "1011-H";
            //conta3.SetSaldo(200);
            //Console.WriteLine(conta3.GetSaldo());
            //Console.WriteLine(conta3.numero_agencia);
            //Console.WriteLine(conta3.Conta);

            //ContaCorrente conta4 = new ContaCorrente();
            //conta4.SetSaldo(500);
            //conta4.numero_agencia = 18;
            //conta4.titular = new Cliente();

            //Console.WriteLine(conta4.GetSaldo());
            //Console.WriteLine(conta4.numero_agencia);

            //ContaCorrente conta5 = new ContaCorrente(283, "1234-X");
            //Console.WriteLine(conta5.TotalDeContasCriadas);

            //ContaCorrente conta6 = new ContaCorrente(284, "9874-Z");
            //Console.WriteLine(conta6.TotalDeContasCriadas);

            ContaCorrente conta5 = new ContaCorrente(283, "1234-X");
            Console.WriteLine(ContaCorrente.TotalDeContasCriadas);

            ContaCorrente conta6 = new ContaCorrente(284, "9874-Z");
            Console.WriteLine(ContaCorrente.TotalDeContasCriadas);

            ContaCorrente conta7 = new ContaCorrente(285, "1111-Z");
            Console.WriteLine(ContaCorrente.TotalDeContasCriadas);


            Console.ReadLine();


        }
    }
}

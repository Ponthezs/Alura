using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Criando_uma_classe
{
    internal class ContaCorrente
    {



        public int TotalDeContasCriadas { get; set; }
        private int numero_agencia;
        public int Numero_agencia
        {
            get { return this.numero_agencia; }
            private set
            {
                if (value > 0)
                {
                    this.numero_agencia = value;
                }
            }
        }

        public ContaCorrente(int numero_agencia, string numero_conta)
        {
            this.numero_agencia = numero_agencia;
            this.Conta = numero_conta;
            TotalDeContasCriadas++;
        }

        public string conta;
        public double saldo = 100;

        public Cliente titular;
        public void Depositar (double valor)
        {
            this.saldo += valor;
        }

        public bool Sacar(double valor)
        {
            if (valor <= this.saldo)
            {
                this.saldo -= valor;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Transferir(double valor, ContaCorrente destino)
        {
            if (this.saldo < valor)
            {
                return false;
            }
            else
            {
                this.Sacar(valor);
                destino.Depositar(valor);
                return true;
            }
        }

        public void DefinirSaldo(double valor)
        {
            if (valor < 0)
            {
                return;
            }
            else
            {
                this.saldo = valor;
            }
        }

        public double ObterSaldo()
        {
            return this.saldo;
        }
        public int MyProperty { get; set; }
        //private string conta;
        public string Conta { get; set; }

    }
}

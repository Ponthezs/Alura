using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Criando_uma_classe
{
    internal class ContaCorrente
    {
        public int numero_agencia;
        public string conta;
        public double saldo = 100;

        public string titularNome;
        public string titularCPF;
        public string titularProfissao;
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


    }
}

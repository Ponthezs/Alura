using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bankADM
{
    public abstract class Funcionario
    {
        public string Nome { get; set; }
        public string Cpf { get; private set; }
        public double Salario { get; private set; }
        //public double Salario { get; set; }
        private int tipo; //0-Funcionario 1-Diretor 2-Analista...
        public static int TotalDeFuncionarios { get; private set; }

        //public virtual double GetBonificacao()
        //{
        //    //if (tipo == 1)
        //    //{
        //    //    return this.Salario;
        //    //}
        //    return this.Salario * 0.10;
        //}

        public Funcionario(string cpf, double salario)
        {
            this.Salario = salario;

            this.Cpf = cpf;
            TotalDeFuncionarios++;
            Console.WriteLine("Criando um funcionário.");
        }
        public abstract double GetBonificacao();

        // ...

        public abstract void AumentarSalario();


        //public void AumentarSalario()
        //{
        //    this.Salario *= 1.15;
        //}





        //public Funcionario(int tipo)
        //{
        //    this.tipo = tipo;
        //}
    }
}

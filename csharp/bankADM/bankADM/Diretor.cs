using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bankADM.Funcionarios;

namespace bankADM.Funcionarios
{
    public class Diretor : Funcionario
    {

        public override double GetBonificacao()
        {
            return this.Salario * 0.5;
        }

        public Diretor(string cpf) : base(cpf, 5000)
        {
            //Console.WriteLine("Criando um diretor.");
        }

        public void AumentarSalario()
        {
            this.Salario *= 1.15;
        }


        //public string Nome { get; set; }
        //public string Cpf { get; set; }
        //public double Salario { get; set; }

        //public double GetBonificacao()
        //{
        //    return this.Salario;
        //}
    }
}

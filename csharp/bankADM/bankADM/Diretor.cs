using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bankADM.Funcionarios
{
    public class Diretor : Funcionario
    {

        public override double GetBonificacao()
        {
            return this.Salario + base.GetBonificacao();
        }

        public Diretor()
        {
            Console.WriteLine("Criando um diretor.");
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

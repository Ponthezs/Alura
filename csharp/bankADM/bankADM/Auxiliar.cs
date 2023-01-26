using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bankADM.Funcionarios;

namespace bankADM
{
    public class Auxiliar : Funcionario
    {
        public Auxiliar(string cpf) : base(cpf, 2000)
        {

        }

        public override double GetBonificacao()
        {
            return Salario * 0.2;
        }

        public void AumentarSalario()
        {
            this.Salario *= 1.15;
        }
    }
}

using bytebank_ADM.SistemaInterno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Funcionarios
{
    public class Diretor: FuncionarioAutenticavel 
    { 

        public override double GetBonificacao()
        {
            return this.Salario * 0.5;
        }

        public Diretor(string cpf):base(cpf,5000)
        {
            //Console.WriteLine("Criando um diretor.");
        }

        public override void AumentarSalario()
        {
            this.Salario *= 1.15; 
        }

    }

    
}

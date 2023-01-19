using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Criando_uma_classe
{
    public class Cliente
    {
        public string Nome { get; set; }

        public string cpf { get; set; }

        public string Profissao { get; set; }



        public static int TotalDeContasCriadas { get; private set; }
    }

}

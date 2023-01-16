using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class ResgistraNoDisco : IRegistro
    {
        private Stream nomeArquivo;

        private string NomeArquivo { get; set; }

        public ResgistraNoDisco(string nomeArquivo)
        {
            NomeArquivo = nomeArquivo;
        }


        public void RegistraInfo(string mensagem)
        {
                using (StreamWriter arquivo = new StreamWriter(nomeArquivo))
                {
                    arquivo.WriteLine(mensagem);
                }
        }
    }
}

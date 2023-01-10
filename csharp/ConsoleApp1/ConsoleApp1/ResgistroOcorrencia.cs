using ConsoleApp1;
using System;
using System.IO;

namespace Interface
{
    internal class ResgistraOcorrencia
    {
        private IRegistro Resgistra;

        public ResgistraOcorrencia(IRegistro registra)
        {
           Resgistra = registra;
        }

        public void Registrar (string mensagem)
        {
            Resgistra.RegistraInfo(mensagem);
        }

    }
}
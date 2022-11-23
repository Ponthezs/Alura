using Caelum.Stella.CSharp.Format;
using Caelum.Stella.CSharp.Validation;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidacaoCPF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string cpf1 = "86288366757";
            string cpf2 = "98745366797";
            string cpf3 = "22222222222";

            ValidarCPF(cpf1);
            ValidarCPF(cpf2);
            ValidarCPF(cpf3);

            string titulo1 = "041372570132";
            string titulo2 = "774387480132";

            ValidarTitulo(titulo1);
            ValidarTitulo(titulo2);

            Debug.WriteLine(cpf1);
            string cpfFormatado = new CPFFormatter().Format(cpf1);
            Debug.WriteLine(cpfFormatado);
            Debug.WriteLine(new CPFFormatter().Format(cpfFormatado));
            Debug.WriteLine(new CPFFormatter().Unformat(cpfFormatado));
            Debug.WriteLine(titulo1);
            Debug.WriteLine(new TituloEleitoralFormatter().Format(titulo1));

        }



        private static void ValidarTitulo(string titulo)
        {
            if (new TituloEleitoralValidator().IsValid(titulo))
            {
                Debug.WriteLine("Título válido: " + titulo);
            }
            else
            {
                Debug.WriteLine("Título inválido: " + titulo);
            }
        }

        private static void ValidarCPF(string cpf)
        {
            if (new CPFValidator().IsValid(cpf))
            {
                Debug.WriteLine("CPF válido: " + cpf);
            }
            else
            {
                Debug.WriteLine("CPF inválido: " + cpf);
            }
        }
    }
}

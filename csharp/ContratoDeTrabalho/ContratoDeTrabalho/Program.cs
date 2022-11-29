using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContratoDeTrabalho
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var contrato = new
            {
                Empresa = new
                {
                    RazaoSocial = "Alura Serviços Hidráulicos Ltda.",
                    CNPJ = "23432323000150",
                    Endereco = viaCEP.GetEndereco("04101300"),
                    Numero = "123 fundos"
                },
                Funcionario = new
                {
                    Nome = "Mario Mario",
                    CPF = "14538551228",
                    RG = "123456789-00",
                    Nacionalidade = "italiana",
                    EstadoCivil = "casado",
                    Endereco = viaCEP.GetEndereco("07091000"),
                    Numero = "234"
                },
                Inicio = new DateTime(2018, 1, 1),
                Cargo = "encanador",
                Salario = 3108.45,
                SlExtenso = "Três mil cento e oito reais e quarenta e cinco centavos"
            };

            string documento = $@"

EMPREGADOR: {contrato.Empresa.RazaoSocial}, com sede à (LOGRADOURO), {contrato.Empresa.Numero}, (BAIRRO), CEP {contrato.Empresa.Endereco}, (LOCALIDADE), (UF), inscrita no CNPJ sob nº {contrato.Empresa.CNPJ};

EMPREGADO: {contrato.Funcionario}, {contrato.Funcionario.Nacionalidade}, {contrato.Funcionario.EstadoCivil}, portador da cédula de identidade R.G. nº {contrato.Funcionario.RG} e CPF/MF nº {contrato.Funcionario.CPF}, residente e domiciliado na (LOGRADOURO), {contrato.Funcionario.Numero}, (BAIRRO), CEP {contrato.Funcionario.Endereco}, (LOCALIDADE), (UF).

Pelo presente instrumento particular de contrato individual de trabalho, fica justo e contratado o seguinte:

Cláusula 1ª - O EMPREGADO prestará ao EMPREGADOR, a partir de {contrato.Inicio}, e assinatura deste instrumento, seus trabalhos exercendo a função de {contrato.Cargo}, prestando pessoalmente o labor diário no período compreendido entre 9 horas às 18 horas, e intervalo de 1 hora para almoço;

Cláusula 2ª - Não haverá expediente nos dias de sábado, sendo prestado a compensação de horário semanal;

Cláusula 3ª - O EMPREGADOR pagará mensalmente, ao EMPREGADO, a título de salário a importância de {contrato.Salario} {contrato.SlExtenso}, com os descontos previstos por lei;

Cláusula 4ª - Estará o EMPREGADO subordinado a legislação vigente no que diz respeito aos descontos de faltas e demais sanções disciplinares contidas na Consolidação das Leis do Trabalho.

Cláusula 5ª - O prazo de duração do contrato é de 2 (dois) anos, contados a partir da assinatura pelos contratantes;

Cláusula 6ª - O EMPREGADO obedecerá o regulamento interno da empresa, e filosofia de trabalho da mesma.

Como prova do acordado, assinam instrumento, firmado e respeitando seu teor por inteiro, e firmam conjuntamente a este duas testemunhas, comprovando as razões descritas.

(LOCALIDADE), (DATA POR EXTENSO)


_______________________________________________________
{contrato.Empresa.RazaoSocial}

_______________________________________________________
{contrato.Funcionario}

_______________________________________________________
(Nome, R.G,Testemunha)

_______________________________________________________
(Nome, R.G,Testemunha)";

            Console.WriteLine(documento);
            Console.ReadKey();
        }
    }
}

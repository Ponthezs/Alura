using csharp_exception.Titular;
using csharp_exception.Contas;


try
{
    ContaCorrente conta1 = new ContaCorrente(0, "1234-X");
}
catch(ArgumentException ex)
{
    Console.WriteLine("Parâmetro com erro" + ex.ParamName);
    Console.WriteLine("Não é possível criar uma conta com o número de agência menor ou igual a zero!");
    Console.WriteLine(ex.Message);
    
}


using Alura.LeilaoOnline.WebApp.Models;

namespace Alura.LeilaoOnline.WebApp.Dados
{
    public interface ILeilaoDao : ICommand<Leilao>, IQuery<Leilao>
    {
    }
}

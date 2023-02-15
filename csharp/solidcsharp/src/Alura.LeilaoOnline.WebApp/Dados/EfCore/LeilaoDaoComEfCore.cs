using System.Collections.Generic;
using Alura.LeilaoOnline.WebApp.Models;
using Microsoft.EntityFrameworkCore;

namespace Alura.LeilaoOnline.WebApp.Dados.EfCore
{
    public class LeilaoDaoComEfCore : ILeilaoDao
    {
        AppDbContext _context;

        public LeilaoDaoComEfCore(AppDbContext context)
        {
            _context = context;
        }

        public Leilao BuscarPorId(int id)
        {
            return _context.Leiloes.Find(id);
        }

        public IEnumerable<Leilao> BuscarTodos()
        {
            return _context.Leiloes.Include(l => l.Categoria);
        }

        public void Incluir(Leilao obj)
        {
            _context.Leiloes.Add(obj);
            _context.SaveChanges();
        }

        public void Alterar(Leilao obj)
        {
            _context.Leiloes.Update(obj);
            _context.SaveChanges();
        }

        public void Excluir(Leilao leilao)
        {
            _context.Leiloes.Remove(leilao);
            _context.SaveChanges();
        }
    }
}

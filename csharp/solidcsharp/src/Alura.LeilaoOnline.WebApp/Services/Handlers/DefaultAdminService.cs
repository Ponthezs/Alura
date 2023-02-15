using System;
using System.Collections.Generic;
using Alura.LeilaoOnline.WebApp.Dados;
using Alura.LeilaoOnline.WebApp.Models;

namespace Alura.LeilaoOnline.WebApp.Services.Handlers
{
    public class DefaultAdminService : IAdminService
    {
        ILeilaoDao _dao;
        ICategoriaDao _categDao;

        public DefaultAdminService(ILeilaoDao dao, ICategoriaDao categoriaDao)
        {
            _dao = dao;
            _categDao = categoriaDao;
        }

        public IEnumerable<Categoria> ConsultaCategorias()
        {
            return _categDao.BuscarTodos();
        }

        public IEnumerable<Leilao> ConsultaLeiloes()
        {
            return _dao.BuscarTodos();
        }

        public Leilao ConsultaLeilaoPorId(int id)
        {
            return _dao.BuscarPorId(id);
        }

        public void CadastraLeilao(Leilao leilao)
        {
            _dao.Incluir(leilao);
        }

        public void ModificaLeilao(Leilao leilao)
        {
            _dao.Alterar(leilao);
        }

        public void RemoveLeilao(Leilao leilao)
        {
            if (leilao != null && leilao.Situacao != SituacaoLeilao.Pregao)
            {
                _dao.Excluir(leilao);
            }
        }

        public void FinalizaPregaoDoLeilaoComId(int id)
        {
            var leilao = _dao.BuscarPorId(id);
            if (leilao != null && leilao.Situacao == SituacaoLeilao.Pregao)
            {
                leilao.Situacao = SituacaoLeilao.Finalizado;
                leilao.Termino = DateTime.Now;
                _dao.Alterar(leilao);
            }
        }

        public void IniciaPregaoDoLeilaoComId(int id)
        {
            var leilao = _dao.BuscarPorId(id);
            if (leilao != null && leilao.Situacao == SituacaoLeilao.Rascunho)
            {
                leilao.Situacao = SituacaoLeilao.Pregao;
                leilao.Inicio = DateTime.Now;
                _dao.Alterar(leilao);
            }
        }
    }
}

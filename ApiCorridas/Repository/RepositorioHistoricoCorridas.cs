using ApiCorridas.Models;
using ApiCorridas.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ApiCorridas.Repository
{
    public class RepositorioHistoricoCorridas : IHistoricoCorridasRepository
    {
        private readonly APIDbContext _context;

        public RepositorioHistoricoCorridas(APIDbContext context)
        {
            _context = context;
        }

        public async Task<bool> AdicionarCorrida(HistoricoCorrida model)
        {
            _context.HistoricoCorridas.Add(model);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> AlterarCorrida(int id, HistoricoCorrida model)
        {
            model.Id = id;
            _context.HistoricoCorridas.Update(model);
            await _context.SaveChangesAsync();
            return true;
        }

        public dynamic ListaCompetidoresSemCorrida()
        {
            try
            {
                dynamic competidores = (from c in _context.Competidores
                                        join a in _context.HistoricoCorridas
                                            on c.Id equals a.CompetidorId into juncao
                                        from j in juncao.DefaultIfEmpty()
                                        where j.CompetidorId == null
                                        select new
                                        {
                                            Nome = c.Nome
                                        })
                                        .ToList();

                return competidores;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public dynamic ListaCompetidoresTempoMedio()
        {
            try
            {
                dynamic competidores = (from s in _context.Competidores
                                        join sa in _context.HistoricoCorridas on s.Id equals sa.CompetidorId
                                        group sa by s.Nome into teste
                                        select new
                                        {
                                            Nome = teste.Key,
                                            Soma = teste.Sum(y => y.TempoGasto)
                                        })
                                        .ToList();

                return competidores;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public dynamic ListaTodasPistasUtilizadas()
        {
            try
            {
                dynamic pistas = (from s in _context.Pistas
                                  join sa in _context.HistoricoCorridas on s.Id equals sa.PistaId
                                  select new
                                  {
                                      Pista = s.Descricao
                                  })
                                  .ToList()
                                  .Distinct();

                return pistas;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<HistoricoCorrida> SelecionaTodasCorridas()
        {
            return _context.HistoricoCorridas.ToList();
        }

        public HistoricoCorrida SelecionaUmaCorrida(int id)
        {
            return _context.HistoricoCorridas.Find(id);
        }
    }
}

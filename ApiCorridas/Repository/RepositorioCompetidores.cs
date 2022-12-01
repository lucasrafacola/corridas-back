using ApiCorridas.Models;
using ApiCorridas.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ApiCorridas.Repository
{
    public class RepositorioCompetidores : ICompetidoresRepository
    {
        private readonly APIDbContext _context;

        public RepositorioCompetidores(APIDbContext context)
        {
            _context = context;
        }

        public async Task<bool> AdicionarCompetidor(Competidor competidor)
        {
            _context.Competidores.Add(competidor);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> AlterarCompetidor(int id, Competidor competidor)
        {
            competidor.Id = id;
            _context.Competidores.Update(competidor);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> ExcluirCompetidor(int id)
        {
            var competidor = _context.Competidores.Find(id);
            _context.Competidores.Remove(competidor);
            await _context.SaveChangesAsync();
            return true;

        }

        public List<Competidor> SelecionaTodosCompetidores()
        {
            return _context.Competidores.ToList();
        }

        public Competidor SelecionaUmCompetidor(int id)
        {
            return _context.Competidores.Find(id);
        }
    }
}

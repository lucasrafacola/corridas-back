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

        public async Task<bool> AdicionarCompetidor(Competidor model)
        {
            _context.Competidores.AddAsync(model);
            await _context.SaveChangesAsync();
            return true;
        }

        public bool AlterarCompetidor(Competidor model)
        {
            throw new NotImplementedException();
        }

        public bool ExcluirCompetidor(int id)
        {
            throw new NotImplementedException();
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

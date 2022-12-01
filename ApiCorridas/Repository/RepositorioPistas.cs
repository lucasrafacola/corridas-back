using ApiCorridas.Models;
using ApiCorridas.Repository.Interfaces;

namespace ApiCorridas.Repository
{
    public class RepositorioPistas : IPistasRepository
    {
        private readonly APIDbContext _context;

        public RepositorioPistas(APIDbContext context)
        {
            _context = context;
        }

        public async Task<bool> AdicionarPista(Pista model)
        {
            _context.Pistas.Add(model);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> AlterarPista(int id, Pista model)
        {
            model.Id = id;
            _context.Pistas.Update(model);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> ExcluirPista(int id)
        {
            var model = _context.Pistas.Find(id);
            _context.Pistas.Remove(model);
            await _context.SaveChangesAsync();
            return true;
        }

        public List<Pista> SelecionaTodasPistas()
        {
            return _context.Pistas.ToList();
        }

        public Pista SelecionaUmaPista(int id)
        {
            return _context.Pistas.Find(id);
        }
    }
}

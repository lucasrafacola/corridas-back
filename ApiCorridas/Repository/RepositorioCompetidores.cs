using ApiCorridas.Models;
using ApiCorridas.Repository.Interfaces;

namespace ApiCorridas.Repository
{
    public class RepositorioCompetidores : ICompetidoresRepository
    {
        private readonly APIDbContext _context;

        public RepositorioCompetidores(APIDbContext context)
        {
            _context = context;
        }

        public bool AdicionarCompetidor(Competidor model)
        {
            throw new NotImplementedException();
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

using ApiCorridas.Models;
using ApiCorridas.Repository;
using ApiCorridas.Repository.Interfaces;
using ApiCorridas.Services.Interfaces;

namespace ApiCorridas.Services
{
    public class ServicoCompetidores : ICompetidoresService
    {
        private readonly ICompetidoresRepository _competidoresRepository;

        public ServicoCompetidores(ICompetidoresRepository competidoresRepository)
        {
            _competidoresRepository = competidoresRepository;
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
            return _competidoresRepository.SelecionaTodosCompetidores();
        }

        public Competidor SelecionaUmCompetidor(int id)
        {
            return _competidoresRepository.SelecionaUmCompetidor(id);
        }
    }
}

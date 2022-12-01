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

        public async Task<bool> AdicionarCompetidor(Competidor competidor)
        {
            return await _competidoresRepository.AdicionarCompetidor(competidor);
        }

        public async Task<bool> AlterarCompetidor(int id, Competidor competidor)
        {
            return await _competidoresRepository.AlterarCompetidor(id, competidor);
        }

        public async Task<bool> ExcluirCompetidor(int id)
        {
            return await _competidoresRepository.ExcluirCompetidor(id);
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

using ApiCorridas.Models;
using ApiCorridas.Repository;
using ApiCorridas.Repository.Interfaces;
using ApiCorridas.Services.Interfaces;

namespace ApiCorridas.Services
{
    public class ServicoCompetidores : ICompetidoresService
    {
        private readonly ICompetidoresRepository _competidoresRepository;
        private readonly IUtils _utils;

        public ServicoCompetidores(ICompetidoresRepository competidoresRepository, IUtils utils)
        {
            _competidoresRepository = competidoresRepository;
            _utils = utils;
        }

        public async Task<bool> AdicionarCompetidor(Competidor competidor)
        {
            var validacao = _utils.ValidaCompetidor(competidor);
            
            if (validacao)
                return await _competidoresRepository.AdicionarCompetidor(competidor);

            return false;
        }

        public async Task<bool> AlterarCompetidor(int id, Competidor competidor)
        {
            var validacao = _utils.ValidaCompetidor(competidor);

            if (validacao)
                return await _competidoresRepository.AlterarCompetidor(id, competidor);

            return false;
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

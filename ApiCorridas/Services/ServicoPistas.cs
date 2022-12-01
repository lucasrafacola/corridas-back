using ApiCorridas.Models;
using ApiCorridas.Repository;
using ApiCorridas.Repository.Interfaces;
using ApiCorridas.Services.Interfaces;

namespace ApiCorridas.Services
{
    public class ServicoPistas : IPistasService
    {
        private readonly IPistasRepository _pistasRepository;

        public ServicoPistas(IPistasRepository pistasRepository)
        {
            _pistasRepository = pistasRepository;
        }

        public async Task<bool> AdicionarPista(Pista model)
        {
            return await _pistasRepository.AdicionarPista(model);
        }

        public async Task<bool> AlterarPista(int id, Pista model)
        {
            return await _pistasRepository.AlterarPista(id, model);
        }

        public async Task<bool> ExcluirPista(int id)
        {
            return await _pistasRepository.ExcluirPista(id);
        }

        public List<Pista> SelecionaTodasPistas()
        {
            return  _pistasRepository.SelecionaTodasPistas();
        }

        public Pista SelecionaUmaPista(int id)
        {
            return _pistasRepository.SelecionaUmaPista(id);
        }
    }
}

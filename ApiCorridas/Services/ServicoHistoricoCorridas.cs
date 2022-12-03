using ApiCorridas.Models;
using ApiCorridas.Repository.Interfaces;
using ApiCorridas.Services.Interfaces;

namespace ApiCorridas.Services
{
    public class ServicoHistoricoCorridas : IHistoricoCorridasService
    {
        private readonly IHistoricoCorridasRepository _historicoCorridasRepository;
        private readonly IUtils _utils;

        public ServicoHistoricoCorridas(IHistoricoCorridasRepository historicoCorridasRepository, IUtils utils)
        {
            _historicoCorridasRepository = historicoCorridasRepository;
            _utils = utils;
        }

        public async Task<bool> AdicionarCorrida(HistoricoCorrida model)
        {
            if(_utils.ValidaCorrida(model))
                return await _historicoCorridasRepository.AdicionarCorrida(model);

            return false;
        }

        public async Task<bool> AlterarCorrida(int id, HistoricoCorrida model)
        {
            if (_utils.ValidaCorrida(model))
                return await _historicoCorridasRepository.AlterarCorrida(id, model);

            return false;
        }

        public dynamic ListaCompetidoresSemCorrida()
        {
            return _historicoCorridasRepository.ListaCompetidoresSemCorrida();
        }

        public dynamic ListaCompetidoresTempoMedio()
        {
            return _historicoCorridasRepository.ListaCompetidoresTempoMedio();
        }

        public dynamic ListaTodasPistasUtilizadas()
        {
            return _historicoCorridasRepository.ListaTodasPistasUtilizadas();
        }

        public List<HistoricoCorrida> SelecionaTodasCorridas()
        {
            return  _historicoCorridasRepository.SelecionaTodasCorridas();
        }

        public HistoricoCorrida SelecionaUmaCorrida(int id)
        {
            return _historicoCorridasRepository.SelecionaUmaCorrida(id);
        }
    }
}

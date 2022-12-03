using ApiCorridas.Models;

namespace ApiCorridas.Repository.Interfaces
{
    public interface IHistoricoCorridasRepository
    {
        Task<bool> AdicionarCorrida(HistoricoCorrida model);
        Task<bool> AlterarCorrida(int id, HistoricoCorrida model);
        HistoricoCorrida SelecionaUmaCorrida(int id);
        List<HistoricoCorrida> SelecionaTodasCorridas();
        dynamic ListaTodasPistasUtilizadas();
        dynamic ListaCompetidoresTempoMedio();
        dynamic ListaCompetidoresSemCorrida();
    }
}

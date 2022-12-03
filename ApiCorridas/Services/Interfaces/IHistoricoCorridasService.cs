using ApiCorridas.Models;

namespace ApiCorridas.Services.Interfaces
{
    public interface IHistoricoCorridasService
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

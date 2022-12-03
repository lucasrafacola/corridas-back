using ApiCorridas.Models;

namespace ApiCorridas.Services.Interfaces
{
    public interface IUtils
    {
        bool ValidaCompetidor(Competidor competidor);
        bool ValidaCorrida(HistoricoCorrida corrida);
    }
}

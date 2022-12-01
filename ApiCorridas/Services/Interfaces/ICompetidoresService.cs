using ApiCorridas.Models;

namespace ApiCorridas.Services.Interfaces
{
    public interface ICompetidoresService
    {
        Task<bool> AdicionarCompetidor(Competidor model);
        Task<bool> AlterarCompetidor(int id, Competidor model);
        Task<bool> ExcluirCompetidor(int id);
        Competidor SelecionaUmCompetidor(int id);
        List<Competidor> SelecionaTodosCompetidores();
    }
}

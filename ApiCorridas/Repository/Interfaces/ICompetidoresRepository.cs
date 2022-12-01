using ApiCorridas.Models;
using Microsoft.AspNetCore.Mvc;

namespace ApiCorridas.Repository.Interfaces
{
    public interface ICompetidoresRepository
    {
        Task<bool> AdicionarCompetidor(Competidor model);
        Task<bool> AlterarCompetidor(int id, Competidor model);
        Task<bool> ExcluirCompetidor(int id);
        Competidor SelecionaUmCompetidor(int id);
        List<Competidor> SelecionaTodosCompetidores();
    }
}

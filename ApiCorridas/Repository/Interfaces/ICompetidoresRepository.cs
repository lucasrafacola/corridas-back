using ApiCorridas.Models;
using Microsoft.AspNetCore.Mvc;

namespace ApiCorridas.Repository.Interfaces
{
    public interface ICompetidoresRepository
    {
        Task<bool> AdicionarCompetidor(Competidor model);
        bool AlterarCompetidor(Competidor model);
        bool ExcluirCompetidor(int id);
        Competidor SelecionaUmCompetidor(int id);
        List<Competidor> SelecionaTodosCompetidores();
    }
}

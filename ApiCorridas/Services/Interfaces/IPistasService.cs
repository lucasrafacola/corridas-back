using ApiCorridas.Models;

namespace ApiCorridas.Services.Interfaces
{
    public interface IPistasService
    {
        Task<bool> AdicionarPista(Pista model);
        Task<bool> AlterarPista(int id, Pista model);
        Task<bool> ExcluirPista(int id);
        Pista SelecionaUmaPista(int id);
        List<Pista> SelecionaTodasPistas();
    }
}

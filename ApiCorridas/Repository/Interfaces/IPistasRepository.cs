using ApiCorridas.Models;

namespace ApiCorridas.Repository.Interfaces
{
    public interface IPistasRepository
    {
        Task<bool> AdicionarPista(Pista model);
        Task<bool> AlterarPista(int id, Pista model);
        Task<bool> ExcluirPista(int id);
        Pista SelecionaUmaPista(int id);
        List<Pista> SelecionaTodasPistas();
    }
}

using ApiCorridas.Models;

namespace ApiCorridas.Repository.Interfaces
{
    public interface ICompetidoresRepository
    {
        bool AdicionarCompetidor(Competidor model);
        bool AlterarCompetidor(Competidor model);
        bool ExcluirCompetidor(int id);
        Competidor SelecionaUmCompetidor(int id);
        List<Competidor> SelecionaTodosCompetidores();
    }
}

﻿using ApiCorridas.Models;

namespace ApiCorridas.Services.Interfaces
{
    public interface ICompetidoresService
    {
        bool AdicionarCompetidor(Competidor model);
        bool AlterarCompetidor(Competidor model);
        bool ExcluirCompetidor(int id);
        Competidor SelecionaUmCompetidor(int id);
        List<Competidor> SelecionaTodosCompetidores();
    }
}
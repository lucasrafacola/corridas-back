using ApiCorridas.Models;
using ApiCorridas.Repository.Interfaces;
using ApiCorridas.Services.Interfaces;

namespace ApiCorridas.Services.Utils
{
    public class Utils : IUtils
    {
        public bool ValidaCompetidor(Competidor competidor)
        {
            string sexoComp = competidor.Sexo.ToString().ToUpper();
            bool temp = false;
            bool pesoAltura = false;
            bool sexo = false;

            if (competidor.TempMedCorpo >= 36 && competidor.TempMedCorpo <= 38)
                temp = true;

            if (competidor.Peso > 0 && competidor.Altura > 0)
                pesoAltura = true;

            if (sexoComp == "M" || sexoComp == "F" || sexoComp == "O")
                sexo = true;

            if (temp && pesoAltura && sexo)
                return true;

            return false;
        }

        public bool ValidaCorrida(HistoricoCorrida corrida)
        {
            DateTime hoje = DateTime.Today;
            if (corrida.DataCorrida <= hoje)
                return true;

            return false;
        }
    }
}

using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace ApiCorridas.Models
{
    public class Competidor
    {
        [Key]
        [JsonIgnore]
        public int? Id { get; set; }

        [Required(ErrorMessage = "Nome não pode ser nulo.")]
        public string? Nome { get; set; }

        [Required(ErrorMessage = "Sexo não pode ser nulo.")]
        public char Sexo { get; set; }

        [Required(ErrorMessage = "TempMedCorpo não pode ser nulo.")]
        public double TempMedCorpo { get; set; }

        [Required(ErrorMessage = "Peso não pode ser nulo.")]
        public double Peso { get; set; }

        [Required(ErrorMessage = "Altura não pode ser nulo.")]
        public double Altura { get; set; }

        [JsonIgnore]
        public List<HistoricoCorrida>? Historico { get; set; }
    }
}

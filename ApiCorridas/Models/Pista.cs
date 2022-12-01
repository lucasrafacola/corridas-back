using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace ApiCorridas.Models
{
    public class Pista
    {
        [Key]
        [JsonIgnore]
        public int Id { get; set; }

        [Required(ErrorMessage = "Descricao não pode ser nulo.")]
        public string? Descricao { get; set; }

        [JsonIgnore]
        public List<HistoricoCorrida>? Historico { get; set; }
    }
}

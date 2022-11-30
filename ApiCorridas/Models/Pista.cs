using System.ComponentModel.DataAnnotations;

namespace ApiCorridas.Models
{
    public class Pista
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Descricao não pode ser nulo.")]
        public string? Descricao { get; set; }

        public List<HistoricoCorrida>? Historico { get; set; }
    }
}

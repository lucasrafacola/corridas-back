using System.ComponentModel.DataAnnotations;

namespace ApiCorridas.Models
{
    public class HistoricoCorrida
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "CompetidorId não pode ser nulo.")]
        public int CompetidorId { get; set; }

        [Required(ErrorMessage = "PistaId não pode ser nulo.")]
        public int PistaId { get; set; }

        public Competidor? Competidor { get; set; }
        public Pista? Pista { get; set; }

        [Required(ErrorMessage = "DataCorrida não pode ser nulo.")]
        public DateTime DataCorrida { get; set; }

        [Required(ErrorMessage = "TempoGasto não pode ser nulo.")]
        public double TempoGasto { get; set; }
    }
}

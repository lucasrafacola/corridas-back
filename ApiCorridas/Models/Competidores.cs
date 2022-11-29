﻿using System.ComponentModel.DataAnnotations;

namespace ApiCorridas.Models
{
    public class Competidores
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Nome não pode ser nulo.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Sexo não pode ser nulo.")]
        public char Sexo { get; set; }

        [Required(ErrorMessage = "TempMedCorpo não pode ser nulo.")]
        public decimal TempMedCorpo { get; set; }

        [Required(ErrorMessage = "Peso não pode ser nulo.")]
        public decimal Peso { get; set; }

        [Required(ErrorMessage = "Altura não pode ser nulo.")]
        public decimal Altura { get; set; }
    }
}

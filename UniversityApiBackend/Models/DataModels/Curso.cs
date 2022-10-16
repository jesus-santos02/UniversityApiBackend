using System.ComponentModel.DataAnnotations;

namespace UniversityApiBackend.Models.DataModels
{
    public class Curso : BaseEntity
    {
        [Required]
        public string Nombre { get; set; } = string.Empty;
        [Required, StringLength(280)]
        public string DescripcionCorta { get; set; } = string.Empty;
        public string DescripcionLarga { get; set; } = string.Empty;
        public string PublicoObjetivo { get; set; } = string.Empty;
        public List<string> Objetivos { get; set; } = new List<string>();
        public List<string> Requisitos { get; set; } = new List<string>();
        public Nivel Nivel { get; set; }

    }

    public enum Nivel
    {
        Basico,
        Intermedio,
        Avanzado
    }
}

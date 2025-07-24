using System.ComponentModel.DataAnnotations;

namespace Desafio1_DES.Models
{
    public class Departamento
    {
        [Key]
        public int Codigo { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 3)]
        public string Nombre { get; set; } = string.Empty;

        public string? Descripcion { get; set; }
    }
}

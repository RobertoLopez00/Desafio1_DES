using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Desafio1_DES.Models
{
    public class Empleado
    {
        [Key]
        public int Codigo { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 2)]
        public string Nombre { get; set; } = string.Empty;

        [Required]
        [DataType(DataType.Date)]
        [DisplayName("Fecha de nacimiento")]
        public DateTime FechaNacimiento { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayName("Fecha de contratacion")]
        public DateTime FechaContratacion { get; set; }

        [Required]
        public int DepartamentoId { get; set; }

        public Departamento? Departamento { get; set; }

        [Required]
        [Range(0.01, double.MaxValue, ErrorMessage = "El salario debe ser mayor que cero.")]
        public decimal Salario { get; set; }

        public string? Descripcion { get; set; }
    }
}

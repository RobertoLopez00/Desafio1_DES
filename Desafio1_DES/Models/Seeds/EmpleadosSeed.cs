using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Desafio1_DES.Models.Seeds
{
    public class EmpleadosSeed: IEntityTypeConfiguration<Empleado>
    {
        public void Configure(EntityTypeBuilder<Empleado> builder)
        {
            builder.HasData(
                new Empleado { Codigo = 1, Nombre = "John Doe", FechaNacimiento = new DateTime(1985,05,20), FechaContratacion = new DateTime(2010,08,15), Salario = 50000, DepartamentoId = 1},
                new Empleado { Codigo = 2, Nombre = "Jane Smith", FechaNacimiento = new DateTime(1990, 03, 10), FechaContratacion = new DateTime(2015, 01, 25), Salario = 70000, DepartamentoId = 2 },
                new Empleado { Codigo = 3, Nombre = "Mark Johnson", FechaNacimiento = new DateTime(1982, 11, 22), FechaContratacion = new DateTime(2012, 06, 18), Salario = 55000, DepartamentoId = 3 },
                new Empleado { Codigo = 4, Nombre = "Emily Davis", FechaNacimiento = new DateTime(1978, 07, 30), FechaContratacion = new DateTime(2005, 10, 12), Salario = 75000, DepartamentoId = 1 },
                new Empleado { Codigo = 5, Nombre = "Michael Brown", FechaNacimiento = new DateTime(1995, 12, 05), FechaContratacion = new DateTime(2020, 04, 15), Salario = 60000, DepartamentoId = 2 }
            );
        }
    }
}

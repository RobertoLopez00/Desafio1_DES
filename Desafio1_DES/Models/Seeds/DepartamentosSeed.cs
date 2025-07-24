using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Desafio1_DES.Models.Seeds
{
    public class DepartamentosSeed: IEntityTypeConfiguration<Departamento>
    {
        public void Configure(EntityTypeBuilder<Departamento> builder)
        {
            builder.HasData(
                new Departamento { Codigo = 1, Nombre = "Recursos Humanos" },
                new Departamento { Codigo = 2, Nombre = "Tecnología" },
                new Departamento { Codigo = 3, Nombre = "Ventas" }
            );
        }
    }
}

using Desafio1_DES.Models.Seeds;
using Microsoft.EntityFrameworkCore;

namespace Desafio1_DES.Models
{
    public class Desafio1DBContext : DbContext
    {
        public Desafio1DBContext(DbContextOptions<Desafio1DBContext> options) : base(options)
        {
        }
        public DbSet<Empleado> Empleados { get; set; }
        public DbSet<Departamento> Departamentos { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new EmpleadosSeed());
            modelBuilder.ApplyConfiguration(new DepartamentosSeed());
            base.OnModelCreating(modelBuilder);

        }
    }
}

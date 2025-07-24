using Microsoft.EntityFrameworkCore;
//using Desafio1_DES.Models.Seeds;

namespace Desafio1_DES.Models
{
    public class Desafio1DBContext : DbContext
    {
        public Desafio1DBContext(DbContextOptions<Desafio1DBContext> options) : base(options)
        {
        }
        public DbSet<Empleado> Empleados { get; set; }
        public DbSet<Departamento> Departamentos { get; set; }
        /*protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.ApplyConfiguration(new EmpleadoSeed());
            //modelBuilder.ApplyConfiguration(new DepartamentoSeed());
            base.OnModelCreating(modelBuilder);

        }*/
    }
}

using Microsoft.EntityFrameworkCore;
using WebApiEstacionamiento.Entidades;

namespace WebApiEstacionamiento
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext (DbContextOptions options) : base(options)
        {
        }

        public DbSet<Estacionamiento> Estacionamientos { get; set; }
    }
}

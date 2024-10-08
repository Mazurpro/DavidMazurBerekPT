using DavidMazurBerek.Models;
using System.Data.Entity;

namespace DavidMazurBerek.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Persona> Personas { get; set; }
    }
}

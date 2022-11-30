using ApiCorridas.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiCorridas.Repository
{
    public class APIDbContext : DbContext
    {
        public APIDbContext(DbContextOptions<APIDbContext> options)
            : base(options) { }

        public DbSet<Competidor>? Competidores { get; set; }

        public DbSet<Pista>? Pistas { get; set; }

        public DbSet<HistoricoCorrida>? HistoricoCorridas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
    }
}

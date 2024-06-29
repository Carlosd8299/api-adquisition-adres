using AdresAdquisition.Domain.Entities;
using AdresAdquisition.Infraestructure.DataAccess.Seed;
using AdresAdquisition.Infraestructure.Models;
using Microsoft.EntityFrameworkCore;

namespace AdresAdquisition.Infraestructure.DataAccess
{
    public class AdresContext : DbContext
    {
        public virtual DbSet<LogHistorico> LogHistoricos { get; set; }
        public virtual DbSet<Adquisicion> Adquisiciones { get; set; }
        public AdresContext(DbContextOptions<AdresContext> options)
: base(options)
        {

        }

        //    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //=> optionsBuilder.UseSqlServer("Server=tcp:adrescloudserver.database.windows.net,1433;Initial Catalog=DBAdresApi;Persist Security Info=False;User ID=Carlosdlc;Password=Adres2025*;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AdquisicionSeed());

            base.OnModelCreating(modelBuilder);
        }
    }
}

using AdresAdquisition.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AdresAdquisition.Infraestructure.DataAccess.Seed
{
    internal class AdquisicionSeed : IEntityTypeConfiguration<Adquisicion>
    {
        public void Configure(EntityTypeBuilder<Adquisicion> builder)
        {
            // Insertar registros iniciales
            builder.HasData(
                new Adquisicion(1000, "Unidad 1", "Bien 1", 1, 1000, 1000, DateTime.UtcNow, "Proveedor1", "Docu1"),
                new Adquisicion(2000, "Unidad 2", "Bien 2", 2, 1000, 1000, DateTime.UtcNow, "Proveedor1", "Docu1"),
                new Adquisicion(3000, "Unidad 3", "Bien 3", 3, 1000, 1000, DateTime.UtcNow, "Proveedor1", "Docu1"),
                new Adquisicion(4000, "Unidad 4", "Bien 4", 4, 1000, 1000, DateTime.UtcNow, "Proveedor1", "Docu1"),
                new Adquisicion(5000, "Unidad 5", "Bien 5", 5, 1000, 1000, DateTime.UtcNow, "Proveedor1", "Docu1"),
                new Adquisicion(6000, "Unidad 6", "Bien 6", 4, 1000, 1000, DateTime.UtcNow, "Proveedor1", "Docu1")
            );
        }
    }
}

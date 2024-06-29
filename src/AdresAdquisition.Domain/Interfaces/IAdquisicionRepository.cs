using AdresAdquisition.Domain.Entities;

namespace AdresAdquisition.Domain.Interfaces
{
    public interface IAdquisicionRepository
    {
        public Task<List<Adquisicion>> ObtenerTodo();
        public Task<Adquisicion> ObtenerPorId(int id);
        public Task<Adquisicion> Crear(Adquisicion adquisicion);
        public Task<Adquisicion> Actualizar(Adquisicion adquisicion);
        public Task<bool> Desactivar(int adquisicion);

    }
}

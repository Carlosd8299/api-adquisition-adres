using AdresAdquisition.Domain.Entities;
using AdresAdquisition.Domain.Interfaces;
using AdresAdquisition.Infraestructure.DataAccess;
using AdresAdquisition.Infraestructure.ErrorHandling.Exceptions;
using Microsoft.EntityFrameworkCore;

namespace AdresAdquisition.Infraestructure.Repositories
{
    public class AdquisicionRepository : IAdquisicionRepository
    {
        private AdresContext _adresContext { get; set; }

        public AdquisicionRepository(AdresContext adresContext)
        {
            _adresContext = adresContext;
        }

        public async Task<Adquisicion> Actualizar(Adquisicion adquisicion)
        {
            try
            {
                var response = this._adresContext.Adquisiciones.Update(adquisicion);
                await _adresContext.SaveChangesAsync();
                return adquisicion;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public async Task<Adquisicion> Crear(Adquisicion adquisicion)
        {
            try
            {
                var response = await this._adresContext.Adquisiciones.AddAsync(adquisicion);
                await _adresContext.SaveChangesAsync();
                return adquisicion;
            }
            catch (Exception ex)
            {
                throw new InfraestructureException("No se pudo guardar el producto");
            }
        }

        public async Task<bool> Desactivar(int adquisicion)
        {
            try
            {
                var response = await this._adresContext.Adquisiciones.Where(r => r.Id == adquisicion).FirstOrDefaultAsync();

                if (response is not null)
                {
                    response.SetEstado(false);
                    await _adresContext.SaveChangesAsync();
                    return true;
                }
                else
                {
                    throw new NotFoundException("No se encontro el producto a eliminar");
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public async Task<Adquisicion> ObtenerPorId(int id)
        {
            return await _adresContext.Adquisiciones.FindAsync(id);
        }

        public async Task<List<Adquisicion>> ObtenerTodo()
        {
            return await _adresContext.Adquisiciones.Where(a => a.Estado == true).ToListAsync();
        }
    }
}

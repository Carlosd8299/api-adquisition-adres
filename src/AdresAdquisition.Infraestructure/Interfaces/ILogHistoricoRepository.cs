using AdresAdquisition.Infraestructure.Models;

namespace AdresAdquisition.Infraestructure.Interfaces
{
    public interface ILogHistoricoRepository
    {
        public Task Crear(LogHistorico log);
        public Task<IEnumerable<LogHistorico>> Consultar(DateTime date);
    }
}

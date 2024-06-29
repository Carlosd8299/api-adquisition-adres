using AdresAdquisition.Infraestructure.DataAccess;
using AdresAdquisition.Infraestructure.Interfaces;
using AdresAdquisition.Infraestructure.Models;

namespace AdresAdquisition.Infraestructure.Repositories
{
    public class LogHistoricoRepository : ILogHistoricoRepository
    {

        private AdresContext _adresContext { get; set; }

        public LogHistoricoRepository(AdresContext adresContext)
        {
            _adresContext = adresContext;
        }

        public Task<IEnumerable<LogHistorico>> Consultar(DateTime date)
        {
            throw new NotImplementedException();
        }

        public Task Crear(LogHistorico log)
        {
            throw new NotImplementedException();
        }
    }
}

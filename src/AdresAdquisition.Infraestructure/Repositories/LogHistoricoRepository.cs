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

        public async Task<List<LogHistorico>> Consultar(DateTime date)
        {
            return _adresContext.LogHistoricos.Where(a => a.Date >= date).ToList();
        }

        public async Task Crear(LogHistorico log)
        {
            _adresContext.LogHistoricos.Add(log);
        }
    }
}

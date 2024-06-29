using AdresAdquisition.Infraestructure.Models.Enums;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace AdresAdquisition.Infraestructure.Models
{
    public class LogHistorico
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; private set; }
        public DateTime Date { get; private set; }
        public string Message { get; private set; }
        public string User { get; private set; }
        public Events Event { get; private set; }

        public LogHistorico(string message, string user, Events @event)
        {
            Date = DateTime.UtcNow;
            Message = message;
            User = user;
            Event = @event;
        }
    }
}

using JustSell.Data.Entities.Base;
using Microsoft.Extensions.Logging;

namespace JustSell.Data.Entities
{
    public class LogEntry : BaseEntity
    {
        public LogLevel LogLevel { get; set; }
        public string Message { get; set; } 
    }
}

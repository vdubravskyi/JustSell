using JustSell.Data;
using Microsoft.Extensions.Logging;

namespace JustSell.DatabaseLogger
{
    public class DatabaseLoggerProvider : ILoggerProvider
    {
        private readonly MainDBContext _context;

        public DatabaseLoggerProvider(MainDBContext context)
        {
            _context = context;
        }

        public ILogger CreateLogger(string categoryName)
        {
            return new DatabaseLogger(_context);
        }

        public void Dispose()
        {
        }
    }
}

using JustSell.Data;
using JustSell.Data.Entities;
using Microsoft.Extensions.Logging;
using System;
using System.Diagnostics;

namespace JustSell.DatabaseLogger
{
    public class DatabaseLogger : ILogger
    {
        private readonly MainDBContext _context;

        public DatabaseLogger(MainDBContext context)
        {
            _context = context;
        }

        public IDisposable BeginScope<TState>(TState state)
        {
            return null;
        }

        public bool IsEnabled(LogLevel logLevel)
        {
            return true;
        }

        public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception exception, Func<TState, Exception, string> formatter)
        {
            if (formatter != null)
            {
                _context.LogEntries.Add(new LogEntry
                {
                    Id = new Guid(),
                    CreationDate = DateTime.Now,
                    ModifyingDate = DateTime.Now,
                    LogLevel = logLevel,
                    Message = formatter(state, exception)
                });

                _context.SaveChanges();
            }
        }
    }
}

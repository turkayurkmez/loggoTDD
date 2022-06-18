using Microsoft.Extensions.Logging;
using System;

namespace Catalog.Tests
{
    public class DummyLogging : ILogger
    {
        /*
         * Dummy objelerde void'ler boştur ve diğerleri varsayılan değerleri döndürür.
         */
        public IDisposable BeginScope<TState>(TState state)
        {
            return null;
        }

        public bool IsEnabled(LogLevel logLevel)
        {
            return false;
        }

        public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception? exception, Func<TState, Exception?, string> formatter)
        {

        }
    }
}

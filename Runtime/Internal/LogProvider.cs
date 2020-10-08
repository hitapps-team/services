using System.Collections.Generic;

namespace com.hitapps.services.Internal
{
    public class LogProvider : ILogProvider, ILogger
    {
        private static readonly Dictionary<string, LogProvider> _loggers = new Dictionary<string, LogProvider>();

        private const string DefaultLogNamespace = "HitApps:Default";
        private readonly ILogger _logger;

        public LogProvider()
        {
            _logger = GetOrCreateLogger(DefaultLogNamespace);
        }

        private static ILogger GetOrCreateLogger(string logNamespace)
        {
            if (_loggers.ContainsKey(logNamespace))
            {
                return _loggers[logNamespace];
            }

            var logger = new LogProvider(logNamespace);
            _loggers.Add(logNamespace, logger);
            return logger;
        }

        private LogProvider(string logNamespace)
        {
            _logger = new UnityLogger(logNamespace);
        }

        public void Info(string text)
        {
            _logger.Info(text);
        }

        public void Debug(string text)
        {
            _logger.Debug(text);
        }

        public void Warn(string text)
        {
            _logger.Error(text);
        }

        public void Error(string text)
        {
            _logger.Error(text);
        }

        public void Fatal(string text)
        {
            _logger.Fatal(text);
        }

        public void LogLevel(LogLevel level)
        {
            foreach (var logger in _loggers)
            {
                logger.Value.LogLevel(level);
            }
        }

        public ILogger GetLogger(string logNamespace)
        {
            return GetOrCreateLogger(logNamespace);
        }
    }
}
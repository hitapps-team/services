using System;

namespace com.hitapps.services.Internal
{
    internal class UnityLogger : ILogger
    {
        private readonly string _prefix;

        public UnityLogger(string logNamespace, LogLevel level = LogLevel.Info)
        {
            _prefix = $"[{logNamespace}]";
        }

        public void Debug(string text)
        {
            Log(text, LogLevel.Debug);
        }

        public void Warn(string text)
        {
            Log(text, LogLevel.Warn);
        }

        public void Error(string text)
        {
            Log(text, LogLevel.Error);
        }

        public void Fatal(string text)
        {
            Log(text, LogLevel.Fatal);
        }

        public void Info(string text)
        {
            Log(text, LogLevel.Info);
        }

        private void Log(string text, LogLevel level)
        {
            switch (level)
            {
                case LogLevel.Info:
                case LogLevel.Debug:
                    UnityEngine.Debug.Log($"{_prefix} : {text}");
                    break;
                case LogLevel.Warn:
                    UnityEngine.Debug.LogWarning($"{_prefix} : {text}");
                    break;
                case LogLevel.Error:
                case LogLevel.Fatal:
                    UnityEngine.Debug.LogError($"{_prefix} : {text}");
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(level), level, null);
            }
        }
    }
}
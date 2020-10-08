namespace com.hitapps.services
{
    public enum LogLevel
    {
        Debug = 0,
        Info = 10,
        Warn = 100,
        Error = 1000,
        Fatal = 10000
    }

    public interface ILogger
    {
        void Info(string text);
        void Debug(string text);
        void Warn(string text);
        void Error(string text);
        void Fatal(string text);
    }
}
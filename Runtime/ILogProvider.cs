namespace com.hitapps.services
{
    public interface ILogProvider
    {
        void LogLevel(LogLevel level);
        ILogger GetLogger(string logNamespace);
    }
}
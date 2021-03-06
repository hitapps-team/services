namespace com.hitapps.services
{
    public interface IServiceProvider
    {
        void SetCrashlytics<T>(T service) where T : ICrashlyticsService;

        void SetAnalytics<T>(T service) where T : IAnalyticsService;

        void SetAdService<T>(T service) where T : IAdService;
        void SetupLogProvider(ILogProvider logProvider);

        void SetSerializer(ISerializer serializer);
        IConfigProvider Config { get; }
        ISerializer StringSerializer { get; }
        ILogProvider LogProvider { get; }
        IAdService Ads { get; }
        IAnalyticsService Analytics { get; }
        ICrashlyticsService Crashlytics { get; }
    }
}
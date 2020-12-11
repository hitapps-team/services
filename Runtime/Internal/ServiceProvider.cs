using System.Runtime.InteropServices;
using com.hitapps.services.Stub;

namespace com.hitapps.services.Internal
{
    internal class ServiceProvider : IServiceProvider
    {
        private readonly IConfigProvider _provider = new ConfigProvider();
        
        private ICrashlyticsService _crashlytics = new CrashlyticsStub();
        private static IAnalyticsService _analytics = new AnalyticsStub();
        private IAdService _ad = new AdServiceStub();
        private ILogProvider _logs = new LogProvider();
        private ISerializer _serializer = new UnitySerializer();

        public IAnalyticsService Analytics => _analytics;
        public ICrashlyticsService Crashlytics => _crashlytics;
        public ILogProvider LogProvider => _logs;
        public ISerializer StringSerializer => _serializer;
        public IAdService Ads => _ad;
        public IConfigProvider Config => _provider;

        public void SetCrashlytics<T>(T service) where T : ICrashlyticsService
        {
            _crashlytics = service;
        }

        public void SetAnalytics<T>(T service) where T : IAnalyticsService
        {
            _analytics = service;
        }

        public void SetSerializer(ISerializer serializer)
        {
            _serializer = serializer;
        }

        public void SetAdService<T>(T service) where T : IAdService
        {
            _ad = service;
        }

        public void SetupLogProvider(ILogProvider logProvider)
        {
            _logs = logProvider;
        }
    }
}
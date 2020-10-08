using System.Runtime.InteropServices;
using com.hitapps.services.Stub;

namespace com.hitapps.services.Internal
{
    internal class ServiceProvider : IServiceProvider
    {
        private ICrashlyticsService _crashlytics = new CrashlyticsStub();
        private static IAnalyticsService _analytics = new AnalyticsStub();
        private IAdService _ad = new AdServiceStub();
        private ILogProvider _logs = new LogProvider();

        public IAnalyticsService Analytics => _analytics;
        public ICrashlyticsService Crashlytics => _crashlytics;
        public ILogProvider LogProvider => _logs;
        public IAdService Ads => _ad;
        public IConfigProvider Config { get; } = new ConfigProvider();

        public void SetCrashlytics<T>(T service) where T : ICrashlyticsService
        {
            _crashlytics = service;
        }

        public void SetAnalytics<T>(T service) where T : IAnalyticsService
        {
            _analytics = service;
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
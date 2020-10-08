using com.hitapps.services.Internal;

namespace com.hitapps.services
{
    public static class HitappsServices
    {
        private static IServiceProvider _provider = new ServiceProvider();
        public static IServiceProvider Get => _provider;
    }
}
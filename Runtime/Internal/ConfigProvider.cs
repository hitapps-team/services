using com.hitapps.services;
using com.hitapps.services.Stub;

namespace com.hitapps.services.Internal
{
    internal class ConfigProvider : HitappsServiceBase, IConfigProvider
    {
        public IConfigLoader<T> ConfigLoader<T>()
        {
            return Stub.ConfigLoader<T>.I;
        }
    }
}
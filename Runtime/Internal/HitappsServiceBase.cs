namespace com.hitapps.services.Internal
{
    public abstract class HitappsServiceBase : IService
    {
        protected ILogger Log => HitappsServices.Get.LogProvider.GetLogger(GetType().Name);
    }
}
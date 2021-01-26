using System;
using UnityEngine;

namespace com.hitapps.services.Stub
{
    public class UnityResourceLoader<T> : AsyncObserver<T>, IManifestLoader<T>
    {
        private readonly string _resourcePath;
        private static ILogger Log => HitappsServices.Get.LogProvider.GetLogger("com.hitapps.modules.configs.http");
        private static readonly ISerializer Serializer = HitappsServices.Get.StringSerializer;
        private IObserver<T> _observer;

        public UnityResourceLoader(string resourcePath)
        {
            _resourcePath = resourcePath;
        }

        public IObservable<T> LoadManifest()
        {
            try
            {
                var json = Resources.Load<TextAsset>(_resourcePath);
                SetValue(Serializer.Deserialize<T>(json.text));
            }
            catch (Exception e)
            {
                SendError(e);
            }

            return this;
        }

        private void SendError(Exception exception)
        {
            _observer.OnError(exception);
            _observer.OnCompleted();
        }

        public override void Dispose()
        {
        }
    }
}
using System;

namespace com.hitapps.services
{
    public interface IManifestLoader<out T> : IDisposable
    {
        IObservable<T> LoadManifest();
    }
}
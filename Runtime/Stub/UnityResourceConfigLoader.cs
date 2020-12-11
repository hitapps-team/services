using System;
using com.hitapps.services;
using UnityEngine;
using ILogger = com.hitapps.services.ILogger;

public class ResourceConfigLoader<T> : IManifestLoader<T>, IObservable<T>, IDisposable
{
    private readonly string _resourcePath;
    private static ILogger Log => HitappsServices.Get.LogProvider.GetLogger("com.hitapps.modules.configs.http");
    private static readonly ISerializer Serializer = HitappsServices.Get.StringSerializer;
    private IObserver<T> _observer;

    public ResourceConfigLoader(string resourcePath)
    {
        _resourcePath = resourcePath;
    }

    public IObservable<T> LoadManifest()
    {
        try
        {
            var json = Resources.Load<TextAsset>(_resourcePath);
            var config = Serializer.Deserialize<T>(json.text);
            _observer.OnNext(config);
            _observer.OnCompleted();
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

    public IDisposable Subscribe(IObserver<T> observer)
    {
        _observer = observer;
        return this;
    }

    public void Dispose()
    {
    }
}
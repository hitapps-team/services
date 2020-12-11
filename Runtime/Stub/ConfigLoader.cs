using System;
using UniRx;

namespace com.hitapps.services.Stub
{
    /// <summary>
    /// Default configurations loader. 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    internal class ConfigLoader<T> : IConfigLoader<T>, IDisposable
    {
        private static readonly ILogger Log = HitappsServices.Get.LogProvider.GetLogger("com.hitapps.configs");
        private IManifestLoader<T> _customLoader;
        private Func<T> _defaultConfig;

        private static ConfigLoader<T> _i;
        public static ConfigLoader<T> I => _i ?? (_i = new ConfigLoader<T>());

        private ConfigLoader()
        {
        }

        public IObservable<T> LoadConfig()
        {
            var loader = new Loader<T>();
            try
            {
                _customLoader.LoadManifest().Subscribe(
                    complete => { loader.Send(complete); },
                    error =>
                    {
                        Log.Warn($"Error loading default config. Loading local \n  {error}");
                        loader.Send(_defaultConfig.Invoke());
                    }
                );
            }
            catch
            {
                Log.Warn("Can not load default config. Loading local!");
                loader.Send(_defaultConfig.Invoke());
            }

            return loader;
        }


        public void RegisterCustomLoader(IManifestLoader<T> loader)
        {
            _customLoader = loader;
        }

        public void SetDefaultConfig(Func<T> config)
        {
            _defaultConfig = config;
        }

        public void Dispose()
        {
            _customLoader?.Dispose();
        }
    }

    internal class Loader<T> : IObservable<T>, IDisposable
    {
        private IObserver<T> _observer;

        public void Send(T config)
        {
            _observer.OnNext(config);
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
}
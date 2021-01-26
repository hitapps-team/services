using System;
using UniRx;

namespace com.hitapps.services.Stub
{
    /// <summary>
    /// Default configurations loader. 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    internal class ConfigAsyncObserver<T> : AsyncObserver<T>, IConfigLoader<T>, IDisposable
    {
        private static readonly ILogger Log = HitappsServices.Get.LogProvider.GetLogger("com.hitapps.configs");
        private IManifestLoader<T> _customLoader;
        private Func<T> _defaultConfig;

        private static ConfigAsyncObserver<T> _i;
        public static ConfigAsyncObserver<T> I => _i ?? (_i = new ConfigAsyncObserver<T>());

        private ConfigAsyncObserver()
        {
        }

        public IObservable<T> LoadConfig()
        {
            try
            {
                _customLoader.LoadManifest().Subscribe(
                    complete => { SetValue(complete); },
                    error =>
                    {
                        Log.Warn($"Error loading default config. Loading local \n  {error}");
                        SetValue(_defaultConfig.Invoke());
                    }
                );
            }
            catch
            {
                Log.Warn("Can not load default config. Loading local!");
                SetValue(_defaultConfig.Invoke());
            }

            return this;
        }


        public void RegisterCustomLoader(IManifestLoader<T> loader)
        {
            _customLoader = loader;
        }

        public void SetDefaultConfig(Func<T> config)
        {
            _defaultConfig = config;
        }

        public override void Dispose()
        {
            _customLoader?.Dispose();
        }
    }
}
using System;

namespace com.hitapps.services
{
    /// <summary>
    /// Configuration loader.
    /// Wraps configuration loading cycle.
    /// When we have built-in config and also want to use configuration updates from external web-storage.
    /// </summary>
    /// <typeparam name="T">Result type</typeparam>
    public interface IConfigLoader<T> 
    {
        /// <summary>
        /// Starts config loading cycle.
        /// </summary>
        /// <returns>Observable T result</returns>
        IObservable<T> LoadConfig();
        /// <summary>
        /// Define custom config loader.It  will be called first.
        /// </summary>
        /// <param name="loader"></param>
        void RegisterCustomLoader(IManifestLoader<T> loader);
        /// <summary>
        /// Set default config loading Func<T>.
        /// Using Func<T> because we do not need to load it if custom configs was already loaded
        /// </summary>
        /// <param name="config">Call this func if CustomLoader was not defined or nothing was loaded</param>
        void SetDefaultConfig(Func<T> config);
    }
}
namespace com.hitapps.services
{
    /// <summary>
    /// Configuration loaders provider.
    /// </summary>
    public interface IConfigProvider
    {
        /// <summary>
        /// Returns config loader
        /// </summary>
        /// <typeparam name="T">Returned config type (f.e. GameConfig)</typeparam>
        /// <returns>Configuration loader</returns>
        IConfigLoader<T> ConfigLoader<T>();
    }
}
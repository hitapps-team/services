using System;

namespace com.hitapps.services
{
    /// <summary>
    /// Describes any crashlytics Api service.
    /// </summary>
    public interface ICrashlyticsService
    {
        /// <summary>
        /// Initialize Api service
        /// </summary>
        void Init(Action callOnInit);

        /// <summary>
        /// Throws Uncaught by Api service exception (test method)
        /// </summary>
        void ThrowUncaughtException();

        /// <summary>
        /// Throws exception to be caught and logged by Api service
        /// </summary>
        void LogCaughtException();

        /// <summary>
        /// Write custom log to Api service
        /// </summary>
        /// <param name="text">Custom log text</param>
        void WriteCustomLog(string text);

        /// <summary>
        /// Set custom key-value param to Api service
        /// </summary>
        /// <param name="key">Param key</param>
        /// <param name="value">Param value</param>
        void SetCustomKey(string key, string value);

        /// <summary>
        /// Set user id to Api service
        /// </summary>
        /// <param name="id">User id</param>
        void SetUserID(string id);
    }
}
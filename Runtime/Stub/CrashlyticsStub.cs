using System;
using com.hitapps.services.Internal;

namespace com.hitapps.services.Stub
{
    /// <summary>
    /// Default crashlytics implementation.
    /// Usi
    /// </summary>
    internal class CrashlyticsStub : HitappsServiceBase, ICrashlyticsService
    {
        public void Init(Action doOnInit)
        {
            Log.Debug("Crashlytics was initialized");
            doOnInit();
        }

        public void ThrowUncaughtException()
        {
            Log.Debug("Crashlytics uncaught exception");
        }

        public void LogCaughtException()
        {
            Log.Debug("Crashlytics caught exception");
        }

        public void WriteCustomLog(string text)
        {
            Log.Debug($"Crashlytics custom log {text}");
        }

        public void SetCustomKey(string key, string value)
        {
            Log.Debug($"Crashlytics set custom key : {key} / {value}");
        }

        public void SetUserID(string id)
        {
            Log.Debug($"Crashlytics set user id {id}");
        }
    }
}
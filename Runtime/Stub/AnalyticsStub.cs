using System;
using System.Threading.Tasks;
using com.hitapps.services.Internal;
using com.hitapps.services.data;

namespace com.hitapps.services.Stub
{
    /// <summary>
    /// Stub class for analytics
    /// Writes all analytics event to log using default logging service; 
    /// </summary>
    internal class AnalyticsStub : HitappsServiceBase, IAnalyticsService
    {
        public bool Initialised => true;

        public void Init(Action onInit)
        {
            onInit?.Invoke();
        }

        public void SetSessionTimeoutDuration(TimeSpan timeSpan)
        {
            throw new NotImplementedException();
        }

        public void SetAnalyticsCollectionEnabled(bool enabled)
        {
            throw new NotImplementedException();
        }

        public void LogEvent(string name, string parameterName, string parameterValue)
        {
            throw new NotImplementedException();
        }

        public void LogEvent(string name, string parameterName, double parameterValue)
        {
            throw new NotImplementedException();
        }

        public void LogEvent(string name, string parameterName, long parameterValue)
        {
            throw new NotImplementedException();
        }

        public void LogEvent(string name, string parameterName, int parameterValue)
        {
            throw new NotImplementedException();
        }

        public void LogEvent(string name)
        {
            throw new NotImplementedException();
        }

        public void SetUserProperty(string name, string property)
        {
            throw new NotImplementedException();
        }

        public void SetUserId(string userId)
        {
            throw new NotImplementedException();
        }

        public void SetCurrentScreen(string screenName, string screenClass)
        {
            throw new NotImplementedException();
        }

        public void ResetAnalyticsData()
        {
            throw new NotImplementedException();
        }

        public Task<string> GetAnalyticsInstanceIdAsync()
        {
            throw new NotImplementedException();
        }

        public void LogEvent(string name, params ParameterWrapper[] parameters)
        {
            throw new NotImplementedException();
        }
    }
}
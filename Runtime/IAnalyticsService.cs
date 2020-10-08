using System;
using System.Threading.Tasks;
using com.hitapps.services.data;

namespace com.hitapps.services
{
    /// <summary>
    /// Describes any analytics Api.  
    /// </summary>
    public interface IAnalyticsService : IService
    {
        bool Initialised { get; }
        void Init(Action onInit);
        void SetSessionTimeoutDuration(TimeSpan timeSpan);
        void SetAnalyticsCollectionEnabled(bool enabled);
        void LogEvent(string name, string parameterName, string parameterValue);
        void LogEvent(string name, string parameterName, double parameterValue);
        void LogEvent(string name, string parameterName, long parameterValue);
        void LogEvent(string name, string parameterName, int parameterValue);
        void LogEvent(string name);
        void SetUserProperty(string name, string property);
        void SetUserId(string userId);
        void SetCurrentScreen(string screenName, string screenClass);
        void ResetAnalyticsData();
        Task<string> GetAnalyticsInstanceIdAsync();
        void LogEvent(string name, params ParameterWrapper[] parameters);
    }
}
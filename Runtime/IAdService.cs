using System;
using com.hitapps.services.data;

namespace com.hitapps.services
{
    public enum UnitStatus
    {
        None = 0,
        Requesting = 1,
        Failed = 3,
        Ready = 4
    }

    public interface IAdService : IService
    {
        event Action<string> InterstitialTryToShow;
        event Action<string> RewardedTryToShow;
        event Action<string, bool> InterstitialShown;
        event Action<string, bool> RewardedShown;
        event Action<string,UnitStatus> StatusCnahged;
        bool IsReady(string unitId);
        void Enable();
        void Disable();
        event Action SdkInitialized;
        bool Initialised { get; }
        void Init();
        void ShowBanner<T>(string id, T settings);
        void HideBanner(string id);
        void ShowInterstitial<T>(string id, T settings);
        void ShowRewarded<T>(string id, T settings);
        void ShowBanner(string id);
        void ShowInterstitial(string id);
        void ShowRewarded(string id);
        void RequestBanner(string id);
        void RequestInterstitial(string id);
        void RequestRewarded(string id);
        void LoadConsentDialog();
        void ShowConsentDialog();
        void ForceGdprApplicable();
        void GrantConsent();
        void RevokeConsent();
        void ReportApplicationOpen();
        void EnableLocationSupport(bool enable);
    }
}
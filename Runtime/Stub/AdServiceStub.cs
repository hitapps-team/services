using System;
using com.hitapps.services.data;

namespace com.hitapps.services.Stub
{
    public class AdServiceStub : IAdService
    {
        public event Action<string> InterstitialTryToShow;
        public event Action<string> RewardedTryToShow;
        public event Action<string, bool> InterstitialShown;
        public event Action<string, bool> RewardedShown;
        public event Action<string,UnitStatus> StatusCnahged;

        public bool IsReady(string unitId)
        {
            return true;
        }

        public void Enable()
        {
            throw new NotImplementedException();
        }

        public void Disable()
        {
            throw new NotImplementedException();
        }

        public event Action SdkInitialized;
        public bool Initialised => true;

        public void Init()
        {
            SdkInitialized?.Invoke();
        }

        public void ShowBanner<T>(string id, T settings)
        {
            throw new NotImplementedException();
        }

        public void HideBanner(string id)
        {
            throw new NotImplementedException();
        }

        public void ShowInterstitial<T>(string id, T settings)
        {
            throw new NotImplementedException();
        }

        public void ShowRewarded<T>(string id, T settings)
        {
            throw new NotImplementedException();
        }

        public void ShowBanner(string id)
        {
            throw new NotImplementedException();
        }

        public void ShowInterstitial(string id)
        {
            throw new NotImplementedException();
        }

        public void ShowRewarded(string id)
        {
            throw new NotImplementedException();
        }

        public void RequestBanner(string id)
        {
            throw new NotImplementedException();
        }

        public void RequestInterstitial(string id)
        {
            throw new NotImplementedException();
        }

        public void RequestRewarded(string id)
        {
            throw new NotImplementedException();
        }

        public void LoadConsentDialog()
        {
            throw new NotImplementedException();
        }

        public void ShowConsentDialog()
        {
            throw new NotImplementedException();
        }

        public void ForceGdprApplicable()
        {
            throw new NotImplementedException();
        }

        public void GrantConsent()
        {
            throw new NotImplementedException();
        }

        public void RevokeConsent()
        {
            throw new NotImplementedException();
        }

        public void ReportApplicationOpen()
        {
            throw new NotImplementedException();
        }

        public void EnableLocationSupport(bool enable)
        {
            throw new NotImplementedException();
        }
    }
}
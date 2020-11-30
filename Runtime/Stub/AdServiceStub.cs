using System;

namespace com.hitapps.services.Stub
{
    public class AdServiceStub : IAdService
    {
        public bool BannerReady { get; }
        public bool RewardedReady { get; }
        public bool InterReady { get; }

        public void Run()
        {
            //  throw new NotImplementedException();
        }

        public bool ShowRewardedVideo(string placement, Action<bool> onRewardedShown)
        {
            return false;
        }

        public void ShowInterstitial(string placement, Action call = null)
        {
            // throw new NotImplementedException();
        }

        public void ShowBanner()
        {
            // throw new NotImplementedException();
        }

        public void HideBanner()
        {
            //   throw new NotImplementedException();
        }
    }
}
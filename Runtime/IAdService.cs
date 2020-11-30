using System;

namespace com.hitapps.services
{
    public interface IAdService : IService
    {
        bool BannerReady { get; }
        bool RewardedReady { get; }
        bool InterReady { get; }
        void Run();
        bool ShowRewardedVideo(string placement, Action<bool> onRewardedShown);
        void ShowInterstitial(string placement, Action call = null);
        void ShowBanner();
        void HideBanner();
    }
}
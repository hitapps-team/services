namespace com.hitapps.services.data
{
    public interface IAdsAnalyticsTracker
    {
        void TrackBannerNeeded(string placement);
        void TrackInterNeeded(string placement);
        void TrackRewardedNeeded(string placement);
    }
}
using UnityEngine;

namespace com.hitapps.services
{
    public class HitappsInfo
    {
        public string DeviceOrientation()
        {
            return Input.deviceOrientation.ToString();
        }

        public bool IdfaTrackingIsLimited()
        {
            return false;
        }

        public string DeviceConnectionType()
        {
            return Application.internetReachability.ToString();
        }
    }
}
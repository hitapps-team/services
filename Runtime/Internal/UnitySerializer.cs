using UnityEngine;

namespace com.hitapps.services.Internal
{
    public class UnitySerializer : ISerializer
    {
        public T Deserialize<T>(string val)
        {
            return JsonUtility.FromJson<T>(val);
        }

        public string Serialize<T>(T val)
        {
            return JsonUtility.ToJson(val);
        }
    }
}
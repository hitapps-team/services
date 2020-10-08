namespace com.hitapps.services
{
    public interface ISerializer
    {
        T Deserialize<T>(string val);
        string Serialize<T>(T val);
    }
}
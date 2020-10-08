using System.Collections.Generic;

namespace com.hitapps.services.data
{
    public interface IVersionConfig
    {
        string LevelsMap { get; }
        List<string> Levels { get; }
    }
}
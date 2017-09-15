using Newtonsoft.Json.Linq;

namespace Antares.Stringifiers.Json
{
    public interface IJsonObjectSelector
    {
        // Note: consider to abstract our own JToken
        JToken SelectOne(string jPath);
    }
}

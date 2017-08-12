using Microsoft.Extensions.Configuration;

namespace Antares.Essentials.Configuration
{
    public interface IAppSettings : IConfiguration
    {
        string Get(string key);
    }
}

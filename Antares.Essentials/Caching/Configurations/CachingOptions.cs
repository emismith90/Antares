using Microsoft.Extensions.Configuration;
using Antares.Essentials.Configuration;
using Antares.Essentials.Extensions;

namespace Antares.Essentials.Caching.Configurations
{
    public class CachingOptions : OptionsBase, ICachingOptions
    {
        public CachingOptions(IConfiguration scope) : base(scope)
        {
        }

        public int ExpiredInMinute => GetInt().Default(5);
        public int SlidingInMinute => GetInt().Default(1);

        public int RetryInSecond => GetInt().Default(10);
    }
}

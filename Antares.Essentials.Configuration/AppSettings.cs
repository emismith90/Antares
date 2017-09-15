using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Primitives;

namespace Antares.Essentials.Configuration
{
    public class AppSettings : IAppSettings
    {
        protected IConfiguration Configuration;
        public AppSettings()
        {
            var builder = new ConfigurationBuilder()
               .SetBasePath(Directory.GetCurrentDirectory())
               .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

            Configuration = builder.Build();
        }

        public string this[string key]
        {
            get
            {
                return Configuration[key];
            }
            set
            {
                Configuration[key] = value;
            }
        }

        public string Get(string key)
        {
            return Configuration[key];
        }

        public IEnumerable<IConfigurationSection> GetChildren()
        {
            return Configuration.GetChildren();
        }

        public IChangeToken GetReloadToken()
        {
            return Configuration.GetReloadToken();
        }

        public IConfigurationSection GetSection(string section)
        {
            return Configuration.GetSection(section);
        }
    }
}

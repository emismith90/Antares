using System;
using System.Collections.Generic;
using System.Text;

namespace Antares.GoogleMaps.Geocoding
{
    public class GeocodingQuery : IGeocodingQuery
    {
        public GeocodingQuery(string baseServiceUrl, string apiKey)
        {
            this.BaseServiceUrl = baseServiceUrl;
            this.ApiKey = apiKey;

            this.Params = new Dictionary<string, string>();
        }

        public virtual string ApiKey { get; protected set; }

        public virtual string BaseServiceUrl { get; protected set; }

        public virtual Dictionary<string, string> Params { get; protected set; }
    }
}

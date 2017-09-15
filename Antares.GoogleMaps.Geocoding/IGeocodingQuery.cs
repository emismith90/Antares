using System;
using System.Collections.Generic;
using System.Text;

namespace Antares.GoogleMaps.Geocoding
{
    public interface IGeocodingQuery
    {
        string BaseServiceUrl { get; }
        string ApiKey { get; }

        Dictionary<string, string> Params { get; }
    }
}

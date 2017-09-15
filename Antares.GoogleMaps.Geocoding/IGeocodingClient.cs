using System;
using System.Collections.Generic;
using System.Text;

namespace Antares.GoogleMaps.Geocoding
{
    public interface IGeocodingClient
    {
        IGeocodingQuery FindLocation();
    }
}

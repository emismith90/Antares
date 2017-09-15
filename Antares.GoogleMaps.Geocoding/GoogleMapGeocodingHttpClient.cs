using System.Net.Http;

namespace Antares.GoogleMaps.Geocoding
{
    public sealed class GoogleMapGeocodingHttpClient : HttpClient
    {
        private GoogleMapGeocodingHttpClient()
        {
        }

        public static HttpClient Instance { get { return Nested.instance; } }

        private class Nested
        {
            // Explicit static constructor to tell C# compiler
            // not to mark type as beforefieldinit
            static Nested()
            {
            }

            internal static readonly HttpClient instance = new HttpClient();
        }
    }
}

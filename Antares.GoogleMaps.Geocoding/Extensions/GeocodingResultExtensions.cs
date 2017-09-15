using System.Text;
using Newtonsoft.Json;
using Antares.GoogleMaps.Geocoding.Models;
using System.Threading.Tasks;

namespace Antares.GoogleMaps.Geocoding.Extensions
{
    public static class GeocodingResultExtensions
    {
        public static async Task<string> GetResultAsync(this IGeocodingQuery query)
        {
            return await GoogleMapGeocodingHttpClient.Instance.GetStringAsync(GetRequestUrl(query));
        }

        public static async Task<GeocodingResultLite> GetGeocodingResultAsync(this IGeocodingQuery query)
        {
            var responseAsString = await query.GetResultAsync();
            return JsonConvert.DeserializeObject<GeocodingResultLite>(responseAsString);
        }

        private static string GetRequestUrl(this IGeocodingQuery query)
        {
            var requestBuilder = new StringBuilder(query.BaseServiceUrl);
            requestBuilder = requestBuilder.AppendFormat("?key={0}", query.ApiKey);

            foreach (var param in query.Params)
            {
                requestBuilder = requestBuilder.AppendFormat("&{0}={1}", param.Key, param.Value);
            }

            return requestBuilder.ToString();
        }
    }
}

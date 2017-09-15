using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Antares.GoogleMaps.Geocoding.Enums;

namespace Antares.GoogleMaps.Geocoding.Models
{
    public class GeocodingResultLite
    {
        [JsonProperty("results")]
        public virtual IList<Result> Results { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        [JsonProperty("status")]
        public virtual Status Status { get; set; }
    }
}

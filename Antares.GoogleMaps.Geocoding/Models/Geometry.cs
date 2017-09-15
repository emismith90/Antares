using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Antares.GoogleMaps.Geocoding.Enums;

namespace Antares.GoogleMaps.Geocoding.Models
{
    public class Geometry
    {
        [JsonProperty("location")]
        public virtual Location Location { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        [JsonProperty("location_type")]
        public virtual LocationType LocationType { get; set; }
    }
}

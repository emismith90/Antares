using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Antares.GoogleMaps.Geocoding.Enums;

namespace Antares.GoogleMaps.Geocoding.Models
{
    public class AddressComponent
    {
        [JsonProperty("long_name")]
        public virtual string LongName { get; set; }

        [JsonProperty("short_name")]
        public virtual string ShortName { get; set; }

        [JsonProperty("types", ItemConverterType = typeof(StringEnumConverter))]
        public virtual IList<ResultType> Types { get; set; }
    }
}

using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Antares.GoogleMaps.Geocoding.Enums;

namespace Antares.GoogleMaps.Geocoding.Models
{
    public class Result
    {
        [JsonProperty("address_components")]
        public virtual IList<AddressComponent> AddressComponents { get; set; }

        [JsonProperty("formatted_address")]
        public virtual string FormattedAddress { get; set; }

        [JsonProperty("geometry")]
        public virtual Geometry Geometry { get; set; }

        [JsonProperty("types", ItemConverterType = typeof(StringEnumConverter))]
        public virtual IList<ResultType> Types { get; set; }
    }
}

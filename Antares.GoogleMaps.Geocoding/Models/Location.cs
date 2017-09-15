using Newtonsoft.Json;

namespace Antares.GoogleMaps.Geocoding.Models
{
    public class Location
    {
        public Location() { }
        public Location(double lat, double lng)
        {
            this.Latitude = lat;
            this.Longitude = lng;
        }

        [JsonProperty("lat")]
        public virtual double Latitude { get; set; }

        [JsonProperty("lng")]
        public virtual double Longitude { get; set; }
    }
}

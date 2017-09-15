using System;

namespace Antares.GoogleMaps.Geocoding
{
    public class GoogleMapGeocodingClient : IGeocodingClient
    {
        private string _format = "json";
        //TODO
        //private string _baseUrl = ConfigurationManager.AppSettings["googlemaps:geocoding:serviceUrl"];
        //private string _apiKey = ConfigurationManager.AppSettings["googlemaps:api:key"];
        private string _baseUrl;
        private string _apiKey;
        public virtual string Format { get { return _format; } protected set { _format = value; } }
        public virtual string BaseUrl { get { return _baseUrl; } protected set { _baseUrl = value; } }
        public virtual string ApiKey { get { return _apiKey; } protected set { _apiKey = value; } }

        public GoogleMapGeocodingClient()
        {
        }

        public virtual IGeocodingQuery FindLocation()
        {
            if (string.IsNullOrEmpty(BaseUrl))
            {
                throw new ArgumentException("BaseUrl");
            }

            string template = BaseUrl.EndsWith("/") ? "{0}{1}" : "{0}/{1}";
            var baseUrl = string.Format(template, BaseUrl, Format);

            return new GeocodingQuery(baseUrl, ApiKey);
        }
    }
}

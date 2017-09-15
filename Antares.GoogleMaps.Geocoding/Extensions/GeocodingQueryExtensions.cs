using System;
using Antares.GoogleMaps.Geocoding.Enums;
using Antares.GoogleMaps.Geocoding.Models;

namespace Antares.GoogleMaps.Geocoding.Extensions
{
    public static class GeocodingQueryExtensions
    {
        public static IGeocodingQuery WithAddress(this IGeocodingQuery query, string address)
        {
            query.Params["address"] = address;
            return query;
        }

        public static IGeocodingQuery WithCordinate(this IGeocodingQuery query, Location location)
        {
            query.Params["latlng"] = string.Format("{0},{1}", location.Latitude, location.Longitude);
            return query;
        }

        public static IGeocodingQuery WithLocationType(this IGeocodingQuery query, LocationType locationType)
        {
            query.Params["location_type"] = Enum.GetName(typeof(LocationType), locationType);
            return query;
        }

        public static IGeocodingQuery WithResultType(this IGeocodingQuery query, ResultType resultType)
        {
            query.Params["result_type"] = Enum.GetName(typeof(ResultType), resultType);
            return query;
        }
    }
}

namespace Antares.GoogleMaps.Geocoding.Enums
{
    public enum Status
    {
        /// <summary>
        /// Indicates that no errors occurred; the address was successfully parsed and at least one geocode was returned.
        /// </summary>
        OK,

        /// <summary>
        /// Indicates that the geocode was successful but returned no results. This may occur if the geocoder was passed a non-existent address.
        /// </summary>
        ZERO_RESULTS,

        /// <summary>
        /// Indicates that you are over your quota.
        /// </summary>
        OVER_QUERY_LIMIT,

        /// <summary>
        /// Indicates that your request was denied.
        /// </summary>
        REQUEST_DENIED,

        /// <summary>
        /// Generally indicates that the query (address, components or latlng) is missing.
        /// </summary>
        INVALID_REQUEST,

        /// <summary>
        /// Indicates that the request could not be processed due to a server error. The request may succeed if you try again.
        /// </summary>
        UNKNOWN_ERROR
    }
}

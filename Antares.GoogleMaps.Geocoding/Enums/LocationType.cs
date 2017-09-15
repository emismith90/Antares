namespace Antares.GoogleMaps.Geocoding.Enums
{
    public enum LocationType
    {
        /// <summary>
        /// Indicates that the returned result reflects a precise geocode.
        /// </summary>
        ROOFTOP,

        /// <summary>
        /// Indicates that the returned result reflects an approximation (usually on a road) interpolated between two precise points (such as intersections). 
        /// Interpolated results are generally returned when rooftop geocodes are unavailable for a street address. 
        /// </summary>
        RANGE_INTERPOLATED,

        /// <summary>
        /// Indicates that the returned result is the geometric center of a result such as a polyline (for example, a street) or polygon (region).
        /// </summary>
        GEOMETRIC_CENTER,

        /// <summary>
        /// Indicates that the returned result is approximate
        /// </summary>
        APPROXIMATE
    }
}

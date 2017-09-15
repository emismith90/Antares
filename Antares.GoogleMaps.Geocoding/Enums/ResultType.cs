namespace Antares.GoogleMaps.Geocoding.Enums
{
    public enum ResultType
    {
        /// <summary>
        /// Indicates a first-order civil entity below the country level. 
        /// Within the United States, these administrative levels are states. 
        /// Not all nations exhibit these administrative levels.
        /// </summary>
        ADMINISTRATIVE_AREA_LEVEL_1,

        /// <summary>
        /// Indicates a second-order civil entity below the country level.
        /// </summary>
        ADMINISTRATIVE_AREA_LEVEL_2,

        /// <summary>
        /// Indicates a third-order civil entity below the country level.
        /// </summary>
        ADMINISTRATIVE_AREA_LEVEL_3,

        /// <summary>
        /// Indicates a fourth-order civil entity below the country level.
        /// </summary>
        ADMINISTRATIVE_AREA_LEVEL_4,

        /// <summary>
        /// Indicates a fifth-order civil entity below the country level.
        /// </summary>
        ADMINISTRATIVE_AREA_LEVEL_5,

        /// <summary>
        /// Indicates an airport.
        /// </summary>
        AIRPORT,

        /// <summary>
        /// Indicates the location of a bus stop.
        /// </summary>
        BUS_STATION,

        /// <summary>
        /// indicates an incorporated city or town political entity.
        /// </summary>
        COLLOQUIAL_AREA,

        /// <summary>
        /// Indicates the national political entity, and is typically the highest order type returned by the Geocoder.
        /// </summary>
        COUNTRY,

        /// <summary>
        /// Indicates a place that has not yet been categorized.
        /// </summary>
        ESTABLISHMENT,

        /// <summary>
        /// Indicates the floor of a building address.
        /// </summary>
        FLOOR,

        /// <summary>
        /// Indicates a major intersection, usually of two major roads.
        /// </summary>
        INTERSECTION,

        /// <summary>
        /// Indicates an incorporated city or town political entity.
        /// </summary>
        LOCALITY,

        /// <summary>
        /// Indicates a prominent natural feature.
        /// </summary>
        NATURAL_FEATURE,

        /// <summary>
        /// Indicates a named neighborhood.
        /// </summary>
        NEIGHBORHOOD,

        /// <summary>
        /// Indicates a named park.
        /// </summary>
        PARK,

        /// <summary>
        /// Indicates a parking lot or parking structure.
        /// </summary>
        PARKING,

        /// <summary>
        /// Idicates a named point of interest.
        /// </summary>
        POINT_OF_INTEREST,

        /// <summary>
        /// Indicates a political entity. Usually, this type indicates a polygon of some civil administration.
        /// </summary>
        POLITICAL,

        /// <summary>
        /// Indicates a specific postal box.
        /// </summary>
        POST_BOX,

        /// <summary>
        /// Indicates a postal code as used to address postal mail within the country.
        /// </summary>
        POSTAL_CODE,

        /// <summary>
        /// Indicates a postal code suffix as used to address postal mail within the country.
        /// </summary>
        POSTAL_CODE_SUFFIX,

        /// <summary>
        /// Indicates a grouping of geographic areas, such as locality and sublocality, used for mailing addresses in some countries.
        /// </summary>
        POSTAL_TOWN,

        /// <summary>
        /// Indicates a named location, usually a building or collection of buildings with a common name.
        /// </summary>
        PREMISE,

        /// <summary>
        /// Indicates the room of a building address.
        /// </summary>
        ROOM,

        /// <summary>
        /// Indicates a named route (such as "US 101").
        /// </summary>
        ROUTE,

        /// <summary>
        /// Indicates a precise street address.
        /// </summary>
        STREET_ADDRESS,

        /// <summary>
        /// Indicates the precise street number.
        /// </summary>
        STREET_NUMBER,

        /// <summary>
        /// Indicates a first-order civil entity below a locality. 
        /// For some locations may receive one of the additional types: sublocality_level_1 through to sublocality_level_5. 
        /// Each sublocality level is a civil entity. Larger numbers indicate a smaller geographic area.
        /// </summary>
        SUBLOCALITY,
        SUBLOCALITY_LEVEL_1,
        SUBLOCALITY_LEVEL_2,
        SUBLOCALITY_LEVEL_3,
        SUBLOCALITY_LEVEL_4,
        SUBLOCALITY_LEVEL_5,

        /// <summary>
        /// Indicates a first-order entity below a named location, usually a singular building within a collection of buildings with a common name.
        /// </summary>
        SUBPREMISE,

        /// <summary>
        /// Indicates the location of a train station.
        /// </summary>
        TRAIN_STATION,

        /// <summary>
        /// Indicates the location of a transit station.
        /// </summary>
        TRANSIT_STATION,

        /// <summary>
        /// Indicates an unknown address component type returned by the server.
        /// </summary>
        UNKNOWN
    }
}

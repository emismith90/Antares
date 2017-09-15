**##USAGE**

```java
var location = new Location(1, 1) // lat, lng
var scopes = new[] { ResultType.LOCALITY, ResultType.ADMINISTRATIVE_AREA_LEVEL_1, ResultType.COUNTRY };

var geoClient = new GoogleMapGeocodingClient()
var geoResult = await geoClient.FindLocation()
                    .WithCordinate(location)
                    .WithLocationType(LocationType.APPROXIMATE)
                    .WithResultType(scopes)
                    .GetGeocodingResultAsync();

```
##
Pull-Requests are welcome!

##
The Antares.Stringifiers.Json was developed by [emismith90] under the [MIT license](LICENSE).

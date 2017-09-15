**##USAGE**

```java
var jObject = JObject.Parse(@"{
                          'Name': 'Bad Boys',
                          'ReleaseDate': '1995-4-7T00:00:00',
                          'Genres': [
                            'Action',
                            'Comedy'
                          ]
                        }");

var stringifier = new JsonStringifier(jObject);
var output = stringifier.Stringify("Hello, ${Name}");

// output: Hello, Bad Boys
```
##
Pull-Requests are welcome!

##
The Antares.Stringifiers.Json was developed by [emismith90] under the [MIT license](LICENSE).

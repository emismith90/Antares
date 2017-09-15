using Antares.DesignPatterns.DataFlow.Pipeline;
using Antares.Stringifiers.Json;
using Newtonsoft.Json.Linq;
using System;

namespace Antares.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var jObject = JObject.Parse(@"{'company':{'@attributes':{'duns':'422126034','nip':'5213422006','regon':'140869962','krs':'0000276954','rating':'D'}},'name':{'@attributes':{'id':'1'},'value':'WAPOL WYK\u0141ADZINY OBIEKTOWE SP Z O O'},'address':[{'@attributes':{'id':'1'},'str':'W\u00f3lka Kozodawska, Ul. Polnych Kwiat\u00f3w 17','post_code':'05-502','city':'Piaseczno','prov':'MAZOWIECKIE','district':'piaseczy\u0144ski'},{'@attributes':{'id':'3'},'str':'Ul. Czarnomorska 13\/pok. 8p','post_code':'02-758','city':'Warszawa','prov':'MAZOWIECKIE','district':'M. st. Warszawa'}],'tlcm_nbrs':{'nbr':'48226516913'},'urls':{'www':'http:\/\/www.wykladzinywapol.pl'},'emails':{'eml':'wapol@wykladzinywapol.pl'},'lgl_form':{'@attributes':{'id':'1'},'value':'Sp\u00f3\u0142ka z ograniczon\u0105 odpowiedzialno\u015bci\u0105'},'start_dt':{'year':'2007'},'activity_text':'Pozosta\u0142a sprzeda\u017c hurtowa','pkd':{'@attributes':{'id':'9','code_dtl':'46.90.Z'},'desc_dtl':'Sprzeda\u017c hurtowa niewyspecjalizowana'},'similars':{'similar':[{'@attributes':{'subj':'617901'},'value':'AMBERTECH SP Z O O'},{'@attributes':{'subj':'642245'},'value':'DOLNO\u015aL\u0104SKIE ZAK\u0141ADY PRZEMYS\u0141U CUKIERNICZEGO \u015aNIE\u017bKA SP Z O O'},{'@attributes':{'subj':'646356'},'value':'PROINVEST METAL SP Z O O'}]}}");

            var stringifier = new JsonStringifier(jObject);
            var output2 = stringifier.Stringify("${address}");

            var output = stringifier.Stringify("${address.str}");
        }
    }
}
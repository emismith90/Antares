namespace Antares.Stringifiers.Json
{
    public interface IJsonStringifier
    {
        /* 
         * Parse value inside interpollations: ${path_to_attribute}
         * Parse support 
         * - Formater for numberic and datetime field ${path_to_attribute:formater}. 
         * ex: -> ${datetime:yyyyMMdd} ${numeric:f} 
         * - Fallback ${path_to_primary_att|path_to_fallback_att}
        */
        string Stringify(string format);
    }
}

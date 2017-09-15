using System.Linq;
using System.Text.RegularExpressions;
using Newtonsoft.Json.Linq;

namespace Antares.Stringifiers.Json
{
    public class JPathSimpleProcessor : JPathProcessorBase
    {
        public JPathSimpleProcessor(IJsonObjectSelector selector)
            : base(@"(?<interpollation>\${(?<jpath>([^ }|:])+)\|?(?<jpathfb>([^ }|:])*)})", selector)
        {
        }

        public JPathSimpleProcessor(string regex, IJsonObjectSelector selector)
            : base(regex, selector)
        {
        }

        public override string Process(string format)
        {
            if (string.IsNullOrEmpty(format)) return format;

            var match = Regex.Match(format);

            while (match.Success)
            {
                var interpollation = GetInterpollation(match);
                var value = GetSmartExpressionValue(match, "jpath");
                if (string.IsNullOrEmpty(value))
                {
                    value = GetSmartExpressionValue(match, "jpathfb");
                }

                format = format.Substring(0, interpollation.Index) + value + format.Substring(interpollation.Index + interpollation.Length);

                match = Regex.Match(format);
            }

            return format;
        }

        public virtual Group GetInterpollation(Match match)
        {
            return match.Groups["interpollation"];
        }

        /// <summary>
        /// Return it self if the jpath points to a JObject
        /// Return first child element if the jpath points to a JArray
        /// </summary>
        /// <param name="match"></param>
        /// <returns></returns>
        public virtual string GetSmartExpressionValue(Match match, string jpath)
        {
            var jPath = match.Groups[jpath];
            if (string.IsNullOrEmpty(jPath.Value))
                return string.Empty;

            var jValue = Selector.SelectOne(jPath.Value);
            if (jValue == null)
                return string.Empty;

            var jArray = jValue as JArray;
            if (jArray != null)
            {
                var children = jArray.Children();
                if (children.Any())
                    return children.First().ToString();
            }

            return jValue.ToString();
        }
    }
}

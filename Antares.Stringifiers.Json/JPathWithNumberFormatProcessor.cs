using System;
using System.Text.RegularExpressions;

namespace Antares.Stringifiers.Json
{
    public class JPathWithNumberFormatProcessor : JPathSimpleProcessor
    {
        public JPathWithNumberFormatProcessor(IJsonObjectSelector selector)
            : base(@"(?<interpollation>\${(?<jpath>([^ }|:])+)\|?(?<jpathfb>([^ }|:])*):?(?<formater>([^ }|:])*)})", selector)
        {
        }

        public JPathWithNumberFormatProcessor(string regex, IJsonObjectSelector selector)
            : base(regex, selector)
        {
        }

        public override string GetSmartExpressionValue(Match match, string jpath)
        {
            var raw = base.GetSmartExpressionValue(match, jpath);
            var formater = match.Groups["formater"].Value;
            double number;
            if (!string.IsNullOrEmpty(formater) && double.TryParse(raw, out number))
            {
                return string.Format("{0:" + formater + "}", number);
            }

            DateTime date;
            if (!string.IsNullOrEmpty(formater) && DateTime.TryParse(raw, out date))
            {
                return date.ToString(formater);
            }

            return raw;
        }
    }
}

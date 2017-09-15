using System.Text.RegularExpressions;
using Antares.DesignPatterns.DataFlow.Pipeline;

namespace Antares.Stringifiers.Json
{
    public abstract class JPathProcessorBase : IProcessor<string>
    {
        protected readonly Regex Regex;
        protected readonly IJsonObjectSelector Selector;

        public JPathProcessorBase(string pattern, IJsonObjectSelector selector)
        {
            Regex = new Regex(pattern);
            Selector = selector;
        }

        public abstract string Process(string format);
    }
}

using Newtonsoft.Json.Linq;
using Antares.DesignPatterns.DataFlow.Pipeline;

namespace Antares.Stringifiers.Json
{
    public class JsonStringifier : PipelineBase<string>, IJsonStringifier
    {
        protected IJsonObjectSelector Selector;

        public JsonStringifier(JToken jObject) : this(new JsonObjectSelector(jObject))
        {
        }

        public JsonStringifier(IJsonObjectSelector selector)
        {
            Selector = selector;
            BuildParser();
        }

        protected virtual void BuildParser()
        {
            this.Register(new JPathWithNumberFormatProcessor(Selector))
                .Register(new JPathSimpleProcessor(Selector));
        }

        public virtual string Stringify(string format)
        {
            return ProcessAll(format);
        }
    }
}

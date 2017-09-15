using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using System;
using System.Linq;

namespace Antares.Stringifiers.Json
{
    public sealed class JsonObjectSelector : IJsonObjectSelector
    {
        private readonly JToken Root;
        private readonly Dictionary<string, JToken> Cache;

        public JsonObjectSelector(JToken root)
        {
            Root = root;
            Cache = new Dictionary<string, JToken>();
        }

        public JToken SelectOne(string jPath)
        {
            if (Root == null) return null;
            if (string.IsNullOrEmpty(jPath)) return Root.ToString();

            JToken token;
            if (Cache.ContainsKey(jPath))
            {
                token = Cache[jPath];
            }
            else
            {
                var segments = jPath.Split(new[] { "." }, StringSplitOptions.RemoveEmptyEntries);

                token = Root;
                for (var i = 0; i < segments.Length; i++)
                {
                    token = token.SelectToken(segments[i]);
                    var jArray = token as JArray;
                    if (jArray != null)
                    {
                        var children = jArray.Children();
                        if (children.Any())
                            token = children.First();
                    }
                }

                Cache[jPath] = token;
            }

            return token;
        }
    }
}

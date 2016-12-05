using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Newtonsoft.Json;

namespace Stripe.Infrastructure.Middleware
{
    internal class DictionaryPlugin : IParserPlugin
    {
        public bool Parse(ref string requestString, JsonPropertyAttribute attribute, PropertyInfo property, object propertyValue, object propertyParent)
        {
            if (!attribute.PropertyName.Contains("metadata") && !attribute.PropertyName.Contains("fraud_details")) return false;

            var dictionary = (Dictionary<string, string>) propertyValue;
            if (dictionary == null) return true;

            foreach (var key in dictionary.Keys)
                RequestStringBuilder.ApplyParameterToRequestString(ref requestString, $"{attribute.PropertyName}[{key}]", dictionary[key]);

            return true;
        }
    }
}

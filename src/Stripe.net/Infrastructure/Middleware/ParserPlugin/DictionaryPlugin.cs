using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection;
using Newtonsoft.Json;

namespace Stripe.Infrastructure.Middleware
{
    internal class DictionaryPlugin : IParserPlugin
    {
        public bool Parse(ref string requestString, JsonPropertyAttribute attribute, PropertyInfo property, object propertyValue, object propertyParent)
        {
            // Check if the property is a Dictionary
            var type = property.PropertyType;
            if (!type.GetTypeInfo().IsGenericType) return false;
            if (type.GetTypeInfo().GetGenericTypeDefinition() != typeof(Dictionary<,>)) return false;

            // Ensure that key and value types are both string
            var keyType = type.GetTypeInfo().GenericTypeArguments[0];
            if (keyType != typeof(string))
                throw new System.ArgumentException($"Expected {typeof(string).ToString()} as dictionary key type, got {keyType.ToString()}");

            var valueType = type.GetTypeInfo().GenericTypeArguments[1];
            if (valueType != typeof(string))
                throw new System.ArgumentException($"Expected {typeof(string).ToString()} as dictionary value type, got {valueType.ToString()}");

            var dictionary = (Dictionary<string, string>) propertyValue;
            if (dictionary == null) return true;

            foreach (var key in dictionary.Keys)
                RequestStringBuilder.ApplyParameterToRequestString(ref requestString, $"{attribute.PropertyName}[{WebUtility.UrlEncode(key)}]", dictionary[key]);

            return true;
        }
    }
}

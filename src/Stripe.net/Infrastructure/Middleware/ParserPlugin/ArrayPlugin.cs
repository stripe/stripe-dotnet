using System;
using System.Collections;
using System.Linq;
using System.Reflection;
using Newtonsoft.Json;

namespace Stripe.Infrastructure.Middleware
{
    internal class ArrayPlugin : IParserPlugin
    {
        public bool Parse(ref string requestString, JsonPropertyAttribute attribute, PropertyInfo property, object propertyValue, object propertyParent)
        {
            // Check if the property is an array
            var type = property.PropertyType;
            if (!type.GetTypeInfo().IsArray) return false;

            var values = ((IEnumerable) propertyValue).Cast<object>().Select(x => x.ToString()).ToArray();

            foreach (var value in values)
                RequestStringBuilder.ApplyParameterToRequestString(ref requestString, $"{attribute.PropertyName}[]", value);

            return true;
        }
    }
}

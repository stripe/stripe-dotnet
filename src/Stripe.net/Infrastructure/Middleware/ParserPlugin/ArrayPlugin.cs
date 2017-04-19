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
            if (!attribute.PropertyName.Contains("array:")) return false;

            var values = ((IEnumerable) propertyValue).Cast<object>().Select(x => x.ToString()).ToArray();

            var key = attribute.PropertyName.Replace("array:", "") + "[]";
            
            foreach (var value in values)
                RequestStringBuilder.ApplyParameterToRequestString(ref requestString, key, value);

            return true;
        }
    }
}

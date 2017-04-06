using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Newtonsoft.Json;

namespace Stripe.Infrastructure.Middleware
{
    internal class IncludePlugin : IParserPlugin
    {
        public bool Parse(ref string requestString, JsonPropertyAttribute attribute, PropertyInfo property, object propertyValue, object propertyParent)
        {
            if (!attribute.PropertyName.Contains("include_total_count")) return false;

            var doInclude = (bool) propertyValue;

            if (doInclude)
                RequestStringBuilder.ApplyParameterToRequestString(ref requestString, $"include[]", "total_count");

            return true;
        }
    }
}

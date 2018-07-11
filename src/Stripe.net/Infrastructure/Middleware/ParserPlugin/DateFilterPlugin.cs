using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Newtonsoft.Json;

namespace Stripe.Infrastructure.Middleware
{
    internal class DateFilterPlugin : IParserPlugin
    {
        public bool Parse(ref string requestString, JsonPropertyAttribute attribute, PropertyInfo property, object propertyValue, object propertyParent)
        {
            if (property.PropertyType != typeof(StripeDateFilter)) return false;

            var filter = (StripeDateFilter) propertyValue;

            if (filter.EqualTo.HasValue)
                RequestStringBuilder.ApplyParameterToRequestString(ref requestString, attribute.PropertyName, filter.EqualTo.Value.ToUniversalTime().ConvertDateTimeToEpoch().ToString());

            if (filter.LessThan.HasValue)
                RequestStringBuilder.ApplyParameterToRequestString(ref requestString, attribute.PropertyName + "[lt]", filter.LessThan.Value.ToUniversalTime().ConvertDateTimeToEpoch().ToString());

            if (filter.LessThanOrEqual.HasValue)
                RequestStringBuilder.ApplyParameterToRequestString(ref requestString, attribute.PropertyName + "[lte]", filter.LessThanOrEqual.Value.ToUniversalTime().ConvertDateTimeToEpoch().ToString());

            if (filter.GreaterThan.HasValue)
                RequestStringBuilder.ApplyParameterToRequestString(ref requestString, attribute.PropertyName + "[gt]", filter.GreaterThan.Value.ToUniversalTime().ConvertDateTimeToEpoch().ToString());

            if (filter.GreaterThanOrEqual.HasValue)
                RequestStringBuilder.ApplyParameterToRequestString(ref requestString, attribute.PropertyName + "[gte]", filter.GreaterThanOrEqual.Value.ToUniversalTime().ConvertDateTimeToEpoch().ToString());

            return true;
        }
    }
}

using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Newtonsoft.Json;

namespace Stripe.Infrastructure.Middleware
{
    internal class PlanTransformUsagePlugin : IParserPlugin
    {
        public bool Parse(ref string requestString, JsonPropertyAttribute attribute, PropertyInfo property, object propertyValue, object propertyParent)
        {
            if (attribute.PropertyName != "transform_usage") return false;

            var opts = ((StripePlanTransformUsageOptions) property.GetValue(propertyParent, null));
            RequestStringBuilder.ApplyParameterToRequestString(ref requestString,
                $"transform_usage[divide_by]", opts.DivideBy.ToString());
            RequestStringBuilder.ApplyParameterToRequestString(ref requestString,
                $"transform_usage[round]", opts.Round);

            return true;
        }
    }
}

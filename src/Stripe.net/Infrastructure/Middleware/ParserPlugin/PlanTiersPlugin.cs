using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Newtonsoft.Json;

namespace Stripe.Infrastructure.Middleware
{
    internal class PlanTiersPlugin : IParserPlugin
    {
        public bool Parse(ref string requestString, JsonPropertyAttribute attribute, PropertyInfo property, object propertyValue, object propertyParent)
        {
            if (attribute.PropertyName != "tiers_array") return false;

            var items = ((List<StripePlanTierOptions>) property.GetValue(propertyParent, null));

            var itemIndex = 0;
            foreach (var item in items)
            {
                var properties = item.GetType().GetRuntimeProperties();

                foreach (var prop in properties)
                {
                    var value = prop.GetValue(item, null);
                    if (value == null) continue;

                    // it must have a json attribute matching stripe's key, and only one
                    var attr = prop.GetCustomAttributes<JsonPropertyAttribute>().SingleOrDefault();
                    if (attr == null) continue;

                    string valueRep;
                    if (value is StripePlanTierOptions.UpToInf)
                    {
                        valueRep = "inf";
                    } else if (value is StripePlanTierOptions.UpToBound) {
                        StripePlanTierOptions.UpToBound valueBound = (StripePlanTierOptions.UpToBound) value;
                        valueRep = valueBound.Bound.ToString();
                    }
                    else
                    {
                        valueRep = value.ToString();
                    }

                    RequestStringBuilder.ApplyParameterToRequestString(ref requestString,
                        $"tiers[{itemIndex}][{attr.PropertyName}]", valueRep);
                }

                itemIndex++;
            }

            return true;
        }
    }
}

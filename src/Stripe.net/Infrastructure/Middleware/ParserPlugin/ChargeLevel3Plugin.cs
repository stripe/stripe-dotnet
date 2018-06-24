using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Newtonsoft.Json;

namespace Stripe.Infrastructure.Middleware
{
    internal class ChargeLevel3Plugin : IParserPlugin
    {
        public bool Parse(ref string requestString, JsonPropertyAttribute attribute, PropertyInfo property, object propertyValue, object propertyParent)
        {
            if (attribute.PropertyName != "charge_level3_line_items_array") return false;

            var items = ((List<StripeChargeLevel3LineItemOptions>) property.GetValue(propertyParent, null));

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

                    RequestStringBuilder.ApplyParameterToRequestString(ref requestString,
                        $"level3[line_items][{itemIndex}][{attr.PropertyName}]", value.ToString());
                }

                itemIndex++;
            }

            return true;
        }
    }
}

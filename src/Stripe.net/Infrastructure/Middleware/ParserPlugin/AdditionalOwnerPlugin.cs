using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Newtonsoft.Json;

namespace Stripe.Infrastructure.Middleware
{
    internal class AdditionalOwnerPlugin : IParserPlugin
    {
        public bool Parse(ref string requestString, JsonPropertyAttribute attribute, PropertyInfo property, object propertyValue, object propertyParent)
        {
            if (attribute.PropertyName != "legal_entity[additional_owners]") return false;

            var owners = ((List<StripeAccountAdditionalOwner>) property.GetValue(propertyParent, null));

            if (owners.Count == 0)
            {
                RequestStringBuilder.ApplyParameterToRequestString(ref requestString, attribute.PropertyName, "");
                return true;
            }

            var ownerIndex = 0;
            foreach (var owner in owners)
            {
                var properties = owner.GetType().GetRuntimeProperties();

                foreach (var prop in properties)
                {
                    var value = prop.GetValue(owner, null);
                    if (value == null) continue;

                    // it must have a json attribute matching stripe's key, and only one
                    var attr = prop.GetCustomAttributes<JsonPropertyAttribute>().SingleOrDefault();
                    if (attr == null) continue;

                    RequestStringBuilder.ApplyParameterToRequestString(ref requestString,
                        $"{attribute.PropertyName}[{ownerIndex}]{attr.PropertyName}", 
                        value.ToString());
                }

                ownerIndex++;
            }

            return true;
        }
    }
}

using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Newtonsoft.Json;

namespace Stripe.Infrastructure.Middleware
{
    // todo: this only varies from the item created plugin by the type in `items` below. couldn't find a clean way to make this share without being confusing
    internal class SubscriptionItemUpdatedPlugin : IParserPlugin
    {
        public bool Parse(ref string requestString, JsonPropertyAttribute attribute, PropertyInfo property, object propertyValue, object propertyParent)
        {
            if (attribute.PropertyName != "subscription_items_array_updated") return false;

            var items = ((List<StripeSubscriptionItemUpdateOption>) property.GetValue(propertyParent, null));

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
                    // a JsonPropertyAttribute is required to supply a property name to parser plugins.
                    var indexedItemAttribute = new JsonPropertyAttribute($"items[{itemIndex}][{attr.PropertyName}]");
                    RequestStringBuilder.ProcessPlugins(ref requestString, indexedItemAttribute, prop, value, propertyParent);
                }

                itemIndex++;
            }

            return true;
        }
    }
}

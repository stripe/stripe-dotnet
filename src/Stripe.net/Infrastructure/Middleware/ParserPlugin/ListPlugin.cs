using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Newtonsoft.Json;

namespace Stripe.Infrastructure.Middleware
{
    internal class ListPlugin : IParserPlugin
    {
        public bool Parse(ref string requestString, JsonPropertyAttribute attribute,
                PropertyInfo property, object propertyValue, object propertyParent)
        {
            // Check if the property is a List
            var type = property.PropertyType;
            if (!type.GetTypeInfo().IsGenericType) return false;
            if (type.GetTypeInfo().GetGenericTypeDefinition() != typeof(List<>)) return false;

            // Cast to List<object>
            var items = ((IEnumerable) propertyValue).Cast<object>().ToList();

            // If the list is empty, just send the parameter's name with an empty string as the
            // value to tell Stripe's API to empty the parameter.
            if (items.Count == 0)
            {
                RequestStringBuilder.ApplyParameterToRequestString(ref requestString, attribute.PropertyName, "");
                return true;
            }

            // Encode each item
            var itemIndex = 0;
            foreach (var item in items)
            {
                var itemType = item.GetType();

                if ((itemType.GetTypeInfo().IsPrimitive) || (itemType == typeof(String))) {
                    // Primitive type encoding (string counts as a primitive type)
                    RequestStringBuilder.ApplyParameterToRequestString(ref requestString,
                        $"{attribute.PropertyName}[{itemIndex}]", item.ToString());
                } else {
                    // Complex type encoding
                    var itemProperties = item.GetType().GetRuntimeProperties();

                    foreach (var itemProp in itemProperties)
                    {
                        var itemAttr = itemProp.GetCustomAttributes<JsonPropertyAttribute>().SingleOrDefault();
                        if (itemAttr == null)
                        {
                            // Skip attributes not tagged with JsonPropertyAttribute
                            continue;
                        }

                        var itemValue = itemProp.GetValue(item, null);
                        if (itemValue == null)
                        {
                            // Ignore null elements
                            continue;
                        }

                        // A JsonPropertyAttribute is required to supply a property name to parser plugins.
                        var key = $"{attribute.PropertyName}[{itemIndex}][{itemAttr.PropertyName}]";
                        var indexedItemAttribute = new JsonPropertyAttribute(key);
                        RequestStringBuilder.ProcessPlugins(ref requestString, indexedItemAttribute, itemProp, itemValue, propertyParent);
                    }
                }

                itemIndex++;
            }

            return true;
        }
    }
}

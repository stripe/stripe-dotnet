using System;
using System.Reflection;
using Newtonsoft.Json;

namespace Stripe.Infrastructure.Middleware
{
    internal class EnumPlugin : IParserPlugin
    {
        public bool Parse(ref string requestString, JsonPropertyAttribute attribute, PropertyInfo property, object propertyValue, object propertyParent)
        {
            // Check if the property is an Enum or a Nullable<Enum>
            var type = property.PropertyType;
            if (type.GetTypeInfo().IsGenericType && type.GetGenericTypeDefinition() == typeof(Nullable<>))
            {
                type = Nullable.GetUnderlyingType(type);
            }
            if (!type.GetTypeInfo().IsEnum) return false;

            // Use JsonConvert to grab the EnumMemberAttribute's Value for the enum element
            string value = JsonConvert.SerializeObject(propertyValue).Trim('"');

            RequestStringBuilder.ApplyParameterToRequestString(ref requestString, $"{attribute.PropertyName}", value);

            return true;
        }
    }
}

#if NET6_0_OR_GREATER
namespace StripeTests.Wholesome
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;
    using System.Reflection;

    using Newtonsoft.Json;
    using STJS = System.Text.Json.Serialization;

    public class SystemTextJsonTestUtils
    {
        private static bool breakOnIncorrectAttributes = Debugger.IsAttached;

        // This maps newtonsoft types to equivalent STJ types so we can check that
        // if the key type is present the value type is also present.
        private static Dictionary<Type, Type> equivalents = new Dictionary<Type, Type>
        {
            { typeof(JsonConverterAttribute), typeof(STJS.JsonConverterAttribute) },
            { typeof(JsonPropertyAttribute), typeof(STJS.JsonPropertyNameAttribute) },

            // NOTE: STJ does not have an equivalent for JsonObject to control member serialization
            // (https://learn.microsoft.com/en-us/dotnet/standard/serialization/system-text-json/migrate-from-newtonsoft?pivots=dotnet-6-0#jsonobjectattribute)
            // Instead, every public property to be ignored must be marked with a JsonIgnore attribute
            // This is ok, as we verify this verified as part of the PropertiesHaveJsonAttributes
            { typeof(JsonIgnoreAttribute), typeof(STJS.JsonIgnoreAttribute) },
            { typeof(JsonExtensionDataAttribute), typeof(STJS.JsonExtensionDataAttribute) },
        };

        static SystemTextJsonTestUtils()
        {
            var attrs = AttributeTestUtils.FindAllUsedAttributesFromNamespace("Newtonsoft");
            foreach (var attr in attrs)
            {
                var attrType = attr.GetType();
                if (attrType == typeof(JsonObjectAttribute))
                {
                    // Skip JsonObject; see note above
                    continue;
                }

                if (!equivalents.ContainsKey(attrType))
                {
                    throw new Exception($"Missing System.Text.Json equivalent for {attrType.Namespace}.{attrType.Name}");
                }
            }
        }

        public static bool HasCorrectAttributes(Attribute jsonAttribute, IEnumerable<Attribute> toSearch, bool isNotPublic)
        {
            // If the jsonAttribute type isn't present, do nothing; we confirm above that all
            // expected types have an entry in the map
            if (!equivalents.TryGetValue(jsonAttribute.GetType(), out var expectedEquivalentType))
            {
                return true;
            }

            var hasCorrectEquivalentAttribute = false;

            // technically, this means "is included" which is true for public properties or
            // if we find the JsonInclude attribute
            var hasIncludeAttribute = false;
            foreach (var attribute in toSearch)
            {
                if (attribute.GetType() == expectedEquivalentType)
                {
                    hasCorrectEquivalentAttribute = true;
                }

                // this is required to deserialize non-public properties; in Newtonsoft, this
                // was handled by a class level JsonObject(MemberSerialization.OptIn) attribute
                // which told Json.NET to serialize any property that has a JsonProperty attribute
                if (jsonAttribute.GetType() == typeof(JsonPropertyAttribute))
                {
                    if (!isNotPublic || attribute.GetType() == typeof(STJS.JsonIncludeAttribute))
                    {
                        hasIncludeAttribute = true;
                    }
                }
                else
                {
                    // We don't check for anything other than JsonProperty json attributes
                    hasIncludeAttribute = true;
                }

                if (hasCorrectEquivalentAttribute && hasIncludeAttribute)
                {
                    break;
                }
            }

            var hasCorrectAttributes = hasCorrectEquivalentAttribute && hasIncludeAttribute;

            if (!hasCorrectAttributes && breakOnIncorrectAttributes)
            {
                Debugger.Break();
            }

            return hasCorrectAttributes;
        }
    }
}
#endif

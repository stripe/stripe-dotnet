#if NET6_0_OR_GREATER
namespace StripeTests.Wholesome
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;
    using System.Reflection;
    using System.Text;
    using Newtonsoft.Json;
    using Stripe;
    using Stripe.Infrastructure;
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

            // STJ does not have an equivalent for JsonObject to control member serialization
            // (https://learn.microsoft.com/en-us/dotnet/standard/serialization/system-text-json/migrate-from-newtonsoft?pivots=dotnet-6-0#jsonobjectattribute)
            // Instead, every public property to be ignored must be marked with a JsonIgnore attribute
            // This is ok, as we verify this verified as part of the PropertiesHaveJsonAttributes
            // STJ DOES have built in converters for e.g. IEnumerable
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

        public static Tuple<string, string> HasCorrectConverterType(Type type, MemberInfo attributeTarget)
        {
            Type expectedConverterType = null;
            Type[] expectedGenericTypeArguments = null;

            var classTarget = attributeTarget as TypeInfo;
            var propertyTarget = attributeTarget as PropertyInfo;

            // In V1 DateTime properties require a UnixDateTimeConverter, in V2
            // datetime conversion is handled by Newtonsoft.Json
            // Note that the Stripe.Events namespace contains V2 events; there are
            // some whos name starts with V1 but those are V1 payloads inside V2
            // style events.
            var v2Class =
                propertyTarget?.DeclaringType.Namespace.Contains("V2") == true ||
                propertyTarget?.DeclaringType.Namespace == "Stripe.Events";
            if (type == typeof(DateTime) && !v2Class)
            {
                expectedConverterType = typeof(STJUnixDateTimeConverter);
            }
            else if (typeof(IAnyOf).GetTypeInfo().IsAssignableFrom(type.GetTypeInfo()))
            {
                expectedConverterType = typeof(STJAnyOfConverter);
            }
            else if (typeof(IExpandableField).GetTypeInfo().IsAssignableFrom(type.GetTypeInfo()))
            {
                expectedConverterType = typeof(STJExpandableFieldConverter<>);
                if (classTarget != null)
                {
                    // because the annotation is going above a class, we don't have
                    // access to the specific type parameter for the expandable field
                    // so we add the annotation with <IHasId> as the parameter, and it
                    // just works.
                    expectedGenericTypeArguments = new Type[] { typeof(IHasId) };
                }
                else if (propertyTarget != null)
                {
                    expectedGenericTypeArguments = type.GenericTypeArguments;
                }
                else
                {
                    throw new Exception($"Unsupported attribute target {attributeTarget.Name}");
                }
            }
            else if (type.GetTypeInfo().IsInterface)
            {
                expectedConverterType = typeof(STJStripeObjectConverter);
            }

            var expectedConverterName = GetConverterName(
                expectedConverterType,
                expectedGenericTypeArguments);

            Type actualConverterType = null;
            Type[] actualGenericTypeArguments = null;

            // For this check, we are looking for the attribute on the class/type that is passed in.
            var jsonConverterAttribute = attributeTarget.GetCustomAttribute<STJS.JsonConverterAttribute>();
            if (jsonConverterAttribute != null)
            {
                actualConverterType = jsonConverterAttribute.ConverterType;
                actualGenericTypeArguments = actualConverterType.GenericTypeArguments;
            }

            var actualConverterName = GetConverterName(
                actualConverterType,
                actualGenericTypeArguments);

            if (expectedConverterName == actualConverterName)
            {
                return null;
            }

            return Tuple.Create(expectedConverterName, actualConverterName);
        }

        internal static bool HasCorrectNullValueHandlingAttribute(PropertyInfo property)
        {
            var stjAttribute = property.GetCustomAttribute<STJS.JsonIgnoreAttribute>();
            return stjAttribute != null && stjAttribute.Condition == STJS.JsonIgnoreCondition.WhenWritingNull;
        }

        private static string GetConverterName(Type type, Type[] genericTypeArguments)
        {
            if (type == null)
            {
                return "null";
            }

            var sb = new StringBuilder();
            sb.Append(type.Name);

            if (genericTypeArguments != null && genericTypeArguments.Length > 0)
            {
                sb.Append("<");
                sb.Append(string.Join(", ", genericTypeArguments.Select(t => t.Name)));
                sb.Append(">");
            }

            return sb.ToString();
        }
    }
}
#endif

#if NETCOREAPP
namespace StripeTests
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;
    using System.Text;
    using Newtonsoft.Json;
    using Stripe;
    using Stripe.Infrastructure;
    using Xunit;

    /// <summary>
    /// This wholesome test ensures that properties with types that require custom converters to
    /// use the correct custom converter.
    /// </summary>
    public class CorrectJsonConvertersForTypes : WholesomeTest
    {
        private const string AssertionMessage =
            "Found at least one property with a missing or incorrect [JsonConverter] attribute.";

        [Fact]
        public void Check()
        {
            var results = new List<string>();

            // Get all classes that derive from StripeEntity or implement INestedOptions
            var stripeClasses = GetSubclassesOf(typeof(StripeEntity));
            stripeClasses.AddRange(GetClassesWithInterface(typeof(INestedOptions)));

            foreach (var stripeClass in stripeClasses)
            {
                foreach (var property in stripeClass.GetProperties())
                {
                    var propType = property.PropertyType;
                    if (Nullable.GetUnderlyingType(propType) != null)
                    {
                        propType = Nullable.GetUnderlyingType(propType);
                    }

                    // Skip properties that don't have a `JsonProperty` attribute
                    var jsonPropertyAttribute = property.GetCustomAttribute<JsonPropertyAttribute>();
                    if (jsonPropertyAttribute == null)
                    {
                        continue;
                    }

                    Type expectedConverterType = null;
                    Type[] expectedGenericTypeArguments = null;
                    if (propType == typeof(DateTime))
                    {
                        expectedConverterType = typeof(DateTimeConverter);
                    }
                    else if (typeof(IAnyOf).GetTypeInfo().IsAssignableFrom(propType.GetTypeInfo()))
                    {
                        expectedConverterType = typeof(AnyOfConverter);
                    }
                    else if (typeof(IExpandableField).GetTypeInfo().IsAssignableFrom(propType.GetTypeInfo()))
                    {
                        expectedConverterType = typeof(ExpandableFieldConverter<>);
                        expectedGenericTypeArguments = propType.GenericTypeArguments;
                    }
                    else if (propType.GetTypeInfo().IsInterface)
                    {
                        expectedConverterType = typeof(StripeObjectConverter);
                    }

                    var expectedConverterName = GetConverterName(
                        expectedConverterType,
                        expectedGenericTypeArguments);

                    Type actualConverterType = null;
                    Type[] actualGenericTypeArguments = null;
                    var jsonConverterAttribute = property.GetCustomAttribute<JsonConverterAttribute>();
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
                        continue;
                    }

                    results.Add(
                        $"{stripeClass.Name}.{property.Name}, expected = {expectedConverterName}, "
                            + $"actual = {actualConverterName}");
                }
            }

            AssertEmpty(results, AssertionMessage);
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

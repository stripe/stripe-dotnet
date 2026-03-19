namespace StripeTests.Wholesome
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;
    using System.Text.Json.Serialization;
    using Newtonsoft.Json;
    using Stripe;
    using Stripe.Infrastructure;
    using Xunit;

    /// <summary>
    /// This wholesome test ensures that if any class property has Newtonsoft JSON attributes,
    /// it also has all other necessary/equivalent attributes (i.e. for System.Text.Json support)
    /// attributes.
    /// </summary>
    public class PropertiesHaveAllNecessaryJsonAttributes : WholesomeTest
    {
        private const string AssertionMessage =
            "Found at least one class with a Json*Attribute that is missing other necessary (e.g. System.Text.Json) attributes.";

        [Fact]
        public void Check()
        {
            List<string> results = new List<string>();

            // Get all classes in the Stripe namespace
            var assembly = typeof(StripeEntity).Assembly;
            var types = assembly.DefinedTypes.Where(t => t.FullName.StartsWith("Stripe."));
            foreach (TypeInfo type in types)
            {
                foreach (ExtendedPropertyInfo property in GetPropertiesToCheck(type))
                {
                    if (property.GetCustomAttribute(typeof(NoSystemTextJsonAttributesNeededAttribute), false) != null)
                    {
                        continue;
                    }

                    if (property.PropertyType == typeof(decimal) || property.PropertyType == typeof(decimal?))
                    {
                        var jsonAttribute = property.GetCustomAttribute(typeof(Newtonsoft.Json.JsonConverterAttribute), false) as Newtonsoft.Json.JsonConverterAttribute;
                        var stjAttribute = property.GetCustomAttribute(typeof(JsonNumberHandlingAttribute)) as JsonNumberHandlingAttribute;
                        if (jsonAttribute?.ConverterType == typeof(DecimalStringConverter))
                        {
                            var hasCorrectAttributes =
                                (stjAttribute.Handling & (JsonNumberHandling.AllowReadingFromString | JsonNumberHandling.WriteAsString)) != 0;

                            if (!hasCorrectAttributes)
                            {
                                results.Add($"{type.FullName}.{property.Name}");
                            }

                            continue;
                        }
                    }

                    if (property.PropertyType == typeof(long) || property.PropertyType == typeof(long?))
                    {
                        var jsonAttribute = property.GetCustomAttribute(typeof(Newtonsoft.Json.JsonConverterAttribute), false) as Newtonsoft.Json.JsonConverterAttribute;
                        var stjAttribute = property.GetCustomAttribute(typeof(JsonNumberHandlingAttribute)) as JsonNumberHandlingAttribute;
                        if (jsonAttribute?.ConverterType == typeof(Int64StringConverter))
                        {
                            var hasCorrectAttributes =
                                (stjAttribute.Handling & (JsonNumberHandling.AllowReadingFromString | JsonNumberHandling.WriteAsString)) != 0;

                            if (!hasCorrectAttributes)
                            {
                                results.Add($"{type.FullName}.{property.Name}");
                            }

                            continue;
                        }
                    }

                    foreach (Attribute attribute in property.GetCustomAttributes())
                    {
                        if (attribute.GetType().Namespace.StartsWith("Newtonsoft", true, null))
                        {
                            bool hasCorrectAttributes = SystemTextJsonTestUtils.HasCorrectAttributes(attribute, property.GetCustomAttributes(), property.IsNotPublic);
                            if (!hasCorrectAttributes)
                            {
                                results.Add($"{type.FullName}.{property.Name}");
                            }
                        }
                    }
                }
            }

            var message = $"{AssertionMessage}\n{results.Count} affected properties: {string.Join(",", results)}";
            AssertEmpty(results, message);
        }
    }
}

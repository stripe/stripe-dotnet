namespace StripeTests.Wholesome
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;
    using System.Reflection;
    using Newtonsoft.Json;
    using Stripe;
    using Xunit;

#if NET6_0_OR_GREATER
    using STJSerialization = System.Text.Json.Serialization;
#endif

    /// <summary>
    /// This wholesome test ensures that all properties in Stripe entities and options classes are
    /// annotated with either <see cref="JsonPropertyAttribute"/> or
    /// <see cref="JsonIgnoreAttribute"/>.
    /// </summary>
    public class PropertiesHaveJsonAttributes : WholesomeTest
    {
        // TODO(jar): update to include JsonExtensionData, and STJ attributes
        private const string AssertionMessage =
            "Found at least one property lacking a Json*Attribute or equivalent System.Text.Json attribute. Please add either a "
            + "[JsonProperty(\"name\")] or a [JsonIgnore] attribute.";

        [Fact]
        public void Check()
        {
            List<string> results = new List<string>();

            // Get all classes that derive from StripeEntity or implement INestedOptions
            var stripeClasses = GetSubclassesOf(typeof(StripeEntity));
            stripeClasses.AddRange(GetClassesWithInterface(typeof(INestedOptions)));

            foreach (var stripeClass in stripeClasses)
            {
                var privateProperties = stripeClass.GetProperties(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static);
                var allProperties = stripeClass.GetProperties().Concat(privateProperties);
                foreach (var property in allProperties)
                {
                    var jsonAttribute = default(Attribute);

                    foreach (var attribute in property.GetCustomAttributes())
                    {
                        // TODO(jar) this does not check for duplicates; maybe that's a different wholesome test?
                        if (attribute.GetType() == typeof(JsonPropertyAttribute)
                            || attribute.GetType() == typeof(JsonIgnoreAttribute)
                            || attribute.GetType() == typeof(JsonExtensionDataAttribute))
                        {
                            jsonAttribute = attribute;
                            break;
                        }
                    }

                    var hasAllCorrectAttributes = jsonAttribute != null;

#if NET6_0_OR_GREATER
                    // if there isnt a json attribute present, no sense in looking for an equivalent; fall thru and
                    // proceed as if this additional check wasn't here
                    if (jsonAttribute != null)
                    {
                        hasAllCorrectAttributes = SystemTextJsonTestUtils.HasCorrectAttributes(jsonAttribute, property.GetCustomAttributes(), privateProperties.Contains(property));
                    }
#endif
                    if (hasAllCorrectAttributes)
                    {
                        continue;
                    }

                    results.Add($"{stripeClass.Name}.{property.Name}");
                }
            }

            var message = $"{AssertionMessage}\n{results.Count} affected properties: {string.Join(",", results)}";
            AssertEmpty(results, message);
        }
    }
}

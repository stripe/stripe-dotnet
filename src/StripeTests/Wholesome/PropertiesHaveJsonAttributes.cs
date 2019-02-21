#if NETCOREAPP
namespace StripeTests
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;
    using Newtonsoft.Json;
    using Stripe;
    using Xunit;

    /// <summary>
    /// This wholesome test ensures that all properties in Stripe entities and options classes are
    /// annotated with either <see cref="JsonPropertyAttribute"/> or
    /// <see cref="JsonIgnoreAttribute"/>.
    /// </summary>
    public class PropertiesHaveJsonAttributes : WholesomeTest
    {
        private const string AssertionMessage =
            "Found at least one property lacking a Json*Attribute. Please add either a "
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
                foreach (var property in stripeClass.GetProperties())
                {
                    var hasJsonAttribute = false;

                    foreach (var attribute in property.GetCustomAttributes())
                    {
                        if (attribute.GetType() == typeof(JsonPropertyAttribute)
                            || attribute.GetType() == typeof(JsonIgnoreAttribute)
                            || attribute.GetType() == typeof(JsonExtensionDataAttribute))
                        {
                            hasJsonAttribute = true;
                            break;
                        }
                    }

                    if (hasJsonAttribute)
                    {
                        continue;
                    }

                    results.Add($"{stripeClass.Name}.{property.Name}");
                }
            }

            AssertEmpty(results, AssertionMessage);
        }
    }
}
#endif

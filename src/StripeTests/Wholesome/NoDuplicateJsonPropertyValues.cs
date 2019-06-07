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
    /// This wholesome test ensures that no entity or options class reuses the same name in
    /// different `JsonProperty` attributes.
    /// </summary>
    public class NoDuplicateJsonPropertyValues : WholesomeTest
    {
        private const string AssertionMessage =
            "Found at least one duplicate JsonProperty name.";

        [Fact]
        public void Check()
        {
            List<string> results = new List<string>();

            // Get all classes that derive from StripeEntity or implement INestedOptions
            var stripeClasses = GetSubclassesOf(typeof(StripeEntity));
            stripeClasses.AddRange(GetClassesWithInterface(typeof(INestedOptions)));

            foreach (Type stripeClass in stripeClasses)
            {
                var jsonPropertyNames = new List<string>();

                foreach (PropertyInfo property in stripeClass.GetProperties())
                {
                    var propType = property.PropertyType;

                    // Skip properties that don't have a `JsonProperty` attribute
                    var attribute = property.GetCustomAttribute<JsonPropertyAttribute>();
                    if (attribute == null)
                    {
                        continue;
                    }

                    if (jsonPropertyNames.Contains(attribute.PropertyName))
                    {
                        results.Add($"{stripeClass.Name}.{property.Name}");
                    }
                    else
                    {
                        jsonPropertyNames.Add(attribute.PropertyName);
                    }
                }
            }

            AssertEmpty(results, AssertionMessage);
        }
    }
}
#endif

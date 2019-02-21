#if NETCOREAPP
namespace StripeTests
{
    using System;
    using System.Collections.Generic;
    using System.Reflection;
    using Newtonsoft.Json;
    using Stripe;
    using Xunit;

    /// <summary>
    /// This wholesome test ensures that lists (as in `List<>`) are used instead of arrays (`[]`)
    /// in Stripe entities and options classes.
    /// </summary>
    public class UseListsInsteadOfArrays : WholesomeTest
    {
        private const string AssertionMessage =
            "Found at least one array type. Please use List<> instead.";

        [Fact]
        public void Check()
        {
            List<string> results = new List<string>();

            // Get all classes that derive from StripeEntity or implement INestedOptions
            var stripeClasses = GetSubclassesOf(typeof(StripeEntity));
            stripeClasses.AddRange(GetClassesWithInterface(typeof(INestedOptions)));

            foreach (Type stripeClass in stripeClasses)
            {
                foreach (PropertyInfo property in stripeClass.GetProperties())
                {
                    var propType = property.PropertyType;

                    // Skip properties that don't have a `JsonProperty` attribute
                    var attribute = property.GetCustomAttribute<JsonPropertyAttribute>();
                    if (attribute == null)
                    {
                        continue;
                    }

                    // Skip non-array types
                    if (!propType.GetTypeInfo().IsArray)
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

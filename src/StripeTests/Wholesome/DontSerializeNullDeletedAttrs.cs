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

    public class DontSerializeNullDeletedAttrs : WholesomeTest
    {
        private const string AssertionMessage =
            "Found at least one invalid Deleted property. Make sure that the property " +
            "has a JsonPropertyAttribute and that NullValueHandling is set to Ignore.";

        [Fact]
        public void Check()
        {
            List<string> results = new List<string>();

            // Get all StripeEntity subclasses
            var entityClasses = GetSubclassesOf(typeof(StripeEntity));

            foreach (Type entityClass in entityClasses)
            {
                foreach (PropertyInfo property in entityClass.GetProperties())
                {
                    if (property.Name != "Deleted")
                    {
                        continue;
                    }

                    // Check that property has a JsonPropertyAttribute
                    var attribute = property.GetCustomAttribute<JsonPropertyAttribute>();
                    if (attribute == null)
                    {
                        continue;
                    }

                    // Check that NullValueHanding is set to Ignore
                    if (attribute.NullValueHandling == NullValueHandling.Ignore)
                    {
                        continue;
                    }

                    results.Add($"{entityClass.Name}.{property.Name}");
                }
            }

            if (results.Any())
            {
                // Sort results alphabetically
                results = results.OrderBy(i => i).ToList();

                // Display our own error message (because Assert.Empty truncates the results)
                Console.WriteLine("Found invalid Deleted properties:");
                foreach (string item in results)
                {
                    Console.WriteLine($"- {item}");
                }

                // Actually fail test
                Assert.True(false, AssertionMessage);
            }
        }
    }
}
#endif
